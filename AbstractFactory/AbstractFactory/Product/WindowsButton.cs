namespace AbstractFactory.Product
{
    // classe ConcreteProduct
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Renderizando botão no estilo Windows");
        }

        public void OnClick()
        {
            Console.WriteLine("Evento de clique no botão Windows");
        }
    }
}
