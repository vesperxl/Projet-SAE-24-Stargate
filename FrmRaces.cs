using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SAE_24_Stargate
{
    public partial class frmRaces : Form
    {
        private bool enUpdate = false;

        public frmRaces()
        {
            InitializeComponent();
            ThemeCp.ApplyTheme(this);

        }

        Dictionary<string, string> dicoTrad = new Dictionary<string, string>()
        {
            { "Bleu", "Blue" },
            { "Gris", "Gray" },
            { "Marron", "Brown" },
            { "Orange", "Orange" },
            { "Pourpre", "Purple" },
            { "Rose", "Pink" },
            { "Vert", "Green" },
            { "Violet", "Purple" }
        };

        private void frmRaces_Load(object sender, EventArgs e)
        {
            cboNom.Items.Add("Tous");
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Rows)
            {
                cboNom.Items.Add(row["nom"].ToString());
            }
            cboNom.SelectedIndex = 0;

            cboColor.Items.Add("Toutes");

            List<string> couleursAjoutees = new List<string>();

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Rows)
            {
                string couleur = row["couleur"].ToString();

                if (!couleursAjoutees.Contains(couleur))
                {
                    couleursAjoutees.Add(couleur);
                    cboColor.Items.Add(couleur);
                }
            }
            cboColor.SelectedIndex = 0;

            cboType.Items.Add("Toutes");
            cboType.Items.Add("Alliés");
            cboType.Items.Add("Ennemies");
            cboType.SelectedIndex = 0;

            genererRaces(false, false);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxTriAlpha.Checked)
            {
                chkBoxTriCoul.Checked = false;
                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBoxTriCoul.Checked)
            {
                chkBoxTriAlpha.Checked = false;
                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);
            }
        }

        private void genererRaces(bool alpha, bool colo)
        {
            flowLayoutPanel1.Controls.Clear();

            string ordreTri;

            if (alpha)
            {
                ordreTri = "nom ASC";
            }
            else if (colo)
            {
                ordreTri = "couleur ASC";
            }
            else
            {
                ordreTri = "id ASC";
            }

            List<string> conditions = new List<string>();

            if (cboNom.SelectedItem != null && cboNom.SelectedItem.ToString() != "Tous")
            {
                conditions.Add("nom = '" + cboNom.SelectedItem.ToString().Replace("'", "''") + "'");
            }

            if (cboColor.SelectedItem != null && cboColor.SelectedItem.ToString() != "Toutes")
            {
                conditions.Add("couleur = '" + cboColor.SelectedItem.ToString() + "'");
            }

            string filtre = string.Join(" AND ", conditions);

            string typeSelectionne = "Toutes";
            if (cboType.SelectedItem != null)
            {
                typeSelectionne = cboType.SelectedItem.ToString();
            }

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Select(filtre, ordreTri))
            {
                string id = row["id"].ToString();

                DataRow[] estAllie = MesDatas.DsGlobal.Tables["Allie"].Select("idEspece = " + id);
                
                DataRow[] estEnnemi = MesDatas.DsGlobal.Tables["Ennemi"].Select("idEspece = " + id);

                if (typeSelectionne == "Alliés" && estAllie.Length == 0)
                {
                    continue; 
                }
                else if (typeSelectionne == "Ennemies" && estEnnemi.Length == 0)
                {
                    continue; 
                }

                string nom = row["nom"].ToString();
                string couleur = row["couleur"].ToString();
                string origine = "Inconnue";

                string nomImage = nom + ".png";
                string cheminImage = "./../../pic/" + nomImage;
                Image image = Properties.Resources.loadingScreen;
                string insArme = "";
                DataRow[] habitation = MesDatas.DsGlobal.Tables["Habiter"].Select("idEspece = " + id);

                if (dicoTrad.ContainsKey(couleur))
                {
                    couleur = dicoTrad[couleur];
                }

                if (habitation.Length > 0)
                {
                    origine = habitation[0]["nomPlanete"].ToString();
                }

                int allie_enemy = -1;
                if (estAllie.Length > 0)
                {
                    insArme = estAllie[0]["instrumentMusique"].ToString();
                    allie_enemy = 0;
                }
                else if (estEnnemi.Length > 0)
                {
                    insArme = estEnnemi[0]["typeArme"].ToString();
                    allie_enemy = 1;
                }

                ucRaces newRaces = new ucRaces(nom, origine, couleur, image, insArme, allie_enemy);
                flowLayoutPanel1.Controls.Add(newRaces);
            }
        }

        private void cboNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;

                if (cboColor.Items.Count > 0)
                {
                    cboColor.SelectedIndex = 0;
                }

                if (cboType.Items.Count > 0)
                {
                    cboType.SelectedIndex = 0;
                }

                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);

                enUpdate = false;
            }
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;

                if (cboNom.Items.Count > 0)
                {
                    cboNom.SelectedIndex = 0;
                }

                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);

                enUpdate = false;
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;

                if (cboNom.Items.Count > 0)
                {
                    cboNom.SelectedIndex = 0;
                }

                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);

                enUpdate = false;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            chkBoxTriAlpha.Checked = false;
            chkBoxTriCoul.Checked = false;

            cboColor.SelectedIndex = 0;
            cboNom.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
        }
    }
}