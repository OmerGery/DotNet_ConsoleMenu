
using System;

namespace Ex04.Menus.Delegates
{
    public abstract class Option
    {
        public string m_Text;

        protected Option(string i_Text)
        {
            m_Text = i_Text;
        }
        public void Selected()
        {
            OnSelection();
        }

        protected abstract void OnSelection();

        public override string ToString()
        {
            return m_Text;
        }
    }
}
