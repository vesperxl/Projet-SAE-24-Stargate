using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SAE_24_Stargate
{
    public partial class ucCarteIdentité : UserControl
    {
        public ucCarteIdentité()
        {
            InitializeComponent();
        }

        public ucCarteIdentité(string status, string nom, string prenom, Image image)
        {
            InitializeComponent();
            this.lblStatu.Text = status;
            this.lblNom.Text = nom;
            this.lblPrenom.Text = prenom;
            this.pictureCi.Image = image;
        }

        
    }
}
