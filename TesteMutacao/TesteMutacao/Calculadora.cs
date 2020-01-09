using System;

namespace TesteMutacao
{
    public class Calculadora
    {
        public int Somar(int primeiroNumero, int segundoNumero) {

            if (segundoNumero != default)
                primeiroNumero += segundoNumero;

            return primeiroNumero;
        }

    }
}
