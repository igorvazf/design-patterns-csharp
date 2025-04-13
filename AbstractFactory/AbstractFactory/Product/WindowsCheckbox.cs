namespace AbstractFactory.Product
{
    // classe ConcreteProduct
    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Renderizando checkbox no estilo Windows");
        }

        public void Toggle()
        {
            Console.WriteLine("Alternando estado do checkbox Windows");
        }
    }
}
