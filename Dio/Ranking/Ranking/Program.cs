using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    class Program
    {
        //Níveis de Herói em CSHARP;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do herói:? ");
            string nameHero = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de experiência do héroi: ");
            int xp = int.Parse(Console.ReadLine());

            string level;

            if (xp < 1000)
                level = "Ferro";
            else if (xp <= 2000)
                level = "Bronze";
            else if (xp <= 5000)
                level = "Prata";
            else if (xp <= 7000)
                level = "Ouro";
            else if (xp <= 8000)
                level = "Platina";
            else if (xp <= 9000)
                level = "Ascendente";
            else if (xp <= 10000)
                level = "Imortal";
            else
                level = "Radiante";

            Console.WriteLine($"O Herói de nome {nameHero} está no Nível {level}");
            Console.ReadKey();
                    

        }
    }
}
