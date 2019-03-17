//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao13
namespace ExercicioFixacao13
{
    //Classe ExercicioFixacao13
    class ExercicioFixacao13
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite sua senha: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, utilizando o método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
            int senha = int.Parse(Console.ReadLine());

            //Utilizando o método repetitivo while para testar a condição e repetir o bloco de instruções enquanto a condição for verdadeira.Quando não mais, termina o método
            while (senha != 2002)
            {
                //Imprime a frase na tela
                Console.WriteLine("Senha Invalida.");
                
                //Quebra de linha
                Console.Write("\n");

                //Imprime a frase na tela
                Console.Write("Digite a senha novamente: ");

                //Atribui um novo valor à variável senha, sendo digitado pelo usuário via teclado, através do método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
                senha = int.Parse(Console.ReadLine());

            }//Fim do método repetitivo while

            //Imprime a frase na tela
            Console.WriteLine("Acesso permitido!");
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao13
}//Fim do namespace ExercicioFixacao13
