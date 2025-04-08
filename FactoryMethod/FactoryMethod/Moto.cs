namespace FactoryMethod
{
    // classe ConcreteProduct
    public class Moto : Veiculo
    {
        public Moto()
        {
            Modelo = "Modelo de Moto";
            Ano = DateTime.Now.Year;
        }
    }
}
