namespace AbstractFactory.Product
{
    // classe ConcreteProduct
    public class MacOSCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Renderizando checkbox no estilo macOS");
        }

        public void Toggle()
        {
            Console.WriteLine("Alternando estado do checkbox macOS");
        }
    }
}
