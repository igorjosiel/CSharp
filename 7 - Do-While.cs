//Importa todas as classes da biblioteca System
using System;

//Mecanismo de visibilidade para controlar todos os nomes no programa
namespace While
{
    //Classe DoWhile
    class DoWhile
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Variável k do tipo int sendo inicializada com o valor 0
            int k = 0;

            //Comando de repetição Do-while para imprimir na tela a frase com o valor da variável k até que a condição de próxima iteração seja falsa, nesse caso, quando k for igual a 100
            do
            {
                //Imprime a frase na tela com o valor de k enquanto o loop de iteração for verdadeiro
                Console.WriteLine("O valor de k e`{0}", k);

                //Incrementa 10 à variável k
                k = k + 10;

            } while (k < 100);//Fim do comando Do-while

            //Mantém a aplicação aberta
            Console.ReadLine();

        }//Fim do método Main
    }//Fim da classe While
}//Fim de namespace
