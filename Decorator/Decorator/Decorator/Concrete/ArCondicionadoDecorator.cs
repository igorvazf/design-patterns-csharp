using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete
{
    public class ArCondicionadoDecorator : CarroDecorator
    {
        public ArCondicionadoDecorator(ICarro carro) : base(carro)
        {
        }

        public override string RetornarCarro()
        {
            return base.RetornarCarro() + " com Ar Condicionado";
        }
    }
}
