using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace NumerosMoedas
{
    class Moedas
    {
        public static void NumerosMoedas()
        {
            Console.Clear();
            decimal value = 10.25m;
            Console.WriteLine(value);
            Console.WriteLine("decimal value = 10.25m;, siginifica que é numero tipo decimal, perfeito pra usar em valores, moedas e tal.");
            Console.WriteLine(value.ToString(CultureInfo.CreateSpecificCulture("pt-BR"))); Console.WriteLine("posso por E, C, e outros tipos para definir que tipo de *dinheiro* ou calculo que é!!!");
            Console.WriteLine(value.ToString("E", CultureInfo.CreateSpecificCulture("en-ES")));

            Console.WriteLine(" ");
            Console.WriteLine(" -- ");
        }

        public static void maisMoedas()
        {
            decimal valor = 1819.96m;
            Math.Round(valor); Console.WriteLine("Math.Round - arrendoda o valor ");
            Console.WriteLine(valor);
            Console.WriteLine(Math.PI); Console.WriteLine("Valor de PI!");

        }
    }
}
