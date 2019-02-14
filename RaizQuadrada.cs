
/*Programa que calcula as raízes quadradas dos números entre 10 e 100, em intervalos de 10*/

//Importa todas as classes da biblioteca System
using System;

//Mecanismo de controle da visibilidade de nomes dentro de um programa
namespace RaizQuadrada
{
    //Classe Programa
    class RaizQuadrada
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Variável int numero para armazenar os números de 10 a 100
            int numero = 10;

            //Comando de repetição while para fazer iterações e passar para o próximo número
            while (numero <= 100)
            {
                //Calcula o valor da raíz quadrada e envia-a para a tela
                //Variável double raiz para armazenar os valores das raízes dos números utilizando a classe Math da biblioteca System e seu método Sqrt que é passado como parâmetro o argumento numero para calcular a raíz quadrada do mesmo
                double raiz = Math.Sqrt(numero);

                //Chamando a classe Console da biblioteca System utilizando seu método WriteLine() para imprimir na tela a frase com o valor da variável numero e a raíz desse núemro
                Console.WriteLine("A raiz de {0} e {1}", numero, raiz);

                //Incrementa para o próximo número, somando 10
                numero = numero + 10;

            }//Fim do laço de repetição while

            //Chamando a classe Console da biblioteca System e utilizando seu método ReadLine() para manter a aplicação aberta
            Console.ReadLine();

        }//Fim do método Main
    }//Fim da classe Programa
}//Fim de namespace
