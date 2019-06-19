using System;

namespace Domain.ObjetoValor
{
    public class NumeroDecimal
    {
        public NumeroDecimal(decimal numero)
        {
            this.numero = Decimal.Round((decimal)numero, 2, MidpointRounding.AwayFromZero);;
        }

        public decimal numero { get; private set; }
    }
}