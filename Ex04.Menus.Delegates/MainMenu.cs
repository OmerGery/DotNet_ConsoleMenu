using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private Menu m_MainScreen;
        public Menu MainScreen
        {
            get { return m_MainScreen; }
        }
        public MainMenu(string i_Title)
        {
            m_MainScreen = new Menu(i_Title);
        }
        
        public void RunMenu()
        {
            m_MainScreen.RunMenu();
        }

    }
}
