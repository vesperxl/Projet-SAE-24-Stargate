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
            flowLayoutPanel1.SuspendLayout();

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

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Select("", ordreTri))
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

                flowLayoutPanel1.ResumeLayout();
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
    }
}
