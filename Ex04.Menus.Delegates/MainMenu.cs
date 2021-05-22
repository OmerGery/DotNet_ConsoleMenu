namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly Menu r_MainScreen;

        public Menu MainScreen
        {
            get { return r_MainScreen; }
        }

        public MainMenu(string i_Title)
        {
            r_MainScreen = new Menu(i_Title);
        }
        
        public void Show()
        {
            r_MainScreen.RunMenu();
        }
    }
}
