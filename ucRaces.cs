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

        public ucRaces(String nom, String origine, String couleur, Image image, String insArm, String attitude, String dateContact, int races)
        {
            InitializeComponent();
            ThemeCp.AppliquerTheme(this);

            lblNom.Text = nom;
            lblOrigine.Text = origine;
            panel1.BackColor = Color.FromName(couleur);
            picBox.Image = image;

            if (races == 0)
            {
                grpBoxInsArm.Visible = true;
                grpBoxAttitude.Visible = true;

                grpBoxInsArm.Text = "Instrument favori";
                grpBoxAttitude.Text = "Degré de bienveillance";

                lblDate.Visible = true;
                lblDate.Text = "1er Contact : " + dateContact;
            }

            else if (races == 1)
            {
                grpBoxInsArm.Visible = true;
                grpBoxAttitude.Visible = true;

                grpBoxInsArm.Text = "Type d'arme";
                grpBoxAttitude.Text = "Agressivité";

                lblDate.Visible = false;
            }

            else
            {
                grpBoxInsArm.Visible = false;
                grpBoxAttitude.Visible = false;
                lblDate.Visible = false;
            }

            lblInsArm.Text = insArm;
            lblAttitude.Text = attitude;
        }
    }
}
