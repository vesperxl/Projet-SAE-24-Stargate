using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Projet_SAE_24_Stargate
{
    public partial class frmRaces : Form
    {
        public frmRaces()
        {
            InitializeComponent();
        }

        string chcon = @"Data Source=Stargate.db";

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

            SQLiteDataAdapter daEspece = new SQLiteDataAdapter("SELECT * FROM Espece", chcon);
            daEspece.Fill(MesDatas.DsGlobal, "Espece");

            SQLiteDataAdapter daHabiter = new SQLiteDataAdapter("SELECT * FROM Habiter", chcon);
            daHabiter.Fill(MesDatas.DsGlobal, "Habiter");

            SQLiteDataAdapter daAllie = new SQLiteDataAdapter("SELECT * FROM Allie", chcon);
            daAllie.Fill(MesDatas.DsGlobal, "Allie");

            SQLiteDataAdapter daEnnemi = new SQLiteDataAdapter("SELECT * FROM Ennemi", chcon);
            daEnnemi.Fill(MesDatas.DsGlobal, "Ennemi");

            cboNom.Items.Add("Tous");
            cboNom.SelectedIndex = 0;
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Rows)
            {
                cboNom.Items.Add(row["nom"].ToString());
            }

            cboColor.Items.Add("Toutes");
            cboColor.SelectedIndex = 0;

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

            cboType.Items.Add("TouTes");
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

        private void genererRaces(bool alpha, bool colo)
        {
            flowLayoutPanel1.Controls.Clear();

            string ordreTri;

            if (alpha == true)
            {
                ordreTri = "nom ASC";
            }
            else if (colo == true)
            {
                ordreTri = "couleur ASC";
            }
            else
            {
                ordreTri = "id ASC";
            }

            string filtre = "";
            if (cboNom.SelectedItem != null && cboNom.SelectedItem.ToString() != "Tous")
            {
                filtre = "nom = '" + cboNom.SelectedItem.ToString() + "'";
            }

            if (cboColor.SelectedItem != null && cboColor.SelectedItem.ToString() != "Toutes")
            {
                filtre = "couleur = '" + cboColor.SelectedItem.ToString() + "'";
            }


            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Select(filtre, ordreTri))
            {
                string id = row["id"].ToString();
                string nom = row["nom"].ToString();
                string couleur = row["couleur"].ToString();
                string origine = "Inconnue";

                string nomImage = nom + ".png";
                string cheminImage = "./../../pic/" + nomImage;
                Image image = Properties.Resources.loadingScreen;

                DataRow[] habitation = MesDatas.DsGlobal.Tables["Habiter"].Select("idEspece = " + id);

                couleur = dicoTrad[couleur];

                if (habitation.Length > 0)
                {
                    origine = habitation[0]["nomPlanete"].ToString();
                }

                ucRaces newRaces = new ucRaces(nom, origine, couleur, image);
                flowLayoutPanel1.Controls.Add(newRaces);

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

        private void cboNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);
        }
    }
}
