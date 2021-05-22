

using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelgatesImplementationRunner
    {
        private MainMenu m_MainMenu;
        public MainMenu BuildMenu()
        {
            m_MainMenu = new MainMenu("Main Menu");
            Menu mainScreen = m_MainMenu.MainScreen;
            Menu versionAndSpacesMenu = new Menu("Version and Spaces Menu", ref mainScreen);
            mainScreen.AddOption(new NavigationMenuItem("Version and Spaces", ref versionAndSpacesMenu));
            Menu dateAndTime = new Menu("Show Date / Time", ref mainScreen);
            mainScreen.AddOption(new NavigationMenuItem("Show Date / Time", ref dateAndTime));
            versionAndSpacesMenu.AddOption(new ActionMenuItem("Show Version", TesterMethods.ShowVersion));
            versionAndSpacesMenu.AddOption(new ActionMenuItem("Count Spaces", TesterMethods.CountSpaces));
            dateAndTime.AddOption(new ActionMenuItem("Show Time", TesterMethods.ShowTime));
            dateAndTime.AddOption(new ActionMenuItem("Show Date", TesterMethods.ShowDate));
            return m_MainMenu;
        }
        public void RunMenuWithDelegatesImplementation()
        {
            BuildMenu();
            m_MainMenu.Show();
        }
    }
}
