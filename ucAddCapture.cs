using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projet_SAE_24_Stargate
{
    public partial class ucAddCapture : UserControl
    {
        private string nomTableDs;
        public ucAddCapture(string nomTable)
        {
            InitializeComponent();
            ThemeCp.ApplyTheme(this);
            this.nomTableDs = nomTable;
        }

        private void ucAddCapture_Load(object sender, EventArgs e)
        {

            if(MesDatas.DsGlobal.Tables[nomTableDs].Rows.Count == 0)
            {
                cboEspece.Enabled = false;
                pictureBox1.Visible = true;

            }
            cboEspece.DataSource = MesDatas.DsGlobal.Tables[nomTableDs];
            cboEspece.DisplayMember = "nomEspece";

           
            
        }


        public string getCboEspece
        {
            get
            {   
                return cboEspece.Text.ToString();
            }
        }

        

        public int getNumEspece
        {
            get
            {

                return Convert.ToInt32(numNbEspece.Value);
            }
        }

        public bool active
        {
            get { return cboEspece.Enabled; }
        }
    }
}
