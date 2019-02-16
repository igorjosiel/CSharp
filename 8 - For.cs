//Importa todas as classes da biblioteca System
using System;

//Mecanismo de visibilidade para controlar todos os nomes no programa
namespace While
{
    //Classe For
    class For
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Comando de repetição for com a declaração da variável i e sua inicialização; condição de continuação do loop de repetição; incrementação da variável de controle do loop
            for (int i = 0; i < 10; i++)
            {
                //Imprime a frase com o valor da variável controladora i
                Console.WriteLine("O valor de <i> e {0}", i);

            }//Fim do comando for

            //Mantém a aplicação aberta
            Console.ReadLine();

        }//Fim do método Main
    }//Fim da classe While
}//Fim de namespace