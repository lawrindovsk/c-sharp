using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.ComponentModel;
namespace TextEditor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");//Obrigatório.
        Thread.Sleep(1000);
        Console.Clear();
        Menu();
    }

    static void Menu()
    {

        Console.WriteLine("Welcome to the Text Editor!");
        Console.WriteLine("Choose your option:");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("1 - Open File");
        Console.WriteLine("2 - Create a new File");


#pragma warning disable CS8604 // Possível argumento de referência nula.
        short option = short.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.

        switch (option)
        {
            case 0: Environment.Exit(0); break;
            case 1: OpenFile(); break;
            case 2: CreateFile(); break;
            default: Menu(); break;
        }
    }//Function to show the menu.


    public static void OpenFile()
    {
        //var;
        int bindY = 1;
        int bindN = 0;


        Console.Clear();
        Thread.Sleep(5000);
        Console.WriteLine("To use that option, you need to type the full path of the file.");
        Console.WriteLine("Like this exemple: C:/Users/You/Desktop/nametxt.txt");
        Console.WriteLine("What's the file path?");//asking to user what is the file path.
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
        string path = Console.ReadLine();//read the user path.
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

#pragma warning disable CS8604 // Possível argumento de referência nula.
        using (var file = new StreamReader(path))
        {
            string textUser = file.ReadToEnd();//read the file and store in textUser at the end name.
            Thread.Sleep(1000);
            Console.WriteLine(textUser);//show the text to user.
            Thread.Sleep(5000);
            Console.WriteLine("Your txt file was readed sucssesfully!");
            Thread.Sleep(5000);
        }


#pragma warning restore CS8604 // Possível argumento de referência nula.
        Console.WriteLine("");
        Thread.Sleep(5000);
        Console.WriteLine("You wanna open another file? (Y/N)");

        ConsoleKeyInfo bind = Console.ReadKey();//read the user key.
        if (bind.Key == ConsoleKey.Y)//if user press Y, the function will be called again.
        {

            if (bindY == 1)//if the user press Y, the function will be called again.
            {
                Menu();//execute the function Menu!
            }
        }
        else if (bind.Key == ConsoleKey.N)//but if the user press N, the program will be closed.
        {
            if (bindN == 0)//if the user press N, the program will be closed.
            {
                Console.Clear();
                Console.WriteLine("Great to see you, bye!");
                Thread.Sleep(2000);
                Environment.Exit(0);//exit.

            }
        }

        //Console.Clear();
        //Menu();


    }//Fuction to Open the file.

    public static void CreateFile()
    {

        Console.Clear();
        Console.WriteLine("Type your text bellow (ESC to finish)");
        Console.WriteLine("-----------------------------------");

        string textUser = "";// Every text will be stored here.

        do
        {
            textUser += Console.ReadLine(); // User text type stored here.
            textUser += Environment.NewLine; // Every time the user press ENTER, a new line will be created.
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);// if user press ESC, the loop will stop.

        SaveFile(textUser);
    }//Function to edit the file.

    public static void SaveFile(string text)
    {
        //var;

        int bindY = 1;
        int bindN = 0;



        Console.Clear();
        Console.WriteLine("To you save your text file, you need to scribe a full path, like this");
        Console.WriteLine("Exemple: C:/Users/You/Desktop/yourfile.txt");
        Console.WriteLine("---------------------------------------------------------------------------");
        Thread.Sleep(9500);//Time to user read the message.
        Console.Clear();
        Thread.Sleep(2500);

        Console.WriteLine("What the path you want the save file?");// Ask to user the file name.
        var path = Console.ReadLine();

#pragma warning disable CS8604 // Possível argumento de referência nula.
        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
#pragma warning restore CS8604 // Possível argumento de referência nula.

        Console.WriteLine($"Your archive {path} was saved successfully!");
        Console.WriteLine(" ");
        Console.WriteLine("Do you wanna create another file? (Y/N)");

        ConsoleKeyInfo bind = Console.ReadKey();//read the user key.
        if (bind.Key == ConsoleKey.Y)//if user press Y, the function will be called again.
        {

            if (bindY == 1)//if the user press Y, the function will be called again.
            {
                CreateFile();//execute the function Menu!
            }
        }
        else if (bind.Key == ConsoleKey.N)//but if the user press N, the program will be closed.
        {
            if (bindN == 0)//if the user press N, the program will be closed.
            {
                Console.Clear();
                Console.WriteLine("Great to see you, bye!");
                Thread.Sleep(2000);
                Environment.Exit(0);//exit.

            }
        }

        //Console.ReadLine();
        //Menu();
    }//Function to save the file.




}
