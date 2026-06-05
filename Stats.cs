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

        public DataTable Req1(string matricule)
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = Connexion.Connec;
            SQLiteCommand command = null;
            SQLiteDataReader reader = null;

            string requete = @"
                SELECT DISTINCT mb.nom, mb.prenom,
                CASE WHEN mil.matriculeMembre IS NOT NULL THEN 'Militaire' ELSE 'Civil' END AS Type
                FROM Membre mb
                JOIN Composer c1 ON mb.matricule = c1.matriculeMembre
                JOIN Composer c2 ON c1.nomPlanete = c2.nomPlanete AND c1.numeroMission = c2.numeroMission
                LEFT JOIN Militaire mil ON mb.matricule = mil.matriculeMembre
                WHERE c2.matriculeMembre = @matricule AND mb.matricule != @matricule";

            try
            {
                command = new SQLiteCommand(requete, connection);
                command.Parameters.AddWithValue("@matricule", matricule);
                reader = command.ExecuteReader();
                table.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }

        public DataTable Req2()
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = Connexion.Connec;
            SQLiteCommand command = null;
            SQLiteDataReader reader = null;

            string requete = @"
                 SELECT m.nomPlanete || '-' || m.numero AS NomMission,
                 d.dateD, d.motif, d.montant,
                 m.budget AS BudgetInitial,
                (m.budget - (SELECT TOTAL(montant) FROM Depense d2 WHERE d2.nomPlanete = m.nomPlanete AND d2.numeroMission = m.numero)) AS BudgetActuel
                FROM Mission m
                LEFT JOIN Depense d ON m.nomPlanete = d.nomPlanete AND m.numero = d.numeroMission
                WHERE (SELECT COUNT(*) FROM Composer c WHERE c.nomPlanete = m.nomPlanete AND c.numeroMission = m.numero) > 10";

            try
            {
                command = new SQLiteCommand(requete, connection);
                reader = command.ExecuteReader();
                table.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }

        public DataTable Req3()
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = Connexion.Connec;
            SQLiteCommand command = null;
            SQLiteDataReader reader = null;

            string requete = @"
                SELECT p.nom, COUNT(m.numero) AS NombreMissions
                FROM Planete p
                LEFT JOIN Mission m ON p.nom = m.nomPlanete
                GROUP BY p.nom";

            try
            {
                command = new SQLiteCommand(requete, connection);
                reader = command.ExecuteReader();
                table.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }

        public DataTable Req4()
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = Connexion.Connec;
            SQLiteCommand command = null;
            SQLiteDataReader reader = null;

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

            try
            {
                command = new SQLiteCommand(requete, connection);
                reader = command.ExecuteReader();
                table.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmdMembres = null;
            SQLiteDataReader rMembres = null;
            SQLiteCommand cmdMissions = null;
            SQLiteDataReader rMissions = null;

            try
            {
                dgvReq1.Font = new Font(dgvReq1.Font.FontFamily, 14);
                dgvReq2.Font = new Font(dgvReq1.Font.FontFamily, 14);
                dgvReq3.Font = new Font(dgvReq1.Font.FontFamily, 14);
                dgvReq4.Font = new Font(dgvReq1.Font.FontFamily, 14);
                dgvReq5.Font = new Font(dgvReq1.Font.FontFamily, 14);

                dgvReq1.Font = new Font(dgvReq1.Font.FontFamily, 14);
                dgvReq2.DataSource = Req2();
                dgvReq3.DataSource = Req3();
                dgvReq4.DataSource = Req4();

                string reqMembres = "SELECT matricule, nom || ' ' || prenom AS NomComplet FROM Membre ORDER BY nom";
                DataTable membres = new DataTable();

                cmdMembres = new SQLiteCommand(reqMembres, Connexion.Connec);
                rMembres = cmdMembres.ExecuteReader();
                membres.Load(rMembres);

                cboReq1.DisplayMember = "NomComplet";
                cboReq1.ValueMember = "matricule";
                cboReq1.DataSource = membres;

                string reqMissions = @"SELECT nomPlanete || '-' || numero AS NomMission, 
                                      nomPlanete, numero 
                               FROM Mission ORDER BY nomPlanete, numero";
                DataTable missions = new DataTable();

                cmdMissions = new SQLiteCommand(reqMissions, Connexion.Connec);
                rMissions = cmdMissions.ExecuteReader();
                missions.Load(rMissions);

                cboReq5.DisplayMember = "NomMission";
                cboReq5.ValueMember = "NomMission";
                cboReq5.DataSource = missions;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable Req5(string nomPlanete, int numeroMission)
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = Connexion.Connec;
            SQLiteCommand command = null;
            SQLiteDataReader reader = null;

            string requete = @"
                SELECT i.nomCode, e.nom AS EspeceOrigine, SUM(co.sommeVersee) AS TotalRecu
                FROM Contact co
                JOIN Informateur i ON co.nomCodeInformateur = i.nomCode
                JOIN Ennemi en ON i.idEspeceEnnemi = en.idEspece
                JOIN Espece e ON en.idEspece = e.id
                WHERE co.nomPlanete = @nomPlanete AND co.numeroMission = @numeroMission
                GROUP BY i.nomCode, e.nom
                HAVING SUM(co.sommeVersee) = (
                SELECT MIN(total) FROM (
                SELECT SUM(sommeVersee) AS total
                FROM Contact
                WHERE nomPlanete = @nomPlanete AND numeroMission = @numeroMission
                GROUP BY nomCodeInformateur
                ))";

            try
            {
                command = new SQLiteCommand(requete, connection);
                command.Parameters.AddWithValue("@nomPlanete", nomPlanete);
                command.Parameters.AddWithValue("@numeroMission", numeroMission);
                reader = command.ExecuteReader();
                table.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }

        private void cboReq1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReq1.SelectedValue != null)
            {
                dgvReq1.DataSource = Req1(cboReq1.SelectedValue.ToString());
            }
        }

        private void cboReq5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReq5.SelectedItem is DataRowView row)
            {
                string nomPlanete = row["nomPlanete"].ToString();
                int numero = Convert.ToInt32(row["numero"]);
                dgvReq5.DataSource = Req5(nomPlanete, numero);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelReq1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelReq2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelReq3.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelReq4.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelReq5.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}