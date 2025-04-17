using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            double[] salarios = new double[5];

            //o for serve para fazer, junto com o vetor, numa lapada só os 5 nomes e 5 salarios, foda demais.
           for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite os nomes {0}: ", i);
                nomes[i] = Console.ReadLine();

                Console.WriteLine("Digite os salários de {0}: ", nomes[i]);
                salarios[i] = Convert.ToDouble(Console.ReadLine());

            }
            //pritando;
            Console.WriteLine("\n | Dados | :");
            for (int i = 0; i < 5; i++) { 
            
                Console.WriteLine("{0} - {1:C2}", nomes[i], salarios[i]);
            }
           
            Console.ReadKey();  
                
        }
    }
}


