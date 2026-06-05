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
    // Formulaire de connexion administrateur (authentification)
    public partial class FrmLoginAdmin : Form
    {
        public FrmLoginAdmin()
        {
            InitializeComponent();

            // Suppression du texte du groupbox + personnalisation visuelle
            grpboxAuth.Text = "";

            // Application du thème global
            ThemeCp.ApplyTheme(this);

            // Fond transparent pour le groupbox
            grpboxAuth.BackColor = Color.Transparent;

            // Dessin personnalisé du titre dans le groupbox
            grpboxAuth.Paint += (s, e) =>
                e.Graphics.DrawString(
                    "AUTHENTIFICATION",
                    new Font("Consolas", 12, FontStyle.Bold),
                    Brushes.Cyan,
                    10,
                    0
                );

            // Masquage du mot de passe
            txtMdp.UseSystemPasswordChar = true;
        }

        // =========================
        // CONTRÔLE LOGIN (INPUT USERNAME)
        // =========================
        private void txtBoxlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validation par touche ENTER
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnVerifier.PerformClick();
            }

            // Autorise uniquement les lettres (pas de chiffres ni symboles)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // =========================
        // CONTRÔLE MOT DE PASSE
        // =========================
        private void txtMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validation par ENTER
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnVerifier.PerformClick();
            }
        }

        // =========================
        // AUTHENTIFICATION ADMIN
        // =========================
        private void btnVerifier_Click(object sender, EventArgs e)
        {
            try
            {
                // Requête SQL pour récupérer le mot de passe hashé de l'admin
                // ⚠ Attention : ici concaténation directe (risque SQL injection)
                string sql = $@"SELECT mdp FROM Admin WHERE login = '{txtBoxlogin.Text}'";

                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                // Exécution de la requête (retour d'une seule valeur)
                object resultat = cmd.ExecuteScalar();

                // Vérification que la requête a bien retourné un résultat
                if (resultat != DBNull.Value && resultat != null)
                {
                    string mdpStocke = resultat.ToString();

                    // Vérification du mot de passe avec BCrypt (hash sécurisé)
                    bool valide = BCrypt.Net.BCrypt.Verify(txtMdp.Text, mdpStocke);

                    // Si authentification réussie
                    if (valide)
                    {
                        MessageBox.Show(
                            "Accès USAF autorisé \n \n Bienvenue au centre de gestion des missions SG !",
                            "Authentification"
                        );

                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        // Mot de passe incorrect
                        errorProvider1.SetError(txtBoxlogin, "Login ou mot de passe incorrect");
                        errorProvidermdp.SetError(txtMdp, "Login ou mot de passe incorrect");
                    }
                }
                else
                {
                    // Aucun utilisateur trouvé
                    errorProvider1.SetError(txtBoxlogin, "Login ou mot de passe incorrect");
                    errorProvidermdp.SetError(txtMdp, "Login ou mot de passe incorrect");
                }
            }
            catch (Exception ex)
            {
                // Gestion des erreurs SQL ou connexion
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        // Fermeture du formulaire (annulation connexion)
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