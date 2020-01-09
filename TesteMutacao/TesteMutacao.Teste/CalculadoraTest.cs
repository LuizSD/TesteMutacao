using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteMutacao.Teste
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Somar_RecebendoDoisNumeros_SomarOsDois()
        {

            var primeiroNumero = 1;
            var segundoNumero = 2;

            var resultado = new Calculadora().Somar(primeiroNumero, segundoNumero);

            Assert.IsNotNull(resultado);

        }
    }
}
