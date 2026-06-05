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
            ThemeCp.ApplyTheme(this);
        }

        public ucPlanetes(String nom, Image image)
        {
            InitializeComponent();
            
            lblNom.Text = nom;
            pctBoxImage.Image = image;
            pctBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            nomPlanete = nom;

            pctBoxImage.Click += new EventHandler(Clickeuh);
            lblNom.Click += new EventHandler(Clickeuh);

            Cursor = Cursors.Hand;

            MouseEnter += new EventHandler(BleuSurvol);
            MouseLeave += new EventHandler(BaseSurvol);
            pctBoxImage.MouseEnter += new EventHandler(BleuSurvol);
            pctBoxImage.MouseLeave += new EventHandler(BaseSurvol);
            lblNom.MouseEnter += new EventHandler(BleuSurvol);
            lblNom.MouseLeave += new EventHandler(BaseSurvol);
        }

        private void Clickeuh(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void BleuSurvol(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void BaseSurvol(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(15, 15, 20);
        }
    }
}
