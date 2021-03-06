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

            Menu versionAndSpacesMenu = new Menu("Version and Spaces Menu", mainScreen);
            versionAndSpacesMenu.AddOption(new ActionMenuItem("Show Version", TesterDelegatesMethods.ShowVersion));
            versionAndSpacesMenu.AddOption(new ActionMenuItem("Count Spaces", TesterDelegatesMethods.CountSpaces));

            Menu dateAndTime = new Menu("Show Date / Time", mainScreen);
            dateAndTime.AddOption(new ActionMenuItem("Show Time", TesterDelegatesMethods.ShowTime));
            dateAndTime.AddOption(new ActionMenuItem("Show Date", TesterDelegatesMethods.ShowDate));

            mainScreen.AddOption(new NavigationMenuItem("Version and Spaces", versionAndSpacesMenu));
            mainScreen.AddOption(new NavigationMenuItem("Show Date / Time", dateAndTime));
            return m_MainMenu;
        }

        public void RunMenu()
        {
            BuildMenu();
            m_MainMenu.Show();
        }
    }
}
