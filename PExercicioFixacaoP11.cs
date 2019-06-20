//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando a namespace ExercicioFixacao11
namespace ExercicioFixacao11
{
    //Classe ExercicioFixacao11
    class ExercicioFixacao11
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite um numero: ");

            //Declarando variável do tipo double e inicializando-a com um valor digitado pelo usuário via teclado através do método double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) para converter a string em um valor double e fixar um ponto separador da parte inteira da decimal no número
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Usando o método if-else encadeado para testar as condições. Se a condição do comando if for verdadeira, executa o bloco de instruções e termina o método, senão, pula para o próximo teste
            if (numero >= 0 && numero <= 25)
            {
                //Imprime a frase na tela com o valor da variável numero e utilizando o método ToString(CultureInfo.InvariantCulture) para fixar o ponto separador da parte inteira da parte decimal do número
                Console.WriteLine("\nO numero " + numero.ToString(CultureInfo.InvariantCulture) + " se encontra no intervalo [0, 25].\n");

            }//Fim do comando if do método if-else encadeado

            //Se a condição anterior foi falsa, testa a condição do comando else if a seguir. Se for verdadeira executa o bloco de instruções e termina o método, senão, pula para o próximo teste
            else if (numero > 25 && numero <= 50)
            {
                //Imprime a frase na tela com o valor da variável numero e utilizando o método ToString(CultureInfo.InvariantCulture) para fixar o ponto separador da parte inteira da parte decimal do número
                Console.WriteLine("\nO numero " + numero.ToString(CultureInfo.InvariantCulture) + " se encontra no intervalo [25, 50].\n");

            }//Fim do comando else if do método if-else encadeado

            //Se a condição anterior foi falsa, testa a condição do comando else if a seguir. Se for verdadeira executa o bloco de instruções e termina o método, senão, pula para o próximo teste
            else if (numero > 50 && numero <= 75)
            {
                //Imprime a frase na tela com o valor da variável numero e utilizando o método ToString(CultureInfo.InvariantCulture) para fixar o ponto separador da parte inteira da parte decimal do número
                Console.WriteLine("\nO numero " + numero.ToString(CultureInfo.InvariantCulture) + " se encontra no intervalo [50, 75].\n");

            }//Fim do comando else if do método if-else encadeado

            //Se a condição anterior foi falsa, testa a condição do comando else if a seguir. Se for verdadeira executa o bloco de instruções e termina o método, senão, pula para o próximo teste
            else if (numero > 75 && numero <= 100)
            {
                //Imprime a frase na tela com o valor da variável numero e utilizando o método ToString(CultureInfo.InvariantCulture) para fixar o ponto separador da parte inteira da parte decimal do número
                Console.WriteLine("\nO numero " + numero.ToString(CultureInfo.InvariantCulture) + " se encontra no intervalo [75, 100].\n");

            }//Fim do comando else if do método if-else encadeado

            //Se a condição anterior foi falsa, executa o bloco de instruções do comando else
            else
            {
                //Imprime a frase na tela com o valor da variável numero e utilizando o método ToString(CultureInfo.InvariantCulture) para fixar o ponto separador da parte inteira da parte decimal do número
                Console.WriteLine("\nO numero " + numero.ToString(CultureInfo.InvariantCulture) + " se encontra fora dos intervalos.\n");

            }//Fim do comando else do método if-else encadeado

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao11
}//Fim do namespace ExercicioFixacao11
