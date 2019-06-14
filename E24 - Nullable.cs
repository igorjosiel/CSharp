//Usando o namespace System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace Nullable
namespace Nullable
{
    //Classe Nullable
    class Nullable
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Variáveis do tipo double sendo declaradas como Nullable (opcionais) com o caracter ? e sendo inicializadas
            double? x = null;
            double? y = 10.0;

            //Imprime na tela os respectivos resultados dos métodos GetValueOrDefault através das variáveis x e y, que imprime o valor da variável, ou se a mesma for nula o valor padrão do tipo da variável
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Salta uma linha
            Console.Write("\n");

            //Imprime na tela os respectivos resultados dos atributos HasValue através das variáveis x e y, que informa se nas variáveis existe um valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Salta uma linha
            Console.Write("\n");

            //Método condicional if-else composto
            //Se a variável x possuir um valor, executa o bloco de instruções abaixo
            if (x.HasValue)
            {
                //Imprime a frase na tela com o resultado da chamada ao atributo Value da variável x com a devida formatação
                Console.WriteLine("x is " + x.Value.ToString("F1", CultureInfo.InvariantCulture));

            }//Fim do comando if do método if-else composto

            //Senão, executa o bloco de instruções abaixo
            else
            {
                //Imprime a frase na tela
                Console.WriteLine("x is nullable");

            }//Fim do comando else do método if-else composto

            //Método condicional if-else composto
            //Se a variável y possuir um valor, executa o bloco de instruções abaixo
            if (y.HasValue)
            {
                //Imprime a frase na tela com o resultado da chamada ao atributo Value da variável y com a devida formatação
                Console.WriteLine("y is " + y.Value.ToString("F1", CultureInfo.InvariantCulture));

            }//Fim do comando if do método if-else composto

            //Senão, executa o bloco de instruções abaixo
            else
            {
                //Imprime a frase na tela
                Console.WriteLine("y is nullable");

            }//Fim do comando else do método if-else composto

            //Salta uma linha
            Console.Write("\n");

            //Declarando variáveis do tipo double Nullable e sendo inicializadas
            double? z = null;
            double? s = 2.0;

            //Declarando variáveis do tipo double e atribuindo valores às mesmas com o operador Coalescência nula, que atribui o valor da variável, caso possuir, ou o valor que se encontra à direita do operador ??
            double a = z ?? 5;
            double b = s ?? 5;

            //Imprime na tela os valores das variáveis a e b com as devidas formatações
            Console.WriteLine(a.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(b.ToString("F1", CultureInfo.InvariantCulture));

            //Salta uma linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe Nullable
}//Fim do namespace Nullable
