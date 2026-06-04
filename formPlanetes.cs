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
    public partial class formPlanetes : Form
    {
        string chcon = @"Data Source=Stargate.db";
        String planetSelect = "";

        // Booléen pour empêcher les boucles d'événements
        private bool enUpdate = false;

        public formPlanetes()
        {
            InitializeComponent();
            ThemeCp.AppliquerTheme(this);
        }

        Dictionary<string, string> dicoTrad = new Dictionary<string, string>()
        {
            { "Bleu", "Blue" },
            { "Gris", "Gray" },
            { "Marron", "Peru" },
            { "Orange", "Orange" },
            { "Pourpre", "Crimson" },
            { "Rose", "Pink" },
            { "Vert", "Green" },
            { "Violet", "Purple" }
        };

        private void formPlanetes_Load(object sender, EventArgs e)
        {
            cboData.SelectedIndexChanged += cboData_SelectedIndexChanged;
            cboAliens.SelectedIndexChanged += cboAliens_SelectedIndexChanged; 
            chkTriAlpha.CheckedChanged += chkTriAlpha_CheckedChanged;
            ChkTriTemp.CheckedChanged += ChkTriTemp_CheckedChanged;
            chkTriPes.CheckedChanged += chkTriPes_CheckedChanged;

            cboData.Items.Clear();
            cboData.Items.Add("Toutes les planètes");
            cboData.Items.Add("Avec DataBaz");
            cboData.Items.Add("Sans DataBaz");

            cboAliens.Items.Clear();
            cboAliens.Items.Add("Peu importe");
            cboAliens.Items.Add("Avec espèces");
            cboAliens.Items.Add("Sans aucune espèce");

            enUpdate = true;
            cboData.SelectedIndex = 0;
            cboAliens.SelectedIndex = 0;
            enUpdate = false;

            genererPlanetes(false, false, false);
        }

        private void genererPlanetes(bool alpha, bool temp, bool pes)
        {
            flpMonstres.Controls.Clear();
            flpPlanet.Controls.Clear();

            string ordreTri = "";

            if (alpha)
            {
                ordreTri = "nom ASC";
            }
            else if (temp)
            {
                ordreTri = "temperature ASC";
            }
            else if (pes)
            {
                ordreTri = "gravite ASC";
            }

            List<string> conditions = new List<string>();

            if (cboData.SelectedItem != null && cboData.SelectedIndex != 0)
            {
                if (cboData.SelectedIndex == 1)
                {
                    conditions.Add("dataBazON = 1");
                }
                else if (cboData.SelectedIndex == 2)
                {
                    conditions.Add("(dataBazON = 0 OR dataBazON IS NULL)");
                }
            }

            string filtre = string.Join(" AND ", conditions);

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Planete"].Select(filtre, ordreTri))
            {
                string nom = row["nom"].ToString();

                if (cboAliens.SelectedItem != null && cboAliens.SelectedIndex != 0)
                {
                    bool aDesAliens = MesDatas.DsGlobal.Tables["Habiter"].Select("nomPlanete = '" + nom.Replace("'", "''") + "'").Length > 0;

                    if (cboAliens.SelectedIndex == 1 && !aDesAliens)
                    {
                        continue;
                    }
                    else if (cboAliens.SelectedIndex == 2 && aDesAliens)
                    {
                        continue;
                    }
                }

                Image image = (Image)Properties.Resources.ResourceManager.GetObject(nom);

                if (image == null)
                {
                    image = Properties.Resources.PlanetNotFound;
                }

                ucPlanetes ucPlanete = new ucPlanetes(nom, image);
                ucPlanete.Click += new EventHandler(ucPlanete_Click);
                flpPlanet.Controls.Add(ucPlanete);
            }
        }

        private void cboData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        private void cboAliens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        private void chkTriAlpha_CheckedChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (chkTriAlpha.Checked)
                {
                    ChkTriTemp.Checked = false;
                    chkTriPes.Checked = false;
                }
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        private void ChkTriTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (ChkTriTemp.Checked)
                {
                    chkTriAlpha.Checked = false;
                    chkTriPes.Checked = false;
                }
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        private void chkTriPes_CheckedChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (chkTriPes.Checked)
                {
                    chkTriAlpha.Checked = false;
                    ChkTriTemp.Checked = false;
                }
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        private void ucPlanete_Click(object sender, EventArgs e)
        {
            ucPlanetes planeteClicked = sender as ucPlanetes;

            if (planeteClicked != null)
            {
                planetSelect = planeteClicked.nomPlanete;
            }

            if (MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["temperature"] != DBNull.Value)
            {
                lblTemp.Text = MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["temperature"].ToString() + "°C";
            }
            else
            {
                lblTemp.Text = "Inconnu";
            }

            if (MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["gravite"] != DBNull.Value)
            {
                lblPes.Text = MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["gravite"].ToString() + "g";
            }
            else
            {
                lblPes.Text = "Inconnu";
            }

            if (MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["dataBazON"] != DBNull.Value && Convert.ToInt32(MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["dataBazON"]) == 1)
            {
                lblDatabaz.Text = "Disponible";
            }
            else
            {
                lblDatabaz.Text = "Indisponible";
            }

            flpMonstres.Controls.Clear();

            DataRow[] habitations = MesDatas.DsGlobal.Tables["Habiter"].Select("nomPlanete = '" + planetSelect + "'");

            if (habitations.Length > 0)
            {
                foreach (DataRow hab in habitations)
                {
                    string idEspece = hab["idEspece"].ToString();

                    DataRow[] estAllie = MesDatas.DsGlobal.Tables["Allie"].Select("idEspece = " + idEspece);
                    DataRow[] estEnnemi = MesDatas.DsGlobal.Tables["Ennemi"].Select("idEspece = " + idEspece);

                    DataRow[] espece = MesDatas.DsGlobal.Tables["Espece"].Select("id = " + idEspece);

                    if (espece.Length > 0)
                    {
                        String nom = espece[0]["nom"].ToString();
                        String couleur = espece[0]["couleur"].ToString();

                        if (dicoTrad.ContainsKey(couleur))
                        {
                            couleur = dicoTrad[couleur];
                        }

                        Image image = (Image)Properties.Resources.ResourceManager.GetObject(nom);

                        string insArme = "";
                        string attitude = "";
                        string pourcentage = " % De Population : ";
                        int allie_enemy = -1;

                        if (estAllie.Length > 0)
                        {
                            insArme = estAllie[0]["instrumentMusique"].ToString();
                            attitude = estAllie[0]["degreBienveillance"].ToString();
                            allie_enemy = 0;
                        }
                        else if (estEnnemi.Length > 0)
                        {
                            insArme = estEnnemi[0]["typeArme"].ToString();
                            attitude = estEnnemi[0]["degreAgressivite"].ToString();
                            allie_enemy = 1;
                        }

                        pourcentage += hab["pourcentage"].ToString() + " %";

                        ucRaces ucRace = new ucRaces(nom, planetSelect, couleur, image, insArme, attitude, pourcentage, allie_enemy);
                        flpMonstres.Controls.Add(ucRace);
                    }
                }
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "AUCUNE ESPÈCE";
                lbl.Font = new Font("Arial", 64, FontStyle.Bold);
                lbl.ForeColor = Color.Red;
                lbl.AutoSize = true;

                flpMonstres.Controls.Add(lbl);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboAliens.SelectedIndex = 0;
            cboData.SelectedIndex = 0;
            chkTriAlpha.Checked = false;
            chkTriPes.Checked = false;
            ChkTriTemp.Checked = false;

            genererPlanetes(false, false, false);
        }
    }
}