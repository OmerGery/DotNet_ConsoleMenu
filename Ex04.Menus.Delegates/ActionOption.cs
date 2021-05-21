
using System;

namespace Ex04.Menus.Delegates
{
    public class ActionOption : Option
    {
        private Action m_Function;

        public ActionOption(string i_Text, ref Action i_Function) : base(i_Text)
        {
            m_Function = i_Function;
        }
        
       protected override void OnSelection()
       {
           m_Function();
       }
    }
}
