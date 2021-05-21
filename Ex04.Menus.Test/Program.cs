using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MainMenu menu = new MainMenu();
            MenuItem mainScreen = menu.MainScreen;
            mainScreen.Title = "Main Menu";
            MenuItem versionAndSpacesMenu = new MenuItem(1);
            versionAndSpacesMenu.Title = "Version and Spaces Menu";
            versionAndSpacesMenu.AddNavigationOption("Back", ref mainScreen);
            mainScreen.AddNavigationOption("Version and Spaces", ref versionAndSpacesMenu);
            menu.Show();

        }
    }
}
