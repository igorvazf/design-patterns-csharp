namespace Bridge
{
    public class JanelaWindows : IJanelaBridge
    {
        public void desenharBotao(string titulo)
        {
            Console.WriteLine(titulo + " - Botão Windows");
        }

        public void desenharJanela(string titulo)
        {
            Console.WriteLine(titulo + " - Janela Windows");
        }
    }
}