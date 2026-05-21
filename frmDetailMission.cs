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
    public partial class frmDetailMission : Form
    {

        String nomPlanete;
        int num;
        public frmDetailMission(string nomPlanete, int num)
        {
            InitializeComponent();
            this.nomPlanete = nomPlanete;
            this.num = num;
        }

        private void frmDetailMission_Load(object sender, EventArgs e)
        {
            lblNomMission.Text = "Mission " + nomPlanete + " - " + num;

            DataRow[] ligneMission = MesDatas.DsGlobal.Tables["Mission"].Select("nomPlanete = '" + nomPlanete + "' AND numero = " + num);

            picturePlanete.Image = (Image)Properties.Resources.ResourceManager.GetObject(nomPlanete);
            lblDateDépart.Text = ligneMission[0]["dateDepart"].ToString();
            lblDateDeFin.Text = ligneMission[0]["dateRetour"].ToString();
            lblBudget.Text = ligneMission[0]["budget"].ToString() + " $G";
            int budget = Convert.ToInt16(ligneMission[0]["budget"]);
            grpMembre.Text = "Membre (" + ligneMission[0]["nbMembreRequis"] + " requis)";


            //Calcul du solde apres depenses
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Depense"].Rows)
            {
                if (row["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row["numeroMission"]) == num)
                {
                    budget -= Convert.ToInt16(row["montant"]);
                }
            }
            lblSoldeApresDepense.Text = budget.ToString() + " $G";
            richTextFeuilleRoute.Text = ligneMission[0]["feuilleDeRoute"].ToString();

            //Ajout des objectif
            Label lblObjData = new Label();
            lblObjData.AutoSize = true;
            lblObjData.Text = ligneMission[0]["objectifDatabaz"].ToString() + " Databaz";
            flpObjectif.Controls.Add(lblObjData);
            Label sep = new Label();
            sep.AutoSize = true;
            sep.Text = "-----------------------------";
            flpObjectif.Controls.Add(sep);

            foreach (DataRow row in MesDatas.DsGlobal.Tables["ObjectifCapture"].Rows)
            {
                if (row["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row["numeroMission"]) == num)
                {
                    string nomEspece = MesDatas.DsGlobal.Tables["Espece"].Select("id = " + row["idEspeceEnnemi"])[0]["nom"].ToString();
                    Label lblObj = new Label();
                    lblObj.AutoSize = true; 
                    lblObj.Text = nomEspece + " ---> " + row["objectif"] + " prise(s)";
                    flpObjectif.Controls.Add(lblObj);



                }
            }

            //Recuperation des information du chef et ajout du UC
            string statutChef = MesDatas.DsGlobal.Tables["Militaire"].Select("matriculeMembre = '" + ligneMission[0]["MatriculeChef"] + "'")[0]["grade"].ToString();
            Image imgChef = Properties.Resources.Chef;
            DataRow[] rowChef = MesDatas.DsGlobal.Tables["Membre"].Select("matricule = '" + ligneMission[0]["MatriculeChef"] + "'");
            string chefNom = rowChef[0]["nom"].ToString();
            string chefPrenom = rowChef[0]["prenom"].ToString();
            ucCarteIdentité ucChef = new ucCarteIdentité(statutChef,chefNom,chefPrenom,imgChef);
            ucChef.BackColor = Color.DarkGreen;
            flpMembre.Controls.Add(ucChef);
            
            
            //2 boucle foreach pour afficher d'abord les militaire puis les civils
            
            //Ajout des UC des autre militaire de l'equipe 
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Composer"].Rows)
            {
                if (row["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row["numeroMission"]) == num && row["MatriculeMembre"].ToString().StartsWith("M"))
                {
                    DataRow[] rowMilitaire = MesDatas.DsGlobal.Tables["Membre"].Select("matricule = '" + row["matriculeMembre"] + "'");
                    string nomMilitaire = rowMilitaire[0]["nom"].ToString();
                    string prenomMilitaire = rowMilitaire[0]["prenom"].ToString();
                    string gradeMilitaire = MesDatas.DsGlobal.Tables["Militaire"].Select("matriculeMembre = '" + row["matriculeMembre"] + "'")[0]["grade"].ToString();
                    Image imgMilitaire = Properties.Resources.soldat;

                    ucCarteIdentité ucMilitaire = new ucCarteIdentité(gradeMilitaire, nomMilitaire, prenomMilitaire, imgMilitaire);
                    ucMilitaire.BackColor = Color.DarkOliveGreen;
                    flpMembre.Controls.Add(ucMilitaire);
                }
            }

            //2e boucle pour les civils
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Composer"].Rows)
            {
               if (row["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row["numeroMission"]) == num && row["MatriculeMembre"].ToString().StartsWith("C"))
               {
                    DataRow[] rowCivil = MesDatas.DsGlobal.Tables["Membre"].Select("matricule = '" + row["matriculeMembre"] + "'");
                    string nomCivil = rowCivil[0]["nom"].ToString();
                    string prenomCivil = rowCivil[0]["prenom"].ToString();
                    string specialiteCivil = MesDatas.DsGlobal.Tables["Civil"].Select("matriculeMembre = '" + row["matriculeMembre"] + "'")[0]["Specialite"].ToString();
                    Image imgCivil = Properties.Resources.Civil;
                    ucCarteIdentité ucCivil = new ucCarteIdentité(specialiteCivil, nomCivil, prenomCivil, imgCivil);
                    ucCivil.BackColor = Color.DarkCyan;
                    flpMembre.Controls.Add(ucCivil);
               }
                
            }

        }
    }
}
