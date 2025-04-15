namespace Builder
{
    // classe Director
    public class Cozinha
    {
        public Hamburguer PrepararXSalada(HamburguerBuilder builder)
        {
            return builder
                .SetTipoPao("Branco")
                .SetTipoCarne("Bovina")
                .TemSalada()
                .Build();
        }

        public Hamburguer PrepararXBacon(HamburguerBuilder builder)
        {
            return builder
                .SetTipoPao("Branco")
                .SetTipoCarne("Bovina")
                .TemBacon()
                .TemQueijo()
                .Build();
        }

        public Hamburguer PrepararXTudo(HamburguerBuilder builder)
        {
            return builder
                .SetTipoPao("Branco")
                .SetTipoCarne("Bovina")
                .TemBacon()
                .TemQueijo()
                .TemSalada()
                .Build();
        }
    }
}
