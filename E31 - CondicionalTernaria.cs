//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace ExpressaoCondicionalTernaria
namespace ExpressaoCondicionalTernaria
{
    //Classe CondicionalTernaria
    class CondicionalTernaria
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um valor: ");

            //Declarando variável do tipo double e inicializando-a com um valor digitado pelo usuário via teclado
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando variável do tipo double e atribuindo-a um valor conforme for o resultado da expressão condicional ternária abaixo. (Condição) ? valor_se_verdadeiro : valor_se_falso
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            //Imprime a frase na tela e o valor da variável desconto
            Console.WriteLine("O valor do desconto e: " + desconto + "\n");

        }//Fim do método Main
    }//Fim da classe CondicionalTernaria
}//Fim do namespace ExpressaoCondicionalTernaria
