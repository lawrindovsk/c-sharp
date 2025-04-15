using System;
using Arrays;
using Data;
using NumerosMoedas;
using TreinamentoTabuada;

namespace Treinamento
{

    public class Menu()
    {
        public static void Treinamento()
        {
            Console.WriteLine("Treinamento .NET");
            Console.WriteLine("----------------------");

            Console.WriteLine("1 - Datas ");
            Console.WriteLine("2 - Moedas (validações, deciamais, culture e etc.)");
            Console.WriteLine("3 - Arrays ");
            Console.WriteLine("4 - Tabuada");
            Console.WriteLine("# -");
            Console.WriteLine("# -");
            Console.WriteLine("# -");

#pragma warning disable CS8604 // Possível argumento de referência nula.
            short choose = short.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.

            switch (choose)
            {
                case 1:
                    Datas.MostrarData();
                    break;
                case 2:
                    Moedas.NumerosMoedas();
                    Moedas.maisMoedas();
                    break;
                case 3:
                    Listas.arryasList();
                    break;
                case 4:
                    Tab.Tabuada();
                    break;
                case 5:
                    break;
                default:
                    Menu.Treinamento();
                    break;
            }//
        }//
    }//
}//