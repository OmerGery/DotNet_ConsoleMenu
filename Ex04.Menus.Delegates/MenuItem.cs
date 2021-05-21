
using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private int m_Level;
        private string m_Title;
        private List<Option> m_UserOptions;

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }
        public MenuItem(int i_Level)
        {
            m_UserOptions = new List<Option>();
            m_Level = i_Level;
            if(i_Level == 0)
            {
                Action exitFunction = () => System.Environment.Exit(0);
                AddActionOption("Exit", ref exitFunction);
            }
        }
        

        private void ShowLevel()
        {
            Console.WriteLine(m_Level);
        }

        public void ShowOptions()
        {
            Console.WriteLine(m_Title);
            Console.WriteLine("The level is {0}",m_Level);
            bool selected = false;
            int currentOptionToPrint= 0;
            foreach(Option option in m_UserOptions)
            {
                Console.WriteLine(@"{0} - {1}", currentOptionToPrint, option.ToString());
                currentOptionToPrint++;
            }
            getInput();
        }

        private void getInput()
        {
            int userOptionSelection;
            Console.WriteLine("please enter selection");
            int.TryParse(Console.ReadLine(), out userOptionSelection);
            m_UserOptions[userOptionSelection].Selected();
            Console.ReadLine();
        }

        public void AddActionOption(string i_NameOfOption, ref Action i_Function)
        {
            Option newOption = new ActionOption(i_NameOfOption,ref i_Function);
            m_UserOptions.Add(newOption);
        }
        public void AddNavigationOption(string i_NameOfOption, ref MenuItem menuToNavigateTo)
        {
            Option newOption = new NavigationOption(i_NameOfOption, ref menuToNavigateTo);
            m_UserOptions.Add(newOption);
        }
    }
}
