
using System;

namespace Ex04.Menus.Delegates
{
    public class ActionMenuItem : MenuItem
    {
        public event Action MenuItemToDoOnSelection;

        public ActionMenuItem(string i_Text, Action i_Function) : base(i_Text)
        {
            MenuItemToDoOnSelection += i_Function;
        }
        
       protected override void OnSelection()
       {
           if(MenuItemToDoOnSelection != null)
           {
               MenuItemToDoOnSelection.Invoke();
           }
           else
           {
                Console.WriteLine("This Option doesn't exist");
           }
       }
    }
}
