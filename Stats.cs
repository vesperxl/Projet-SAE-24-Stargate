using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Projet_SAE_24_Stargate
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
            ThemeCp.ApplyTheme(this);
        }

        public DataTable Req2()
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = Connexion.Connec;

            string requete = @"
                SELECT m.nomPlanete || '-' || m.numero AS NomMission,
                       d.dateD, d.motif, d.montant,
                       m.budget AS BudgetInitial,
                       (m.budget - COALESCE((SELECT SUM(montant) FROM Depense d2 WHERE d2.nomPlanete = m.nomPlanete AND d2.numeroMission = m.numero), 0)) AS BudgetActuel
                FROM Mission m
                LEFT JOIN Depense d ON m.nomPlanete = d.nomPlanete AND m.numero = d.numeroMission
                WHERE (SELECT COUNT(*) FROM Composer c WHERE c.nomPlanete = m.nomPlanete AND c.numeroMission = m.numero) > 10";

            using (SQLiteCommand command = new SQLiteCommand(requete, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            return table;
        }

        public DataTable Req3()
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = Connexion.Connec;

            string requete = @"
                SELECT p.nom, COUNT(m.numero) AS NombreMissions
                FROM Planete p
                LEFT JOIN Mission m ON p.nom = m.nomPlanete
                GROUP BY p.nom";

            using (SQLiteCommand command = new SQLiteCommand(requete, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            return table;
        }

        public DataTable Req4()
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = Connexion.Connec;

            string requete = @"
                SELECT d.dateD || ' - ' || d.motif || ' - ' || d.montant || '€' AS 'Dépenses les plus importantes',
                       m.nomPlanete || '-' || m.numero AS NomMission,
                       chef.prenom, chef.nom
                FROM Depense d
                JOIN Mission m ON d.nomPlanete = m.nomPlanete AND d.numeroMission = m.numero
                JOIN Membre chef ON m.matriculeChef = chef.matricule
                WHERE d.montant = (
                    SELECT MAX(montant)
                    FROM Depense d2
                    WHERE d2.nomPlanete = d.nomPlanete AND d2.numeroMission = d.numeroMission
                )";

            using (SQLiteCommand command = new SQLiteCommand(requete, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            return table;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            try
            {
                dgvReq2.DataSource = Req2();
                dgvReq3.DataSource = Req3();
                dgvReq4.DataSource = Req4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
