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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNvMissions_Click(object sender, EventArgs e)
        {
            FrmLoginAdmin fadmin = new FrmLoginAdmin();

            fadmin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRaces formRaces = new FrmRaces();
            formRaces.ShowDialog();
        }
    }
}
