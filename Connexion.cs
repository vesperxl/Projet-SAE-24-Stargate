using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SAE_24_Stargate
{
    internal class Connexion
    {
        private static SQLiteConnection connec;

        private Connexion() { }

        public static SQLiteConnection Connec
        {
            get
            {
                if (connec == null) {
                    try
                    {
                        string chaine = @"Data Source = Stargate.db";
                        connec = new SQLiteConnection(chaine);
                        connec.Open();
                    }
                    catch(SQLiteException err)
                    {
                        Console.WriteLine("Erreur lors de l'ouverture de la connexion" + err.GetType());
                        
                    }
                }

                return connec;
            }
          
        }
    }
}
