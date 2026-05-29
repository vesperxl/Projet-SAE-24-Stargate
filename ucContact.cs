using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SAE_24_Stargate
{
    public partial class ucContact : UserControl
    {
        public ucContact()
        {
            InitializeComponent();
        }


        public string getDate
        {
            get { return dateChoice.Value.ToString("dd/MM/yyyy"); }
        }

        public int getSomme
        {
            get
            {
            
                return Convert.ToInt32(numSomme.Value);
            }
        }
       
        public string getAppreciation
        {
            get { 
            
                return txtAppreciation.Text;
            }
           
        }

        public string getInformateur
        {

            get { return cboInformateur.SelectedValue.ToString(); }
        }

        private void ucContact_Load(object sender, EventArgs e)
        {
            cboInformateur.DataSource = MesDatas.DsGlobal.Tables["Informateur"];

            cboInformateur.DisplayMember = "nom";
            cboInformateur.ValueMember = "nomCode";   
        }
    }
}
