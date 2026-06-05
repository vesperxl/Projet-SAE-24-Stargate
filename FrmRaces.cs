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
    public partial class frmRaces : Form
    {
        // Variable Pour Éviter Les Mises À Jour Infini Des Combobox
        private bool enUpdate = false;

        public frmRaces()
        {
            InitializeComponent();
            // Application Du Thème Visuel Au Formulaire
            ThemeCp.ApplyTheme(this);

        }

        // Dictionnaire Pour Traduire Les Noms De Couleurs Du Français Vers L'Anglais
        Dictionary<string, string> dicoTrad = new Dictionary<string, string>()
        {
            { "Bleu", "Blue" },
            { "Gris", "Gray" },
            { "Marron", "Peru" },
            { "Orange", "Orange" },
            { "Pourpre", "Crimson" },
            { "Rose", "Pink" },
            { "Vert", "Green" },
            { "Violet", "Purple" }
        };

        // Initialisation Du Formulaire Au Chargement
        private void frmRaces_Load(object sender, EventArgs e)
        {
            // Remplissage Du Combobox Des Noms D'Espèces Depuis La Base De Données
            cboNom.Items.Add("Tous");
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Rows)
            {
                cboNom.Items.Add(row["nom"].ToString());
            }
            cboNom.SelectedIndex = 0;

            // Remplissage Du Combobox Des Couleurs En Évitant Les Doublons
            cboColor.Items.Add("Toutes");
            List<string> couleursAjoutees = new List<string>();
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Rows)
            {
                string couleur = row["couleur"].ToString();
                if (!couleursAjoutees.Contains(couleur))
                {
                    couleursAjoutees.Add(couleur);
                    cboColor.Items.Add(couleur);
                }
            }
            cboColor.SelectedIndex = 0;

            // Remplissage Du Combobox Du Type D'Espèce (Alliés Ou Ennemies)
            cboType.Items.Add("Toutes");
            cboType.Items.Add("Alliés");
            cboType.Items.Add("Ennemies");
            cboType.SelectedIndex = 0;

            // Affichage Initial Des Races Sans Tri
            genererRaces(false, false);
        }

        // Quand La Case "Tri Alphabétique" Est Cochée, On Décoche Le Tri Par Couleur Et Recharge
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (chkBoxTriAlpha.Checked)
                {
                    chkBoxTriCoul.Checked = false;
                }
                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);
                enUpdate = false;
            }
        }

        // Quand La Case "Tri Par Couleur" Est Cochée, On Décoche Le Tri Alphabétique Et Recharge
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (chkBoxTriCoul.Checked)
                {
                    chkBoxTriAlpha.Checked = false;
                }
                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);
                enUpdate = false;
            }
        }

        // Méthode Principale : Génère Et Affiche Les Cartes De Races Selon Les Filtres Et Le Tri
        private void genererRaces(bool alpha, bool colo)
        {
            // Nettoyage Du Panneau Avant De Le Remplir À Nouveau
            flowLayoutPanel1.Controls.Clear();

            // Choix De L'Ordre De Tri Selon Les Cases Cochées
            string ordreTri;
            if (alpha)
            {
                ordreTri = "nom ASC";
            }
                
            else if (colo)
            {
                ordreTri = "couleur ASC";
            }
                
            else
            {
                ordreTri = "id ASC";
            }
                

            // Construction Des Conditions De Filtre Selon Les Sélections Des Combobox
            List<string> conditions = new List<string>();

            if (cboNom.SelectedItem != null && cboNom.SelectedItem.ToString() != "Tous")
            {
                conditions.Add("nom = '" + cboNom.SelectedItem.ToString().Replace("'", "''") + "'");
            }

            if (cboColor.SelectedItem != null && cboColor.SelectedItem.ToString() != "Toutes")
            {
                conditions.Add("couleur = '" + cboColor.SelectedItem.ToString() + "'");
            }

            string filtre = string.Join(" AND ", conditions);

            // Récupération Du Type Sélectionné (Toutes / Alliés / Ennemies)
            string typeSelectionne = "Toutes";
            if (cboType.SelectedItem != null)
            {
                typeSelectionne = cboType.SelectedItem.ToString();
            }

            // Parcours De Chaque Espèce Filtrée Et Triée
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Espece"].Select(filtre, ordreTri))
            {
                string id = row["id"].ToString();

                // Vérification Si L'Espèce Est Alliée Ou Ennemie
                DataRow[] estAllie = MesDatas.DsGlobal.Tables["Allie"].Select("idEspece = " + id);
                DataRow[] estEnnemi = MesDatas.DsGlobal.Tables["Ennemi"].Select("idEspece = " + id);

                string nom = row["nom"].ToString();
                string couleur = row["couleur"].ToString();
                string origine = "Inconnue";

                // Chargement De L'Image Correspondant À L'Espèce Depuis Les Ressources
                Image image = (Image)Properties.Resources.ResourceManager.GetObject(nom);

                string insArme = "";
                string attitude = "";
                string dateContact = "";

                // Recherche De La Planète D'Origine De L'Espèce
                DataRow[] habitation = MesDatas.DsGlobal.Tables["Habiter"].Select("idEspece = " + id);

                // Traduction De La Couleur En Anglais Pour L'Affichage
                if (dicoTrad.ContainsKey(couleur))
                {
                    couleur = dicoTrad[couleur];
                }
                    

                // Récupération Du Nom De La Planète Si Disponible
                if (habitation.Length > 0)
                {
                    origine = habitation[0]["nomPlanete"].ToString();
                }

                // -1 = Neutre, 0 = Allié, 1 = Ennemi
                int allie_enemy = -1;

                if (estAllie.Length > 0)
                {
                    // Récupération Des Informations Spécifiques Aux Alliés
                    insArme = estAllie[0]["instrumentMusique"].ToString();
                    attitude = estAllie[0]["degreBienveillance"].ToString();
                    if (estAllie[0]["datePremierContact"] != DBNull.Value)
                        dateContact = "1er Contact : " + estAllie[0]["datePremierContact"].ToString();
                    allie_enemy = 0;
                }
                else if (estEnnemi.Length > 0)
                {
                    // Récupération Des Informations Spécifiques Aux Ennemis
                    insArme = estEnnemi[0]["typeArme"].ToString();
                    attitude = estEnnemi[0]["degreAgressivite"].ToString();
                    dateContact = "";
                    allie_enemy = 1;
                }

                // Filtrage Par Type : On Ignore Les Espèces Qui Ne Correspondent Pas Au Filtre
                if (typeSelectionne == "Alliés" && allie_enemy != 0)
                {
                    continue;
                }

                if (typeSelectionne == "Ennemies" && allie_enemy != 1)
                {
                    continue;
                }

                // Création Et Ajout De La Carte Visuelle De La Race Dans Le Panneau
                ucRaces newRaces = new ucRaces(nom, origine, couleur, image, insArme, attitude, dateContact, allie_enemy);
                flowLayoutPanel1.Controls.Add(newRaces);
            }
        }

        // Quand Le Nom Change : Réinitialise Les Autres Filtres Et Rafraîchit L'Affichage
        private void cboNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (cboColor.Items.Count > 0)
                {
                    cboColor.SelectedIndex = 0;
                }
                if (cboType.Items.Count > 0)
                {
                    cboType.SelectedIndex = 0;
                }
                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);
                enUpdate = false;
            }
        }

        // Quand La Couleur Change : Réinitialise Le Filtre Par Nom Et Rafraîchit L'Affichage
        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (cboNom.Items.Count > 0)
                {
                    cboNom.SelectedIndex = 0;
                }
                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);
                enUpdate = false;
            }
        }

        // Quand Le Type Change : Réinitialise Le Filtre Par Nom Et Rafraîchit L'Affichage
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (cboNom.Items.Count > 0)
                {
                    cboNom.SelectedIndex = 0;
                }
                genererRaces(chkBoxTriAlpha.Checked, chkBoxTriCoul.Checked);
                enUpdate = false;
            }
        }

        // Bouton Réinitialiser : Remet Tous Les Filtres Et Tris À Zéro
        private void btnRes_Click(object sender, EventArgs e)
        {
            enUpdate = true;
            chkBoxTriAlpha.Checked = false;
            chkBoxTriCoul.Checked = false;
            cboColor.SelectedIndex = 0;
            cboNom.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
            enUpdate = false;
            genererRaces(false, false);
        }

        // Clic Sur L'Image De Fermeture : Ferme Le Formulaire
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}