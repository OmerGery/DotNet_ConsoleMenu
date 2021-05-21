using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private MenuItem m_MainScreen;
        public MenuItem MainScreen
        {
            get { return m_MainScreen; }
        }
        public MainMenu()
        {
            m_MainScreen = new MenuItem(0);
        }

        public void Show()
        {
            m_MainScreen.ShowOptions();
        }

    }
}
