using BCrypt.Net;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Projet_SAE_24_Stargate
{
    public partial class FrmLoginAdmin : Form
    {
        public FrmLoginAdmin()
        {
            InitializeComponent();
            grpboxAuth.Text = "";
            ThemeCp.ApplyTheme(this);
            grpboxAuth.BackColor = Color.Transparent;
            grpboxAuth.Paint += (s, e) => e.Graphics.DrawString("AUTHENTIFICATION", new Font("Consolas", 12, FontStyle.Bold), Brushes.Cyan, 10, 0);
            txtMdp.UseSystemPasswordChar = true;
        }

        private void txtBoxlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnVerifier.PerformClick();
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnVerifier.PerformClick();
            }
        }

        private void btnVerifier_Click(object sender, EventArgs e)
        {

           
                try
                {
                    //Récupération du mot de passe en fonction du login
                    string sql = $@"SELECT mdp FROM Admin WHERE login = '{txtBoxlogin.Text}'";
                    SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                    object resultat = cmd.ExecuteScalar();
                    //Test si la requête a renvoyé un résultat non null
                    if (resultat != DBNull.Value && resultat != null)
                    {
                        string mdpStocke = resultat.ToString();
                        //Vérification du mot de passe
                        bool valide = BCrypt.Net.BCrypt.Verify(txtMdp.Text, mdpStocke);
                        //Résultat de l'authentification
                        if (valide)
                        {
                            MessageBox.Show("Accès USAF autorisé \n \n Bienvenue au centre de gestion des missions SG !", "Authentification");
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            errorProvider1.SetError(txtBoxlogin, "Login ou mot de passe incorrect");
                            errorProvidermdp.SetError(txtMdp, "Login ou mot de passe incorrect");
                        }


                }
                    else
                    {
                        errorProvider1.SetError(txtBoxlogin, "Login ou mot de passe incorrect");
                        errorProvidermdp.SetError(txtMdp, "Login ou mot de passe incorrect");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally { }
            
                
                
            
                
            
            
            
                
                
            
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void lbltxttitre_Click(object sender, EventArgs e)
        {

        }

        private void FrmLoginAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
