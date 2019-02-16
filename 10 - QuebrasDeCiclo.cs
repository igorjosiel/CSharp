//Importa todas as classes da biblioteca System
using System;

//Mecanismo de visibilidade para controlar os nomes no programa
namespace QuebrasDeCiclo
{
    //Classe QuebrasDeLinha
    class QuebrasDeLinha
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Comando de repetição for
            for (int i = 0; i <= 20; i++)
            {
                //Comando if para testar se o valor na variável i é divisível por dois, caso seja, pula a iteração para a próxima
                if (i % 2 == 0)
                {
                    //Comando continue utilizado para pular para a próxima iteração do ciclo de repetição for
                    continue;

                }//Fim do comando if

                //Comando if para testar se o valor na variável i é divisível por 10, caso seja, aborta o ciclo de repetição for
                if (i % 15 == 0)
                {
                    //Imprime a frase
                    Console.WriteLine("Fim do programa ...");

                    //Comando break utilizado para abortar o ciclo de repetição for
                    break;

                }//Fim do comando if

                //Imprime a frase com o valor da variável i
                Console.WriteLine("O valor da variável <i> e {0}", i);

            }//Fim do comando de repetição for

            //Mantém a aplicação aberta
            Console.ReadLine();

        }//Fim método Main
    }//Fim da classe QuebrasDeLinha
}//Fim de namespace
