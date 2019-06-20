//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao19
namespace ExercicioFixacao19
{
    //Classe ExercicioFixacao19
    class ExercicioFixacao19
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um numero: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado através do método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
            int n = int.Parse(Console.ReadLine());

            //Quebra de linha
            Console.Write("\n");

            //Imprime a frase na tela com o valor da variável n usando o método de impressão Concatenação
            Console.WriteLine("Os numeros divisiveis por " + n + " sao: ");

            //Usando o método repetitivo for para repetir o bloco de instruções enquanto a condição for verdadeira. Quando não mais, termina o método
            for (int i = 1; i <= n; i ++)
            {
                //Utilizando o método condicional if-else simples para testar a condição. Se a condição for verdadeira, executa o bloco de instruções. Senão, prossegue com a próxima iteração
                if (n % i == 0)
                {
                    //Imprime o valor da variável i
                    Console.WriteLine(i);

                }//Fim do comando if do método condicional if-else simples
            }//Fim do método repetitivo for

            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao19
}//Fim do namespace ExercicioFixacao19
