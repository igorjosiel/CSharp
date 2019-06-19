//Utilizando o namespace System
using System;

//Usando o namespace EstruturaRepetitiva_For_
namespace EstruturaRepetitiva_For_
{
    //Classe EstruturaRepetitiva_For_
    class EstruturaRepetitiva_For_
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Quantos numeros inteiros voce vai digitar? ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado através do método int.Parse(Console.ReadLine()
            int n = int.Parse(Console.ReadLine());

            //Declarando variável do tipo int e inicializando-a com o valor 0
            int soma = 0;

            //Quebra de linha
            Console.Write("\n");

            //Usando método de repetição for para repetir o bloco de comandos enquanto a condição for verdadeira. Quando for falsa termina o laço
            //Declarando variável do tipo int e inicializando-a com o valor 1; verifica a condição que é: enquanto a variável i for menor ou igual ao valor da variável n; e por fim a incrementação da variável i para continuar as iterações
            for (int i = 1; i <= n; i ++)
            {
                //Imprime a frase 
                Console.Write("Valor #{0}: ", i);

                //Declarando variável do tipo int e inicializando-a com valor digitado pelo usuário via teclado através do método int.Parse(Console.ReadLine()
                int valor = int.Parse(Console.ReadLine());

                //Adiciona o valor da variável valor à variável soma
                soma += valor;

                //Quebra de linha
                Console.Write("\n");

            }//Fim do método de repetição for

            //Imprime a frase com o valor da variável soma usando o método de impressão Placeholders
            Console.WriteLine("Soma = {0}\n", soma);

        }//Fim do método Main
    }//Fim da classe EstruturaRepetitiva_For_
}//Fim do namespace EstruturaRepetitiva_For_
