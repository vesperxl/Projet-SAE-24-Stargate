using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SAE_24_Stargate
{
    internal class ThemeCp
    {
        public static void AppliquerTheme(Control controleParent)
        {
            // Définition des couleurs Cyberpunk
            Color fondSombre = Color.FromArgb(15, 15, 20); // Gris très foncé / Noir
            Color bleuNeon = Color.FromArgb(0, 255, 255); // Cyan pur
            Color fondControle = Color.FromArgb(10, 25, 40); // Bleu nuit pour les TextBox

            // Style général de la fenêtre
            controleParent.BackColor = fondSombre;
            controleParent.ForeColor = bleuNeon;
            controleParent.Font = new Font("Consolas", 10F, FontStyle.Bold);

            // Boucle sur tous les éléments à l'intérieur de la fenêtre
            foreach (Control controle in controleParent.Controls)
            {
                // Appel récursif au cas où il y a des panels dans des panels
                AppliquerTheme(controle);

                // Personnalisation spécifique selon le type du contrôle
                if (controle is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = bleuNeon;
                    btn.FlatAppearance.BorderSize = 2;
                    btn.BackColor = fondSombre;
                    btn.Cursor = Cursors.Hand;
                }
                else if (controle is TextBox txt)
                {
                    txt.BackColor = fondControle;
                    txt.ForeColor = bleuNeon;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (controle is DataGridView grid)
                {
                    grid.BackgroundColor = fondSombre;
                    grid.GridColor = bleuNeon;
                    grid.DefaultCellStyle.BackColor = fondControle;
                    grid.DefaultCellStyle.ForeColor = bleuNeon;
                    grid.EnableHeadersVisualStyles = false;
                    grid.ColumnHeadersDefaultCellStyle.BackColor = fondSombre;
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = bleuNeon;
                }
            }
        }
    }
}
