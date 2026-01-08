using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete
{
    public class BancoDeCouro : CarroDecorator
    {
        public BancoDeCouro(ICarro carro) : base(carro)
        {
        }

        public override string RetornarCarro()
        {
            return base.RetornarCarro() + " com Banco de Couro";
        }
    }
}
