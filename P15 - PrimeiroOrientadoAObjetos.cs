//Utilizando os namespace System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace PrimeiroOrientadoAObjetos
namespace PrimeiroOrientadoAObjetos
{
    //Classe PrimeiroOrientadoAObjetos
    class PrimeiroOrientadoAObjetos
    {
        //Método principal Main
        static void Main(String[] args)
        {
            //Declarando dois objetos do tipo Triangulo
            Triangulo x, y;

            //Instanciando os dois objetos com a palavra-chave new
            x = new Triangulo();
            y = new Triangulo();

            //Imprime a frase na tela
            Console.WriteLine("Entre com as medidas do triangulo X: ");

            //Atribuindo valores aos atributos do objeto x
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprime a frase na tela
            Console.WriteLine("\nEntre com as medidas do triangulo Y: ");

            //Atribuindo valores aos atributos do objeto y
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando variável areaX do tipo double para armazenar a area do objeto x
            double areaX = x.Area();

            //Declarando variável areaY do tipo double para armazenar a area do objeto y
            double areaY = y.Area();

            //Imprime as frases na tela com as respectivas formatações
            Console.WriteLine("\nArea de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("\nArea de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //Estrutura condicional if-else composto
            //Se o valor da variável areaX for maior que o valor da variável areaY executa o bloco de instruções abaixo
            if (areaX > areaY)
            {
                //Imprime a frase na tela
                Console.WriteLine("\nMaior area: X");

            }//Fim do comando if da estrutura condicional if-else composto

            //Senão, executa o bloco de intruções abaixo
            else
            {
                //Imprime a frase na tela
                Console.WriteLine("\nMaior area: Y");

            }//Fim do comando else da estrutura condicional if-else composto

        }//Fim do método Main
    }//Fim da classe PrimeiroOrientadoAObjetos
}//Fim do namespace PrimeiroOrientadoAObjetos
