//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao16
namespace ExercicioFixacao16
{
    //Classe ExercicioFixacao16
    class ExercicioFixacao16
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um numero: ");

            //Declarando variável do tipo int e inicializando-a com valor digitado pelo usuário via teclado através do método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
            int n = int.Parse(Console.ReadLine());

            //Quebra de linha
            Console.Write("\n");

            //Declarando variáveis do tipo int e inicializando-as com o valor 0
            int contDentro = 0;
            int contFora = 0;

            //Método repetitivo for para repetir o bloco de intruções enquanto a condição for verdadeira. Quando a condição for falsa termina o método
            //Declarando variável do tipo int e inicializando-a com o valor 0; condição enquanto i for menor que o valor da variável n; e a incrementação à variável i para prosseguir com as iterações 
            for (int i = 0; i < n; i ++)
            {
                //Imprime a frase na tela com o valor da variável i acressentada com 1 unidade utilizando o método de impressão Concatenação
                Console.Write("Digite o " + (i + 1) + "° numero: ");

                //Declarando variável do tipo int e sendo inicializada com o valor digitado pelo usuário através do método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
                int num = int.Parse(Console.ReadLine());
                
                //Método condicional if-else composto para testar a condição. Se a condição for verdadeira, executa o bloco de instruções do comando if. Senão, excuta o bloco de instruções do comando else.
                if (num >= 10 && num <= 20)
                {
                    //É incrementada 1 unidade à variável contDentro
                    contDentro ++;

                }//Fim do comando if do método condicional if-else composto

                else
                {
                    //É incrementada 1 unidade à variável contFora
                    contFora ++;

                }//Fim do comando else do método condicional if-else composto
            }//Fim do método repetitivo for

            //Quebra de linha
            Console.Write("\n");

            //Imprime as frases na tela com os respectivos valores das variáveis contDentro e ContFora usando o método de impressão Concatenação
            Console.WriteLine(contDentro + " in");
            Console.WriteLine(contFora + " out");

            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao16
}//Fim do namespace ExercicioFixacao16
