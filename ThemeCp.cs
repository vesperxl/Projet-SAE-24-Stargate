using System;
using System.Drawing;
using System.Windows.Forms;

public static class ThemeCp
{
    // Palette de couleurs
    private static readonly Color DarkBackground = Color.FromArgb(15, 15, 20);
    private static readonly Color ControlBackground = Color.FromArgb(10, 25, 40);
    private static readonly Color NeonCyan = Color.FromArgb(0, 255, 255);
    private static readonly Color ElectricBlue = Color.FromArgb(0, 150, 255);
    private static readonly Color SapphireBlue = Color.FromArgb(0, 102, 204);
    private static readonly Color TitleMagenta = Color.FromArgb(255, 0, 255);

    // Fonction pour à appeler pour appliquer le style
    public static void ApplyTheme(Control parentControl)
    {
        parentControl.BackColor = DarkBackground;
        parentControl.ForeColor = NeonCyan;

        foreach (Control childControl in parentControl.Controls)
        {
            // Application du style aux enfant de manière récursive
            ApplyTheme(childControl);

            bool isTitle = (childControl.Tag != null && childControl.Tag.ToString() == "title");

            // Couleur différente si le contrôle est marqué comme titre
            if (isTitle)
            {
                childControl.ForeColor = TitleMagenta;
            }
            else
            {
                childControl.ForeColor = NeonCyan;

                string currentFontName = childControl.Font.Name;
                float currentFontSize = childControl.Font.Size;
                FontStyle currentFontStyle = childControl.Font.Style;

                // Meme font pour tout le monde sauf les titres
                if (currentFontName != "Consolas")
                {
                    childControl.Font = new Font("Consolas", currentFontSize, currentFontStyle);
                }
            }

            // Application des styles spécifiques par type de contrôle
            if (childControl is Button button)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = isTitle ? TitleMagenta : ElectricBlue;
                button.FlatAppearance.BorderSize = 2;
                button.BackColor = DarkBackground;
                button.Cursor = Cursors.Hand;

                button.Paint -= DrawDisabledButton;
                button.Paint += DrawDisabledButton;
            }
            else if (childControl is TextBox textBox)
            {
                textBox.BackColor = ControlBackground;
                textBox.ForeColor = isTitle ? TitleMagenta : NeonCyan;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (childControl is DataGridView dataGridView)
            {
                dataGridView.BackgroundColor = DarkBackground;
                dataGridView.GridColor = ElectricBlue;
                dataGridView.DefaultCellStyle.BackColor = ControlBackground;
                dataGridView.DefaultCellStyle.ForeColor = NeonCyan;
                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = DarkBackground;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = NeonCyan;
            }
            else if (childControl is GroupBox groupBox)
            {
                groupBox.Paint -= DrawNeonGroupBox;
                groupBox.Paint += DrawNeonGroupBox;
            }
            else if (childControl is TabControl tabControl)
            {
                tabControl.Appearance = TabAppearance.FlatButtons;

                foreach (TabPage tabPage in tabControl.TabPages)
                {
                    tabPage.BackColor = DarkBackground;
                    tabPage.ForeColor = NeonCyan;
                }

                tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
                tabControl.DrawItem -= DrawNeonTabs;
                tabControl.DrawItem += DrawNeonTabs;
            }
            else if (childControl is Panel panel)
            {
                if (panel.BorderStyle == BorderStyle.FixedSingle || panel.BorderStyle == BorderStyle.Fixed3D)
                {
                    panel.BorderStyle = BorderStyle.None;
                    panel.Paint -= DrawNeonPanelBorder;
                    panel.Paint += DrawNeonPanelBorder;
                }
            }
        }
    }

