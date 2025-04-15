using System;
using Microsoft.VisualBasic;
using Data;
using System.Data.SqlTypes;
using System.Globalization;

namespace Data
{
    public class Datas()
    {
        public static void MostrarData()
        {
            Console.Clear();

            Console.WriteLine("espera 10 a 15 segundos para mostrar tudo sobre!!");

            var date = new DateTime();
            Console.WriteLine(date);
            Console.WriteLine("Mostra um valor padrão de data, .NET que decide.");
            Console.WriteLine(" --- ");
            Console.WriteLine(" ");
            Thread.Sleep(1500);

            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine("Mostrar data e hora atual, ele pega essa informação do meu PC.");
            Console.WriteLine(" --- ");
            Console.WriteLine(" ");
            Thread.Sleep(1500);
            var datas = new DateTime(2025, 01, 15, 00, 00, 00);
            Console.WriteLine(datas);
            Console.WriteLine("Mostra o valor que determenei, dentro do paranteses (paramentro), *new DateTime(2025, 01, 15, 00, 00, 00);.");
            Console.WriteLine(" --- ");
            Console.WriteLine(" ");
            Thread.Sleep(1500);

            var algoDias = new DateTime(2005, 01, 24, 07, 15, 00);
            Console.WriteLine(algoDias);
            Console.WriteLine(algoDias.Year);
            Console.WriteLine(algoDias.Month);
            Console.WriteLine(algoDias.Day);
            Console.WriteLine(algoDias.Hour);
            Console.WriteLine(algoDias.Minute);
            Console.WriteLine(algoDias.Second);
            Console.WriteLine("varias metodos do datetime, para poder imprimir, por na tela oque quero separadamente.");
            Console.WriteLine(" --- ");
            Console.WriteLine(" ");
            Thread.Sleep(1500);

            var formato = String.Format("{0:yyyy}", data);
            Console.WriteLine(formato);
            Console.WriteLine("posso determinar qual info que mostrar na tela. passando no String.Format, o parametro com yyyy!, pode ser mm para mes, dd para dia, ou só um de cada e assim vai.");
            String.Format("pode fazer com {0:f}", data);
            Console.WriteLine("com F para aparecer tudo, ou U ou  R");
            Console.WriteLine(" --- ");
            Console.WriteLine(" ");
            Thread.Sleep(1500);

            Console.WriteLine("segue estrutra de if comparando hora");
            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual a de hoje");
                Console.WriteLine(data);
            }
            else
                Console.WriteLine("ta errado, corrija");
            if (date.Date >= DateTime.Now)
            {
                Console.WriteLine("É Antiga!");
            }
            Console.WriteLine(" --- ");
            Console.WriteLine(" ");
            Thread.Sleep(1500);

            var pt = new CultureInfo("pt-BR");
            var eng = new CultureInfo("en-US");
            Console.WriteLine(DateTime.Now.ToString("D", pt)); Console.WriteLine("aqui é portugues brazuca");
            Console.WriteLine(DateTime.Now.ToString("D", eng)); Console.WriteLine("aqui é english");
            Console.WriteLine("criei duas variaveis tipo english e outra como portuguese, no .net tem valdação de cultura, posso utilzar em diversas validaçoes que utilizara isso.");
            Console.WriteLine("CultureInfo!!");
            Console.WriteLine(" --- ");
            Console.WriteLine(" ");
            Thread.Sleep(1500);

            // Obter o fuso horário local
            TimeZone timeZone = TimeZone.CurrentTimeZone;

            Console.WriteLine($"Fuso horário local: {timeZone.StandardName}");
            Console.WriteLine($"Diferença em relação ao UTC: {timeZone.GetUtcOffset(DateTime.Now)}");
            //O TimeZone representa o fuso horário, indicando o deslocamento em relação ao horário universal (UTC).
            // Criar um intervalo de tempo de 2 horas e 30 minutos
            TimeSpan intervalo = new TimeSpan(2, 30, 0);

            Console.WriteLine($"Intervalo: {intervalo}");
            Console.WriteLine($"Total de minutos: {intervalo.TotalMinutes}");

            // Adicionar um intervalo de tempo
            TimeSpan extra = new TimeSpan(1, 0, 0); // 1 hora
            TimeSpan resultado = intervalo + extra;
            //O TimeSpan representa um intervalo de tempo (duração), como 2 horas, 30 minutos, etc.
            Console.WriteLine($"Novo intervalo: {resultado}");
            Console.WriteLine(@"Resumo:TimeZone:Serve para trabalhar com fusos horários.Pode dizer qual é o horário local ou UTC.TimeSpan:Usado para calcular durações(ex.: quanto tempo se passou entre 2 horários");

            Console.ReadKey();
        }


    }
}
