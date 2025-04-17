using System;

namespace LimitsOnSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            string choose = GetUserInput("O seu cálculo possui divisão? (Sim ou Não)");

            if (IsDivision(choose))
            {
                HandleDivision();
            }
            else
            {
                HandleNoDivision();
            }

            Console.ReadKey();
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Olá, bem-vindo à Calculadora de Limites");
            Console.WriteLine("Não sabe como usar? Utilize o manual online, link do manual: ");
            Console.WriteLine("\nIntegrantes: Gustavo Laurindo Dos Santos - Matrícula: 082230032");
            Console.WriteLine("Arthur Benevides dos Santos - Matrícula: 082230016");
            Console.WriteLine("Guilherme Macedo");
            Console.WriteLine("---------------------------------------------------------------\n");
        }

        static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().ToUpper();
        }

        static bool IsDivision(string choose)
        {
            return choose == "SIM" || choose == "S";
        }

        static void HandleDivision()
        {
            int qtdTermoNum = GetUserInputAsInt("Digite quantos termos existem no numerador?");
            int qtdTermoDen = GetUserInputAsInt("Digite quantos termos existem no denominador?");

            string[] vOperadorNum = GetOperadores(qtdTermoNum - 1);
            string[] vOperadorDen = GetOperadores(qtdTermoDen - 1);

            string[] valorNum = GetValores("numerador", qtdTermoNum, vOperadorNum);
            string[] valorDen = GetValores("denominador", qtdTermoDen, vOperadorDen);

            double valueX = GetUserInputAsDouble("\nEscreva o valor de X");

            double resultFinalNum = CalculateExpressionResult(valueX, valorNum, vOperadorNum);
            double resultFinalDen = CalculateExpressionResult(valueX, valorDen, vOperadorDen);

            HandleLimits(valueX, resultFinalNum, resultFinalDen);
        }

        static int GetUserInputAsInt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        static double GetUserInputAsDouble(string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());
        }

        static string[] GetOperadores(int count)
        {
            string[] operadores = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}ª operação: ");
                operadores[i] = Console.ReadLine();
            }
            return operadores;
        }

        static string[] GetValores(string tipo, int qtdTermo, string[] vOperador = null)
        {
            string[] valores = new string[qtdTermo];
            if (vOperador != null)
            {
                for (int i = 0; i < qtdTermo; i++)
                {
                    Console.WriteLine($"Digite o valor do {i + 1}º termo do {tipo}: ");
                    valores[i] = Console.ReadLine();

                    if (i != qtdTermo - 1)
                    {
                        Console.WriteLine($"Digite o valor da {i + 1}ª operação: ");
                        vOperador[i] = Console.ReadLine();
                    }
                }
            }
            else
            {
                for (int i = 0; i < qtdTermo; i++)
                {
                    Console.WriteLine($"Digite o valor do {i + 1}º termo do {tipo}: ");
                    valores[i] = Console.ReadLine();
                }
            }
            return valores;
        }

        static double CalculateExpressionResult(double valueX, string[] valores, string[] operadores)
        {
            double[] resultNumerador = new double[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                resultNumerador[i] = EvaluateTerm(valueX, valores[i]);
            }

            return CalculateResult(resultNumerador, operadores);
        }

        static double EvaluateTerm(double valueX, string term)
        {
            double resultado = 0;

            if (term.ToUpper().IndexOf("X") == -1)
            {
                resultado = double.Parse(term);
            }
            else
            {
                string[] separated = term.ToUpper().Split('X');

                if (separated.Length == 2 && separated[1] != "")
                {
                    resultado = Math.Pow(valueX, double.Parse(separated[1]));
                    resultado = resultado * double.Parse(separated[0]);
                }
                else
                {
                    resultado = valueX * double.Parse(separated[0]);
                }
            }

            return resultado;
        }

        static double CalculateResult(double[] values, string[] operators)
        {
            double result = values[0];

            for (int i = 0; i < operators.Length; i++)
            {
                if (operators[i] == "+")
                {
                    result += values[i + 1];
                }
                else
                {
                    result -= values[i + 1];
                }
            }

            return result;
        }

        static void HandleLimits(double valueX, double resultFinalNum, double resultFinalDen)
        {
            // Implement the logic for handling limits here
        }

        static void HandleNoDivision()
        {
            int qtdTermo = GetUserInputAsInt("Escreva a quantidade de termos: ");
            string[] valor = GetValores("termo", qtdTermo, null);
            string[] valorOperador = GetOperadores(qtdTermo - 1);
            double valueX = GetUserInputAsDouble("Escreva o valor de X");
            double resultFinalExp = CalculateExpressionResult(valueX, valor, valorOperador);

            Console.WriteLine($"O valor do limite é: {resultFinalExp}");
        }
    }
}
