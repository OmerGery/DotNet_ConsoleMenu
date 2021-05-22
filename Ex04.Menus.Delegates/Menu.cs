using System;
using System.Collections.Generic;
using System.Threading;
using Ex03.GarageLogic;

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

        public Menu(string i_Title, Menu i_PreviousMenu)
        {
            m_Title = i_Title;
            m_UserOptions = new List<MenuItem>();
            m_Level = i_PreviousMenu.Level + 1;
            AddOption(new NavigationMenuItem("Back", i_PreviousMenu));
        }

        public void RunMenu()
        {
            ShowOptions();
            while(true)
            {
                try
                {
                    getInput();
                }
                catch(FormatException formatException)
                {
                    Console.WriteLine("There was an error with the input format.{0}{1}", Environment.NewLine, formatException.Message);
                }
                catch(ValueOutOfRangeException outOfRangeException)
                {
                    Console.WriteLine("The selected input was out of range.{0}{1}", Environment.NewLine, outOfRangeException.Message);
                }

                Thread.Sleep(2000);
                Console.Clear();
                ShowOptions();
            }
        }
        
    public void ShowOptions()
    {
        Console.WriteLine(m_Title);
        Console.WriteLine("The level is {0}", m_Level);
        int currentOptionToPrint = 0;
        foreach (MenuItem option in m_UserOptions)
        {
            Console.WriteLine(@"{0} - {1}", currentOptionToPrint, option);
            currentOptionToPrint++;
        }
    }

    private void getInput()
    {
        Console.WriteLine("please select an option from the menu");
        if (!int.TryParse(Console.ReadLine(), out int userOptionSelection))
        {
            throw new FormatException("You must enter a number for the selection of the requested option.");
        }

        if (userOptionSelection < 0 || userOptionSelection > m_UserOptions.Count - 1)
        {
            throw new ValueOutOfRangeException(0, m_UserOptions.Count - 1, "Option Selection");
        }

        Console.Clear();
        m_UserOptions[userOptionSelection].Selected();
    }

    public void AddOption(MenuItem i_MenuItemToAdd)
    {
        m_UserOptions.Add(i_MenuItemToAdd);
    }
}
}
