
using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private int m_Level;
        public List<MenuOption> m_UserOptions;
        public MenuItem(int i_Level)
        {
            m_UserOptions = new List<MenuOption> { new MenuOption("omer"), new MenuOption("daniel") };
            m_Level = i_Level;
        }

        public void ShowLevel()
        {
            Console.WriteLine(m_Level);
        }

        public void ShowOptions()
        {
            bool selected = false;
            foreach(MenuOption option in m_UserOptions)
            {
                option.Show();
            }

            string selection  = Console.ReadLine();
            int choose = 1;
            m_UserOptions[1].Selected();
            Console.ReadLine();

        }
    }
}
