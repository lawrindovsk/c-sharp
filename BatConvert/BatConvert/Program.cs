using System;
using System.IO;
using Microsoft.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.CSharp;
namespace BatConvert;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o Caminho da Pasta que contém os arquivos .bat:");
        string caminhoPasta = Console.ReadLine();

        Console.WriteLine("Digite o cainho da pasta para salvar os .bat convertidos:");
        string finalPasta = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(finalPasta))
        {
            finalPasta = caminhoPasta;
        }

        var conversor = new BatConversor();

        Thread.Sleep(1000);

        Console.WriteLine("Iniciando a conversão...");
        Thread.Sleep(1000);
        conversor.ConversorPastaBatInFolder(caminhoPasta, finalPasta);
        Console.WriteLine("Conversão concluída, verificar pasta!.");


    }
}
