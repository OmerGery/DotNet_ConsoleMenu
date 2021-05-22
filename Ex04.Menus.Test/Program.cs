using System;
using System.Threading;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelgatesImplementationRunner delegatesRunner = new DelgatesImplementationRunner();
            InterfacesImplementationRunner interfacesRunner = new InterfacesImplementationRunner();
            interfacesRunner.RunMenu();
            SwitchMenusScreen();
            delegatesRunner.RunMenu();
        }

        public static void SwitchMenusScreen()
        {
            Console.WriteLine("Switching to the delegates-implemented menu...");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
