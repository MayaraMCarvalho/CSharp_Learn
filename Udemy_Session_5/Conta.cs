using System;
using System.Globalization;

namespace Udemy_Session_5
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta( int numero, string titular )
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                Saldo -= valor + 5.0;
            }
        }

        public override string ToString()
        {
            return $"Conta {Numero}, " +
                   $"Titular: {Titular}, " +
                   $"Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public static void Cadastro()
        {
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine().ToLowerInvariant());

            if (resposta == 's')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                conta = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, titular); 
            }

            Console.WriteLine($"\nDados da conta:\n{conta}");

            Console.Write("\nEntre com um valor para depósito: ");
            conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados:\n{conta}");

            Console.Write("\nEntre com um valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados:\n{conta}");
        }
    }
}


