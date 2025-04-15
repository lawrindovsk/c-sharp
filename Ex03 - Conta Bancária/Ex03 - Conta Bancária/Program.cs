using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03___Conta_Bancária
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("by Gustavo Laurindo");




            double saldo = 0.0;
            double limiteChequeEspecial = 0.0;

            Console.Write("Digite o saldo do cliente: ");
            saldo = ValidarDoubleNaoNegativo();

            Console.Write("Digite o limite de cheque especial: ");
            limiteChequeEspecial = ValidarDoubleNaoNegativo();

            char opcao;

            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("D - Depósito");
                Console.WriteLine("S - Saque");
                Console.WriteLine("V - Visualizar saldo");
                Console.WriteLine("X - Sair do programa");

                opcao = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (opcao)
                {
                    case 'D':
                        Console.Write("\nDigite o valor do depósito: ");
                        saldo += ValidarDoubleNaoNegativo();
                        break;

                    case 'S':
                        Console.Write("\nDigite o valor do saque: ");
                        double valorSaque = ValidarDoubleNaoNegativo();
                        if (valorSaque <= saldo + limiteChequeEspecial)
                        {
                            saldo -= valorSaque;
                            Console.WriteLine($"Saque de {valorSaque:C} realizado com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        break;

                    case 'V':
                        Console.WriteLine($"\nSaldo atual: {saldo:C}");
                        break;

                    case 'X':
                        Console.WriteLine("\nPrograma encerrado.");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 'X');
        }

        static double ValidarDoubleNaoNegativo()
        {
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0)
            {
                Console.Write("Digite um valor válido (não negativo): ");
            }
            return valor;
        }

    }
    
}

