namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelgatesImplementationRunner delegatesRunner = new DelgatesImplementationRunner();
            InterfacesImplementationRunner interfacesRunner = new InterfacesImplementationRunner();
            interfacesRunner.RunMenu();
            delegatesRunner.RunMenu();
        }
    }
}
