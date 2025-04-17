using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int qtdWin;
            int qtDft;
            int totalStatus;

             //ferro = 10;
             //bronze = 20;
             //prata = 50;
             //ouro = 80;
             //diamante = 90;
             //lendario = 100;
             //Imortal = 101;

            Console.WriteLine("Digite seu nome:");
            name = Console.ReadLine();

            Console.WriteLine($"{name}, digite sua quantidade de Vitórias que você tem atualmente:");
            qtdWin = int.Parse(Console.ReadLine());

            Console.WriteLine($"{name}, digite sua quantidade de Derrotas que você tem atualmente:");
            qtDft = int.Parse(Console.ReadLine());

            totalStatus = (qtdWin - qtDft);
            string result;


            if (totalStatus < 10)
                result = "Ferro";
            else if (totalStatus <= 20)
                result = "Bronze";
            else if (totalStatus <= 50)
                result = " Prata";
            else if (totalStatus <= 80)
                result = "Ouro";
            else if (totalStatus <= 90)
                result = "Diamante";
            else if (totalStatus <= 100)
                result = "Lendário";
            else
                result = "IMORTAL";

            Console.WriteLine ($"{name},seu Ranking atualmente é {result}, e tem um saldo de vitórias de {totalStatus}");
            Console.ReadKey();



        }
    }
}
