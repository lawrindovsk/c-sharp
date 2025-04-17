using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
        * separar uma função em dois vetores
        * vetor de termos 
        * vetor de operaçõe
        */
            static void Main(string[] args)
            {
                int qtdtermos;

                Console.Write("Quantos termos? ");
                qtdtermos = int.Parse(Console.ReadLine());

                //criar os vetores de acordo com os termos
                String[] termos = new string[qtdtermos];
                String[] operacoes = new string[qtdtermos - 1];
                double[] resultados = new double[qtdtermos];

                //solicitar a função
                for (int parte = 0; parte < qtdtermos; parte++)
                {
                    Console.Write($"Informe o {parte + 1} termo:");
                    termos[parte] = Console.ReadLine();

                    //verifica se tem que solicitar a operação
                    if (parte != qtdtermos - 1)
                    {
                        Console.Write($"Digite o {parte + 1} operador: ");
                        operacoes[parte] = Console.ReadLine();
                    }
                }

                Console.WriteLine();

                //exibindo a função
                for (int parte = 0; parte < qtdtermos; parte++)
                {
                    if (parte != qtdtermos - 1)
                        Console.Write($"{termos[parte]} {operacoes[parte]} ");
                    else
                        Console.Write($"{termos[parte]}");
                }

                //vamos ver quanto vale o 'X'
                int valor = 0;
                Console.Write("\n\nDigite o valor de X: ");
                string entrada = Console.ReadLine();
                if (int.Parse(entrada, out valor))
                {
                    Console.WriteLine("deu certo, continua");

                }
                else
                {
                    Console.WriteLine("deu errado, digite algo certo.");
                }











                ]

                valor = Convert.ToInt32(Console.ReadLine());

                //vamos varrer cada Termo
                for (int parte = 0; parte < qtdtermos; parte++)
                {
                    resultados[parte] = calculaTermo(valor, termos[parte]);
                }

                //exibindo a função calculada
                for (int parte = 0; parte < qtdtermos; parte++)
                {
                    if (parte != qtdtermos - 1)
                        Console.Write($"{resultados[parte]} {operacoes[parte]} ");
                    else
                        Console.Write($"{resultados[parte]}");
                }
                Console.ReadKey();
            }
            static double calculaTermo(int valorX, String expressao)
            {
                double resultado = 0;

                //se a expressao não tem variavel, não precisa calcular
                if (expressao.ToUpper().IndexOf("X") == -1)
                {
                    resultado = double.Parse(expressao);
                }
                else
                {
                    //separa a expressão e joga dentro de um vetor
                    String[] separado = expressao.ToUpper().Split('X');

                    //verifica se a expressao tem exponencial
                    if (separado.Length == 2)
                    {
                        resultado = Math.Pow(valorX, double.Parse(separado[1]));
                        resultado = resultado * double.Parse(separado[0]);
                    }
                    else //não tem exponencial
                    {
                        resultado = valorX * double.Parse(separado[0]);
                    }
                }

                return resultado;
            }
        }
    }




}
  
