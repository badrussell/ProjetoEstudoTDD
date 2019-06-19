using System;
using Domain.ObjetoValor;

namespace Domain.Entidades
{
    public class Cerveja
    {
        public Cerveja(string marca, string tipo, NumeroDecimal preco, int quantidade, int volume)
        {
            Marca = marca;
            Tipo = tipo;
            Preco = preco;
            Quantidade = quantidade;
            Volume = volume;
        }

        public string Marca { get; private set; }
        public string Tipo { get; private set; }
        public NumeroDecimal Preco { get; private set; }
        public int Quantidade { get; private set; }
        public int Volume { get; private set; }

        public int QuantidadeEmMl()
        {
            return Quantidade * Volume;
        }
        public NumeroDecimal QuantidadeEmLitros()
        {
            return new NumeroDecimal((decimal)QuantidadeEmMl() / (decimal)1000);
        }
        public NumeroDecimal ValorGastoTotalNaCompra()
        {
            return new NumeroDecimal((decimal)Preco.numero * (decimal)Quantidade);
        }
    }
}