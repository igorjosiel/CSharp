//Usando o namespace System
using System;

//Utilizando o namespace EstruturaCondicional_if_else
namespace EstruturaCondicional_if_else_
{
    //Classe EstruturaCondicional_if_else
    class EstruturaCondicional_if_else_
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando variável do tipo int e inicializando-a com o valor 10
            int x = 10;

            //Usando estrutura condicional if-else simples para verificar a condição, se for verdade executa o bloco de instruções
            if (x > 5)
            {
                //Imprime a frase na tela com o valor da variável x usando o método de impressão Concatenação
                Console.WriteLine(x + " e maior que 5");
                
                //Quebra de linha
                Console.Write("\n");

            }//Fim do método if-else simples

            //Imprime a frase na tela
            Console.WriteLine("Entre com um numero inteiro: ");

            //Declarando a variável do tipo int e inicializando-a com valor digitado pelo usuário via teclado com o método int.Parse(Console.ReadLine()) para converter a string em um valor int
            int numero = int.Parse(Console.ReadLine());

            //Usando estrutura condicional if-else composta para verificar a condição, se for verdade executa o primeiro bloco de instruções, senão, executa o segundo
            if (numero % 2 == 0)
            {
                //Imprime a frase na tela
                Console.WriteLine("Par!");
                
                //Quebra de linha
                Console.Write("\n");

            }//Fim do comando if do método if-else composto

            //Se a condição entre parênteses for falsa executa o bloco de instruções a seguir
            else
            {
                //Imprime a frase na tela
                Console.WriteLine("Impar!");
                
                //Quebra de linha
                Console.Write("\n");

            }//Fim do comando else do método if-else composto

            //Imprime a frase na tela
            Console.WriteLine("Qual a hora atual? ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, usando o método int.Parse(Console.ReadLine()) para converter a string em um valor int
            int hora = int.Parse(Console.ReadLine());

            //Usando estrutura condicional if-else encadeada para testar as condições
            //Se a condição for verdadeira executa o bloco de intruções e termina o método if-else, senão, pula para a próxima condição
            if (hora < 12)
            {
                //Imprime a frase na tela
                Console.WriteLine("Bom dia!");
                
                //Quebra de linha
                Console.Write("\n");

            }//Fim do comando if do método if-else encadeado

            //Se a condição for verdadeira executa o bloco de intruções a seguir e termina o método, senão, pula para a próxima condição
            else if (hora >= 12 && hora < 18)
            {
                //Imprime a frase na tela
                Console.WriteLine("Boa tarde!");
                
                //Quebra de linha
                Console.Write("\n");

            }//Fim do comando else-if do método if-else encadeado

            //Se nenhuma das condições anteriores foi verdadeira, executa o bloco de intruções do comando else
            else
            {
                //Imprime a frase na tela
                Console.WriteLine("Boa noite!");
                
                //Quebra de linha
                Console.Write("\n");

            }//Fim do comando else do método if-else encadeado

        }//Fim do método Main
    }//Fim da classe OperadoresLogicos
}//Fim do namespace OperadoresLogicos
