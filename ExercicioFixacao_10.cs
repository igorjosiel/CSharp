//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao10
namespace ExercicioFixacao10
{
    //Classe ExercicioFixacao10
    class ExercicioFixacao10
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite o codigo do produto que queira comprar: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, utilizando o método int.Parse(Console.ReadLine()) para converter a string em um valor int
            int codigo = int.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.WriteLine("Quantos desse produto deseja comprar? ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, utilizando o método int.Parse(Console.ReadLine()) para converter a string em um valor int
            int quantProdutos = int.Parse(Console.ReadLine());

            //Declarando variável do tipo double
            double valorPagar;

            //Método condicional if-else encadeado para testar a condição, se a condição no comando if for verdadeira, executa o bloco de intruções e termina o método, senão, pula para o próximo teste
            if (codigo == 1)
            {
                //Imprime a frase na tela
                Console.WriteLine("\nCachorro-Quente: R$ 4.00");

                //Inicializa a variável valorPagar com o produto do valor da quantidade de produtos pelo preço do produto, usando um casting para isso, para converter explicitamente a variável para o tipo double
                valorPagar = quantProdutos * (double) 4.00;

            }//Fim do comando if do método if-else encadeado

            //Se a condição anterior foi falsa, testa a condição no else if seguinte. Se a condição for verdadeira, executa o bloco de intruções, senão, pula para o próximo teste
            else if (codigo == 2)
            {
                //Imprime a frase na tela
                Console.WriteLine("\nX-Salada: R$ 4.50");

                //Inicializa a variável valorPagar com o produto do valor da quantidade de produtos pelo preço do produto, usando um casting para isso, para converter explicitamente a variável para o tipo double
                valorPagar = quantProdutos * (double) 4.50;

            }//Fim do comando else if do método if-else encadeado

            //Se a condição anterior foi falsa, testa a condição no else if seguinte. Se a condição for verdadeira, executa o bloco de intruções, senão, pula para o próximo teste
            else if (codigo == 3)
            {
                //Imprime a frase na tela
                Console.WriteLine("\nX-Bacon: R$ 5.00");

                //Inicializa a variável valorPagar com o produto do valor da quantidade de produtos pelo preço do produto, usando um casting para isso, para converter explicitamente a variável para o tipo double
                valorPagar = quantProdutos * (double) 5.00;

            }//Fim do comando else if do método if-else encadeado

            //Se a condição anterior foi falsa, testa a condição no else if seguinte. Se a condição for verdadeira, executa o bloco de intruções, senão, pula para o próximo teste
            else if (codigo == 4)
            {
                //Imprime a frase na tela
                Console.WriteLine("\nTorrada simples: R$ 2.00");

                //Inicializa a variável valorPagar com o produto do valor da quantidade de produtos pelo preço do produto, usando um casting para isso, para converter explicitamente a variável para o tipo double
                valorPagar = quantProdutos * (double) 2.00;

            }//Fim do comando else if do método if-else encadeado

            //Se a condição anterior foi falsa, executa o bloco de intruções do comando else
            else
            {
                //Imprime a frase na tela
                Console.WriteLine("\nRefrigerante: R$ 1.00");

                //Inicializa a variável valorPagar com o produto do valor da quantidade de produtos pelo preço do produto, usando um casting para isso, para converter explicitamente a variável para o tipo double
                valorPagar = quantProdutos * (double) 1.00;

            }//Fim do comando else do método if-else encadeado

            //Imprime a frase na tela com o valor da variável valorPagar, utilizando para isso o método ToString("F2", CultureInfo.InvariantCulture) para fixar o ponto separador da parte inteira da parte decimal e fixar 2 casas decimais depois do ponto
            Console.WriteLine("\nValor a pagar: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao10
}//Fim do namespace ExercicioFixacao10
