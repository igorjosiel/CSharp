//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao14
namespace ExercicioFixacao14
{
    //Classe ExercicioFixacao14
    class ExercicioFixacao14
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite as coordenadas de um ponto (x, y): ");

            //Declarando variáveis do tipo double e inicializando-as com valores digitados pelo usuário via teclado, utilizando o método double.Parse(Console.ReadLine()) para converter as strings em um valor do tipo double
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Usando o método repetitivo while para testar a condição e repetir o bloco de intruções enquanto a condição for verdadeira. Quando não mais, termina o método
            while (x != 0.0 && y != 0.0)
            {
                //Utilizando o método condicional if-else encadeado para testar as condições. Se a condição if a seguir for verdadeira, executa o bloco de instruçôes, senão, pula para a próxima condição
                if (x > 0.0 && y > 0.0)
                {
                    //Imprime a frase na tela
                    Console.WriteLine("Primeiro quadrante");

                }//Fim do comando if do método if-else encadeado

                //Se a condição if anterior foi falsa, testa a condição else if a seguir. Se for verdadeira, executa o bloco de instruções, senão, pula para a próxima condição
                else if (x < 0.0 && y > 0.0)
                {
                    //Imprime a frase na tela
                    Console.WriteLine("Segundo quadrante");

                }//Fim do comando else if do método if-else encadeado

                //Se a condição else if anterior foi falsa, testa a condição else if a seguir. Se for verdadeira, executa o bloco de instruções, senão, pula para a próxima condição
                else if (x < 0.0 && y < 0.0)
                {
                    //Imprime a frase na tela
                    Console.WriteLine("Terceiro quadrante");

                }//Fim do comando else if do método if-else encadeado

                //Se a condição else if anterior foi falsa, executa o bloco de instruções do comando else a seguir
                else
                {
                    //Imprime a frase na tela
                    Console.WriteLine("Quarto quadrante");

                }//Fim do comando else do método if-else encadeado

                //Imprime a frase na tela
                Console.Write("\n");
                Console.WriteLine("Digite uma nova coordenada: ");

                //Atribui valores às variáveis x e y com valores digitados pelo usuário via teclado, usando o método double.Parse(Console.ReadLine()) para converter as strings em valores do tipo double
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());

            }//Fim do método repetitivo while

            //Salta uma linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao14
}//Fim do namespace ExercicioFixacao14
