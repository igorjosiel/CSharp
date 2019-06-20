//Usando o namespace System
using System;

//Utilizando o namespace Matriz1
namespace Matriz1
{
    //Classe Matriz1
    class Matriz1
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e instanciando uma matriz do tipo double com dimensões de 2 linhas e 3 colunas
            double[,] mat = new double[2, 3];

            //Imprime a frase na tela e o valor do método Length da matriz mat, que especifica o tamanho da mesma
            Console.WriteLine("A matriz possui " + mat.Length + " elementos");

            //Imprime a frase na tela e o valor do método Rank da matriz mat, que especifica o tamanho da primeira dimensão da mesma, ou seja, quantas linhas a matriz possui
            Console.WriteLine("A primeira dimensão da matriz e de tamanho " + mat.Rank);

            //Imprime a frase na tela e o valor do método GetLength da matriz mat, passando como argumento o valor 0, que especifica o tamanho da segunda dimensão (1) da matriz mat
            Console.WriteLine(mat.GetLength(1));

        }//Fim do método Main
    }//Fim da classe Matriz1
}//Fim do namespace Matriz1
