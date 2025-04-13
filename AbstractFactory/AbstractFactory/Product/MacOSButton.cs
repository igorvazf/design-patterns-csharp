namespace AbstractFactory.Product
{
    // classe ConcreteProduct
    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Renderizando botão no estilo macOS");
        }

        public void OnClick()
        {
            Console.WriteLine("Evento de clique no botão macOS");
        }
    }
}
