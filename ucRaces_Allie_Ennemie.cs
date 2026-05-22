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
    public partial class ucRaces_Allie_Ennemie : UserControl
    {
        public ucRaces_Allie_Ennemie()
        {
            InitializeComponent();
        }

        public ucRaces_Allie_Ennemie(String nom, String origine, String couleur,String InstruArme, Image image, bool allie)
        {
            lblNom.Text = nom;
            lblOrigine.Text = origine;
            BackColor = Color.FromName(couleur);
            picBox.Image = image;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;

            if (allie)
            {
                grpBoxInstruArme.Text = "Instrument";
                lblInstruArme.Text = InstruArme;
            }
            else
            {
                grpBoxInstruArme.Text = "Arme";
                lblInstruArme.Text = InstruArme;
            }

            InitializeComponent();
        }
    }
}
