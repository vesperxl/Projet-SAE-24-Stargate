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
using UC_Mission;

namespace Projet_SAE_24_Stargate
{
    public partial class frmDemarrage : Form
    {
        public frmDemarrage()
        {
            InitializeComponent();
        }

        private void frmDemarrage_Load(object sender, EventArgs e)
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


                MesDatas.DsGlobal.Tables["Planete"].Columns.Add("cheminImagePlanete", typeof(string));

                foreach (DataRow Row in MesDatas.DsGlobal.Tables["Planete"].Rows)
                {
                    Row["cheminImagePlanete"] = @"C:\Users\User\Documents\SAE 24\Projet SAE 24 Stargate\images\" + Row["nom"].ToString() + ".png";
                }

                foreach (DataRow Row in MesDatas.DsGlobal.Tables["Mission"].Rows)
                {
                    string nomMission = Row["nomPlanete"].ToString() + " - " + Row["numero"].ToString();
                    string dateDepart = Row["dateDepart"].ToString();
                    string dateRetour = Row["dateRetour"].ToString();
                    string matriculeChef = Row["matriculeChef"].ToString();
                    string budget = Row["budget"].ToString() + " €";
                    string nomChef = "";
                    string nomImage = "";


                    foreach (DataRow Row2 in MesDatas.DsGlobal.Tables["Membre"].Rows)
                    {
                        if (Row2["matricule"].ToString() == matriculeChef)
                        {
                            nomChef = Row2["prenom"].ToString() + " " + Row2["nom"].ToString();
                            break;
                        }

                    }

                    foreach (DataRow Row3 in MesDatas.DsGlobal.Tables["Planete"].Rows)
                    {
                        if (Row3["nom"].ToString() == Row["nomPlanete"].ToString())
                        {
                            nomImage = Row3["cheminImagePlanete"].ToString();
                            break;
                        }

                    }

                    ucPlanetes UCMISSION = new UserControl1(nomMission, nomChef, dateDepart, dateRetour, budget, nomImage);
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

        private void Click_VoirPlus(object sender, EventArgs e)
        {
            ucPlanetes ucClique = (ucPlanetes)sender;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flpMission.Controls.Clear();
            MesDatas.DsGlobal.Reset();
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


                MesDatas.DsGlobal.Tables["Planete"].Columns.Add("cheminImagePlanete", typeof(string));

                foreach (DataRow Row in MesDatas.DsGlobal.Tables["Planete"].Rows)
                {
                    Row["cheminImagePlanete"] = @"C:\Users\User\Documents\SAE 24\Projet SAE 24 Stargate\images\" + Row["nom"].ToString() + ".png";
                }

                foreach (DataRow Row in MesDatas.DsGlobal.Tables["Mission"].Rows)
                {
                    string nomMission = Row["nomPlanete"].ToString() + " - " + Row["numero"].ToString();
                    string dateDepart = Row["dateDepart"].ToString();
                    string dateRetour = Row["dateRetour"].ToString();
                    string matriculeChef = Row["matriculeChef"].ToString();
                    string budget = Row["budget"].ToString() + " €";
                    string nomChef = "";
                    string nomImage = "";


                    foreach (DataRow Row2 in MesDatas.DsGlobal.Tables["Membre"].Rows)
                    {
                        if (Row2["matricule"].ToString() == matriculeChef)
                        {
                            nomChef = Row2["prenom"].ToString() + " " + Row2["nom"].ToString();
                            break;
                        }

                    }

                    foreach (DataRow Row3 in MesDatas.DsGlobal.Tables["Planete"].Rows)
                    {
                        if (Row3["nom"].ToString() == Row["nomPlanete"].ToString())
                        {
                            nomImage = Row3["cheminImagePlanete"].ToString();
                            break;
                        }

                    }

                    ucPlanetes UCMISSION = new UserControl1(nomMission, nomChef, dateDepart, dateRetour, budget, nomImage);
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
    }
}
