

using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelgatesImplentationRunner
    {
        public static void RunMenuWithDelgatesImplementation()
        {
            MainMenu menu = new MainMenu("Main Menu");
            Menu mainScreen = menu.MainScreen;
            Menu versionAndSpacesMenu = new Menu("Version and Spaces Menu", ref mainScreen);
            mainScreen.AddOption(new NavigationMenuItem("Version and Spaces", ref versionAndSpacesMenu));
            Menu dateAndTime = new Menu("Show Date / Time", ref mainScreen);
            mainScreen.AddOption(new NavigationMenuItem("Show Date / Time", ref dateAndTime));
            versionAndSpacesMenu.AddOption(new ActionMenuItem("Show Version",TesterMethods.ShowVersion));
            menu.RunMenu();
        }
    }
}
