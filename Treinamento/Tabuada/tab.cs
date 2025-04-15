using System;
using Treinamento; // Importa o namespace System para usar classes básicas como Console

namespace TreinamentoTabuada // Define o namespace para corresponder à estrutura da pasta
{
    class Tab // Define a classe Tab
    {
        public static void Tabuada() // Define o método estático Tabuada
        {
            Thread.Sleep(1000);

            Console.WriteLine("Bem vindo a tabuada"); // Exibe uma mensagem de boas-vindas
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Escolha um número para ver a tabuada:"); // Solicita ao usuário que escolha um número
            Console.WriteLine("1 - Tabuada do um "); // Exibe a opção 1
            Console.WriteLine("2 - Tabuada do dois "); // Exibe a opção 2
            Console.WriteLine("3 - Tabuada do três "); // Exibe a opção 3
            Console.WriteLine("4 - Tabuada do quatro "); // Exibe a opção 4
            Console.WriteLine("5 - Tabuada do cinco"); // Exibe a opção 5
            Console.WriteLine("6 - Tabuada do seis"); // Exibe a opção 6
            Console.WriteLine("7 - Tabuada do sete"); // Exibe a opção 7
            Console.WriteLine("8 - Tabuada do oito"); // Exibe a opção 8
            Console.WriteLine("9 - Tabuada do nove "); // Exibe a opção 9
            Console.WriteLine("10 - Tabuada do dez"); // Exibe a opção 10
            int op = Convert.ToInt32(Console.ReadLine()); // Lê a entrada do usuário e converte para inteiro

            Thread.Sleep(5000);
            switch (op) // Inicia uma estrutura de controle switch baseada na entrada do usuário
            {

                case 0: // Caso o usuário escolha 0
                    break; // Não faz nada e sai do switch
                case 1: // Caso o usuário escolha 1
                    Tabu(1); // Chama o método Tabu com o argumento 1
                    break; // Sai do switch
                case 2: // Caso o usuário escolha 2
                    Tabu(2); // Chama o método Tabu com o argumento 2
                    break; // Sai do switch
                case 3: // Caso o usuário escolha 3
                    Tabu(3); // Chama o método Tabu com o argumento 3
                    break; // Sai do switch
                case 4: // Caso o usuário escolha 4
                    Tabu(4); // Chama o método Tabu com o argumento 4
                    break; // Sai do switch
                case 5: // Caso o usuário escolha 5
                    Tabu(5); // Chama o método Tabu com o argumento 5
                    break; // Sai do switch
                case 6: // Caso o usuário escolha 6
                    Tabu(6); // Chama o método Tabu com o argumento 6
                    break; // Sai do switch
                case 7: // Caso o usuário escolha 7
                    Tabu(7); // Chama o método Tabu com o argumento 7
                    break; // Sai do switch
                case 8: // Caso o usuário escolha 8
                    Tabu(8); // Chama o método Tabu com o argumento 8
                    break; // Sai do switch
                case 9: // Caso o usuário escolha 9
                    Tabu(9); // Chama o método Tabu com o argumento 9
                    break; // Sai do switch
                case 10: // Caso o usuário escolha 10
                    Tabu(10); // Chama o método Tabu com o argumento 10
                    break; // Sai do switch
                           //disclamer: o argumento quando está sendo chamado o metodo, é sobre o numero base que ele via utilizar. 
                default: // Caso o usuário escolha uma opção inválida
                    Console.WriteLine("Opção inválida"); // Exibe uma mensagem de erro
                    break; // Sai do switch
            }
        }

        public static void Tabu(int numBase) // Define o método estático Tabu que recebe um número base
        {
            int opTrue = 1;
            int opFalse = 0;


            int numMultiplicador = 10; // Define o número de multiplicadores como 10
            int[] tabuada = new int[numMultiplicador]; // Cria um array para armazenar os resultados da tabuada

            for (int cont = 0; cont < numMultiplicador; cont++) // Loop para preencher o array com os resultados
            {
                tabuada[cont] = numBase * (cont + 1); // Calcula o resultado da multiplicação e armazena no array
            }

            Console.WriteLine($"Tabuada do {numBase}"); // Exibe a tabuada do número base
            for (int cont = 0; cont < numMultiplicador; cont++) // Loop para exibir os resultados armazenados no array
            {
                Console.WriteLine($"{numBase} x {cont + 1} = {tabuada[cont]}"); // Exibe cada linha da tabuada
            }
            Thread.Sleep(1500);
            Console.WriteLine("Deseja continuar a vizualizar as tabuadas?");
            Console.WriteLine("Aperte 1 e ENTER para continuar, do contrário, 0 para voltar ao menu!");


            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Y)
            {
                if (opTrue == 1)
                {
                    Tabuada();
                }

            }
            else if (tecla.Key == ConsoleKey.N)
            {
                if (opFalse == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Volte Sempre!");
                    Menu.Treinamento();
                }

            }
        }
    }
}//end.
