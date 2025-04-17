using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ECN12biAlg
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("++++++++++++ Bem vinndo a Atividade N1 do 2º Bimestre de Gustavo Laurindo ++++++++++++");
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1. Intervalos em Array");
                Console.WriteLine("2. Valor A");
                Console.WriteLine("3. Conta Bancária");
                Console.WriteLine("4. 30 Nomes");
                Console.WriteLine("0. Sair");
                Console.WriteLine("Opção: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        IntervaloArray();
                        break;
                    case "2":
                        ValorDeA();
                        break;
                    //case "3":
                        //ContaBancaria();
                        //break;
                    //case "4":
                        //TrintaNomes();
                        //break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Tente novamente escolhendo uma das opções existentes acima.");
                        break;


                }


                //Exercicio 1;
                static void IntervaloArray()
                {
                    Console.WriteLine("Informe o tamanho do array");
                    int tArray = Convert.ToInt32(Console.ReadLine());
                    int[] ArrayNumeros = new int[tArray];

                    for (int i = 0; i< tArray; i++)
                    {
                        Console.WriteLine($"informe o valor [0-100] do número na posição {i}: ");
                        ArrayNumeros[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int frenq1 = 0;
                    int frenq2 = 0;
                    int frenq3 = 0;
                    int frenq4 = 0;
                    

                    foreach (int num in ArrayNumeros)
                    {
                        if(num >= 0 && num <= 25)
                        {
                            frenq1++;
                        }

                        if (num >= 26 && num <= 50)
                        {
                            frenq2++;
                        }

                        if (num >= 51 && num <= 75)
                        {
                            frenq3++;
                        }

                        if (num >= 76 && num <= 100)
                        {
                            frenq4++;
                        }

                        Console.WriteLine($"Quantidade de números  entre [0-25] é: {frenq1}");
                        Console.WriteLine($"Quantidade de números  entre [26-50] é: {frenq2}");
                        Console.WriteLine($"Quantidade de números  entre [51-75] é: {frenq3}");
                        Console.WriteLine($"Quantidade de números  entre [76-100] é: {frenq4}");

                    }
                    //Fim do Exercicio 1.

                    //Exercicio 2;
                    static void ValorDeA()
                    {
                        int num;

                        Console.WriteLine("Digite um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        for (int i = num - 1; i >= i--) 
                        {
                            num *= i;
                        }

                        Console.WriteLine($"O fatorial desse número é: {num}");

                        Console.ReadKey();  

                    }
                    //Fim Exercicio 2.

















































                    

                }
                   


            }
        }

                    





    }

}

   

