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
    public partial class ucEvent : UserControl
    {
        public ucEvent()
        {
            InitializeComponent();
        }

      public string getDate
        {
            get { return dateChoice.Text; }
        }

      public string getCommentaire
        {
            get { return txtCommentaire.Text; }
        }
    }
}
