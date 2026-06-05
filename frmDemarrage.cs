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
using System.Windows.Forms.VisualStyles;
using UC_Mission;

namespace Projet_SAE_24_Stargate
{
    public partial class frmDemarrage : Form
    {
        public frmDemarrage()
        {
            InitializeComponent();
            ThemeCp.ApplyTheme(this);
        }

        private void frmDemarrage_Load(object sender, EventArgs e)
        {
            refresh();

        }

        
        //detail mission
        private void Click_VoirPlus(object sender, EventArgs e)
        {
            UserControl1 ucClique = (UserControl1)sender;
            string txt = ucClique.NomMission;
            string[] tab = txt.Split('-');

            frmDetailMission frm = new frmDetailMission(tab[0].Trim(), Convert.ToInt32(tab[1].Trim()),ucClique.getStatus);
            frm.ShowDialog();

        }

        //bouton refresh
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            MesDatas.DsGlobal.Reset();


            for (int i = flpMission.Controls.Count - 1; i >= 0; i--)
            {
                if (flpMission.Controls[i] is UserControl1)
                {
                    flpMission.Controls.RemoveAt(i);
                }
            }

            if (chkEnCours.Checked)
            {
                chkEnCours.Checked = false;
            }


            refresh();
        }
        //fonction pour charger le dataset a partir des info de la base de données
        public void refresh()
        {
            try
            {
                SQLiteConnection cx = Connexion.Connec;
                DataTable dtSchema = cx.GetSchema("Tables");

                foreach (DataRow Row in dtSchema.Rows)
                {
                    string table = Row["TABLE_NAME"].ToString();
                    SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM " + table, cx);
                    da.Fill(MesDatas.DsGlobal, table);
                }


                //ajout de certaine relation necessaire
                MesDatas.DsGlobal.Relations.Add("relContactInformateur",
                    MesDatas.DsGlobal.Tables["Informateur"].Columns["nomCode"],
                    MesDatas.DsGlobal.Tables["Contact"].Columns["nomCodeInformateur"]);

                MesDatas.DsGlobal.Tables["Contact"].Columns.Add("NomInformateur", typeof(string), "Parent(relContactInformateur).nom");


                MesDatas.DsGlobal.Relations.Add("relDepenseTypeDepense",
                    MesDatas.DsGlobal.Tables["TypeDepense"].Columns["id"],
                    MesDatas.DsGlobal.Tables["Depense"].Columns["idTypeDepense"]);

                MesDatas.DsGlobal.Tables["Depense"].Columns.Add("nomDepense", typeof(string), "Parent(relDepenseTypeDepense).libelle");
                //recuperation des informations
                foreach (DataRow Row in MesDatas.DsGlobal.Tables["Mission"].Rows)
                {
                    string nomMission = Row["nomPlanete"].ToString() + " - " + Row["numero"].ToString();
                    string dateDepart = Row["dateDepart"].ToString();
                    string dateRetour = Row["dateRetour"].ToString();
                    string matriculeChef = Row["matriculeChef"].ToString();
                    string budget = Row["budget"].ToString() + " €";
                    string nomChef = "";
                    Image img = (Image)Properties.Resources.ResourceManager.GetObject(Row["nomPlanete"].ToString());

                    foreach (DataRow Row2 in MesDatas.DsGlobal.Tables["Membre"].Rows)
                    {
                        if (Row2["matricule"].ToString() == matriculeChef)
                        {
                            nomChef = Row2["prenom"].ToString() + " " + Row2["nom"].ToString();
                            break;
                        }

                    }

                    DateTime dateDepartConvert = DateTime.Parse(dateDepart);
                    DateTime dateRetourConvert = DateTime.Parse(dateRetour);
                    Color color = Color.Black;
                    string status = "uz";
                    if (dateDepartConvert <= DateTime.Now && dateRetourConvert >= DateTime.Now)
                    {
                        status = "En cours";
                        color = Color.Orange;

                    }
                    else if (dateDepartConvert > DateTime.Now)
                    {
                        status = "Dans le futur";
                        color = Color.Silver;
                    }
                    else if (dateRetourConvert < DateTime.Now)
                    {
                        status = "Terminée";
                        color = Color.MediumSeaGreen;
                    }

                    UserControl1 UCMISSION = new UserControl1(nomMission, nomChef, dateDepartConvert.ToString("dd/MM/yyyy"), dateRetourConvert.ToString("dd/MM/yyyy"), budget, img, status, color);
                    UCMISSION.afficheur = Click_VoirPlus;
                    UCMISSION.BorderStyle = BorderStyle.FixedSingle;
                    flpMission.Controls.Add(UCMISSION);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



  



        private void flpNvMission_Click(object sender, EventArgs e)
        {
            showNewMission();

        }

        private void lblMission_Click_1(object sender, EventArgs e)
        {
            showNewMission();
        }

        private void showNewMission()
        {
            FrmLoginAdmin fadmin = new FrmLoginAdmin();

            this.Hide();

            fadmin.ShowDialog();
            if (fadmin.DialogResult == DialogResult.OK)
            {
                FormAjoutMission fAMission = new FormAjoutMission();
                fAMission.ShowDialog();

            }

            this.Show();
        }






        //Tout les bouton
        private void showRace()
        {
            frmRaces formRaces = new frmRaces();
            formRaces.ShowDialog();
        }



        private void flpListePlanete_Click(object sender, EventArgs e)
        {
            showPlanet();
        }

        private void pictureMission_Click(object sender, EventArgs e)
        {
            showNewMission();
        }

        private void pictureRace_Click(object sender, EventArgs e)
        {
            showRace();
        }

        private void lblRace_Click(object sender, EventArgs e)
        {
            showRace();
        }

        private void showPlanet()
        {
            formPlanetes frmPlanetes = new formPlanetes();
            frmPlanetes.ShowDialog();
        }

        private void lblPlanete_Click(object sender, EventArgs e)
        {
            showPlanet();
        }

        private void picturePlanete_Click(object sender, EventArgs e)
        {
            showPlanet();
        }

        private void flpListRace_Click(object sender, EventArgs e)
        {
            showRace();
        }

        private void lblStat_Click(object sender, EventArgs e)
        {
            showStat();

        }

        private void flpStat_Click(object sender, EventArgs e)
        {
            showStat();

        }

        private void pictureStt_Click(object sender, EventArgs e)
        {
            showStat();
        }

        private void showStat()
        {
            Stats stats = new Stats();
            stats.ShowDialog();
        }

        //filtre mission en cours
        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnCours.Checked)
            {
                foreach (Control control in flpMission.Controls)
                {
                    if (control is UserControl1 ucMission)
                    {
                        ucMission.Visible = (ucMission.getStatus == "En cours");
                    }
                }
            }
            else
            {
                foreach (Control control in flpMission.Controls)
                {
                    if (control is UserControl1 ucMission)
                    {
                        ucMission.Visible = true;
                    }
                }
            }
        }
    }

}


