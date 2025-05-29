using System;
using System.Drawing;
using System.Windows.Forms;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public static class ThemeStyles
    {
        public static bool isDarkTheme = false;

        private static readonly Color LightBackground = Color.LightGray;
        private static readonly Color LightTextColor = Color.Orange;
        private static readonly Color LightButtonColor = Color.WhiteSmoke;
        private static readonly Color LightButtonTextColor = Color.Orange;
        private static readonly Color LightMenuBackground = Color.White;
        private static readonly Color LightMenuTextColor = Color.Orange;
        private static readonly Color LightTextBoxColor = Color.White;
        private static readonly Color LightTextBoxTextColor = Color.Orange;
        private static readonly Color LightLabelTextColor = Color.Orange;
        private static readonly Color LightComboBoxTextColor = Color.Orange;
        private static readonly Color LightComboBoxColor = Color.White;
        private static readonly Color LightGroupBoxTextColor = Color.Orange;
        private static readonly Color LightDataGridViewBackColor = Color.White;
        private static readonly Color LightDataGridViewTextColor = Color.Orange;
        private static readonly Color LightDataGridViewBackGroundColor = Color.LightGray;
        private static readonly Color LightDataGridViewRowHeadersColor = Color.Gray;
        private static readonly Color LightDataGridViewColumnHeadersColor = Color.Gray;
        private static readonly Color LightRichTextBoxColor = Color.White;
        private static readonly Color LightRichTextBoxTextColor = Color.Orange;


        private static readonly Color DarkBackground = Color.FromArgb(40, 40, 40);
        private static readonly Color DarkTextColor = Color.Orange;
        private static readonly Color DarkButtonColor = Color.FromArgb(70, 70, 70);
        private static readonly Color DarkButtonTextColor = Color.Orange;
        private static readonly Color DarkMenuBackground = Color.Black;
        private static readonly Color DarkMenuTextColor = Color.Orange;
        private static readonly Color DarkTextBoxColor = Color.Black;
        private static readonly Color DarkTextBoxTextColor = Color.Orange;
        private static readonly Color DarkLabelTextColor = Color.Orange;
        private static readonly Color DarkComboBoxTextColor = Color.Orange;
        private static readonly Color DarkComboBoxColor = Color.Black;
        private static readonly Color DarkGroupBoxTextColor = Color.Orange;
        private static readonly Color DarkDataGridViewBackColor = Color.FromArgb(70, 70, 70);
        private static readonly Color DarkDataGridViewTextColor = Color.Orange;
        private static readonly Color DarkDataGridViewBackGroundColor = Color.FromArgb(40, 40, 40);
        private static readonly Color DarkDataGridViewRowHeadersColor = Color.Black;
        private static readonly Color DarkDataGridViewColumnHeadersColor = Color.Black;
        private static readonly Color DarkRichTextBoxColor = Color.Black;
        private static readonly Color DarkRichTextBoxTextColor = Color.Orange;

        private static readonly Font BoldFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);

        public static void ApplyTheme(Control parent)
        {
            Color backgroundColor = isDarkTheme ? DarkBackground : LightBackground;
            Color textColor = isDarkTheme ? DarkTextColor : LightTextColor;
            Color buttonColor = isDarkTheme ? DarkButtonColor : LightButtonColor;
            Color buttonTextColor = isDarkTheme ? DarkButtonTextColor : LightButtonTextColor;
            Color menuBackground = isDarkTheme ? DarkMenuBackground : LightMenuBackground;
            Color menuTextColor = isDarkTheme ? DarkMenuTextColor : LightMenuTextColor;
            Color textBoxColor = isDarkTheme ? DarkTextBoxColor : LightTextBoxColor;
            Color textBoxTextColor = isDarkTheme ? DarkTextBoxTextColor : LightTextBoxTextColor;
            Color labelTextColor = isDarkTheme ? DarkLabelTextColor : LightLabelTextColor;
            Color comboboxTextColor = isDarkTheme ? DarkComboBoxTextColor : LightComboBoxTextColor;
            Color comboboxColor = isDarkTheme ? DarkComboBoxColor : LightComboBoxColor;
            Color groupBoxTextColor = isDarkTheme ? DarkGroupBoxTextColor : LightGroupBoxTextColor;
            Color dataGridViewBackColor = isDarkTheme ? DarkDataGridViewBackColor : LightDataGridViewBackColor;
            Color dataGridViewTextColor = isDarkTheme ? DarkDataGridViewTextColor : LightDataGridViewTextColor;
            Color dataGridViewBackGroundColor = isDarkTheme ? DarkDataGridViewBackGroundColor : LightDataGridViewBackGroundColor;
            Color dataGridViewRowHeadersColor = isDarkTheme ? DarkDataGridViewRowHeadersColor : LightDataGridViewRowHeadersColor;
            Color dataGridViewColumnHeadersColor = isDarkTheme ? DarkDataGridViewColumnHeadersColor : LightDataGridViewColumnHeadersColor;
            Color richTextBoxColor = isDarkTheme ? DarkRichTextBoxColor : LightRichTextBoxColor;
            Color richTextBoxTextColor = isDarkTheme ? DarkRichTextBoxTextColor : LightRichTextBoxTextColor;

            parent.BackColor = backgroundColor;

            foreach (Control control in parent.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = buttonColor;
                    control.ForeColor = buttonTextColor;
                    control.Font = BoldFont;
                }
                else if (control is TextBox)
                {
                    control.BackColor = textBoxColor;
                    control.ForeColor = textBoxTextColor;
                    control.Font = BoldFont;
                }
                else if (control is RichTextBox)
                {
                    control.BackColor = richTextBoxColor;
                    control.ForeColor = richTextBoxTextColor;
                    control.Font = BoldFont;
                }
                else if (control is ComboBox)
                {
                    control.BackColor = comboboxColor;
                    control.ForeColor = comboboxTextColor;
                    control.Font = BoldFont;
                }
                else if (control is GroupBox)
                {
                    control.ForeColor = groupBoxTextColor;
                    control.Font = BoldFont;
                }
                else if (control is DataGridView dataGridView)
                {
                    dataGridView.DefaultCellStyle.BackColor = dataGridViewBackColor;
                    dataGridView.ForeColor = dataGridViewTextColor;
                    dataGridView.Font = BoldFont;
                    dataGridView.BackgroundColor = dataGridViewBackGroundColor;
                    dataGridView.RowHeadersDefaultCellStyle.BackColor = dataGridViewRowHeadersColor;
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = dataGridViewColumnHeadersColor;
                    dataGridView.DefaultCellStyle.ForeColor = dataGridViewTextColor;
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = dataGridViewTextColor;
                }
                else if (control is Label)
                {
                    control.ForeColor = labelTextColor;
                    control.Font = BoldFont;
                }
                else if (control is MenuStrip menuStrip)
                {
                    ApplyMenuStripStyle(menuStrip, menuBackground, menuTextColor);
                }
                else
                {
                    control.ForeColor = textColor;
                    control.BackColor = backgroundColor;
                }

                if (parent is Form form)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new Point(
                        (Screen.PrimaryScreen.WorkingArea.Width - form.Width) / 2,
                        (Screen.PrimaryScreen.WorkingArea.Height - form.Height) / 2
                    );
                }


                if (control.HasChildren)
                    ApplyTheme(control);
            }
        }

        private static void ApplyMenuStripStyle(MenuStrip menuStrip, Color backgroundColor, Color textColor)
        {
            menuStrip.BackColor = backgroundColor;
            menuStrip.ForeColor = textColor;
            menuStrip.Font = BoldFont;

            foreach (ToolStripMenuItem menuItem in menuStrip.Items)
            {
                ApplyMenuItemStyle(menuItem, backgroundColor, textColor);
            }
        }

        private static void ApplyMenuItemStyle(ToolStripMenuItem menuItem, Color backgroundColor, Color textColor)
        {
            menuItem.BackColor = backgroundColor;
            menuItem.ForeColor = textColor;
            menuItem.Font = BoldFont;

            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenuItem)
                {
                    subMenuItem.BackColor = backgroundColor;
                    subMenuItem.ForeColor = textColor;
                    subMenuItem.Font = BoldFont;
                }
            }
        }

        public static void ToggleTheme(Form form)
        {
            isDarkTheme = !isDarkTheme;
            ApplyTheme(form);
        }

        public static void Change_theme_img(PictureBox change_theme)
        {
            change_theme.Image = ThemeStyles.isDarkTheme
                ? Properties.Resources.to_white_theme
                : Properties.Resources.to_dark_theme;
        }
    }
}