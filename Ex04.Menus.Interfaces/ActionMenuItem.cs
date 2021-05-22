using System;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        private IRunable m_Runable;

        public IRunable Runable
        {
            get { return m_Runable; }
            set { m_Runable = value; }
        }

        public ActionMenuItem(string i_Text, IRunable i_MethodToAdd) : base(i_Text)
        {
            m_Runable = i_MethodToAdd;
        }

        protected override void OnSelection()
        {
            m_Runable?.Run();
        }
    }
}
