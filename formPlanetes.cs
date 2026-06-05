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
    public partial class formPlanetes : Form
    {
        // Chaîne De Connexion À La Base De Données SQLite
        string chcon = @"Data Source=Stargate.db";
        // Nom De La Planète Actuellement Sélectionnée
        String planetSelect = "";

        // Booléen Pour Empêcher Les Boucles D'Événements
        private bool enUpdate = false;

        public formPlanetes()
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
        private void formPlanetes_Load(object sender, EventArgs e)
        {
            // Abonnement Des Événements Aux Méthodes Correspondantes
            cboData.SelectedIndexChanged += cboData_SelectedIndexChanged;
            cboAliens.SelectedIndexChanged += cboAliens_SelectedIndexChanged; 
            chkTriAlpha.CheckedChanged += chkTriAlpha_CheckedChanged;
            ChkTriTemp.CheckedChanged += ChkTriTemp_CheckedChanged;
            chkTriPes.CheckedChanged += chkTriPes_CheckedChanged;

            // Remplissage Du Combobox De Filtre Par DataBaz
            cboData.Items.Clear();
            cboData.Items.Add("Toutes les planètes");
            cboData.Items.Add("Avec DataBaz");
            cboData.Items.Add("Sans DataBaz");

            // Remplissage Du Combobox De Filtre Par Présence D'Espèces
            cboAliens.Items.Clear();
            cboAliens.Items.Add("Peu importe");
            cboAliens.Items.Add("Avec espèces");
            cboAliens.Items.Add("Sans aucune espèce");

            // Sélection Des Index Par Défaut Sans Déclencher Les Événements
            enUpdate = true;
            cboData.SelectedIndex = 0;
            cboAliens.SelectedIndex = 0;
            enUpdate = false;

            // Affichage Initial Des Planètes Sans Tri
            genererPlanetes(false, false, false);
        }

        // Méthode Principale : Génère Et Affiche Les Cartes De Planètes Selon Les Filtres Et Le Tri
        private void genererPlanetes(bool alpha, bool temp, bool pes)
        {
            // Nettoyage Des Deux Panneaux Avant De Les Remplir À Nouveau
            flpMonstres.Controls.Clear();
            flpPlanet.Controls.Clear();

            // Choix De L'Ordre De Tri Selon Les Cases Cochées
            string ordreTri = "";

            if (alpha)
            {
                ordreTri = "nom ASC";
            }
            else if (temp)
            {
                ordreTri = "temperature ASC";
            }
            else if (pes)
            {
                ordreTri = "gravite ASC";
            }

            // Construction Des Conditions De Filtre Selon La Sélection Du Combobox DataBaz
            List<string> conditions = new List<string>();

            if (cboData.SelectedItem != null && cboData.SelectedIndex != 0)
            {
                if (cboData.SelectedIndex == 1)
                {
                    conditions.Add("dataBazON = 1");
                }
                else if (cboData.SelectedIndex == 2)
                {
                    conditions.Add("(dataBazON = 0 OR dataBazON IS NULL)");
                }
            }

            string filtre = string.Join(" AND ", conditions);

            // Parcours De Chaque Planète Filtrée Et Triée
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Planete"].Select(filtre, ordreTri))
            {
                string nom = row["nom"].ToString();

                // Filtrage Par Présence Ou Absence D'Espèces Sur La Planète
                if (cboAliens.SelectedItem != null && cboAliens.SelectedIndex != 0)
                {
                    bool aDesAliens = MesDatas.DsGlobal.Tables["Habiter"].Select("nomPlanete = '" + nom.Replace("'", "''") + "'").Length > 0;

                    if (cboAliens.SelectedIndex == 1 && !aDesAliens)
                    {
                        continue;
                    }
                    else if (cboAliens.SelectedIndex == 2 && aDesAliens)
                    {
                        continue;
                    }
                }

                // Chargement De L'Image De La Planète Depuis Les Ressources
                Image image = (Image)Properties.Resources.ResourceManager.GetObject(nom);

                // Image Par Défaut Si Aucune Image N'Est Trouvée
                if (image == null)
                {
                    image = Properties.Resources.PlanetNotFound;
                }

                // Création Et Ajout De La Carte Visuelle De La Planète Dans Le Panneau
                ucPlanetes ucPlanete = new ucPlanetes(nom, image);
                ucPlanete.Click += new EventHandler(ucPlanete_Click);
                flpPlanet.Controls.Add(ucPlanete);
            }
        }

        // Quand Le Filtre DataBaz Change : Rafraîchit L'Affichage Des Planètes
        private void cboData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        // Quand Le Filtre Espèces Change : Rafraîchit L'Affichage Des Planètes
        private void cboAliens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        // Quand Le Tri Alphabétique Est Coché : Décoche Les Autres Tris Et Rafraîchit
        private void chkTriAlpha_CheckedChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (chkTriAlpha.Checked)
                {
                    ChkTriTemp.Checked = false;
                    chkTriPes.Checked = false;
                }
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        // Quand Le Tri Par Température Est Coché : Décoche Les Autres Tris Et Rafraîchit
        private void ChkTriTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (ChkTriTemp.Checked)
                {
                    chkTriAlpha.Checked = false;
                    chkTriPes.Checked = false;
                }
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        // Quand Le Tri Par Gravité Est Coché : Décoche Les Autres Tris Et Rafraîchit
        private void chkTriPes_CheckedChanged(object sender, EventArgs e)
        {
            if (!enUpdate)
            {
                enUpdate = true;
                if (chkTriPes.Checked)
                {
                    chkTriAlpha.Checked = false;
                    ChkTriTemp.Checked = false;
                }
                genererPlanetes(chkTriAlpha.Checked, ChkTriTemp.Checked, chkTriPes.Checked);
                enUpdate = false;
            }
        }

        // Quand Une Planète Est Cliquée : Affiche Ses Informations Et Les Espèces Qui L'Habitent
        private void ucPlanete_Click(object sender, EventArgs e)
        {
            // Récupération Du Nom De La Planète Cliquée
            ucPlanetes planeteClicked = sender as ucPlanetes;

            if (planeteClicked != null)
            {
                planetSelect = planeteClicked.nomPlanete;
            }

            // Affichage De La Température Ou "Inconnu" Si Absente
            if (MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["temperature"] != DBNull.Value)
            {
                lblTemp.Text = MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["temperature"].ToString() + "°C";
            }
            else
            {
                lblTemp.Text = "Inconnu";
            }

            // Affichage De La Gravité Ou "Inconnu" Si Absente
            if (MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["gravite"] != DBNull.Value)
            {
                lblPes.Text = MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["gravite"].ToString() + "g";
            }
            else
            {
                lblPes.Text = "Inconnu";
            }

            // Affichage De La Disponibilité De La DataBaz Sur La Planète
            if (MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["dataBazON"] != DBNull.Value && Convert.ToInt32(MesDatas.DsGlobal.Tables["Planete"].Select("nom = '" + planetSelect + "'")[0]["dataBazON"]) == 1)
            {
                lblDatabaz.Text = "Disponible";
            }
            else
            {
                lblDatabaz.Text = "Indisponible";
            }

            // Nettoyage Du Panneau Des Espèces Avant Affichage
            flpMonstres.Controls.Clear();

            // Récupération De Toutes Les Espèces Habitant Cette Planète
            DataRow[] habitations = MesDatas.DsGlobal.Tables["Habiter"].Select("nomPlanete = '" + planetSelect + "'");

            if (habitations.Length > 0)
            {
                // Parcours De Chaque Espèce Présente Sur La Planète
                foreach (DataRow hab in habitations)
                {
                    string idEspece = hab["idEspece"].ToString();

                    // Vérification Si L'Espèce Est Alliée Ou Ennemie
                    DataRow[] estAllie = MesDatas.DsGlobal.Tables["Allie"].Select("idEspece = " + idEspece);
                    DataRow[] estEnnemi = MesDatas.DsGlobal.Tables["Ennemi"].Select("idEspece = " + idEspece);

                    DataRow[] espece = MesDatas.DsGlobal.Tables["Espece"].Select("id = " + idEspece);

                    if (espece.Length > 0)
                    {
                        String nom = espece[0]["nom"].ToString();
                        String couleur = espece[0]["couleur"].ToString();

                        // Traduction De La Couleur En Anglais Pour L'Affichage
                        if (dicoTrad.ContainsKey(couleur))
                        {
                            couleur = dicoTrad[couleur];
                        }

                        // Chargement De L'Image De L'Espèce Depuis Les Ressources
                        Image image = (Image)Properties.Resources.ResourceManager.GetObject(nom);

                        string insArme = "";
                        string attitude = "";
                        // Préparation Du Texte Du Pourcentage De Population
                        string pourcentage = " % De Population : ";
                        // -1 = Neutre, 0 = Allié, 1 = Ennemi
                        int allie_enemy = -1;

                        // Récupération Des Informations Spécifiques Aux Alliés
                        if (estAllie.Length > 0)
                        {
                            insArme = estAllie[0]["instrumentMusique"].ToString();
                            attitude = estAllie[0]["degreBienveillance"].ToString();
                            allie_enemy = 0;
                        }
                        // Récupération Des Informations Spécifiques Aux Ennemis
                        else if (estEnnemi.Length > 0)
                        {
                            insArme = estEnnemi[0]["typeArme"].ToString();
                            attitude = estEnnemi[0]["degreAgressivite"].ToString();
                            allie_enemy = 1;
                        }

                        // Ajout Du Pourcentage De Population De L'Espèce Sur La Planète
                        pourcentage += hab["pourcentage"].ToString() + " %";

                        // Création Et Ajout De La Carte Visuelle De L'Espèce Dans Le Panneau
                        ucRaces ucRace = new ucRaces(nom, planetSelect, couleur, image, insArme, attitude, pourcentage, allie_enemy);
                        flpMonstres.Controls.Add(ucRace);
                    }
                }
            }
            else
            {
                // Affichage D'Un Message Si Aucune Espèce N'Habite La Planète
                Label lbl = new Label();
                lbl.Text = "AUCUNE ESPÈCE";
                lbl.Font = new Font("Arial", 64, FontStyle.Bold);
                lbl.ForeColor = Color.Red;
                lbl.AutoSize = false;
                lbl.Size = flpMonstres.Size;
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                flpMonstres.Controls.Add(lbl);
            }
        }

        // Clic Sur L'Image De Fermeture : Ferme Le Formulaire
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Bouton Réinitialiser : Remet Tous Les Filtres Et Tris À Zéro
        private void button1_Click(object sender, EventArgs e)
        {
            cboAliens.SelectedIndex = 0;
            cboData.SelectedIndex = 0;
            chkTriAlpha.Checked = false;
            chkTriPes.Checked = false;
            ChkTriTemp.Checked = false;

            genererPlanetes(false, false, false);
        }
    }
}