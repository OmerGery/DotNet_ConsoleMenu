

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private MenuItem firstScreen;

        public MainMenu()
        {
            firstScreen = new MenuItem(0);
        }

        public void StartMenu()
        {
            firstScreen.ShowOptions();
        }

    }
}
