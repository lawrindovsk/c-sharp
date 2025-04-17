using System;
using System.ComponentModel;
using System.Threading;
using System.Collections;
using System.Text;

namespace HTMLEditor
{
    public static class Editor
    {
        internal static void MostrarEditor()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO DE EDIÇÃO");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            IniciarEditor();
        }
        public static void IniciarEditor()
        {
            var arquivo = new StringBuilder();
            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Deseja salvar o Arquivo criado?");
            Viewer.Visualizar(arquivo.ToString());
        }
    }
}