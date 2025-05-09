﻿namespace Builder
{
    // classe Product
    public class Hamburguer
    {
        public string TipoPao { get; set; }
        public string TipoCarne { get; set; }
        public bool TemBacon { get; set; }
        public bool TemQueijo { get; set; }
        public bool TemSalada { get; set; }

        public string GetDescricao()
        {
            return $"Hambúrguer com pão {TipoPao} e carne {TipoCarne}. " +
                $"Bacon: {TemBacon}, Queijo: {TemQueijo}, Salada: {TemSalada}";
        }
    }
}
