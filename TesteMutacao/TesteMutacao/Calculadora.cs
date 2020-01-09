using System;

namespace TesteMutacao
{
    public class Calculadora
    {
        public int Soma(int primeiroNumero, int segundoNumero) {

            if (segundoNumero != default)
                primeiroNumero += segundoNumero;

            return primeiroNumero;
        }

    }
}
