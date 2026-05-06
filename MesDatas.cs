using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SAE_24_Stargate
{
    internal class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();

        public static DataSet DsGlobal
        {
            get
            {
                return MesDatas.dsGlobal;
            }
        }
    }
}
