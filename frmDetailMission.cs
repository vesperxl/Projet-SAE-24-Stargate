using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SAE_24_Stargate
{
    public partial class frmDetailMission : Form
    {

        private string nomPlanete;
        private int num;
        private string status;
        public frmDetailMission(string nomPlanete, int num, string status)
        {
            InitializeComponent();
            this.nomPlanete = nomPlanete;
            this.num = num;
            this.status = status;
        }
        private bool ongletCharge = false;
        BindingSource bsJournal = new BindingSource();

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
           if (status.Equals("Terminée"))
            {
                btnAdd.Enabled = false;
                pictureInfo.Visible = true;
                ToolTip tooltip = new ToolTip();
                tooltip.SetToolTip(pictureInfo, "Impossible d'ajouter des informations à une mission qui est terminée.");

            }
            
            


            //Calcul du solde apres depenses
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Depense"].Rows)
            {
                if (row["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row["numeroMission"]) == num)
                {
                    budget -= Convert.ToInt16(row["montant"]);
                }
            }

            foreach(DataRow row in MesDatas.DsGlobal.Tables["Contact"].Rows)
            {
                if (row["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row["numeroMission"]) == num)
                {
                    budget -= Convert.ToInt16(row["sommeVersee"]);
                }
            }
            lblSoldeApresDepense.Text = budget.ToString() + " $G";
            richTextFeuilleRoute.Text = ligneMission[0]["feuilleDeRoute"].ToString();

            //Ajout des objectif
            Label lblObjData = new Label();
            lblObjData.AutoSize = true; 
            lblObjData.Text = ligneMission[0]["objectifDatabaz"].ToString() + "Kilo de Databaz";
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


        private void tabGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabGeneral.SelectedTab == tabJournalMission && !ongletCharge)
            {
                ongletCharge = true;

                //Binding source 
                bsJournal.DataSource = MesDatas.DsGlobal.Tables["JournalDeBord"];
                bsJournal.Filter = "nomPlanete = '" + nomPlanete + "' AND numero = " + num;
                lblDate.DataBindings.Add("Text", bsJournal, "dateJ");
                lblEvent.DataBindings.Add("Text", bsJournal, "commentaires");


                BindingSource bsContact = new BindingSource();
                bsContact.DataSource = MesDatas.DsGlobal.Tables["Contact"];
                bsContact.Filter = "nomPlanete = '" + nomPlanete + "' AND numeroMission = " + num;
                dgvContact.DataSource = bsContact;
                dgvContact.Columns["nomCodeInformateur"].Visible = false;
                dgvContact.Columns["nomPlanete"].Visible = false;
                dgvContact.Columns["numeroMission"].Visible = false;
                dgvContact.Columns["dateC"].HeaderText = "Date";
                dgvContact.Columns["sommeVersee"].HeaderText = "Somme";
                dgvContact.Columns["appreciation"].HeaderText = "Appréciation";
                dgvContact.Columns["nomInformateur"].HeaderText = "Nom de l'informateur";

                dgvContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvContact.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvContact.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                BindingSource bsDepense = new BindingSource();
                bsDepense.DataSource = MesDatas.DsGlobal.Tables["Depense"];
                bsDepense.Filter = "nomPlanete = '" + nomPlanete + "' AND numeroMission = " + num;
                dgvDepense.DataSource = bsDepense;
                dgvDepense.Columns["idTypeDepense"].Visible = false;
                dgvDepense.Columns["nomPlanete"].Visible = false;
                dgvDepense.Columns["numeroMission"].Visible = false;
                dgvDepense.Columns["id"].HeaderText = "N°";
                dgvDepense.Columns["dateD"].HeaderText = "Date";
                dgvDepense.Columns["montant"].HeaderText = "Montant";
                dgvDepense.Columns["motif"].HeaderText = "Motif";
                dgvDepense.Columns["nomDepense"].HeaderText = "Type de dépense";

                dgvDepense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDepense.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDepense.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                float sommeVerse = 0;
                
                foreach(DataGridViewRow Row in dgvContact.Rows)
                {
                    sommeVerse += Convert.ToInt16(Row.Cells["sommeVersee"].Value);
                   
                }


                lblSommeVersee.Text = "Somme versée : "  + sommeVerse.ToString() + " $G";

                float totDepense = 0;

                foreach (DataGridViewRow Row in dgvDepense.Rows)
                {
                    totDepense += Convert.ToInt16(Row.Cells["Montant"].Value);

                }
                lblTotDepense.Text = "Total des dépenses : " + totDepense.ToString() + " $G";
            }

            if(!MesDatas.DsGlobal.Tables.Contains("BilanCapture" + nomPlanete + "-" + num))
            {
                DataTable tblBilan = new DataTable("BilanCapture" + nomPlanete + "-" + num);
                tblBilan.Columns.Add("nomEspece", typeof(string));
                tblBilan.Columns.Add("objectifInitial", typeof(int));
                tblBilan.Columns.Add("nbCapture", typeof(int));
                tblBilan.Columns.Add("taux", typeof(string));
               
                foreach (DataRow row in MesDatas.DsGlobal.Tables["ObjectifCapture"].Rows)
                {
                    

                    if (row["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row["numeroMission"]) == num)
                    {
                        int nbCapture = 0;
                        string tauxFormat = "0.00%";

                        string nomEspece = MesDatas.DsGlobal.Tables["Espece"].Select("id = " + row["idEspeceEnnemi"])[0]["nom"].ToString();
                        int objectifCapture = Convert.ToInt16(row["objectif"]);

                        foreach (DataRow row2 in MesDatas.DsGlobal.Tables["Capturer"].Rows)
                        {
                            if (row2["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row2["numeroMission"]) == num && row2["idEspeceEnnemi"].ToString() == row["idEspeceEnnemi"].ToString())
                            {
                                nbCapture += Convert.ToInt16(row2["nombre"]);
                                float taux = ((float)nbCapture / (float)objectifCapture) * 100;
                                tauxFormat = taux.ToString("0.00") + " %";

                            }


                        }

                        tblBilan.Rows.Add(nomEspece, objectifCapture, nbCapture, tauxFormat);

                    }
                }

                MesDatas.DsGlobal.Tables.Add(tblBilan);
            }
           
            
            dgvCapture.DataSource = MesDatas.DsGlobal.Tables["BilanCapture" + nomPlanete + "-" + num];
            dgvCapture.Columns["nomEspece"].HeaderText = "Espèce";
            dgvCapture.Columns["objectifInitial"].HeaderText = "Objectif initial";
            dgvCapture.Columns["nbCapture"].HeaderText = "Nombre de capture";
            dgvCapture.Columns["taux"].HeaderText = "Taux de réussite";
           

            dgvCapture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCapture.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCapture.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;









        }

        private void pictureFullGauche_Click(object sender, EventArgs e)
        {
            bsJournal.MoveFirst();
        }

        private void pictureGauche_Click(object sender, EventArgs e)
        {
            bsJournal.MovePrevious();
        }

        private void pictureDroite_Click(object sender, EventArgs e)
        {
            bsJournal.MoveNext();
        }

        private void pictureFullDroite_Click(object sender, EventArgs e)
        {
            bsJournal.MoveLast();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAjoutInfo frm = new frmAjoutInfo(nomPlanete, num);
            frm.ShowDialog();
        }
    }
}
