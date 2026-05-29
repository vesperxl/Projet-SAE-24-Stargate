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
    public partial class ucDepenses : UserControl
    {
        public ucDepenses()
        {
            InitializeComponent();
        }

        private void ucDepenses_Load(object sender, EventArgs e)
        {
            cboDepense.DataSource = MesDatas.DsGlobal.Tables["TypeDepense"];
            cboDepense.DisplayMember = "libelle";
            cboDepense.ValueMember = "id";
        }

        public string getDate
        {
            get { return dateChoice.Text; }
        }

        public int getSomme
        {
            get
            {
                return Convert.ToInt32(numSomme.Text);
            }
        }

        public string getMotif
        {
            get
            {
                if (string.IsNullOrEmpty(txtMotif.Text))
                {
                    return "";
                }
                return txtMotif.Text;
            }
        }

        public int getTypeDepense
        {
            get
            {
               
                return Convert.ToInt32(cboDepense.SelectedValue);
            }
        }


    }
}
