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

        public formPlanetes()
        {
            InitializeComponent();
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

        private void formPlanetes_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Planete"].Select())
            {
                string nom = row["nom"].ToString();

                string nomImage = nom + ".png";
                string cheminImage = "./../../pic/" + nomImage;
                Image image = Properties.Resources.loadingScreen;

                ucPlanetes ucPlanete = new ucPlanetes(nom, image);
                ucPlanete.Click += new EventHandler(ucPlanete_Click);
                flpPlanet.Controls.Add(ucPlanete);

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
                    DataRow[] espece = MesDatas.DsGlobal.Tables["Espece"].Select("id = " + idEspece);

                    if (espece.Length > 0)
                    {
                        String nom = espece[0]["nom"].ToString();
                        String couleur = espece[0]["couleur"].ToString();

                        if (dicoTrad.ContainsKey(couleur))
                        {
                            couleur = dicoTrad[couleur];
                        }

                        Image image = Properties.Resources.loadingScreen;

                        ucRaces ucRace = new ucRaces(nom, planetSelect, couleur, image, "Zgeg", 1);
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
    }
}
