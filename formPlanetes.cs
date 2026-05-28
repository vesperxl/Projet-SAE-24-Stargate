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
                Button btn = new Button();

                string nom = row["nom"].ToString();

                string nomImage = nom + ".png";
                string cheminImage = "./../../pic/" + nomImage;
                Image image = Properties.Resources.loadingScreen;
                btn.BackColor = Color.Red;
                btn.Text = "";
                
                ucPlanetes ucPlanetes = new ucPlanetes(nom, image);
                ucPlanetes.Controls.Add(btn);
                flpPlanet.Controls.Add(ucPlanetes);

            }
        }
    }
}
