//Usando o namespace System
using System;

//Utilizando o namespace Funcoes
namespace Funcoes
{
    //Classe Funcoes
    class Funcoes
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite tres numeros: ");

            //Declarando variáveis do tipo int e inicializando-as com valores digitados pelo usuário via teclado, utilizando o método int.Parse(Console.ReadLine()) para converter as strings para o tipo int
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            //Declarando variável do tipo int e inicializando-a com o valor da chamada à função Maior que utiliza como parâmetros 3 valores para executar a função
            int resultado = Maior(num1, num2, num3);

            //Imprime a frase na tela com o valor da variável resultado utilizando o modelo de impressão Concatenação
            Console.WriteLine("Maior = " + resultado + ".\n");

        }//Fim do método Main

        //Método ou Função Maior que utiliza como argumentos três variáveis que recebem os valores dos parâmetros do método Maior da função Main
        static int Maior (int a, int b, int c)
        {
            //Declarando variável do tipo int
            int maior;

            //Utilizando o método condicional if-else encadeado para testar as condições. Se a condição no comando if for verdadeira, executa o bloco de intruções e termina o método, senão, pula para a próxima condição
            if (a > b && a > c)
            {
                //Variável maior é inicializada com o valor a
                maior = a;

            }//Fim do comando if do método if-else encadeado

            //Se a condição if anterior foi falsa, testa a condição else if a seguir, se for verdadeira, executa o bloco de intruções, senão, pula para a próxima condição
            else if (b > c)
            {
                //Variável maior é inicializada com o valor b
                maior = b;

            }//Fim do comando else if do método if-else encadeado

            //Se a condição do else if anterior foi falsa, executa o bloco de intruções a seguir
            else
            {
                //Variável maior é inicializada com o valor c
                maior = c;

            }//Fim do comando else do método if-else encadeado

            //Retorna o valor da variável maior para o método ou função que fez a chamada
            return maior;

        }//Fim da função Maior
    }//Fim da classe Funcoes
}//Fim do namespace Funcoes
