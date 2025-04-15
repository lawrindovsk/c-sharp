using System;

namespace Exceptions
{
    public class Erro
    {
        public static void Process()
        {
            var arr = new int[3];

            try
            {
                //for (var index = 0; index < 10; index++)
                // {
                //System.IndexOutOfRangeException.
                //  Console.WriteLine(arr[index]);
                //ele sai da casas definidas, o array tem definido por 3, mas eu to tentendo interar pra 10,
                //nao faz sentido!

                //}
                Salvar(""); // Passando um argumento vazio para o método Salvar
            }
            catch (IndexOutOfRangeException ex)//tratativa #1
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não foi encontrado o índice na lista");
            }
            catch (Exception ex)//tratativa #2
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);//mostro o erro pra mim, assim fica melhor pra identificacao.
                Console.WriteLine("Sua tentativa deu erro, tente novamente!");
            }
        }

        static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new Exception("O texto não pode ser nulo ou vazio, escreva algo!");

            }
        }
    }
}
