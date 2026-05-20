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
    public partial class ucRaces : UserControl
    {
        public ucRaces()
        {
            InitializeComponent();
        }

        public ucRaces(String nom, String origine, String couleur, Image image)
        {
            InitializeComponent();

            lblNom.Text = nom;
            lblOrigine.Text = origine;
            BackColor = Color.FromName(couleur);
            picBox.Image = image;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
