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

        public ucRaces(String nom, String origine, String couleur, Image image,String insArm, int races)
        {
            InitializeComponent();
            ThemeCp.ApplyTheme(this);
            lblNom.Text = nom;
            lblOrigine.Text = origine;
            panel1.BackColor = Color.FromName(couleur);
            picBox.Image = image;
            if (races == 0)
            {
                grpBoxInsArm.Text = "Instrument";
            }
            else
            {
                grpBoxInsArm.Text = "Arme";
            }
            lblInsArm.Text = insArm;
        }
    }
}
