using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SAE_24_Stargate
{
    public partial class frmAjoutInfo : Form
    {

        private string nomPlanete;
        private int numMission;
        private int soldeRestant;
        public frmAjoutInfo(string nomPlanete, int num, int solde)
        {
            InitializeComponent();
            this.nomPlanete = nomPlanete;
            this.numMission = num;
            this.soldeRestant = solde;
            ThemeCp.ApplyTheme(this);
        }


        private ucContact contact;
        private ucDepenses depenses;
        private ucEvent events;
        private ucAddCapture capture;

        private void pictureContact_Click(object sender, EventArgs e)
        {
            grpInfo.Controls.Clear();
            contact = new ucContact();
            contact.Dock = DockStyle.Fill;
            grpInfo.Controls.Add(contact);
            grpInfo.Text = "Nouveau contact";
        }

        private void frmAjoutInfo_Load(object sender, EventArgs e)
        {
            contact = new ucContact();
            contact.Dock = DockStyle.Fill;
            grpInfo.Controls.Add(contact);
            grpInfo.Text = "Nouveau contact";

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureDepense_Click(object sender, EventArgs e)
        {
            grpInfo.Controls.Clear();
            depenses = new ucDepenses();
            depenses.Dock = DockStyle.Fill; 
            grpInfo.Controls.Add(depenses);
            grpInfo.Text = "Nouvelle dépense";

        }

        private void pictureEvent_Click(object sender, EventArgs e)
        {
            grpInfo.Controls.Clear();
            events = new ucEvent();
            events.Dock = DockStyle.Fill;
            grpInfo.Controls.Add(events);
            grpInfo.Text = "Nouvel événement";

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (grpInfo.Controls.Contains(contact))
            {

                if (contact.getSomme> soldeRestant)
                {
                    MessageBox.Show("Le montant de la somme versée dépasse le solde restant de la mission."); return;
                }

                try
                {
                    SQLiteConnection cx = Connexion.Connec;

                    DataTable tableContact = MesDatas.DsGlobal.Tables["Contact"];
                    DataRow[] row = tableContact.Select("nomPlanete = '" + nomPlanete + "' AND numeroMission = " + numMission + " AND dateC = '" + contact.getDate + "'");

                    if(row.Length > 0)
                    {
                        MessageBox.Show("Un contact avec la même date existe déjà pour cette mission. Veuillez choisir une autre date.");
                        return;
                    }

                    string requetes = @"INSERT INTO Contact (nomPlanete, numeroMission, dateC, sommeVersee,appreciation,nomCodeInformateur)
                                        VALUES (@planete," + numMission + "," + "'" + contact.getDate + "'," + contact.getSomme + ",@apprec, @info)";

                    SQLiteCommand cd = new SQLiteCommand(requetes, cx);

                    cd.Parameters.AddWithValue("@planete", nomPlanete);
                    cd.Parameters.AddWithValue("@apprec", contact.getAppreciation);
                    cd.Parameters.AddWithValue("@info", contact.getInformateur);

                    cd.ExecuteNonQuery();

                    MessageBox.Show("Contact ajouté avec succès !");
                    MesDatas.DsGlobal.Tables["Contact"].Clear();
                    SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Contact", cx);
                    da.Fill(MesDatas.DsGlobal, "Contact");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }
            else if (grpInfo.Controls.Contains(depenses))
            {

                if (string.IsNullOrEmpty(depenses.getMotif))
                {
                    MessageBox.Show("Veuillez écrire un motif.");
                    return;

                }
                if (depenses.getSomme <= 0)
                {
                    MessageBox.Show("Veuillez entrer une somme supérieure à 0.");
                    return;
                }

                if (depenses.getSomme > soldeRestant)
                {
                     MessageBox.Show("Le montant de la dépense dépasse le solde restant de la mission."); return;
                }
                try
                {
                    SQLiteConnection cx = Connexion.Connec;
                    int nextId = 1;
                    string maxId = MesDatas.DsGlobal.Tables["Depense"].Compute("MAX(id)", "nomPlanete = '" + nomPlanete + "' AND numeroMission = " + numMission).ToString();

                    if (!string.IsNullOrEmpty(maxId))
                    {
                        nextId = Convert.ToInt32(maxId) + 1;
                    }

                    

                    string requetes = @"INSERT INTO Depense (nomPlanete, numeroMission, id, dateD, montant, motif, idTypeDepense)
                                        VALUES (@planete," + numMission + "," + nextId + ",'" + depenses.getDate + "'," + depenses.getSomme + ",@motif," + depenses.getTypeDepense + ")";

                    SQLiteCommand cd = new SQLiteCommand(requetes, cx);

                    cd.Parameters.AddWithValue("@planete", nomPlanete);
                    cd.Parameters.AddWithValue("@motif", depenses.getMotif);

                    cd.ExecuteNonQuery();

                    MessageBox.Show("Dépense ajoutée avec succès !");

                    MesDatas.DsGlobal.Tables["Depense"].Clear();
                    SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Depense", cx);
                    da.Fill(MesDatas.DsGlobal, "Depense");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }
            else if (grpInfo.Controls.Contains(events))
            {
                if (string.IsNullOrEmpty(events.getCommentaire))
                {
                    MessageBox.Show("Veuillez écrire un commentaire.");
                    return;

                }
                try
                {
                    SQLiteConnection cx = Connexion.Connec;


                    string requetes = @"INSERT INTO JournalDeBord (nomPlanete, numero, dateJ, commentaires)
                                        VALUES (@planete," + numMission + ",'" + events.getDate + "',@com)";
                    SQLiteCommand cd = new SQLiteCommand(requetes, cx);
                    cd.Parameters.AddWithValue("@planete", nomPlanete);
                    cd.Parameters.AddWithValue("@com", events.getCommentaire);
                    cd.ExecuteNonQuery();
                    MessageBox.Show("Événement ajouté avec succès !");
                    MesDatas.DsGlobal.Tables["JournalDeBord"].Clear();
                    SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM JournalDeBord", cx);
                    da.Fill(MesDatas.DsGlobal, "JournalDeBord");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }



                this.Close();
            }
            else if (grpInfo.Controls.Contains(capture)) {


                if(capture.getNumEspece == 0)
                {
                    MessageBox.Show("Veuillez entrer un nombre d'espèce capturée supérieur à 0.");
                    return;
                }


                DataRow[] row = MesDatas.DsGlobal.Tables["BilanCapture" + nomPlanete + "-" + numMission].Select("nomEspece = '" + capture.getCboEspece + "'");

                
                row[0]["nbCapture"] = Convert.ToInt32(row[0]["nbCapture"]) + capture.getNumEspece;
                float taux = ((float)Convert.ToInt32(row[0]["nbCapture"]) / (float)Convert.ToInt32(row[0]["objectifInitial"])) * 100;
                row[0]["taux"] = taux + "%";

                MessageBox.Show("Capture ajouté avec succès !");


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            grpInfo.Controls.Clear();
            capture = new ucAddCapture("BilanCapture" + nomPlanete + "-" + numMission);
            capture.Dock = DockStyle.Fill;
            grpInfo.Controls.Add(capture);
            grpInfo.Text = "Nouvelle capture";


            if (!capture.active)
            {


                btnValider.Enabled = false;
            }

        }

        private void grpInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
