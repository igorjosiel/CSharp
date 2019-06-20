//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao17
namespace ExercicioFixacao17
{
    //Classe ExercicioFixacao17
    class ExercicioFixacao17
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um numero de pares que deseja digitar: ");

            //Declarando variável do tipo int e inicializando-a com valor digitado pelo usuário através do método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
            int n = int.Parse(Console.ReadLine());

            //Quebra de linha
            Console.Write("\n");

            //Usando o método repetitivo for para repetir o bloco de instruções enquanto a condição for verdadeira. Quando a condição for falsa termina o método
            //Declarando variável do tipo int e inicializando-a com valor 0; condição de i ser menor que o valor da variável n; incrementando a variável i para prosseguir com a próxima iteração
            for (int i = 0; i < n; i ++)
            {
                //Imprime a frase na tela com o valor da variável i acressentado com uma unidade usando o método de impressão Concatenaçaõ
                Console.Write("Digite o primeiro numero do " + (i + 1) + "° par: ");

                //Declarando variável do tipo int e inicializando-a com valor digitado pelo usuário através do método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
                int numerador = int.Parse(Console.ReadLine());

                //Imprime a frase na tela com o valor da variável i acressentado com uma unidade usando o método de impressão Concatenação
                Console.Write("Digite o segundo numero do " + (i + 1) + "° par: ");

                //Declarando variável do tipo int e inicializando-a com valor digitado pelo usuário através do método int.Parse(Console.ReadLine()) para converter a string em um valor do tipo int
                int denominador = int.Parse(Console.ReadLine());

                //Usando o método condicional if-else composto para testar a condição. Se a condição no comando if for verdadeira, executa o bloco de intruções. Se for falsa, executa o bloco de intruções do comando else 
                if (denominador != 0)
                {
                    //Declarando variável do tipo double que vai receber o valor da divisão do numerador pelo denominador aplicando os castings nos mesmos para converter os valores int em valores double
                    double div = (double)numerador / (double)denominador;

                    //Imprime a frase na tela com o valor da variável div usando o método de impressão Concatenação
                    Console.WriteLine("Divisao = " + div);

                    //Quebra de linha
                    Console.Write("\n");

                }//Fim do comando if do método condicional if-else composto

                else
                {
                    //Imprime a frase na tela
                    Console.WriteLine("Divisao impossivel de acontecer!");

                    //Quebra de linha
                    Console.Write("\n");

                }//Fim do comando else do método condicional if-else composto
            }//Fim do método repetitivo for

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao17
}//Fim do namespace ExercicioFixacao17
