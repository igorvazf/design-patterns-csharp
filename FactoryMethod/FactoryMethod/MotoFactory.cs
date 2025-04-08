namespace FactoryMethod
{
    // classe ConcreteCreator
    public class MotoFactory : VeiculoFactory
    {
        public override Veiculo CriarVeiculo()
        {
            return new Moto();
        }
    }
}
