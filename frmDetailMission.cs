using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            ThemeCp.AppliquerTheme(this);
        }
        private bool ongletCharge = false;
        BindingSource bsJournal = new BindingSource();

        private void frmDetailMission_Load(object sender, EventArgs e)
        {
            lblNomMission.Text = "Mission " + nomPlanete + " - " + num;

            DataRow[] ligneMission = MesDatas.DsGlobal.Tables["Mission"].Select("nomPlanete = '" + nomPlanete + "' AND numero = " + num);
            
            picturePlanete.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(nomPlanete);
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
            
            lblObjData.Text = ligneMission[0]["objectifDatabaz"].ToString() + "Tonnes de Databaz";
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
            System.Drawing.Image imgChef = Properties.Resources.Chef;
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
                    System.Drawing.Image imgMilitaire = Properties.Resources.soldat;

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
                    System.Drawing.Image imgCivil = Properties.Resources.Civil;
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            string chemin = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BilanMission_" + nomPlanete + "-" + num + ".pdf";

            try
            {
                // recuperation d'info de base
                DataRow[] ligneMission = MesDatas.DsGlobal.Tables["Mission"].Select("nomPlanete = '" + nomPlanete + "' AND numero = " + num);
                string matriculeChef = ligneMission[0]["MatriculeChef"].ToString();
                DataRow[] rowChef = MesDatas.DsGlobal.Tables["Membre"].Select("matricule = '" + matriculeChef + "'");
                string gradeChef = MesDatas.DsGlobal.Tables["Militaire"].Select("matriculeMembre = '" + matriculeChef + "'")[0]["grade"].ToString();

                // init document pdf
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(chemin, FileMode.Create));
                doc.Open();

                // création font et autre element graphique
                iTextSharp.text.Font TitleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
                iTextSharp.text.Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                iTextSharp.text.Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                LineSeparator separator = new LineSeparator(1f, 100f, BaseColor.DARK_GRAY, Element.ALIGN_CENTER, -1);

                // header
                Paragraph titreDoc = new Paragraph("RAPPORT DE MISSION STARGATE", TitleFont);
                titreDoc.Alignment = Element.ALIGN_CENTER;
                doc.Add(titreDoc);
                Paragraph pDateEdition = new Paragraph("Édité le " + DateTime.Now.ToString("dd/MM/yyyy"), normalFont);
                pDateEdition.Alignment = Element.ALIGN_RIGHT;
                doc.Add(pDateEdition);
                doc.Add(new Chunk(separator));
                doc.Add(new Paragraph(" "));
                

                // première info à afficher, dans un tableau invisible
                PdfPTable tableInfos = new PdfPTable(2);
                tableInfos.WidthPercentage = 100;
                tableInfos.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER; 
                tableInfos.DefaultCell.Padding = 4f;

                tableInfos.AddCell(new Phrase("Mission : " + nomPlanete + " - " + num, boldFont));
                tableInfos.AddCell(new Phrase("Date de départ : " + lblDateDépart.Text, normalFont));

                tableInfos.AddCell(new Phrase("Chef : " + rowChef[0]["prenom"].ToString() + " " + rowChef[0]["nom"].ToString(), normalFont));
                tableInfos.AddCell(new Phrase("Date de fin : " + lblDateDeFin.Text, normalFont));

                tableInfos.AddCell(new Phrase("Membres requis : " + Regex.Match(grpMembre.Text, @"\d+").Value, normalFont));
                tableInfos.AddCell(new Phrase("Budget initial : " + lblBudget.Text, normalFont));

                tableInfos.AddCell(new Phrase("Objectif DataBaz : " + ligneMission[0]["objectifDatabaz"].ToString() + " Tonnes", boldFont));
                tableInfos.AddCell(new Phrase("Budget restant : " + lblSoldeApresDepense.Text, boldFont));

                tableInfos.AddCell(new Phrase(" ", normalFont));

                doc.Add(tableInfos);
                doc.Add(new Paragraph(" "));

                // affichage feuille de route
              
                doc.Add(new Paragraph("Feuille de route :", headerFont));
                doc.Add(new Paragraph(richTextFeuilleRoute.Text, normalFont));
                doc.Add(new Paragraph(" "));
                doc.Add(new Chunk(separator));
                doc.Add(new Paragraph(" "));

                //liste membre
                doc.Add(new Paragraph("LISTE DES MEMBRE", headerFont));
                doc.Add(new Paragraph(" "));

                PdfPTable tableMembre = new PdfPTable(2);
                tableMembre.WidthPercentage = 100; 
                tableMembre.SetWidths(new float[] { 3f, 2f });
                tableMembre.DefaultCell.Padding = 6f; 
                tableMembre.DefaultCell.BorderColor = BaseColor.GRAY;

                PdfPCell cellNom = new PdfPCell(new Phrase("Nom et Prénom", headerFont));
                PdfPCell cellMetier = new PdfPCell(new Phrase("Spécialité / Grade", headerFont));
                cellNom.BackgroundColor = BaseColor.LIGHT_GRAY;
                cellMetier.BackgroundColor = BaseColor.LIGHT_GRAY;
                cellNom.Padding = 6f;
                cellMetier.Padding = 6f;
                tableMembre.AddCell(cellNom);
                tableMembre.AddCell(cellMetier);

                tableMembre.AddCell(new Phrase(rowChef[0]["nom"].ToString() + " " + rowChef[0]["prenom"].ToString() + " (CHEF)", boldFont));
                tableMembre.AddCell(new Phrase(gradeChef, normalFont));

                foreach (DataRow row in MesDatas.DsGlobal.Tables["Composer"].Rows)
                {
                    if (row["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row["numeroMission"]) == num && row["MatriculeMembre"].ToString().StartsWith("M") && row["MatriculeMembre"].ToString() != matriculeChef)
                    {
                        DataRow[] rowMilitaire = MesDatas.DsGlobal.Tables["Membre"].Select("matricule = '" + row["matriculeMembre"] + "'");
                        string gradeMilitaire = MesDatas.DsGlobal.Tables["Militaire"].Select("matriculeMembre = '" + row["matriculeMembre"] + "'")[0]["grade"].ToString();
                        tableMembre.AddCell(new Phrase(rowMilitaire[0]["nom"].ToString() + " " + rowMilitaire[0]["prenom"].ToString(), normalFont));
                        tableMembre.AddCell(new Phrase(gradeMilitaire, normalFont));
                    }
                }

                foreach (DataRow row in MesDatas.DsGlobal.Tables["Composer"].Rows)
                {
                    if (row["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(row["numeroMission"]) == num && row["MatriculeMembre"].ToString().StartsWith("C"))
                    {
                        DataRow[] rowCivil = MesDatas.DsGlobal.Tables["Membre"].Select("matricule = '" + row["matriculeMembre"] + "'");
                        string specialiteCivil = MesDatas.DsGlobal.Tables["Civil"].Select("matriculeMembre = '" + row["matriculeMembre"] + "'")[0]["Specialite"].ToString();
                        tableMembre.AddCell(new Phrase(rowCivil[0]["nom"].ToString() + " " + rowCivil[0]["prenom"].ToString(), normalFont));
                        tableMembre.AddCell(new Phrase(specialiteCivil, normalFont));
                    }
                }
                doc.Add(tableMembre);
                doc.Add(new Paragraph(" "));
                doc.Add(new Chunk(separator));
                doc.Add(new Paragraph(" "));

                // bilan capture
                doc.Add(new Paragraph("BILAN DES CAPTURES", headerFont));
                doc.Add(new Paragraph(" "));

                PdfPTable tableCapture = new PdfPTable(4);
                tableCapture.WidthPercentage = 100;
                tableCapture.DefaultCell.Padding = 6f;
                tableCapture.DefaultCell.BorderColor = BaseColor.GRAY;
                tableCapture.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER; 

                string[] headersCapture = { "Espèce", "Objectif Initial", "Nombre de capture", "Taux de réussite" };
                foreach (string titre in headersCapture)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(titre, headerFont));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 6f;
                    tableCapture.AddCell(cell);
                }

                string nomTableBilan = "BilanCapture" + nomPlanete + "-" + num;
                foreach (DataRow rowBilan in MesDatas.DsGlobal.Tables[nomTableBilan].Rows)
                {

                    PdfPCell cellEspece = new PdfPCell(new Phrase(rowBilan["nomEspece"].ToString(), normalFont));
                    cellEspece.Padding = 6f;
                    cellEspece.BorderColor = BaseColor.GRAY;
                    tableCapture.AddCell(cellEspece);

                    tableCapture.AddCell(new Phrase(rowBilan["objectifInitial"].ToString(), normalFont));
                    tableCapture.AddCell(new Phrase(rowBilan["nbCapture"].ToString(), normalFont));
                    tableCapture.AddCell(new Phrase(rowBilan["taux"].ToString(), normalFont));
                }
                doc.Add(tableCapture);
                doc.Add(new Paragraph(" "));
                doc.Add(new Chunk(separator));
                doc.Add(new Paragraph(" "));

               //dépenses
                doc.Add(new Paragraph("DÉPENSES DE LA MISSION", headerFont));
                doc.Add(new Paragraph(" "));

                PdfPTable tableDepense = new PdfPTable(4);
                tableDepense.WidthPercentage = 100;
                tableDepense.SetWidths(new float[] { 1.5f, 3f, 2f, 1.5f });
                tableDepense.DefaultCell.Padding = 6f;
                tableDepense.DefaultCell.BorderColor = BaseColor.GRAY;

                string[] headersDepense = { "Date", "Motif", "Type de dépense", "Montant" };
                foreach (string titre in headersDepense)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(titre, headerFont));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 6f;
                    tableDepense.AddCell(cell);
                }

                float totalDepenses = 0;
                foreach (DataRow rowDepense in MesDatas.DsGlobal.Tables["Depense"].Rows)
                {
                    if (rowDepense["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(rowDepense["numeroMission"]) == num)
                    {
                        tableDepense.AddCell(new Phrase(Convert.ToDateTime(rowDepense["dateD"]).ToShortDateString(), normalFont));
                        tableDepense.AddCell(new Phrase(rowDepense["motif"].ToString(), normalFont));
                        tableDepense.AddCell(new Phrase(rowDepense["nomDepense"].ToString(), normalFont));

                        PdfPCell cellMontant = new PdfPCell(new Phrase(rowDepense["montant"].ToString() + " $G", normalFont));
                        cellMontant.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cellMontant.Padding = 6f;
                        cellMontant.BorderColor = BaseColor.GRAY;
                        tableDepense.AddCell(cellMontant);

                        totalDepenses += Convert.ToSingle(rowDepense["montant"]);
                    }
                }
                doc.Add(tableDepense);

                Paragraph pTotal = new Paragraph("Total des dépenses : " + totalDepenses.ToString() + " $G", boldFont);
                pTotal.Alignment = Element.ALIGN_RIGHT;
                doc.Add(pTotal);
                doc.Add(new Paragraph(" "));
                doc.Add(new Chunk(separator));
                doc.Add(new Paragraph(" "));

                // contact
                doc.Add(new Paragraph("CONTACTS DE LA MISSION", headerFont));
                doc.Add(new Paragraph(" "));

                PdfPTable tableContact = new PdfPTable(4);
                tableContact.WidthPercentage = 100;
                tableContact.SetWidths(new float[] { 1.5f, 3f, 2f, 1.5f });
                tableContact.DefaultCell.Padding = 6f;
                tableContact.DefaultCell.BorderColor = BaseColor.GRAY;

                string[] headersContact = { "Date", "Informateur", "Appréciation", "Somme" };
                foreach (string titre in headersContact)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(titre, headerFont));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 6f;
                    tableContact.AddCell(cell);
                }

                float totalContact = 0;
                foreach (DataRow rowContact in MesDatas.DsGlobal.Tables["Contact"].Rows)
                {
                    if (rowContact["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(rowContact["numeroMission"]) == num)
                    {
                        tableContact.AddCell(new Phrase(Convert.ToDateTime(rowContact["dateC"]).ToShortDateString(), normalFont));
                        tableContact.AddCell(new Phrase(rowContact["nomInformateur"].ToString(), normalFont));
                        tableContact.AddCell(new Phrase(rowContact["appreciation"].ToString(), normalFont));

                        PdfPCell cellSomme = new PdfPCell(new Phrase(rowContact["sommeVersee"].ToString() + " $G", normalFont));
                        cellSomme.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cellSomme.Padding = 6f;
                        cellSomme.BorderColor = BaseColor.GRAY;
                        tableContact.AddCell(cellSomme);

                        totalContact += Convert.ToSingle(rowContact["sommeVersee"]);
                    }
                }
                doc.Add(tableContact);

                Paragraph pTotalContact = new Paragraph("Somme totale versée : " + totalContact.ToString() + " $G", boldFont);
                pTotalContact.Alignment = Element.ALIGN_RIGHT;
                doc.Add(pTotalContact);
                doc.Add(new Paragraph(" "));
                doc.Add(new Chunk(separator));
                doc.Add(new Paragraph(" "));

                // journal de bord
                doc.Add(new Paragraph("JOURNAL DE BORD", headerFont));
                doc.Add(new Paragraph(" "));

                PdfPTable tableJournal = new PdfPTable(2);
                tableJournal.WidthPercentage = 100;
                tableJournal.SetWidths(new float[] { 1.5f, 4.5f });
                tableJournal.DefaultCell.Padding = 6f;
                tableJournal.DefaultCell.BorderColor = BaseColor.GRAY;

                string[] headersJournal = { "Date", "Événements / Commentaires" };
                foreach (string titre in headersJournal)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(titre, headerFont));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 6f;
                    tableJournal.AddCell(cell);
                }

                foreach (DataRow rowJournal in MesDatas.DsGlobal.Tables["JournalDeBord"].Rows)
                {
                    if (rowJournal["nomPlanete"].ToString() == nomPlanete && Convert.ToInt16(rowJournal["numero"]) == num)
                    {
                        tableJournal.AddCell(new Phrase(Convert.ToDateTime(rowJournal["dateJ"]).ToShortDateString(), normalFont));
                        tableJournal.AddCell(new Phrase(rowJournal["commentaires"].ToString(), normalFont));
                    }
                }
                doc.Add(tableJournal);

                // fermeture    
                doc.Close();

                MessageBox.Show("Le PDF a bien été généré à l'emplacement suivant : " + chemin);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la création du PDF : " + ex.Message);
            }

        }

        private void tabDetailMission_Click(object sender, EventArgs e)
        {

        }
    }
}
