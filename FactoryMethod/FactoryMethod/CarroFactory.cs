namespace FactoryMethod
{
    // classe ConcreteCreator
    public class CarroFactory : VeiculoFactory
    {
        public override Veiculo CriarVeiculo()
        {
            return new Carro();
        }
    }
}
