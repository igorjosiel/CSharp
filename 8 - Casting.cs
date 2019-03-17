//Usando o namespace System
using System;

//Utilizando o namespace Casting
namespace Casting
{
    //Classe Casting
    class Casting
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando variável do tipo float e inicializando-a com o valor 4.5
            float val1 = 4.5f;

            //Declarando variável do tipo double e inicializando-a com o valor da variável val1 que é float
            double val2 = val1;

            //Imprimindo o valor da variável val2 na tela
            Console.WriteLine(val2);

            //Declarando variável do tipo double e inicializando-a com o valor 5.1
            double a = 5.1;

            //Declarando variável do tipo float e inicializando-a com o valor da variável a que é double utilizando uma conversão explícita para float, chamada casting
            float b = (float) a;

            //Imprimindo o valor da variável a na tela
            Console.WriteLine(a);

            //Declarando a variável num1 e inicilaizando-a com o valor 5.1
            double num1 = 5.1;

            //Declarando a variável num2 e inicilaizando-a com o valor de num1 que é double utilizando a conversão explícita chamada casting
            int num2 = (int) num1;

            //Imprimindo o valor da variável num2 na tela
            Console.WriteLine(num2);

            //Declarando a variável primeiro do tipo int e inicilaizando-a com o valor 5
            int primeiro = 5;

            //Declarando a variável segundo do tipo int e inicializando-a com o valor 2
            int segundo = 2;

            //Declarando a variável resultado do tipo double que armazena o valor da divisão das variáveis primeiro por segundo convertendo o valor da variável primeiro que é do tipo int para um valor double
            double resultado = (double) primeiro / segundo;

            //Imprimindo o valor da variável resultado na tela
            Console.WriteLine(resultado);
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe Casting
}//Fim do namespace Casting
