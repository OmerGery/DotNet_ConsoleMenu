namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        public string m_Text;

        protected MenuItem(string i_Text)
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
