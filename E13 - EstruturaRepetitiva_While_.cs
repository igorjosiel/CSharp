//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace EstruturaRepetitiva_While_
namespace EstruturaRepetitiva_While_
{
    //Classe EstruturaRepetitiva_While_
    class EstruturaRepetitiva_While_
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um numero: ");

            //Declarando variável do tipo double e inicializando-a com um valor digitado pelo usuário via teclado pelo método double.Parse(Console.ReadLine()) para converter a string em um valor double
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Estrutura repetitiva while para testar a condição e repetir o bloco enquanto a condição for verdadeira, quando não mais, termina o bloco
            while (x > 0.0)
            {
                //Declarando variável do tipo double e inicializando-a com o valor da chamada ao método Math.Sqrt(x)
                double raiz = Math.Sqrt(x);

                //Imprime o valor da variável raiz utilizando o método ToString("F3", CultureInfo.InvariantCulture) para fixar 3 casas decimais depois do ponto separador da parte inteira da parte decimal, e fixar o ponto separador
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("\n");

                //Imprime a frase na tela
                Console.Write("Digite um novo numero: ");

                //Atribui um novo valor à variável x, sendo digitado um valor pelo usuário via teclado, utilizando o método double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) para fixar o ponto separador da parte inteira da parte decimal e converter a string para um valor do tipo double
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }//Fim do método repetitivo while

            //Imprime a frase na tela
            Console.WriteLine("Numero negativo!");
            Console.WriteLine("\n");

        }//Fim do método Main
    }//Fim da classe EstruturaRepetitiva_While_
}//Fim do namespace EstruturaRepetitiva_While_
