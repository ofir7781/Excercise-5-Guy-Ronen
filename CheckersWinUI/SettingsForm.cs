using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckersWinUI
{
    public class SettingsForm : Form
    {
        private Label m_BoardSizeLabel;
        private RadioButton m_RadioButton6x6;
        private RadioButton m_RadioButton8x8;
        private RadioButton m_RadioButton10x10;

        public SettingsForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Text = "Game Settings";
            this.ShowIcon = false;
            buildInnerForms();
        }

        private void buildInnerForms()
        {
            // BoardSize Label
            m_BoardSizeLabel = new Label();
            m_BoardSizeLabel.Text = "Board Size:";
            m_BoardSizeLabel.Font = new Font("Arial", 9, FontStyle.Bold);
            m_BoardSizeLabel.ForeColor = Color.Black;
            m_BoardSizeLabel.Top = 20;
            m_BoardSizeLabel.Left = 20;
            this.Controls.Add(m_BoardSizeLabel);
            // RadioButton 6x6
            m_RadioButton6x6 = new RadioButton();
        }
    }
}
