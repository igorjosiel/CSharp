//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao20
namespace ExercicioFixacao20
{
    //Classe ExercicioFixacao20
    class ExercicioFixacao20
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um numero: ");

            //Declarando variável do tipo int e inicializando-a com valor digitado pelo usuário via teclado através do método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
            int n = int.Parse(Console.ReadLine());

            //Quebra de linha
            Console.Write("\n");

            //Imprimindo a frase
            Console.WriteLine("Imprimindo os numeros das respectivas linhas, seus quadrados e seus cubos, respectivamente.");

            //Qubra de linha
            Console.Write("\n");

            //Utilizando o método repetitivo for para repetir o bloco de instruções enquanto a condição for verdadeira. Quando não mais, termina o método
            for (int i = 1; i <= n; i ++)
            {
                //Imprimindo os espaços em branco com os respectivos valores da variável i, i ao quadrado e i ao cubo, respectivamente
                Console.WriteLine(i + " " + (i * i) + " " + (i * i * i));

            }//Fim do método repetitivo for

            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao20
}//Fim do namespace ExercicioFixacao20
