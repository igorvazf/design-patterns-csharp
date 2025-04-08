namespace FactoryMethod
{
    // classe Product
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public string ExibirDetalhes()
        {
            return $"{GetType().Name} => Modelo: {Modelo}, Ano: {Ano}";
        }
    }
}
