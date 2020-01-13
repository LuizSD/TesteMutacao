using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteMutacao.Teste
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Somar_RecebendoDoisNumeros_SomarOsDois()
        {
            //Prepara��o
            var primeiroNumero = 1;
            var segundoNumero = 2;
            var resultadoEsperado = 3;

            //A��o
            var resultadoRecebido = new Calculadora().Somar(primeiroNumero, segundoNumero);

            //Checagem
            Assert.AreEqual(resultadoEsperado, resultadoRecebido);
        }
    }
}
