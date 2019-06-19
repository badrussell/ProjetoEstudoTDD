using System;
using Domain.Entidades;
using Domain.ObjetoValor;
using NUnit.Framework;

namespace Tests
{
    public class TesteDominioCerveja
    {
        public Cerveja cerveja1 { get; set; }
        public Cerveja cerveja2 { get; set; }
        public Cerveja cerveja3 { get; set; }
        
        [SetUp]
        public void Setup()
        {
            cerveja1 = new Cerveja("Polar", "Export", new NumeroDecimal(12), 10, 1000);
            cerveja2 = new Cerveja("Roleta Russa", "IPA", new NumeroDecimal((decimal)2.50),5, 335);
            cerveja3 = new Cerveja("Heineken", "Premium American Lager", new NumeroDecimal(65),1, 5000);
        }
        
        [Test]
        public void ValidarSeRetornoEmMlFunciona()
        {
            Assert.AreEqual(cerveja1.QuantidadeEmMl(),10000);
            Assert.AreEqual(cerveja2.QuantidadeEmMl(),1675);
            Assert.AreEqual(cerveja3.QuantidadeEmMl(),5000);
        }
        
        [Test]
        public void ValidarSeRetornoEmLitroFunciona()
                {
            NumeroDecimal quatidadeEmLitros1 = new NumeroDecimal((decimal)10);
            NumeroDecimal quatidadeEmLitros2 = new NumeroDecimal((decimal)1.675);
            NumeroDecimal quatidadeEmLitros3 = new NumeroDecimal((decimal)5);
            
            Assert.AreEqual(cerveja1.QuantidadeEmLitros().numero,quatidadeEmLitros1.numero);
            Assert.AreEqual(cerveja2.QuantidadeEmLitros().numero,quatidadeEmLitros2.numero);
            Assert.AreEqual(cerveja3.QuantidadeEmLitros().numero,quatidadeEmLitros3.numero);
        }
        
        [Test]
        public void ValidarSeRetornoValorGastoFunciona()
        {
            NumeroDecimal vlTotal1 = new NumeroDecimal((decimal)120);
            NumeroDecimal vlTotal2 = new NumeroDecimal((decimal)12.50);
            NumeroDecimal vlTotal3 = new NumeroDecimal((decimal)65);
            
            Assert.AreEqual(cerveja1.ValorGastoTotalNaCompra().numero,vlTotal1.numero);
            Assert.AreEqual(cerveja2.ValorGastoTotalNaCompra().numero,vlTotal2.numero);
            Assert.AreEqual(cerveja3.ValorGastoTotalNaCompra().numero,vlTotal3.numero);
        }
    }
}