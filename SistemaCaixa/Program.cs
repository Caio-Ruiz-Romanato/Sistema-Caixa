using System;
using System.Globalization;

namespace SistemaCaixa
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta;

            Console.WriteLine("=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#");
            Console.WriteLine("==========   B A N C O N I X   ===========");
            Console.WriteLine("=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#=#");
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Bem vindo ao banco Nix");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ?");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.Write("Haverá depósito inicial ? ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaCorrente(numeroConta, titular, depositoInicial);

            }
            else
            {
                conta = new ContaCorrente(numeroConta, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Qual o valor de depósito R$: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Qual o valor para saque R$: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);


        }
    }
}