using System;
using System.ComponentModel;
using System.Threading;
using System.Collections;
using System.Text;

namespace HTMLEditor
{
    public static class Menu
    {
        internal static void Mostrar()
        {
            Console.Clear(); // Limpa a tela do console
            Console.BackgroundColor = ConsoleColor.Black; // Define a cor de fundo do console;
            Console.ForegroundColor = ConsoleColor.White; // Define a cor do texto do console;
            Console.WriteLine("Bem-vindo ao Editor de HTML");
            Thread.Sleep(5000);//Tempo para iniciar a aplicação.

            DesenharTela();//Função sendo chamada, ela desenha o entorno do software.
            MostrarOpcoes();//Executa o programa.

#pragma warning disable CS8604 // Possível argumento de referência nula.
            var escolha = short.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.
            EscolhaMenu(escolha);


        }
        public static void DesenharTela()
        {
            // Escreve o primeiro caractere "+" no início da borda superior
            Console.Write("+");
            // Loop para criar uma sequência de 30 caracteres "-"
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-"); // Escreve o caractere "-" 31 vezes
            }
            // Finaliza a borda superior com outro "+"
            Console.Write("+");
            // Quebra de linha após desenhar a borda superior
            Console.Write("\n");
            // Loop externo para criar 10 linhas verticais
            for (int lines = 0; lines <= 10; lines++)
            {
                // Inicia a linha com uma borda vertical "|"
                Console.Write("|");
                // Loop interno para preencher o espaço vazio entre as bordas verticais
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" "); // Adiciona um espaço vazio
                }
                // Fecha a linha com outra borda vertical "|"
                Console.Write("|");
                // Quebra de linha após cada linha do "retângulo"
                Console.Write("\n");
            }
            // Desenha a borda inferior começando com "+"
            Console.Write("+");
            // Loop para criar uma sequência de 30 caracteres "-" na borda inferior
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-"); // Escreve o caractere "-" 31 vezes
            }
            // Finaliza a borda inferior com outro "+"
            Console.Write("+");
        }//Fim DesenharTela;
        public static void MostrarOpcoes()//Função para para mostrar opções para utilização do programa.
        {
            Console.SetCursorPosition(3, 2);//estou "setando" um cursor na tela, dentro do parenteses seria a cordenada sendo passada, estou dizendo aonde vai ser escrito.
            Console.WriteLine("Editor HTML");//texto que quero que exiba.
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir Arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");//aqui é a caixinha que o usuario vai ver qual opção ele vai utilizar.
        }
        public static void EscolhaMenu(short choose)//Switch Case para determinar oque vai ser executado.
        {
            switch (choose)
            {
                case 1:
                    Editor.MostrarEditor();
                    break;
                case 2:
                    //Viewer.Visualizar();
                    break;
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("Volte Sempre!");
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Mostrar();
                    break;
            }
        }
    }
}//End All.