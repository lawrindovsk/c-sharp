using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
namespace TimerWatch;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();//limpa a tela (log).
        Console.WriteLine("Hello, World!");//obrigatório né.
        //Start(6);//call fuction Start.
        Menu();
    }//main

    static void Menu()//function Menu
    {
        Console.Clear();
        Console.WriteLine("Bem-Vindo ao Contador .NET Console");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

        Console.WriteLine("Como deseja contar?");
        Console.WriteLine("Em seu teclado, digite o número e a unidade de tempo.");
        Console.WriteLine(@"M para Minutos");
        Console.WriteLine(@"S para Segundos");
        Console.WriteLine("0 - Sair.");

        string dados = Console.ReadLine().ToLower();//leio uma variavel, e nessa variavel tem um ReadLine com validação, ToLower 
        //serve para quando recebemos um dado do usuario, ele converte a digitaçao tudo para minusculo, dependendo do contexto, pode ajudar!.
        char type = char.Parse(dados.Substring(dados.Length - 1, 1));//aqui estou convertendo o char para ser
                                                                     //lido, pois ele é do tipo char, e basicamente vou pegar    o  ultimo caracter que vai determinar qual opção o usuario esta utilizando, entao se ele digitar 123141234s, estou a function rodara em segundos, se for 12312414m, seria minutos.
        int time = int.Parse(dados.Substring(0, dados.Length - 1));//aqui estou pegando numero que vai ser convertido para fazer o tempo acontecer.
        int multiplier = 1;// multiplicador, que vai ser utilizado para multiplicar o tempo digitado pelo usuario, e assim determinar o tempo de execução.

        if (type == 'm')
        {
            multiplier = 60;
        }

        if (time == 0)
        {
            System.Environment.Exit(0);
        }

        PreStart(time * multiplier);

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Contar!");

            Start(time);
        }

        static void Start(int tempo)
        {
            //int tempo = 10;//variavel com um numero determinante.
            int tempoAtual = 0;//current time, this variable determines where the program will start, so, tempoAtual equal zero. Start Line.

            while (tempoAtual != tempo)//while, seria enquanto, entao aqui eu digo que, enquanto tempo atual for diferente de tempo, execute a function abaixo.
            {
                Console.Clear();
                tempoAtual++;//tempo atual, conte de 0 a 10, pois se tempoAtual é diferente de zero, e tempo é igual a dez, entao os steps será até 10.
                Console.WriteLine(tempoAtual);//escreve na tela.
                Thread.Sleep(1000);
            }//end do while;

            Console.Clear();
            Console.WriteLine("Contagem finalizada!");
            Thread.Sleep(2500);
            Menu();
        }//Fim Start   
    }
}