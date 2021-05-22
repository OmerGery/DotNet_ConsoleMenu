using System;
using System.Collections.Generic;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
    public class Menu
    {
        private const int k_ThreadSleepTime = 1500;
        private readonly List<MenuItem> r_UserOptions;
        private readonly int r_Level;
        private string m_Title;

        public int Level
        {
            get
            {
                return r_Level;
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
            r_UserOptions = new List<MenuItem>();
            r_Level = 0;
            AddOption(new ActionMenuItem("Exit", null));
        }

        public Menu(string i_Title, Menu i_PreviousMenu)
        {
            m_Title = i_Title;
            r_UserOptions = new List<MenuItem>();
            r_Level = i_PreviousMenu.Level + 1;
            AddOption(new NavigationMenuItem("Back", i_PreviousMenu));
        }

        public void RunMenu()
        {
            while (true)
            {
                ShowOptions();
                try
                {
                    int userSelection = getInput();
                    Console.Clear();
                    if (userSelection == 0)
                    {
                        break;
                    }

                    r_UserOptions[userSelection].Selected();
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("There was an error with the input format.{0}{1}", Environment.NewLine, formatException.Message);
                    Thread.Sleep(k_ThreadSleepTime);
                }
                catch (ValueOutOfRangeException outOfRangeException)
                {
                    Console.WriteLine("The selected input was out of range.{0}{1}", Environment.NewLine, outOfRangeException.Message);
                    Thread.Sleep(k_ThreadSleepTime);
                }

                Console.Clear();
            }
        }

        public void ShowOptions()
        {
            Console.WriteLine(m_Title);
            Console.WriteLine("The level is {0}", r_Level);
            int currentOptionToPrint = 0;
            foreach (MenuItem option in r_UserOptions)
            {
                Console.WriteLine(@"{0} - {1}", currentOptionToPrint, option);
                currentOptionToPrint++;
            }
        }

        private int getInput()
        {
            Console.WriteLine("please select an option from the menu");
            if (!int.TryParse(Console.ReadLine(), out int userOptionSelection))
            {
                throw new FormatException("You must enter a non negative round number for the selection of the requested option.");
            }

            if (userOptionSelection < 0 || userOptionSelection > r_UserOptions.Count - 1)
            {
                throw new ValueOutOfRangeException(0, r_UserOptions.Count - 1, "Option Selection");
            }

            return userOptionSelection;
        }

        public void AddOption(MenuItem i_MenuItemToAdd)
        {
            r_UserOptions.Add(i_MenuItemToAdd);
        }
    }
}
