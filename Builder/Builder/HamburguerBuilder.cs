namespace Builder
{
    // classe Builder e ConcreteBuilder
    public class HamburguerBuilder
    {
        private Hamburguer _hamburguer;

        public HamburguerBuilder()
        {
            _hamburguer = new Hamburguer();
        }

        public HamburguerBuilder Reset()
        {
            _hamburguer = new Hamburguer();
            return this;
        }

        public HamburguerBuilder SetTipoPao(string pao)
        {
            _hamburguer.TipoPao = pao;
            return this;
        }

        public HamburguerBuilder SetTipoCarne(string carne)
        {
            _hamburguer.TipoCarne = carne;
            return this;
        }

        public HamburguerBuilder TemBacon()
        {
            _hamburguer.TemBacon = true;
            return this;
        }

        public HamburguerBuilder TemQueijo()
        {
            _hamburguer.TemQueijo = true;
            return this;
        }

        public HamburguerBuilder TemSalada()
        {
            _hamburguer.TemSalada = true;
            return this;
        }

        public Hamburguer Build()
        {
            var hamburguer = _hamburguer;
            Reset();
            return hamburguer;
        }
    }
}
