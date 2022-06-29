using System;
using System.Globalization;

namespace SistemaCaixa
{
    internal class ContaCorrente
    {
        //Propriedades altoimplementares
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtores
        public ContaCorrente(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }
        public ContaCorrente(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            Deposito(depositoInicial);
        }

        //Atributos
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 7.50;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Titular
                + ", Saldo R$: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
