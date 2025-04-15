using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        Calc();//Chamando a function.
    }
    static void Calc()
    {
        Console.Clear();
        Console.WriteLine("Hello, World!");
        //var



        //Calculadora;
        Console.WriteLine("Bem-vindo a Calculadora .NET Console");
        Console.WriteLine("Escolha a operação aritmética que deseja:");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("0 - Sair do Programa.");
        int resultOp = Convert.ToInt32(Console.ReadLine());
        switch (resultOp)
        {
            case 0:
                Console.WriteLine("Adeus!");
                break;

            case 1:
                Soma();
                break;

            case 2:
                Subtracao();
                break;

            case 3:
                Multiplica();
                break;

            case 4:
                Divisao();
                break;

            default:

                Console.WriteLine("Tchau!");
                break;

        }
    }//fim static void Main;.

    //Soma 
    static void Soma()
    {
        //var;
        int opY = 1;
        int opN = 0;

        char letterOp = (char)(opY + 89);
        char letterOp2 = (char)(opN + 79);

        //run;
        Console.WriteLine("Digite o primeiro Número");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo Número:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double result = n1 + n2;

        Console.WriteLine($"o resultado da sua Soma foi: {result}");
        Console.WriteLine(" ");
        //Console.WriteLine("Pressione qualquer tecla para continuar calculando!");
        Console.WriteLine("Deseja continuar calculando? se sim, aperte Y no seu teclado.");
        Console.WriteLine("Senão, aperte N.");

        ConsoleKeyInfo tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.Y)
        {
            if (opY == 1)
            {
                Calc();
            }

        }
        else if (tecla.Key == ConsoleKey.N)
        {
            if (opN == 0)
            {
                Console.Clear();
                Console.WriteLine("Volte Sempre!");
                System.Environment.Exit(0);
            }

        }
        //Console.ReadKey();
        //Console.Clear();
        //Calc();

    }//fim Soma;.

    static void Subtracao()
    {
        //var;
        int opY = 1;
        int opN = 0;

        char letterOp = (char)(opY + 89);
        char letterOp2 = (char)(opN + 79);
        Console.WriteLine("Digite o primeiro Número");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo Número:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double result = n1 - n2;

        Console.WriteLine($"o resultado da sua Subtração foi: {result}");
        Console.WriteLine(" ");
        //Console.WriteLine("Pressione qualquer tecla para continuar calculando!");
        Console.WriteLine("Deseja continuar calculando? se sim, aperte Y no seu teclado.");
        Console.WriteLine("Senão, aperte N.");

        ConsoleKeyInfo tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.Y)
        {
            if (opY == 1)
            {
                Calc();
            }

        }
        else if (tecla.Key == ConsoleKey.N)
        {
            if (opN == 0)
            {
                Console.Clear();
                Console.WriteLine("Volte Sempre!");
                System.Environment.Exit(0);
            }

        }

        //Console.ReadKey();
        //Console.Clear();
        //Calc();
    }//fim Subtracao;.

    static void Multiplica()
    {
        //var;
        int opY = 1;
        int opN = 0;

        char letterOp = (char)(opY + 89);//char para ser apenas um valor a ser digitado, e somo a variavel com o numero da tabela ascii (o pc se utiliza dessa tabela para ler oque digitamos.)
        char letterOp2 = (char)(opN + 79);//same

        Console.WriteLine("Digite o primeiro Número");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo Número:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double result = n1 * n2;

        Console.WriteLine($"o resultado da sua Multiplicação foi: {result}");
        Console.WriteLine(" ");
        Console.WriteLine("Pressione qualquer tecla para continuar calculando!");
        Console.WriteLine(" ");
        //Console.WriteLine("Pressione qualquer tecla para continuar calculando!");
        Console.WriteLine("Deseja continuar calculando? se sim, aperte Y no seu teclado.");
        Console.WriteLine("Senão, aperte N.");

        ConsoleKeyInfo tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.Y)
        {
            if (opY == 1)
            {
                Calc();
            }

        }
        else if (tecla.Key == ConsoleKey.N)
        {
            if (opN == 0)
            {
                Console.Clear();
                Console.WriteLine("Volte Sempre!");
                System.Environment.Exit(0);
            }

        }

        //Console.ReadKey();
        //Console.Clear();
        //Calc();
    }//fim Multiplica;.

    static void Divisao()
    {

        //var;
        int opY = 1;
        int opN = 0;

        char letterOp = (char)(opY + 89);
        char letterOp2 = (char)(opN + 79);

        Console.WriteLine("Digite o primeiro Número");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo Número:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double result = n1 / n2;
        if (n2 == 0)
        {
            Console.WriteLine("Impossível dividir por zero!, favor digita um valor válido...");
            Console.WriteLine("tente novamente.");
            Divisao();
        }
        else
        {
            Console.WriteLine($"o resultado da sua Divisão foi: {result}");
            Console.WriteLine(" ");
            //Console.WriteLine("Pressione qualquer tecla para continuar calculando!");
            Console.WriteLine("Deseja continuar calculando? se sim, aperte Y no seu teclado.");
            Console.WriteLine("Senão, aperte N.");

            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Y)
            {
                if (opY == 1)
                {
                    Calc();
                }

            }
            else if (tecla.Key == ConsoleKey.N)
            {
                if (opN == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Volte Sempre!");
                    System.Environment.Exit(0);
                }

            }
        }

        //Console.ReadKey();
        //Console.Clear();
        //Calc();

    }//fim Divisao;
}


