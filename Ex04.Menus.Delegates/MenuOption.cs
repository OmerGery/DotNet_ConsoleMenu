using System;

namespace Ex04.Menus.Delegates
{
    public class MenuOption
    {
        public readonly string r_Text;
        public MenuOption(string i_Text)
        {
            r_Text = i_Text;
        }

        public void Selected()
        {
            OnSelection();
        }

        protected virtual void OnSelection()
        {
            Console.WriteLine("{0} was selected",r_Text);
        }
        public void Show()
        {
            Console.WriteLine(r_Text);
        }
    }
}
