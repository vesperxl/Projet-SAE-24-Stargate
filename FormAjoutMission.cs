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
    // Formulaire permettant de créer une nouvelle mission
    public partial class FormAjoutMission : Form
    {
        // Numéro de la mission (calculé automatiquement selon la planète)
        int numMission;

        // Dates de la mission (départ et retour)
        string dateMissiondep;
        string dateMissionret;

        public FormAjoutMission()
        {
            InitializeComponent();

            // Application du thème graphique global
            ThemeCp.ApplyTheme(this);

            // Contraintes sur les contrôles
            dtpdepart.MinDate = DateTime.Now; // impossible de choisir une date passée
            nUDBudget.Minimum = 0;
            nUDBudget.Maximum = 1000000000;

            NUpDMembres.Minimum = 0;
            NUpDMembres.Maximum = 15;

            try
            {
                // =========================
                // Chargement des planètes disponibles
                // =========================
                string reqplanete = @"SELECT nom from Planete";

                SQLiteCommand cmd = new SQLiteCommand(reqplanete, Connexion.Connec);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader[0].ToString();
                    cboplanete.Items.Add(valeur);
                }
                reader.Close();

                // Initialisation des dates de mission
                dateMissiondep = dtpdepart.Value.ToString("yyyy-MM-dd");
                dateMissionret = dtpretour.Value.ToString("yyyy-MM-dd");

                // Chargement initial des chefs disponibles
                ChargerChefsDisponibles(dateMissiondep, dateMissionret);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        // =========================
        // CHARGEMENT DES CHEFS DISPONIBLES SELON LES DATES
        // =========================
        private void ChargerChefsDisponibles(string dateDep, string dateRet)
        {
            try
            {
                // Requête pour récupérer les militaires disponibles
                string reqchef = @"SELECT v.nom, v.prenom, m.grade, v.matricule 
                                    FROM Membre v 
                                    JOIN Militaire m ON v.matricule=m.matriculeMembre
                                    WHERE v.matricule NOT IN (
                                        SELECT co.matriculeMembre 
                                        FROM Composer co
                                        JOIN Mission mi ON co.nomPlanete = mi.nomPlanete AND co.numeroMission = mi.numero
                                        WHERE mi.dateDepart <= @dateRet AND mi.dateRetour >= @dateDep
                                    )";

                SQLiteCommand cmd2 = new SQLiteCommand(reqchef, Connexion.Connec);

                // Paramètres pour filtrer selon les dates
                cmd2.Parameters.AddWithValue("@dateDep", dateDep);
                cmd2.Parameters.AddWithValue("@dateRet", dateRet);

                SQLiteDataReader reader2 = cmd2.ExecuteReader();

                // Liste des chefs possibles
                List<Militaire> liste = new List<Militaire>();

                while (reader2.Read())
                {
                    liste.Add(new Militaire
                    {
                        Matricule = reader2["matricule"].ToString(),

                        // Format d'affichage dans la ComboBox
                        Display = reader2[0].ToString() + " " +
                                  reader2[1].ToString() + " - " +
                                  reader2[2].ToString()
                    });
                }

                reader2.Close();

                // Liaison avec la ComboBox des chefs de mission
                cbochefmission.DataSource = null;
                cbochefmission.DisplayMember = "Display";
                cbochefmission.ValueMember = "Matricule";
                cbochefmission.DataSource = liste;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur filtrage chefs : " + ex.Message);
            }
        }

        // Annulation de la création de mission
        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // =========================
        // SÉLECTION D'UNE PLANÈTE
        // =========================
        private void cboplanete_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblnomdepcbo.Text = cboplanete.Text;

            if (cboplanete.SelectedIndex != -1)
            {
                try
                {
                    // Compte le nombre de missions déjà existantes sur cette planète
                    string requete = @"Select count(*) from Mission where nomPlanete = '" + cboplanete.Text + "'";

                    SQLiteCommand cd = new SQLiteCommand(requete, Connexion.Connec);

                    int valeur = Convert.ToInt32(cd.ExecuteScalar()) + 1;

                    // Affichage du numéro de mission calculé
                    lblnummission.Text = "- " + valeur.ToString();
                    numMission = valeur;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        // Validation de la planète (verrouillage du choix)
        private void btnvalidplanet_Click(object sender, EventArgs e)
        {
            if (cboplanete.SelectedIndex != -1)
            {
                cboplanete.Enabled = false;
                btnvalidplanet.Enabled = false;
            }
        }

        // =========================
        // VALIDATION FINALE DE LA MISSION
        // =========================
        private void btnValid_Click(object sender, EventArgs e)
        {
            // Réinitialisation des erreurs
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();

            // Vérification des champs obligatoires
            if (cbochefmission.SelectedIndex != -1 &&
                cboplanete.Enabled != true &&
                nUDBudget.Value != 0 &&
                NUpDMembres.Value != 0 &&
                !string.IsNullOrEmpty(rtbFeuilleRoute.Text))
            {
                // Mise à jour des dates
                dateMissiondep = dtpdepart.Value.ToString("yyyy-MM-dd");
                dateMissionret = dtpretour.Value.ToString("yyyy-MM-dd");

                string matriculeChef = cbochefmission.SelectedValue.ToString();
                string planete = cboplanete.SelectedItem.ToString();
                string nomChefText = cbochefmission.Text;

                try
                {
                    // =========================
                    // INSERTION DE LA MISSION EN BASE
                    // =========================
                    string requete = @"INSERT INTO Mission (
                                            nomPlanete,
                                            numero,
                                            nbMembreRequis,
                                            dateDepart,
                                            dateRetour,
                                            matriculeChef,
                                            feuilleDeRoute,
                                            objectifDatabaz,
                                            budget
                                        )
                                        VALUES (
                                            @planete,
                                            @numero,
                                            @nbMembre,
                                            @dateDep,
                                            @dateRet,
                                            @chef,
                                            @feuille,
                                            @databaz,
                                            @budget
                                        )";

                    SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);

                    // Paramètres sécurisés
                    cmd.Parameters.AddWithValue("@planete", planete);
                    cmd.Parameters.AddWithValue("@numero", numMission);
                    cmd.Parameters.AddWithValue("@nbMembre", NUpDMembres.Value);
                    cmd.Parameters.AddWithValue("@dateDep", dateMissiondep);
                    cmd.Parameters.AddWithValue("@dateRet", dateMissionret);
                    cmd.Parameters.AddWithValue("@chef", matriculeChef);
                    cmd.Parameters.AddWithValue("@feuille", rtbFeuilleRoute.Text);
                    cmd.Parameters.AddWithValue("@databaz", NUpDdataBaz.Value);
                    cmd.Parameters.AddWithValue("@budget", nUDBudget.Value);

                    cmd.ExecuteNonQuery();

                    // Ouverture du formulaire suivant (affectation équipe + objectifs)
                    
                    MessageBox.Show("Mission ajoutée avec succès !");

                    FormAffectationCapture fAffecCap =
                        new FormAffectationCapture(
                            (int)NUpDMembres.Value,
                            dateMissiondep,
                            dateMissionret,
                            numMission,
                            planete,
                            nomChefText,
                            matriculeChef
                        );

                    DialogResult = DialogResult.OK;
                    
                    fAffecCap.ShowDialog();
                    

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            // =========================
            // GESTION DES ERREURS UI
            // =========================

            if (cboplanete.Enabled != false)
                errorProvider1.SetError(cboplanete, "Champs non validé");

            if (cbochefmission.SelectedIndex == -1)
                errorProvider2.SetError(cbochefmission, "Veuillez obligatoirement choisir un chef de mission.");

            if (string.IsNullOrEmpty(rtbFeuilleRoute.Text))
                errorProvider3.SetError(rtbFeuilleRoute, "Veuillez remplir obligatoirement le détaillé de votre mission.");

            if (NUpDMembres.Value == 0)
                errorProvider4.SetError(NUpDMembres, "Il est impératif de renseigner l'effectif de la mission.");

            if (nUDBudget.Value == 0)
                errorProvider5.SetError(nUDBudget, "Sans budget, pas de mission...");
        }

        // Libellé (non utilisé ici)
        private void lblprsn_Click(object sender, EventArgs e)
        {
        }

        // Mise à jour quand la date de retour change
        private void dtpretour_ValueChanged(object sender, EventArgs e)
        {
            dateMissiondep = dtpdepart.Value.ToString("yyyy-MM-dd");
            dateMissionret = dtpretour.Value.ToString("yyyy-MM-dd");
            ChargerChefsDisponibles(dateMissiondep, dateMissionret);
        }

        // Mise à jour quand la date de départ change
        private void dtpdepart_ValueChanged(object sender, EventArgs e)
        {
            dtpretour.MinDate = dtpdepart.Value;

            dateMissiondep = dtpdepart.Value.ToString("yyyy-MM-dd");
            dateMissionret = dtpretour.Value.ToString("yyyy-MM-dd");
            ChargerChefsDisponibles(dateMissiondep, dateMissionret);
        }
    }

    // Classe représentant un militaire (chef potentiel de mission)
    public class Militaire
    {
        public string Matricule { get; set; }
        public string Display { get; set; }
    }
}