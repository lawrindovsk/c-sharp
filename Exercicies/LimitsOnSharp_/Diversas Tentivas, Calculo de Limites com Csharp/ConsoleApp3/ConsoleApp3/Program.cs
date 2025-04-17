using System;

namespace LimitsOnSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integrantes: Gustavo Laurindo Dos Santos - Matrícula: 082230032
            //              Arthur Benevides dos Santos - Matrícula: 082230016
            //              Lucas da Silva Macedo - Matrícula: 082230037

            // Variáveis
            int qtdTermo = 0;
            double valueX = 0;
            double resultFinalExp = 0;

            string choose = " ", expressao = " ";

            // Calculadora
            Console.WriteLine("Olá, bem-vindo à Calculadora de Limites");
            Console.WriteLine("Não sabe como usar? Consulte o manual online.");

            Console.WriteLine("\nEscolha: o seu cálculo possui divisão? (Sim ou Não)");
            choose = Console.ReadLine().ToUpper();

            if (choose == "SIM" || choose == "S")
            {
                CalculateDivisionLimits();
            }
            else if (choose == "NAO" || choose == "NÃO")
            {
                CalculateNonDivisionLimits();
            }

            Console.ReadKey();
        }

        // Método para calcular limites com divisão
        static void CalculateDivisionLimits()
        {
            int qtdTermoNum = 0;
            int qtdTermoDen = 0;
            int x = 0;

            double valueX = 0;
            double resultFinalExp = 0;
            double resultFinalLateralMenor = 0;
            double resultFinalLateralMaior = 0;

            string expNum = " ", expDen = " ";

            Console.WriteLine("Digite quantos termos existem no numerador?");
            qtdTermoNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos termos existem no denominador?");
            qtdTermoDen = Int32.Parse(Console.ReadLine());

            // Restante do código de cálculo de limites com divisão
            // ...

            DisplayResults(resultFinalLateralMenor, resultFinalLateralMaior);
        }

        // Método para calcular limites sem divisão
        static void CalculateNonDivisionLimits()
        {
            int qtdTermo = 0;

            double valueX = 0;
            double resultFinalExp = 0;

            string expressao = " ";

            Console.WriteLine("Escreva a quantidade de termos: ");
            qtdTermo = Int32.Parse(Console.ReadLine());

            // Restante do código de cálculo de limites sem divisão
            // ...

            DisplayResult(resultFinalExp);
        }

        // Método para exibir resultados de limites com divisão
        static void DisplayResults(double resultFinalLateralMenor, double resultFinalLateralMaior)
        {
            // Exibir resultados
            resultFinalLateralMenor = Math.Round(resultFinalLateralMenor, 1);
            resultFinalLateralMaior = Math.Round(resultFinalLateralMaior, 1);

            if (resultFinalLateralMaior != resultFinalLateralMenor)
            {
                Console.WriteLine("\nOs limites laterais não coincidem, portanto, não existe um limite.");
            }
            else
                Console.WriteLine($"\nO valor do limite lateral é igual a: {resultFinalLateralMaior}");
        }

        // Método para exibir resultados de limites sem divisão
        static void DisplayResult(double resultFinalExp)
        {
            // Exibir resultado
            Console.WriteLine($"O valor do limite é: {resultFinalExp}");
        }
    }
}
