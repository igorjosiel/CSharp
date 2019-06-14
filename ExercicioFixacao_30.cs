//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao_30
namespace ExercicioFixacao_30
{
    //Classe ExercicioFixacao_30
    class ExercicioFixacao_30
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite o numero de linhas da matriz: ");

            //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário através do teclado
            int m = int.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.Write("Digite o numero de colunas da matriz: ");

            //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário através do teclado
            int n = int.Parse(Console.ReadLine());

            //Declarando e instanciando uma matriz do tipo int com os valores de linhas e colunas m e n
            int[,] matriz = new int[m, n];

            //Imprime a frase na tela
            Console.WriteLine("\n-----Preencha a Matriz-----");

            //Método repetitivo for externo para iterar pela matriz
            for (int i = 0; i < m; i ++)
            {
                //Método repetitivo for interno para iterar pela matriz
                for (int j = 0; j < n; j ++)
                {
                    //Imprime a frase na tela com os respectivos valores das variáveis i e j
                    Console.Write("Elemento [" + i + ", " + j + "]: ");

                    //Atribuindo um valor digitado pelo usuário via teclado à matriz na posição [i, j]
                    matriz[i, j] = int.Parse(Console.ReadLine());

                }//Fim do método repetitivo for interno
            }//Fim do método repetitivo for externo

            //Imprime a frase na tela
            Console.Write("\nDigite um elemento da matriz: ");

            //Declarando e inicializando variável do tipo int sendo digitado pelo usuário via teclado
            int num = int.Parse(Console.ReadLine());

            //Declarando variável do tipo int e inicializando-a com o valor 0
            int count = 0;

            //Método repetitivo for externo para iterar pela matriz com o método GetLength passando como argumento o valor 0, da primeira dimensão da matriz
            for (int i = 0; i < matriz.GetLength(0); i ++)
            {
                //Método repetitivo for interno para iterar pela matriz com o método GetLength passando como argumento o valor 1, da primeira dimensão da matriz
                for (int j = 0; j < matriz.GetLength(1); j ++)
                {
                    //Método condicional if-else simples. Verifica se o valor atribuído à variável num existe na matriz na posição [i, j]
                    if (matriz[i, j] == num)
                    {
                        //Incrementa a variável count
                        count++;

                        //Imprime a frase na tela com os respectivos valores das variáveis i e j
                        Console.WriteLine("\nPosicao: [" + i + ", " + j + "]");

                        //Comando condicional if-else simples. Verifica se o valor da variável j é maior que 0
                        if (j > 0)
                        {
                            //Imprime a frase na tela com o valor do elemento da matriz na posição [i, j - 1]
                            Console.WriteLine("Left: " + matriz[i, j - 1]);

                        }//Fim do comando condicional if-else simples

                        //Comando condicional if-else simples. Verifica se o valor da variável i é maior que 0
                        if (i > 0)
                        {
                            //Imprime a frase na tela com o valor do elemento da matriz na posição [i - 1, j]
                            Console.WriteLine("Up: " + matriz[i - 1, j]);

                        }//Fim do comando condicional if-else simples

                        //Comando condicional if-else simples. Verifica se o valor da variável j é menor que o valor da variável n - 1
                        if (j < n - 1)
                        {
                            //Imprime a frase na tela com o valor do elemento da matriz na posição [i, j + 1]
                            Console.WriteLine("Right: " + matriz[i, j + 1]);

                        }//Fim do comando condicional if-else simples

                        //Comando condicional if-else simples. Verifica se o valor da variável i é menor que o valor da variável n - 1
                        if (i < m - 1)
                        {
                            //Imprime a frase na tela com o valor do elemento da matriz na posição [i + 1, j]
                            Console.WriteLine("Down: " + matriz[i + 1, j]);

                        }//Fim do comando condicional if-else simples

                    }//Fim do comando condicional if-else simples

                }//Fim do método repetitivo for inetrno
            }//Fim do método repetitivo for externo

            //Método condicional if-else simples. Verifica se o valor da variável count é igual a 0
            if (count == 0)
            {
                //Imprime a frase na tela
                Console.WriteLine("\nValor nao encontrado na matriz!\n");

            }//Fim do método condicional if-else simples

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_30
}//Fim do namespace ExercicioFixacao_30
