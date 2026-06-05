using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SAE_24_Stargate
{
    // Formulaire permettant d'affecter une équipe et des objectifs de capture à une mission
    public partial class FormAffectationCapture : Form
    {
        // Liste des matricules des membres sélectionnés pour la mission
        List<string> Matric = new List<string>();

        // Nombre de membres encore à ajouter dans l'équipe
        int nbMembre;

        // Identifiant de la mission en cours
        int idMissionActuelle;

        // Planète associée à la mission
        string planeteActuelle;

        // Liste des espèces ennemies à capturer avec leurs quantités
        List<object> listeCaptures = new List<object>();

        public FormAffectationCapture(int member, string dateDep, string dateRet, int numeroM, string planeteM, string nomChef, string matriculeChef)
        {
            InitializeComponent();

            // Application du thème graphique sur le formulaire
            ThemeCp.ApplyTheme(this);

            // Initialisation du nombre de membres à ajouter (on enlève le chef déjà présent)
            nbMembre = member - 1;
            lblrestreq.Text = nbMembre.ToString();

            // Initialisation des informations de mission
            idMissionActuelle = numeroM;
            planeteActuelle = planeteM;

            // Ajout du chef de mission directement dans la liste affichée
            lstBoxMembre.Items.Add(nomChef + " [CHEF DE MISSION]");

            // On stocke son matricule pour l'insérer plus tard en base
            Matric.Add(matriculeChef);

            try
            {
                // Requête SQL pour récupérer les membres disponibles (non affectés à une mission sur la même période)
                string reqMembre = @"SELECT v.nom, v.prenom, v.matricule, c.Specialite, m.grade
                                    FROM Membre v 
                                    LEFT JOIN Civil c ON v.matricule = c.matriculeMembre
                                    LEFT JOIN Militaire m ON v.matricule = m.matriculeMembre
                                    WHERE v.matricule NOT IN (
                                        SELECT matriculeMembre 
                                        FROM Composer co
                                        JOIN Mission mi ON co.nomPlanete = mi.nomPlanete AND co.numeroMission = mi.numero
                                        WHERE mi.dateDepart <= @dateRet AND mi.dateRetour >= @dateDep
                                    )";

                SQLiteCommand cmd2 = new SQLiteCommand(reqMembre, Connexion.Connec);

                // Paramètres pour éviter les injections SQL et gérer les dates
                cmd2.Parameters.AddWithValue("@dateDep", dateDep);
                cmd2.Parameters.AddWithValue("@dateRet", dateRet);

                SQLiteDataReader reader2 = cmd2.ExecuteReader();

                // Liste temporaire des membres récupérés depuis la base
                List<Membre> liste = new List<Membre>();

                while (reader2.Read())
                {
                    string add = "";

                    // Détection du type de membre via le matricule (M = militaire)
                    if (reader2[2].ToString().Substring(0, 1) == "M")
                    {
                        add = " - Militaire : " + reader2[4].ToString();
                    }

                    // C = civil
                    if (reader2[2].ToString().Substring(0, 1) == "C")
                    {
                        add = " - Civil : " + reader2[3].ToString();
                    }

                    // Création de l'objet membre affichable dans la ComboBox
                    liste.Add(new Membre
                    {
                        Matricule = reader2["matricule"].ToString(),
                        Display = reader2[0].ToString() + " " + reader2[1].ToString() + add
                    });
                }

                // Liaison de la liste à la ComboBox des membres
                cboMembre.DataSource = null;
                cboMembre.DisplayMember = "Display";
                cboMembre.ValueMember = "Matricule";
                cboMembre.DataSource = liste;

                cboMembre.SelectedIndex = -1;

                // =========================
                // Chargement des espèces ennemies capturables
                // =========================

                string reqCapture = @"SELECT e.id, e.nom, e.couleur 
                      FROM Espece e 
                      INNER JOIN Ennemi d ON e.id = d.idEspece;";

                SQLiteCommand cmdCapture = new SQLiteCommand(reqCapture, Connexion.Connec);
                SQLiteDataReader readerCapture = cmdCapture.ExecuteReader();

                var listeEspeces = new List<object>();

                while (readerCapture.Read())
                {
                    string idAlien = readerCapture["id"].ToString();
                    string nomAlien = readerCapture["nom"].ToString();
                    string couleurAlien = readerCapture["couleur"].ToString();

                    // Texte affiché dans la liste déroulante
                    string texteAffichage = nomAlien + " (" + couleurAlien + ")";

                    // Objet anonyme pour la ComboBox
                    listeEspeces.Add(new
                    {
                        Id = idAlien,
                        Display = texteAffichage
                    });
                }

                readerCapture.Close();

                // Liaison des espèces à la ComboBox des objectifs de capture
                cboEspeceCapture.DataSource = null;
                cboEspeceCapture.DisplayMember = "Display";
                cboEspeceCapture.ValueMember = "Id";
                cboEspeceCapture.DataSource = listeEspeces;

                cboEspeceCapture.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Gestion des erreurs SQL ou autres problèmes
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void FormAffectationCapture_Load(object sender, EventArgs e)
        {
            
        }

        // =========================
        // AJOUT D'UN MEMBRE À L'ÉQUIPE
        // =========================
        private void btnAjouterMembre_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (cboMembre.SelectedIndex != -1)
            {
                string matriculeSelectionne = cboMembre.SelectedValue.ToString();

                // Vérifie si le membre n'est pas déjà ajouté
                if (!Matric.Contains(matriculeSelectionne))
                {
                    if (nbMembre > 0)
                    {
                        lstBoxMembre.Items.Add(cboMembre.Text);
                        Matric.Add(matriculeSelectionne);

                        nbMembre--;
                        lblrestreq.Text = nbMembre.ToString();
                    }
                    else
                    {
                        errorProvider1.SetError(cboMembre, "Impossible d'ajouter le membre, l'équipe est au complet.");
                    }
                }
                else
                {
                    errorProvider1.SetError(cboMembre, "Ce membre (ou le chef de mission) fait déjà partie de l'équipe !");
                }
            }
            else
            {
                errorProvider1.SetError(cboMembre, "Aucun membre sélectionné...");
            }
        }

        // Validation de l'équipe (verrouillage des choix)
        private void btnValiderMembre_Click(object sender, EventArgs e)
        {
            if (nbMembre == 0 && lstBoxMembre != null)
            {
                lstBoxMembre.Enabled = false;
                btnAjouterMembre.Enabled = false;
                btnValiderMembre.Enabled = false;
                cboMembre.Enabled = false;
                errorProvider1.Clear();
            }
        }

        // =========================
        // AJOUT D'UN OBJECTIF DE CAPTURE
        // =========================
        private void btnAjouterObjectif_Click(object sender, EventArgs e)
        {
            if (cboEspeceCapture.SelectedIndex != -1 && nudObjectifCapture.Value != 0)
            {
                int idSelectionne = Convert.ToInt32(cboEspeceCapture.SelectedValue);
                string nomAlien = cboEspeceCapture.Text;
                int quantiteAjoutee = Convert.ToInt32(nudObjectifCapture.Value);

                bool especeDejaPresente = false;

                // Vérifie si l'espèce existe déjà dans la liste des objectifs
                foreach (object obj in listeCaptures)
                {
                    EspeceEnnemi esp = (EspeceEnnemi)obj;

                    if (esp.Id == idSelectionne)
                    {
                        esp.Quantite += quantiteAjoutee;
                        especeDejaPresente = true;
                        break;
                    }
                }

                // Si nouvelle espèce, on l'ajoute
                if (especeDejaPresente == false)
                {
                    EspeceEnnemi nouvelleCapture = new EspeceEnnemi();
                    nouvelleCapture.Id = idSelectionne;
                    nouvelleCapture.Nom = nomAlien;
                    nouvelleCapture.Quantite = quantiteAjoutee;

                    listeCaptures.Add(nouvelleCapture);
                }

                // Mise à jour de l'affichage
                lstBoxObjectifs.Items.Clear();
                foreach (object obj in listeCaptures)
                {
                    EspeceEnnemi esp = (EspeceEnnemi)obj;
                    lstBoxObjectifs.Items.Add(esp.Quantite + " x " + esp.Nom);
                }

                // Reset des contrôles
                nudObjectifCapture.Value = 0;
                cboEspeceCapture.SelectedIndex = -1;
            }
        }

        // =========================
        // VALIDATION FINALE DE LA MISSION
        // =========================
        private void btnValiderCapture_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();

            // Vérifie que l'équipe est validée avant les objectifs
            if (lstBoxMembre.Enabled == true)
            {
                errorProvider2.SetError(btnValiderMembre, "Veuillez d'abord valider l'équipe de mission.");
                MessageBox.Show("Erreur : L'équipage doit être validé avant les objectifs !", "SGC - Contrôle");
                return;
            }

            // Transaction SQL pour garantir la cohérence des données
            SQLiteTransaction maTransaction = Connexion.Connec.BeginTransaction();

            try
            {
                // Insertion des membres dans la table Composer
                string reqInsereMembre = "INSERT INTO Composer (matriculeMembre, nomPlanete, numeroMission) VALUES (@matricule, @planete, @numero);";

                foreach (string mat in Matric)
                {
                    SQLiteCommand cmdMembre = new SQLiteCommand(reqInsereMembre, Connexion.Connec, maTransaction);
                    cmdMembre.Parameters.AddWithValue("@matricule", mat);
                    cmdMembre.Parameters.AddWithValue("@planete", planeteActuelle);
                    cmdMembre.Parameters.AddWithValue("@numero", idMissionActuelle);
                    cmdMembre.ExecuteNonQuery();
                }

                // Insertion des objectifs de capture
                string reqInsereObjectif = "INSERT INTO ObjectifCapture (idEspeceEnnemi, nomPlanete, numeroMission, objectif) VALUES (@idEspece, @planete, @numero, @obj);";

                foreach (object obj in listeCaptures)
                {
                    EspeceEnnemi capture = (EspeceEnnemi)obj;

                    SQLiteCommand cmdObjectif = new SQLiteCommand(reqInsereObjectif, Connexion.Connec, maTransaction);
                    cmdObjectif.Parameters.AddWithValue("@idEspece", capture.Id);
                    cmdObjectif.Parameters.AddWithValue("@planete", planeteActuelle);
                    cmdObjectif.Parameters.AddWithValue("@numero", idMissionActuelle);
                    cmdObjectif.Parameters.AddWithValue("@obj", capture.Quantite);
                    cmdObjectif.ExecuteNonQuery();
                }

                // Validation finale de la transaction
                maTransaction.Commit();

                MessageBox.Show("Mission, équipage et objectifs de captures enregistrés avec succès au SGC !", "Succès");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Annulation en cas d'erreur
                maTransaction.Rollback();
                MessageBox.Show("Anomalie détectée ! Aucun objectif n'a été enregistré.\nDétail : " + ex.Message, "Rupture de la Transaction");
            }
        }
    }

    // Classe représentant un membre d'équipe
    public class Membre
    {
        public string Matricule { get; set; }
        public string Display { get; set; }
    }

    // Classe représentant une espèce ennemie et sa quantité à capturer
    public class EspeceEnnemi
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
    }
}