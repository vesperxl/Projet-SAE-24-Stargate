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

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Rows)
            {
                string id = row["id"].ToString();
                string nom = row["nom"].ToString();
                string couleur = row["couleur"].ToString();
                string origine = "Inconnue";

                string nomImage = nom + ".png";
                string cheminImage = "./../../pic/" + nomImage;

                DataRow[] habitation = MesDatas.DsGlobal.Tables["Habiter"].Select("idEspece = " + id);

                couleur = dicoTrad[couleur];

                if (habitation.Length > 0)
                {
                    origine = habitation[0]["nomPlanete"].ToString();
                }

                ucRaces newRaces = new ucRaces(nom,origine,couleur);
                flowLayoutPanel1.Controls.Add(newRaces);
            }
                
        }
    }
}
