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
    public partial class FormAjoutMission : Form
    {
        int numMission;
        string dateMissiondep;
        string dateMissionret;
        public FormAjoutMission()
        {
            InitializeComponent();
            dtpdepart.MinDate = DateTime.Now;
            nUDBudget.Minimum = 0;
            nUDBudget.Maximum = 1000000000;
            NUpDMembres.Minimum = 0;
            NUpDMembres.Maximum = 15;


            try
            {
                //Récupération des planète
                string reqplanete = @"SELECT nom from Planete";

                SQLiteCommand cmd = new SQLiteCommand(reqplanete, Connexion.Connec);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    string valeur = reader[0].ToString();
                    cboplanete.Items.Add(valeur);
                }
                reader.Close();


                // Premier chargement des chefs avec les dates actuelles des sélecteurs
                dateMissiondep = dtpdepart.Value.ToString("yyyy-MM-dd");
                dateMissionret = dtpretour.Value.ToString("yyyy-MM-dd");
                ChargerChefsDisponibles(dateMissiondep, dateMissionret);
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
            finally { }
        }

        // LA MÉTHODE DE FILTRAGE DES CHEFS AJOUTÉE SANS TOUCHER AU RESTE
        private void ChargerChefsDisponibles(string dateDep, string dateRet)
        {
            try
            {
                string reqchef = @"SELECT v.nom, v.prenom, m.grade, v.matricule 
                                    FROM Membre v JOIN Militaire m ON v.matricule=m.matriculeMembre
                                    WHERE v.matricule NOT IN (
                                        SELECT co.matriculeMembre 
                                        FROM Composer co
                                        JOIN Mission mi ON co.nomPlanete = mi.nomPlanete AND co.numeroMission = mi.numero
                                        WHERE mi.dateDepart <= @dateRet AND mi.dateRetour >= @dateDep
                                    )";
                SQLiteCommand cmd2 = new SQLiteCommand(reqchef, Connexion.Connec);
                cmd2.Parameters.AddWithValue("@dateDep", dateDep);
                cmd2.Parameters.AddWithValue("@dateRet", dateRet);
                SQLiteDataReader reader2 = cmd2.ExecuteReader();
                List<Militaire> liste = new List<Militaire>();
                while (reader2.Read())
                {
                    liste.Add(new Militaire
                    {
                        Matricule = reader2["matricule"].ToString(),
                        Display = reader2[0].ToString() + " " + reader2[1].ToString() + " - " + reader2[2].ToString()
                    });
                }
                reader2.Close();

                cbochefmission.DataSource = null;
                cbochefmission.DisplayMember = "Display";
                cbochefmission.ValueMember = "Matricule";
                cbochefmission.DataSource = liste;
            }
            catch (Exception ex) { MessageBox.Show("Erreur filtrage chefs : " + ex.Message); }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cboplanete_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblnomdepcbo.Text = cboplanete.Text;

            if (cboplanete.SelectedIndex != -1)
            {
                try
                {
                    string requete = @"Select count(*) from Mission where nomPlanete = '" + cboplanete.Text + "'";
                    SQLiteCommand cd = new SQLiteCommand(requete, Connexion.Connec);
                    int valeur = Convert.ToInt32(cd.ExecuteScalar()) + 1;
                    lblnummission.Text = "- " + valeur.ToString();
                    numMission = valeur;

                }
                catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
                finally { }
            }



        }

        private void btnvalidplanet_Click(object sender, EventArgs e)
        {
            if (cboplanete.SelectedIndex != -1)
            {
                cboplanete.Enabled = false;
                btnvalidplanet.Enabled = false;
            }
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();



            if (cbochefmission.SelectedIndex != -1 && cboplanete.Enabled != true && nUDBudget.Value != 0 && NUpDMembres.Value != 0 && !string.IsNullOrEmpty(rtbFeuilleRoute.Text))
            {
                //Requete d'implémentation de la nouvelle mission dans la base de donnée
                dateMissiondep = dtpdepart.Value.ToString("yyyy-MM-dd");
                dateMissionret = dtpretour.Value.ToString("yyyy-MM-dd");

                // UNIQUEMENT LE CHANGEMENT DU TYPE ICI POUR ÉVITER LE CRASH (.ToString())
                string matriculeChef = cbochefmission.SelectedValue.ToString();
                string planete = cboplanete.SelectedItem.ToString();
                /*try 
                {
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

                    MessageBox.Show("Mission ajoutée avec succès !");
                    FormAffectationCapture fAffecCap = new FormAffectationCapture((int)NUpDMembres.Value, dateMissiondep, dateMissionret);
                    fAffecCap.ShowDialog();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex){ MessageBox.Show("Erreur : " + ex.Message); }
                finally { }*/

                MessageBox.Show("Mission ajoutée avec succès !");
                this.Hide();
                FormAffectationCapture fAffecCap = new FormAffectationCapture((int)NUpDMembres.Value, dateMissiondep, dateMissionret);
                fAffecCap.ShowDialog();
                
            }

            if (cboplanete.Enabled != false)
            { errorProvider1.SetError(cboplanete, "Champs non validé"); }
            if (cbochefmission.SelectedIndex == -1)
            { errorProvider2.SetError(cbochefmission, "Veuillez obligatoirement choisir un chef de mission."); }
            if (string.IsNullOrEmpty(rtbFeuilleRoute.Text))
            { errorProvider3.SetError(rtbFeuilleRoute, "Veuillez remplir obligatoirement le détaillé de votre mission."); }
            if (NUpDMembres.Value == 0)
            { errorProvider4.SetError(NUpDMembres, "Il est impératif de renseigner l'effectif de la mission."); }
            if (nUDBudget.Value == 0)
            { errorProvider5.SetError(nUDBudget, "Sans budget, pas de mission..."); }







        }

        private void lblprsn_Click(object sender, EventArgs e)
        {

        }

        private void dtpretour_ValueChanged(object sender, EventArgs e)
        {
            // Prise en compte du changement de date de retour pour rafraîchir
            dateMissiondep = dtpdepart.Value.ToString("yyyy-MM-dd");
            dateMissionret = dtpretour.Value.ToString("yyyy-MM-dd");
            ChargerChefsDisponibles(dateMissiondep, dateMissionret);
        }

        private void dtpdepart_ValueChanged(object sender, EventArgs e)
        {
            dtpretour.MinDate = dtpdepart.Value;

            // Prise en compte du changement de date de départ pour rafraîchir
            dateMissiondep = dtpdepart.Value.ToString("yyyy-MM-dd");
            dateMissionret = dtpretour.Value.ToString("yyyy-MM-dd");
            ChargerChefsDisponibles(dateMissiondep, dateMissionret);
        }
    }

    public class Militaire
    {
        public string Matricule { get; set; }
        public string Display { get; set; }
    }
}