    // Fonction pour dessiner une bordure neon pour les groupbox
    private static void DrawNeonGroupBox(object sender, PaintEventArgs e)
    {
        GroupBox groupBox = (GroupBox)sender;
        Graphics graphics = e.Graphics;

        bool isTitle = (groupBox.Tag != null && groupBox.Tag.ToString() == "title");

        Brush textBrush = new SolidBrush(isTitle ? TitleMagenta : NeonCyan);
        using (Pen borderPen = new Pen(isTitle ? TitleMagenta : SapphireBlue, 1.0f))
        {
            graphics.Clear(DarkBackground);

            // Calcul de l'espace nécessaire pour le texte
            SizeF textSize = graphics.MeasureString(groupBox.Text, groupBox.Font);
            int textPositionY = (int)(textSize.Height / 2);
            Rectangle borderRect = new Rectangle(0, textPositionY, groupBox.Width - 1, groupBox.Height - textPositionY - 1);

            graphics.DrawString(groupBox.Text, groupBox.Font, textBrush, groupBox.Padding.Left + 5, 0);

            // Traçage manuel des lignes pour laisser un trou au niveau du texte
            graphics.DrawLine(borderPen, borderRect.Location, new Point(borderRect.X, borderRect.Y + borderRect.Height));
            graphics.DrawLine(borderPen, new Point(borderRect.X, borderRect.Y + borderRect.Height), new Point(borderRect.X + borderRect.Width, borderRect.Y + borderRect.Height));
            graphics.DrawLine(borderPen, new Point(borderRect.X + borderRect.Width, borderRect.Y + borderRect.Height), new Point(borderRect.X + borderRect.Width, borderRect.Y));
            graphics.DrawLine(borderPen, new Point(borderRect.X + borderRect.Width, borderRect.Y), new Point(borderRect.X + groupBox.Padding.Left + (int)textSize.Width + 8, borderRect.Y));
            graphics.DrawLine(borderPen, new Point(borderRect.X, borderRect.Y), new Point(borderRect.X + groupBox.Padding.Left, borderRect.Y));
        }
    }

    // Surcharge graphique pour les onglets
    private static void DrawNeonTabs(object sender, DrawItemEventArgs e)
    {
        TabControl tabControl = (TabControl)sender;
        Graphics graphics = e.Graphics;

        bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
        Brush backgroundBrush = new SolidBrush(isSelected ? ControlBackground : DarkBackground);
        Brush textBrush = new SolidBrush(NeonCyan);

        graphics.FillRectangle(backgroundBrush, e.Bounds);

        // Ajout d'une bordure de sélection pour l'onglet actif
        if (isSelected)
        {
            using (Pen borderPen = new Pen(ElectricBlue, 1))
            {
                graphics.DrawRectangle(borderPen, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
            }
        }

        StringFormat textFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        graphics.DrawString(tabControl.TabPages[e.Index].Text, e.Font, textBrush, e.Bounds, textFormat);
    }

    // Surcharge graphique pour remplacer les bordures Windows par défaut d'un Panel
    private static void DrawNeonPanelBorder(object sender, PaintEventArgs e)
    {
        Panel panel = (Panel)sender;
        using (Pen borderPen = new Pen(ElectricBlue, 1.0f))
        {
            e.Graphics.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1);
        }
    }

    // Surcharge graphique pour maintenir la lisibilité d'un bouton inactif
    private static void DrawDisabledButton(object sender, PaintEventArgs e)
    {
        Button button = (Button)sender;

        if (!button.Enabled)
        {
            Graphics graphics = e.Graphics;
            Color disabledCyan = Color.FromArgb(0, 100, 100);

            graphics.Clear(DarkBackground);

            using (Pen borderPen = new Pen(SapphireBlue, 2))
            {
                graphics.DrawRectangle(borderPen, 1, 1, button.Width - 2, button.Height - 2);
            }

            StringFormat textFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            using (Brush textBrush = new SolidBrush(disabledCyan))
            {
                graphics.DrawString(button.Text, button.Font, textBrush, button.ClientRectangle, textFormat);
            }
        }
    }
}