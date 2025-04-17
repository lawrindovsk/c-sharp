using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02___ValorA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("by Gustavo Laurindo");



            Console.Write("Digite um valor para calcular o fatorial: ");
            int valorInicial = int.Parse(Console.ReadLine());

            Console.Write($"{valorInicial}! = ");

            // Inicializa o resultado com 1, pois qualquer número multiplicado por 1 é o próprio número.
            int resultado = 1;

            for (int i = valorInicial; i >= 1; i--)
            {
                Console.Write(i);

                resultado *= i;

                if (i > 1)
                {
                    Console.Write(" X ");
                }
            }

            Console.WriteLine($" = {resultado}");

            Console.ReadKey();
        }
    }
}
