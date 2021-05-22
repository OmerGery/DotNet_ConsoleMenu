using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TesterInterfacesMethods
    {
        public class ShowVersion : IRunable
        {
            public void Run()
            {
                TesterDelegatesMethods.ShowVersion();
            }
        }

        public class CountSpaces : IRunable
        {
            public void Run()
            {
                TesterDelegatesMethods.CountSpaces();
            }
        }

        public class ShowTime : IRunable
        {
            public void Run()
            {
                TesterDelegatesMethods.ShowTime();
            }
        }

        public class ShowDate : IRunable
        {
            public void Run()
            {
                TesterDelegatesMethods.ShowDate();
            }
        }
    }
}
