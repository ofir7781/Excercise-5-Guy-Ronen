using System;

namespace CheckersWinUI
{
    public class WinUI
    {
        private SettingsForm m_SettingsForm;
        private BoardForm m_BoardForm;

        public void Run()
        {
            m_SettingsForm = new SettingsForm();
            m_SettingsForm.ShowDialog();
        }
    }
}
