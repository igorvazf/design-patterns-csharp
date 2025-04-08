namespace FactoryMethod
{
    // classe ConcreteProduct
    public class Carro : Veiculo
    {
        public Carro()
        {
            Modelo = "Modelo de Carro";
            Ano = DateTime.Now.Year;
        }
    }
}
