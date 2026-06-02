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
    public partial class FormAffectationCapture : Form
    {
        List<string> Matric = new List<string>();
        int nbMembre;
        int idMissionActuelle;
        string planeteActuelle;
        List<object> listeCaptures = new List<object>();

        public FormAffectationCapture(int member, string dateDep, string dateRet, int numeroM, string planeteM, string nomChef, string matriculeChef)
        {
            InitializeComponent();
            ThemeCp.AppliquerTheme(this);

            nbMembre = member-1;
            lblrestreq.Text = nbMembre.ToString();


            idMissionActuelle = numeroM;
            planeteActuelle = planeteM;
            lstBoxMembre.Items.Add(nomChef + " [CHEF DE MISSION]");
            Matric.Add(matriculeChef);

            try
            {
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
                cmd2.Parameters.AddWithValue("@dateDep", dateDep);
                cmd2.Parameters.AddWithValue("@dateRet", dateRet);
                SQLiteDataReader reader2 = cmd2.ExecuteReader();
                List<Membre> liste = new List<Membre>();
                while (reader2.Read())
                {
                    string add = "";
                    if (reader2[2].ToString().Substring(0, 1) == "M")
                    {
                        add = " - Militaire : " + reader2[4].ToString();
                    }
                    if (reader2[2].ToString().Substring(0, 1) == "C")
                    {
                        add = " - Civil : " + reader2[3].ToString();
                    }

                    liste.Add(new Membre
                    {
                        Matricule = reader2["matricule"].ToString(),
                        Display = reader2[0].ToString() + " " + reader2[1].ToString() + add
                    });
                }

                cboMembre.DataSource = null;
                cboMembre.DisplayMember = "Display";
                cboMembre.ValueMember = "Matricule";
                cboMembre.DataSource = liste;

                cboMembre.SelectedIndex = -1;





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

                    string texteAffichage = nomAlien + " (" + couleurAlien + ")";

                    listeEspeces.Add(new
                    {
                        Id = idAlien,
                        Display = texteAffichage
                    });
                }
                readerCapture.Close();

                cboEspeceCapture.DataSource = null;
                cboEspeceCapture.DisplayMember = "Display"; 
                cboEspeceCapture.ValueMember = "Id";        
                cboEspeceCapture.DataSource = listeEspeces;

                cboEspeceCapture.SelectedIndex = -1;



            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
            finally { }
        }

        private void FormAffectationCapture_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouterMembre_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (cboMembre.SelectedIndex != -1)
            {
                string matriculeSelectionne = cboMembre.SelectedValue.ToString();

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

        private void btnValiderMembre_Click(object sender, EventArgs e)
        {
            if(nbMembre == 0 && lstBoxMembre != null)
            {
                lstBoxMembre.Enabled = false;
                btnAjouterMembre.Enabled = false;
                btnValiderMembre.Enabled = false;
                cboMembre.Enabled = false;
                errorProvider1.Clear();
            }
        }

        private void btnAjouterObjectif_Click(object sender, EventArgs e)
        {
            if (cboEspeceCapture.SelectedIndex != -1 && nudObjectifCapture.Value != 0)
            {
                int idSelectionne = Convert.ToInt32(cboEspeceCapture.SelectedValue);
                string nomAlien = cboEspeceCapture.Text;
                int quantiteAjoutee = Convert.ToInt32(nudObjectifCapture.Value);

                bool especeDejaPresente = false;

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

                if (especeDejaPresente == false)
                {
                    EspeceEnnemi nouvelleCapture = new EspeceEnnemi();
                    nouvelleCapture.Id = idSelectionne;
                    nouvelleCapture.Nom = nomAlien;
                    nouvelleCapture.Quantite = quantiteAjoutee;

                    listeCaptures.Add(nouvelleCapture);
                }

                lstBoxObjectifs.Items.Clear();
                foreach (object obj in listeCaptures)
                {
                    EspeceEnnemi esp = (EspeceEnnemi)obj;
                    lstBoxObjectifs.Items.Add(esp.Quantite + " x " + esp.Nom);
                }

                nudObjectifCapture.Value = 0;
                cboEspeceCapture.SelectedIndex = -1;
            }
        }

        private void btnValiderCapture_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();

            if (lstBoxMembre.Enabled == true)
            {
                errorProvider2.SetError(btnValiderMembre, "Veuillez d'abord valider l'équipe de mission.");
                MessageBox.Show("Erreur : L'équipage doit être validé avant les objectifs !", "SGC - Contrôle");
                return;
            }

            SQLiteTransaction maTransaction = Connexion.Connec.BeginTransaction();

            try
            {
                string reqInsereMembre = "INSERT INTO Composer (matriculeMembre, nomPlanete, numeroMission) VALUES (@matricule, @planete, @numero);";

                foreach (string mat in Matric)
                {
                    SQLiteCommand cmdMembre = new SQLiteCommand(reqInsereMembre, Connexion.Connec, maTransaction);
                    cmdMembre.Parameters.AddWithValue("@matricule", mat);
                    cmdMembre.Parameters.AddWithValue("@planete", planeteActuelle);
                    cmdMembre.Parameters.AddWithValue("@numero", idMissionActuelle);
                    cmdMembre.ExecuteNonQuery();
                }

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

                
                maTransaction.Commit();

                MessageBox.Show("Mission, équipage et objectifs de captures enregistrés avec succès au SGC !", "Succès");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                maTransaction.Rollback();
                MessageBox.Show("Anomalie détectée ! Aucun objectif n'a été enregistré.\nDétail : " + ex.Message, "Rupture de la Transaction");
            }
            
        }
    }
    public class Membre
    {
        public string Matricule { get; set; }
        public string Display { get; set; }
    }

    public class EspeceEnnemi
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
    }
}    
