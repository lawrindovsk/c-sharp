using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulinhas_de_CSHURPS
{
    class Program
    {
        static void Main(string[] args) //Static Void = Não retorna algum valor, pois void seria o mesmo que "buraco", basicamente o código só recebe dados.
        {
            bool sair = false; // Aqui é un esquema de verdadeiro ou falso, onde variável "sair" é o verdadeiro ou falso, 
            //esse bool sair ta trabalhando junto com o while abaixo, que é uma estrutura simples e básica de menu. 
            // | | | | | | | |
            // v v v v v v v v

            while (!sair) //Este é um loop de 'while', que continua sendo rodado enquando a váriavel 'sair' for false,
                          //o código só para se for digitado '0', que é = sair.
            {
                //Estrutura básica de Menu interativo para o usuário
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Calcular a soma de dois números;");
                Console.WriteLine("2 - Validar número se é Par ou Ímpar;");
                Console.WriteLine("3 - Juntando os nomes;");
                Console.WriteLine("4 - Calculadora Básica");
                Console.WriteLine("5 - Media");
                Console.WriteLine("6 - Hotel");
                Console.WriteLine("Indisponível");
                Console.WriteLine("Indisponível");
                Console.WriteLine("Indisponível");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                //Fim do menu interativo.

                //várivel escolhe que vai ler a escolha do usuário, abaixo o switch foi feito.
                string escolha = Console.ReadLine();
                // switch (escolha) = literalmente switch (trocar), os case seria as opções que foram criadas acima, e cada um executa a função, se houver mais opções,
                //só adicionar acima no menu e abaixo no switch case, para a função ser rodada.
                switch (escolha)//switch é uma função para fazer o menu acima funcionar;
                {
                    case "1":
                        CalcularSoma();
                        break;
                    case "2":
                        ParImpar();
                        break;
                    case "3":
                        JuntarNomes();
                        break;
                    case "4":
                        Calculadora();
                        break;
                    case "5":
                        Media();
                        break;
                    case "6":
                        Hotel();
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }   //fim do switch case do menu interativo;
        }

        static void CalcularSoma() //Funcção de somar dois números, bem simples! 
        // | | | | | | | |
        // v v v v v v v v
        {
            string nome; //variavel nome que recebe o tipo de dado string = string é tipo texto ou seja, caracter.
            double n1;  // variaveis n1 e n2 recebe tipo double, que seria numeros com virgula, ou seja 10.20 ou 10,20, tipo double = tipo real.
            double n2;

            Console.WriteLine("Olá, digite seu nome: "); //Console.WriteLine, aqui você mostra para o usuário em tela oque será escrito, no caso aqui estou pedindo nome dele.
            nome = Console.ReadLine(); //estou lendo o nome que o usuario ta digitou, pegando a variavel que foi "carregado" com o dado digitado. Console.Read ou ReadLine fazem as mesma coisa, a diferença é que o read -
            //read não pula linha, o readline sim. *o mesmo vale para o nosso querido Write.

            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine()); //aqui estou pedindo um numero para ser digitado e fazendo o c# entender que, essa varivel NÃO É STRING, por isso convertemos na hora de ler, Convert é uma função nativa da linguagem,
            //eu fiz diferente do professor que ele instancia la cima (instaciar = dizer que a variavel é tal coisa), o viott diz que tipo ele é, int16 ou 32 e etc. eu só instancio o tipo de dado, a conversão é automática e evita fru fru.
            // ah e depois eu mando ele ler essa variavel que foi convertida para ser lida como número.

            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());//aqui a mesma coisa com o n1.

            double soma = n1 + n2;//função de soma, instanciei que a variavel SOMA, vai literalmente SOMAR as duas variaveis. numero 1 + numero 2 = soma.

            Console.WriteLine($"{nome}, o resultado da sua soma é: {soma}");// aqui tem um forma interessante de puxar a variavel , no c# podemos usar o $! que ele deixa a gente puxar a variavel junto com a várivel, dessa forma que ta escrita.
            Console.WriteLine();//isso aqui foi pra pular uma linha só isso.

            Console.ReadKey();
        }

        static void ParImpar()// começando uma nova função, aqui vamos validar se o numero é PAR ou IMPAR, 
        {
            string nome;//variavel string = tipo texto, caracter.
            int numero;// variavel tipo int = numero do tipo inteiro, não vai ter VIRGULA, afinal é para validar numeros não calcular eles.


            Console.WriteLine("Olá seja bem-vindo ao validador de Par ou Impar, digite seu nome:");//escrevendo para o user;
            nome = Console.ReadLine(); //lendo a varivel nome;

            Console.WriteLine("Digite um número para validação");//pedindo um numero para o otario que ta outro lado da tela escrevendo.
            numero = Convert.ToInt32(Console.ReadLine());// esse convert to int32 é basicamente ele poder ler o numero como se fosse uma especie de string, mesma coisa que anteriormente, tipo ele vai pode retornar o valor em tela como texto para o
            //usuario e poder calcular também, porque se formos escrever apenas readline, ele não ele porque o read e readline server para só string, a variavel 'numero' não é string, por isso as conversões para int ou double e etc.

            if (numero % 2 == 0) //explicando sobre esse treco aqui, aqui é um if onde utilizamos operadores % e ==, o '%' ele retonra o resto da divisão de um número,
                                 //no casom estamos calculando o resto da divisão de 'numero' por 2. assim ele retorna 0. resumindo tudo, se o resto for divisivel por 0, siginifica que o numero é divisivel por 2;

            // agora esse == ele verifica se o resultado do calculo é igual a 0.

            // ou seja, portanto, if (numero % 2 == 0) verifica se numero é um número divisível por 2 sem deixar resto. Se essa condição for verdadeira,
            // significa que numero é par, e a mensagem "é um número PAR" é exibida. Caso contrário, ou seja,
            // se o resto da divisão não for zero, o número é ímpar e a mensagem "é um número ÍMPAR" é exibida.
            {
                Console.WriteLine($"{numero} é um número PAR!"); //finalizando o if, se for par ele mostrar PAR na tela e se não for , utiliza o ELSE que ele mostra q é IMPAR né.
            }
            else
            {
                Console.WriteLine($"{numero} é um número IMPAR"); // le a explicação de cima 

            }
            //Fim do exercicio ParImpar.

            Console.ReadKey(); //esse readkey serve para manter o código aberto esperando algo ser teclado.

        }

        static void JuntarNomes() // mais uma função, aqui fiz uma função que junta nome e sobrenome.
        {

            string nome; // variavel nome que recebe dado tipo string = tipo texto
            string sobreNome; // mesma coisa, mas um detalhe MUITO IMPORTANTE CARAI, é que a variavel tem que ser bem identificado, sem acento e se for palavra composta, deixe a segunda parte em MAIUSCULO!!!
            //isso se chama boas práticas de programação, não é pra ser bagunçado então, um ex: meu nome é Gustavo Laurindo, quero criar uma variavel gustavolaurindo, mas desse jeita ruim de ler e ser identificado então
            //eu escrevo 'gustavoLaurindo' , fica bem melhor.

            Console.WriteLine("Oi, vou juntar seus nomes, digita ai o primeiro"); //o de sempre, mostrando em tela e pedindo algo para o usuario burro;
            nome = Console.ReadLine();//le a variavel nome, recebendo a informação queo usuario escreveu.

            Console.WriteLine("Agora digite seu sobrenome");//mesma coisa, aqui to perguntando o sobrenome.
            sobreNome = Console.ReadLine();//le a variavel sobreNome!

            string nomeCompleto = nome + " " + sobreNome; //aqui seria uma especie de SOMA, tipo, to juntando duas coisas para se tornarem uma, tipo oque fiz ali de somar dois numeros que entrega um resultado;
            //ou seja, o nome + sobreNome vai se tornar = nomeCompleto, o termo correto é CONCATENAR, no mundo da programação utilizamos isso para algo que é individual se tornar composta, sacou? to grudando uma coisa a outra.
  
            Console.WriteLine($"Então seu bosta, você se chama {nomeCompleto}!"); //agora aqui mostro o resultado na tela escrevendo, usando o $ que deixa a gente colocar a variavel que recebeu uma informação para a tela;
            //sempre utilizando CHAVES não PARENTESES! 

            Console.ReadKey();
        }
        
        static void Calculadora()//aqui é mais extenso, fiz uma calculadora basica com as 4 operações básicas da matemática, Soma , Subtração, Multiplicação e Divisão. se liga ae
        // | | | | | | | |
       // v v v v v v v v
        {
            while (true)// aqui é diferente do menu ali em cima, enquanto se manter TRUE ele fica aberto o menu da calculadora;
            {
                Console.WriteLine("++++++++++++++Bem - Vindo a Calculadora++++++++++++++");
                Console.WriteLine();
                Console.WriteLine("Escolha a operação");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                Console.WriteLine("Opção: ");//aqui estão criando o menu de opção da calculadora;
                int opcao = Convert.ToInt32(Console.ReadLine());//agora opcao é int, mas porque int? porque opcao vai receber o numero que o usuario digitar para selecionar a operação.
                
                if (opcao == 5)//aqui é interessante, se opcao receber o numero 5, significa que ele vai fechar a função; se liga em baixo. 
                {
                    Console.WriteLine("Obrigado por ter usado a minha calculdadora <3.");//escrita pro usuario entender que foi fechado;
                        break;//aqui o break como ja deve ter visto antes, ele basicamente "freia", ele não executa mais oque esta abaixo dele, então o código volta pra o menu que criei la em cima.
                }

                Console.WriteLine("Digite o primeiro número");//para ficar mais facil, peço os numeros primeiro, em vez de ficar pedindo varias vezes em todas asf funções que vier a seguir!
                double num1 = Convert.ToDouble(Console.ReadLine());// definindo variavel numero;

                Console.WriteLine("Digite o segundo número");//
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;//imagina que nem a calculadora, o resultado vai se manter vazio ou zero no caso, se nada for digitado, mas isso é meio inutil porque n coloquei para aparecer mas por tras, isso funciona.
                
                switch (opcao)//mais uma vez o switch e cases, aqui ele vai executar de acordo que o usuario escolher ali em cima.
                {
                    case 1:
                        result = num1 + num2;//soma
                        Console.WriteLine($"O resultado da sua soma é: {result}");//puxando resultado;
                        break;
                    case 2:
                        result = num1 - num2;//subtração.
                        Console.WriteLine($"O resultado da sua subtração é: {result}");
                        break;
                    case 3:
                        result = num1 * num2;//multiplicação, aqui no c# usamos o asterisco para fazer essa operação.
                        Console.WriteLine($"O resultado da sua multiplicação é: {result}");
                        break;
                    case 4:
                        if (num2 != 0)//chegando na divisão, temos que fazer a validação de que, é uma regra matemática que temos, NAO PODE DIVIDIR POR ZERO, é impossível. 
                            //o sinal de exclamção é para reforçar que, enquanto a operação for para dividir por zero, não vai prosseguir.
                        {
                            result = num1 / num2;//divisão
                            Console.WriteLine($"O resultado da sua divisão é: {result} ");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão com/por zero é impossível.");//caso for dividir por zero;
                        }
                        break;
                    default://default é literalmente padrão em portugues; aqui to fazendo outra validação, que se o usuario digitar nenhuma das opções corretas, tipo , digitar 9 , que n ta na função,
                        //ele roda essa menssagem padrão e NÃO PROSSEGUE. <3
                        Console.WriteLine("Opção inválida. Tente novamente digitando as opções possíveis");
                        break;
                }
                //fim da calculadora básica;


            }
        }

        static void Media() 
        {
            double n1;
            double n2;
            double n3;
            double n4;
            string aluno;

            Console.WriteLine("Eae, aluno, digite seu nome porfavor:");
            aluno = Console.ReadLine();

            Console.WriteLine("Digite sua primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua quarta nota");
            n4 = Convert.ToDouble(Console.ReadLine());

            double result = n1 + n2 + n3 + n4 * 4 / 10;

            if (result >= 7) 
            {
                Console.WriteLine($"Caro {aluno}, sua média foi {result}, você passou!");
            
            }
            else 
            {
                Console.WriteLine($"{aluno}, sua média foi {result}, você não passou");
            
            }

            //ps: vo me mata;

        }

        static void Hotel() 
        {

            double diaria;
            double taxa;
            string hospede;

            Console.WriteLine("Olá, digite seu nome");
            hospede = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de diárias do hóspede");
            diaria = Convert.ToDouble(Console.ReadLine());

            if (diaria < 15)
            {
                taxa = 20.00;
            }
            else if (diaria == 15)
            {
                taxa = 14.00;
            }
            else
            {
                taxa = 12.00;
            }

            double total = 300.00 * diaria + taxa;

            Console.WriteLine($"Hóspede: {hospede}");
            Console.WriteLine($"Total a pagar: {total}");
        
        }


    }
}
