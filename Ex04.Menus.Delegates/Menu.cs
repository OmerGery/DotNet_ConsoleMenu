
using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{

    public class Menu
    {
        private int m_Level;
        private string m_Title;
        private List<MenuItem> m_UserOptions;
        public int Level
        {
            get
            {
                return m_Level;
            }
        }
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public Menu(string i_Title) 
        {
            m_Title = i_Title;
            m_UserOptions = new List<MenuItem>();
            m_Level = 0;
            AddOption(new ActionMenuItem("Exit", () => System.Environment.Exit(0)));
        }
        public Menu(string i_Title,ref Menu i_PreviousMenu)
        {
            m_Title = i_Title;
            m_UserOptions = new List<MenuItem>();
            m_Level = i_PreviousMenu.Level + 1;
            AddOption(new NavigationMenuItem("Back",ref i_PreviousMenu));
        }
        


        public void RunMenu()
        {
            ShowOptions();
            while(true)
            {
                getInput();
            }
        }
        public void ShowOptions()
        {
            Console.WriteLine(m_Title);
            Console.WriteLine("The level is {0}",m_Level);
            bool selected = false;
            int currentOptionToPrint= 0;
            foreach(MenuItem option in m_UserOptions)
            {
                Console.WriteLine(@"{0} - {1}", currentOptionToPrint, option.ToString());
                currentOptionToPrint++;
            }
        }

        private void getInput()
        {
            int userOptionSelection;
            Console.WriteLine("please enter selection");    
            int.TryParse(Console.ReadLine(), out userOptionSelection);
            m_UserOptions[userOptionSelection].Selected();
        }

        public void AddOption(MenuItem i_MenuItemToAdd)
        {
            m_UserOptions.Add(i_MenuItemToAdd);
        }
    }
}
