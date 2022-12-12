using System;

namespace ImersaoAVMB
{
    public abstract class ContaBancaria
    {
        public double saldo;
        public double saldoInicial;

        public double sacar(double saldo, double valor)
        {
            return saldo - valor;
        }

        public double depositar(double saldo, double valor)
        {
            return saldo + valor;
        }

    }
}