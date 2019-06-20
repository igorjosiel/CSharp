//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao15
namespace ExercicioFixacao15
{
    //Classe ExercicioFixacao15
    class ExercicioFixacao15
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um numero: ");

            //Declarando variável do tipo int e inicializando-a com valor digitado pelo usuário via teclado através do método int.Parse(Console.ReadLine() para converter a string em um valor do tipo int
            int x = int.Parse(Console.ReadLine());

            //Quebra de linha
            Console.Write("\n");

            //Imprime a frase na tela com o valor da variável x utilizando o método de impressão Concatenação
            Console.WriteLine("Imprime todos os numeros impares de 0 até " + x + ": ");

            //Usando o método repetitivo for para repetir o bloco de comandos enquanto a condição for verdadeira. Quando for falsa termina o método
            //Declarando variável do tipo int e inicializando-a com o valor 0; repete o bloco de instruções enquanto a condição i menor ou igual a x for verdadeira; incrementa a variável i para prosseguir com as iterações
            for (int i = 0; i <= x; i++)
            {
                //Utilizando o método condicional if-else simples para testar a condição. Se a condição for verdadeira, executa o bloco de instruções.
                if (i % 2 != 0)
                {
                    //Imprime o valor da variável i na tela
                    Console.WriteLine(i);

                }//Fim do comando if do método if-else simples
            }//Fim do método repetitivo for

            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao15
}//Fim do namespace ExercicioFixacao15
