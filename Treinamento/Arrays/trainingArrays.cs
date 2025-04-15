using System;

namespace Arrays
{
    class Listas()
    {

        public static void arryasList()
        {
            Console.Clear();
            Thread.Sleep(1000);

            Console.WriteLine("array começa na posi: 0");

            var myArray = new int[5];
            myArray[0] = 12;
            Console.WriteLine(myArray[0]);
            myArray[1] = 13;
            Console.WriteLine(myArray[1]);
            myArray[2] = 24;
            Console.WriteLine(myArray[2]);
            myArray[3] = 21;
            Console.WriteLine(myArray[3]);
            myArray[4] = 50 - 09;
            Console.WriteLine(myArray[4]);

        }
    }

}