//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao7
namespace ExercicioFixacao7
{
    //Classe ExercicioFixacao7
    class ExercicioFixacao7
    {
        //Método principal Main
        static void Main(string[] args)
        { 
            //Imprime a frase na tela
            Console.WriteLine("Digite um numero inteiro: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, através do comando int.Parse(Console.ReadLine()) que converte a string em um valor int
            int numero = int.Parse(Console.ReadLine());

            //Utilizando o método if-else composto para testar a condição, se verdadeira, executa o bloco de intruções a seguir
            if (numero < 0)
            {
                //Imprime a frase na tela
                Console.WriteLine("Numero negativo!");
                Console.WriteLine("\n");

            }//Fim do comando if do método if-else composto

            //Se a condição anterior foi falsa executa o bloco de intruções a seguir
            else
            {
                //Imprime a frase na tela
                Console.WriteLine("Numero positivo!");
                Console.WriteLine();

            }//Fim do comando else do método if-else composto

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao7
}//Fim do namespace ExercicioFixacao7
