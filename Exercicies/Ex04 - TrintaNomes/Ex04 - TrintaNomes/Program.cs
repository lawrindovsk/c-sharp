using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04___TrintaNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao;
            //Criar nosso array de nomes

            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º nome: ");
                nomes[i] = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("++++++++++++ Menu ~ by Gustavo Laurindo ++++++++++++");
            Console.WriteLine("1. Exibir todos os Nomes;");
            Console.WriteLine("2. Exibir o Maior dos Nomes;");
            Console.WriteLine("3. Para exibir o primeiro nome de todos lidos;");
            Console.WriteLine("4. Exibir os nomes que se iniciam com vogais;");
            Console.WriteLine("0. Sair");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Digite sua opção: ");
                opcao = int.Parse(Console.ReadLine().ToUpper());
                while (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4 && opcao != 0)
                {
                    Console.Write("Opção Incorreta, tente novamente com a opção correta: ");
                    opcao = int.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine();
                }
                if (opcao == 1)
                {
                    Console.WriteLine("Exibindo todos os nomes escritos: ");
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("[");
                        }
                        Console.Write(nomes[i]);
                        if (i + 1 != nomes.Length)
                        {
                            Console.Write(", ");
                        }
                        if (i == nomes.Length - 1)
                        {
                            Console.Write("]\n");
                        }
                    }
                    Console.WriteLine();
                }
                if (opcao == 2)
                {
                    Console.WriteLine($"O(s) maior(es) nome(s) digitado(s) foi: ");
                    int maior = 0;
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        if (nomes[i].Length > nomes[maior].Length)
                        {
                            maior = i;
                        }
                    }
                    Console.WriteLine(nomes[maior]);
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        if (nomes[i].Length == nomes[maior].Length && nomes[i] != nomes[maior])
                        {
                            Console.WriteLine(nomes[i]);
                        }
                    }
                    Console.WriteLine($"O maior nome digitado foi {nomes[maior]}");
                    Console.WriteLine();
                }
                if (opcao == 3)
                {
                    Console.WriteLine("Exibindo os primeiros nomes escritos de cada nome: ");
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        string[] pNome = nomes[i].Split();
                        Console.WriteLine(pNome[0]);
                    }
                    Console.WriteLine();
                }
                if (opcao == 4)
                {
                    Console.WriteLine("Exibindo nomes que começam com vogais: ");
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        if (nomes[i][0] == 'A' || nomes[i][0] == 'E' || nomes[i][0] == 'I' || nomes[i][0] == 'O' || nomes[i][0] == 'U')
                        {
                            Console.WriteLine(nomes[i]);
                        }
                    }
                    Console.WriteLine();
                }
                if (opcao == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }

            }
        }
    }
}
