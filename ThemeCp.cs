using System;
using System.Drawing;
using System.Windows.Forms;

public static class ThemeCp
{
    // Les couleurs : retour au cyan de base, et ajout du bleu foncé pour les bordures
    private static readonly Color fondSombre = Color.FromArgb(15, 15, 20);
    private static readonly Color bleuNeon = Color.FromArgb(0, 255, 255); // Ton cyan d'origine
    private static readonly Color bleuFonceBordure = Color.FromArgb(0, 102, 204); // Bleu saphir
    private static readonly Color fondControle = Color.FromArgb(10, 25, 40);

    public static void AppliquerTheme(Control controleParent)
    {
        // Style général
        controleParent.BackColor = fondSombre;
        controleParent.ForeColor = bleuNeon;

        foreach (Control controle in controleParent.Controls)
        {
            // --- Gestion dynamique de la police ---
            string nomPoliceActuelle = controle.Font.Name;
            float tailleActuelle = controle.Font.Size;
            FontStyle styleActuel = controle.Font.Style;

            if (nomPoliceActuelle != "Consolas")
            {
                controle.Font = new Font("Consolas", tailleActuelle, styleActuel);
            }

            // --- Appel récursif ---
            AppliquerTheme(controle);

            // --- Personnalisation ---
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
            else if (controle is GroupBox grp)
            {
                // Force le fond de la GroupBox à transparent pour révéler l'image du formulaire
                grp.BackColor = Color.Transparent;

                grp.Paint -= DessinerGroupBoxNeon;
                grp.Paint += DessinerGroupBoxNeon;
            }
            else if (controle is TabControl tab)
            {
                tab.DrawMode = TabDrawMode.OwnerDrawFixed;
                tab.DrawItem -= DessinerOngletsNeon;
                tab.DrawItem += DessinerOngletsNeon;
            }
            else if (controle is Panel pnl)
            {
                if (pnl.BorderStyle == BorderStyle.FixedSingle || pnl.BorderStyle == BorderStyle.Fixed3D)
                {
                    pnl.BorderStyle = BorderStyle.None;
                    pnl.Paint -= DessinerBordurePanelNeon;
                    pnl.Paint += DessinerBordurePanelNeon;
                }
            }
        }
    }

    // --- Méthodes de dessin ---

    private static void DessinerGroupBoxNeon(object sender, PaintEventArgs e)
    {
        GroupBox box = (GroupBox)sender;
        Graphics g = e.Graphics;

        // Le texte reste cyan, mais le trait de la bordure utilise le bleu foncé
        Brush pinceauTexte = new SolidBrush(bleuNeon);
        using (Pen styloBordure = new Pen(bleuFonceBordure, 1.0f))
        {
            // MODIFICATION : Suppression de g.Clear(fondSombre) pour préserver la transparence

            SizeF tailleTexte = g.MeasureString(box.Text, box.Font);
            int positionTexteY = (int)(tailleTexte.Height / 2);
            Rectangle rect = new Rectangle(0, positionTexteY, box.Width - 1, box.Height - positionTexteY - 1);

            // Dessin du texte (Cyan)
            g.DrawString(box.Text, box.Font, pinceauTexte, box.Padding.Left + 5, 0);

            // Dessin des bordures (Bleu foncé)
            g.DrawLine(styloBordure, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            g.DrawLine(styloBordure, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            g.DrawLine(styloBordure, new Point(rect.X + rect.Width, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y));
            g.DrawLine(styloBordure, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + box.Padding.Left + (int)tailleTexte.Width + 8, rect.Y));
            g.DrawLine(styloBordure, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
        }
    }

    private static void DessinerOngletsNeon(object sender, DrawItemEventArgs e)
    {
        TabControl tab = (TabControl)sender;
        Graphics g = e.Graphics;

        bool estSelectionne = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
        Brush pinceauFond = new SolidBrush(estSelectionne ? fondControle : fondSombre);
        Brush pinceauTexte = new SolidBrush(bleuNeon); // Cyan

        g.FillRectangle(pinceauFond, e.Bounds);

        if (estSelectionne)
        {
            using (Pen styloBordure = new Pen(bleuNeon, 1)) // Cyan
            {
                g.DrawRectangle(styloBordure, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
            }
        }

        StringFormat format = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        g.DrawString(tab.TabPages[e.Index].Text, e.Font, pinceauTexte, e.Bounds, format);
    }

    private static void DessinerBordurePanelNeon(object sender, PaintEventArgs e)
    {
        Panel pnl = (Panel)sender;
        using (Pen styloBordure = new Pen(bleuNeon, 1.0f)) // Cyan
        {
            e.Graphics.DrawRectangle(styloBordure, 0, 0, pnl.Width - 1, pnl.Height - 1);
        }
    }
}