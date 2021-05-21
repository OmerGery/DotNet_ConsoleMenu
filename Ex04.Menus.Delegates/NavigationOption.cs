using System;
namespace Ex04.Menus.Delegates
{
    public class NavigationOption : Option
    {
        private MenuItem m_LinkedMenu;
        public NavigationOption(string i_Text, ref MenuItem io_MenuToNavigateTo) : base(i_Text)
        {
            m_LinkedMenu = io_MenuToNavigateTo;
        }

        protected override void OnSelection()
        { 
            Console.Clear();
            m_LinkedMenu.ShowOptions();
        }
    }
}
