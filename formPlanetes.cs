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

        private void formPlanetes_Load(object sender, EventArgs e)
        {
            SQLiteDataAdapter daPlanete = new SQLiteDataAdapter("SELECT * FROM Planete", chcon);
            daPlanete.Fill(MesDatas.DsGlobal, "Planete");

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

                MessageBox.Show("" + planetSelect);
            }
        }
    }
}
