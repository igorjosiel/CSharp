//Importa todas as classes da biblioteca System
using System;

//Mecanismo de visibilidade para controlar todos os nomes no programa
namespace Foreach
{
    //Classe Foreach
    class Foreach
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Tabela ou vetor ou array elementos sendo inicializado com 4 valores do tipo int
            int[] elementos = {10, 34, 17, 19};

            //Comando foreach para fazer a atribuição de todos os valores em elementos na variável i em cada iteração
            foreach (int i in elementos)
            {
                //Imprime a frase com o valor da variável i
                Console.WriteLine("{0}", i);

            }//Fim do comando foreach

            //Mantém a aplicação aberta
            Console.ReadLine();

        }//Fim do método Main
    }//Fim da classe Foreach
}//Fim de namespace
