//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao_26
namespace ExercicioFixacao_26
{
    //Classe ExercicioFixacao_26
    class ExercicioFixacao_26
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Qual e a cotacao do dolar? ");

            //Declarando variável do tipo double e inicializando-a com valor digitado pelo usuário com a formatação devida
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprime a frase na tela
            Console.Write("Quantos dolares voce vai comprar? ");

            //Declarando variável do tipo double e inicializando-a com valor digitado pelo usuário com a formatação devida
            double compraDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprime a frase na tela com a formatação devida e invocando o método PagarDolar da classe ConversorDeMoeda
            Console.WriteLine("\nValor a ser pago em reais: " + ConversorDeMoeda.PagarDolar(cotacaoDolar, compraDolares).ToString("F2", CultureInfo.InvariantCulture) + ".\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_26
}//Fim do namespace ExercicioFixacao_26
