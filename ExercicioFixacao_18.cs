//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao18
namespace ExercicioFixacao18
{
    //Classe ExercicioFixacao18
    class ExercicioFixacao18
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando variável do tipo int e inicializando-a com o valor 1
            int fatorial = 1;

            //Imprime a frase na tela
            Console.Write("Digite um numero: ");

            //Declarando variável do tipo int e inicializando-a com o valor digitado pelo usuário via teclado através do método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
            int numero = int.Parse(Console.ReadLine());

            //Quebra de linha
            Console.Write("\n");

            //Usando o método repetitivo for para repetir o bloco de instruções enquanto a condição for verdadeira. Se a condição for verdadeira, executa o bloco de instruções. Quando não mais, termina o método
            //Declarando variável do tipo int e inicializando-a com o valor da variável numero; condição de i ser maior que 0; e decrementação da variável i
            for (int i = numero; i > 0; i --)
            {
                //Atribui o valor da variável i multiplicado ao valor da variável fatorial usando o operador de atribuição *=
                fatorial *= i;

            }//Fim do método repetitivo for

            //Imprime a frase na tela com os respectivos valores das variáveis numero e fatorial usando o método de impressão Concatenação
            Console.WriteLine("O fatorial de " + numero + " e: " + fatorial);

            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao18
}//Fim do namespace ExercicioFixacao18
