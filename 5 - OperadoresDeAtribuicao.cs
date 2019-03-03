//Usando o namespace System
using System;

//Utilizandoo o namespace OperadorDeAtribuicao
namespace OperadoresDeAtribuicao
{
    //Classe OperadorDeAtribuicao
    class OperadorDeAtribuicao
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando variável int e inicializando-a
            int a = 10;

            //Imprime o valor da variável a na tela
            Console.WriteLine(a);

            //Operador de atribuição que incrementa 2 no valor da variável a
            a += 2;

            //Imprime o novo valor da variável a na tela
            Console.WriteLine(a);

            //Operador de atribuição que multiplica o valor da variável a por 3
            a *= 3;

            //Imprime o novo valor da variável a na tela
            Console.WriteLine(a);

            //Declarando variável do tipo string e inicializando-a com ABC
            string s = "ABC";

            //Imprime o valor da variável s na tela
            Console.WriteLine(s);

            //Operador de atribuição que adiciona os caracteres DEF na variável s
            s += "DEF";

            //Imprime o novo valor da variável s
            Console.WriteLine(s);

            //Declarando variável do tipo int e inicializando-a com o valor 10
            int b = 10;

            //Operador de atribuição que incrementa 1 ao valor da variável b
            b++;

            //Imprime o novo valor da variável b na tela
            Console.WriteLine(b);
            
            //Operador de atribuição que decrementa 1 ao valor da variável b
            b--;

            //Imprime o novo valor da variável b na tela
            Console.WriteLine(b);

            //Declarando variável do tipo int e inicializando-a com o valor 10
            int val1 = 10;

            //Declarando variável do tipo int e incializando-a com o valor da variável val1. Apenas depois que ela incrementa 1 ao valor da variável val1
            int val2 = val1++;

            //Imprime a frase na tela com os valores das variáveis val1 e val2 utilizando o método de impressão Placeholders
            Console.WriteLine("Valor de val1 e {0} e o valor de val2 e {1}", val1, val2);

            //Declarando variável do tipo int e inicializando-a com o avlor 10
            int num1 = 10;

            //Declarando variável do tipo int e incializando-a com o valor da variável num1 incrementado com 1
            int num2 = ++num1;

            //Imprime a frase na tela com os valores das variáveis num1 e num2 utilizando o método de impressão Placeholders
            Console.WriteLine("Valor de num1 e {0} e o valor de num2 e {1}", num1, num2);

        }//Fim do método Main
    }//Fim da classe OperadorDeAtribuicao
}//Fim do namespace OperadorDeAtribuicao
