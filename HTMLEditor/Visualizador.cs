using System;
using System.ComponentModel;
using System.Threading;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace HTMLEditor
{
    public class Viewer()
    {
        public static void Visualizar(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("----------------------------------------");
            Repor(text);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Mostrar
            ();
        }

        public static void Repor(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }


    }
}