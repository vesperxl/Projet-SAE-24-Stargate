using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SAE_24_Stargate
{
    public partial class FormAffectationCapture : Form
    {
        List<string> Matric = new List<string>();
        int nbMembre;

        public FormAffectationCapture(int member, string dateDep, string dateRet)
        {
            InitializeComponent();
            nbMembre = member;
            lblrestreq.Text = nbMembre.ToString();
            

            try
            {
                string reqMembre = @"SELECT v.nom, v.prenom, v.matricule, c.Specialite, m.grade
                                    FROM Membre v 
                                    LEFT JOIN Civil c ON v.matricule = c.matriculeMembre
                                    LEFT JOIN Militaire m ON v.matricule = m.matriculeMembre
                                    WHERE v.matricule NOT IN (
                                        SELECT matriculeMembre 
                                        FROM Composer co
                                        JOIN Mission mi ON co.nomPlanete = mi.nomPlanete AND co.numeroMission = mi.numero
                                        WHERE mi.dateDepart <= @dateRet AND mi.dateRetour >= @dateDep
                                    )";

                SQLiteCommand cmd2 = new SQLiteCommand(reqMembre, Connexion.Connec);
                cmd2.Parameters.AddWithValue("@dateDep", dateDep);
                cmd2.Parameters.AddWithValue("@dateRet", dateRet);
                SQLiteDataReader reader2 = cmd2.ExecuteReader();
                List<Membre> liste = new List<Membre>();
                while (reader2.Read())
                {
                    string add = "";
                    if (reader2[2].ToString().Substring(0, 1) == "M")
                    {
                        add = " - Militaire : " + reader2[4].ToString();
                    }
                    if (reader2[2].ToString().Substring(0, 1) == "C")
                    {
                        add = " - Civil : " + reader2[3].ToString();
                    }

                    liste.Add(new Membre
                    {
                        Matricule = reader2["matricule"].ToString(),
                        Display = reader2[0].ToString() + " " + reader2[1].ToString() + add
                    });
                }

                cboMembre.DataSource = null;
                cboMembre.DisplayMember = "Display";
                cboMembre.ValueMember = "Matricule";
                cboMembre.DataSource = liste;

                cboMembre.SelectedIndex = -1;

                


            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
            finally { }
        }

        private void FormAffectationCapture_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouterMembre_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!(cboMembre.SelectedIndex == -1))
            {
                if(!lstBoxMembre.Items.Contains(cboMembre.Text))
                {
                    if(nbMembre > 0)
                    {
                        lstBoxMembre.Items.Add(cboMembre.Text);
                        Matric.Add(cboMembre.SelectedValue.ToString());
                        nbMembre--;
                        lblrestreq.Text = nbMembre.ToString();
                        
                    }
                    else
                    {
                        errorProvider1.SetError(cboMembre, "Impossible d'ajouter le membre, l'équipe est au complet.");
                    }
                    
                }
                else
                {
                    errorProvider1.SetError(cboMembre, "Membre déjà présent dans l'équipe !");
                }
            }
            else
            {
                errorProvider1.SetError(cboMembre, "Aucun membre séléctionné...");
            }
        }

        private void btnValiderMembre_Click(object sender, EventArgs e)
        {
            if(nbMembre == 0 && lstBoxMembre != null)
            {
                lstBoxMembre.Enabled = false;
                btnAjouterMembre.Enabled = false;
                btnValiderMembre.Enabled = false;
                cboMembre.Enabled = false;
            }
        }
    }
    public class Membre
    {
        public string Matricule { get; set; }
        public string Display { get; set; }
    }
}    
