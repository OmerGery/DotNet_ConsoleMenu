using System;

namespace Ex04.Menus.Delegates
{
    public class NavigationMenuItem : MenuItem
    {
        private Menu m_LinkedMenu;

        public NavigationMenuItem(string i_Text, ref Menu io_MenuToNavigateTo) : base(i_Text)
        {
            m_LinkedMenu = io_MenuToNavigateTo;
        }

        protected override void OnSelection()
        { 
            Console.Clear();
            m_LinkedMenu.RunMenu();
        }
    }
}
