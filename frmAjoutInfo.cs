using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SAE_24_Stargate
{
    public partial class frmAjoutInfo : Form
    {

        private string nomPlanete;
        private int numMission;
        public frmAjoutInfo(string nomPlanete, int num)
        {
            InitializeComponent();
            this.nomPlanete = nomPlanete;
            this.numMission = num;
        }


        private ucContact contact;
        private ucDepenses depenses;
        private ucEvent events;

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
                try
                {
                    SQLiteConnection cx = Connexion.Connec;
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
                if(depenses.getSomme <= 0)
                {
                    MessageBox.Show("Veuillez entrer une somme supérieure à 0.");
                    return;
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
        }
    }
}
