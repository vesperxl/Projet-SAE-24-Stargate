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
    public partial class ucPlanetes : UserControl
    {
        public String nomPlanete;
        public ucPlanetes()
        {
            InitializeComponent();
        }

        public ucPlanetes(String nom, Image image)
        {
            InitializeComponent();
            lblNom.Text = nom;
            pctBoxImage.Image = image;
            nomPlanete = nom;

            pctBoxImage.Click += new EventHandler(Clickeuh);
            lblNom.Click += new EventHandler(Clickeuh);
        }

        private void Clickeuh(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
