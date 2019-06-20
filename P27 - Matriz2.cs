//Usando o namespace System
using System;

//Utilizando o namespace Matriz2
namespace Matriz2
{
    //Classe Matriz2
    class Matriz2
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite o valor das dimensões da matriz: ");

            //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
            int n = int.Parse(Console.ReadLine());            

            //Declarando e instanciando uma matriz do tipo int com dimensões de tamanho n, digitado anteriormente
            int[,] mat = new int[n, n];

            //Método repetitivo for externo para iterar pelas linhas da matriz mat
            for (int i = 0; i < n; i ++)
            {
                //Imprime a frase na tela com o valor da variável i somado com 1
                Console.Write("\nDigite a " + (i + 1) + "° linha de elementos da matriz: ");

                //Declarando e inicializando um vetor de string pelo usuário através do teclado e utilizando o método Split para recortar do vetor os espaços em branco
                string[] values = Console.ReadLine().Split(' ');

                //Método repetitivo for interno para iterar pelas colunas da matriz mat
                for (int j = 0; j < n; j ++)
                {
                    //Atribui à matriz mat na posição [i, j] o valor do vetor de string values na posição j
                    mat[i, j] = int.Parse(values[j]);

                }//Fim do método repetitivo for interno
            }//Fim do método repetitivo for externo

            //Imprime a frase na tela
            Console.Write("\nDiagonal principal: ");

            //Método repetitivo for para iterar pela matriz
            for (int i = 0; i < n; i ++)
            {
                //Imprime na tela o valor do elemento que se encontra na posição [i, i], ou seja, na diagonal principal da matriz mat
                Console.Write(mat[i, i] + " ");

            }//Fim do método repetitivo for

            //Salta uma linha
            Console.WriteLine();

            //Declarando e inicializando variável do tipo int com o valor 0
            int count = 0;

            //Método repetitivo for externo para iterar pelas linhas da matriz
            for (int i = 0; i < n; i ++)
            {
                //Método repetitivo for interno para iterar pelas colunas da matriz
                for (int j = 0; j < n; j ++)
                {
                    //Comando condicional if-else simples para verificar se o valor do elemento da matriz na posição [i, j] é menor que 0
                    if (mat[i, j] < 0)
                    {
                        //Se o comando acima for verdadeiro incrementa a variável count
                        count ++;

                    }//Fim do comando if do método condicional if-else simples

                }//Fim do método repetitivo for interno
            }//Fim do método repetitivo for externo

            //Imprime a frase na tela com o valor da variável count
            Console.WriteLine("Numeros negativos na matriz: " + count + "\n");

        }//Fim do método Main
    }//Fim da classe Matriz2
}//Fim do namespace Matriz2
