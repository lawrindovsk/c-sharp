using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01___IntervaloArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("by Gustavo Laurindo");

            Console.WriteLine("Informe o tamanho do array:");
            int tArray = Convert.ToInt32(Console.ReadLine());
            int[] ArrayNumeros = new int[tArray];

            for (int i = 0; i < tArray; i++)
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
                if (num >= 0 && num <= 25)
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

                Console.ReadKey();
            }
        }
    }
}
