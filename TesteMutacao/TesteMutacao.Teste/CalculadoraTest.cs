using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteMutacao.Teste
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Somar_RecebendoDoisNumeros_SomarOsDois()
        {
            //Preparação
            var primeiroNumero = 1;
            var segundoNumero = 2;
            var resultadoEsperado = 3;

            //Ação
            var resultadoRecebido = new Calculadora().Somar(primeiroNumero, segundoNumero);

            //Checagem
            Assert.AreEqual(resultadoEsperado, resultadoRecebido);
        }
    }
}
