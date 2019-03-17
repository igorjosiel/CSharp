//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao3
namespace ExercicioFixacao3
{
    //Classe ExercicioFixacao3
    class ExercicioFixacao3
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando constante do tipo double e inicializando-a com o valor 3.14159
            const double PI = 3.14159;

            //Imprime a frase na tela
            Console.WriteLine("Digite o raio do circulo: ");

            //Declarando variável do tipo double e inicializando-a com o valor digitado pelo usuário via teclado através do comando double.Parse(Console.ReadLine()) que é convertido de string para double e usando o método CultureInfo.InvariantInfo para fixar o ponto separador da parte inteira da parte decimal
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando variável do tipo double para armazenar o valor da multiplicação da constante PI pelo valor do raio ao quadrado utilizando o método Math.Pow(base, expoente)
            double area = PI * Math.Pow(raio, 2);

            //Imprime a frase na tela com o valor da variável area usando o método de impressão Placeholders e usando o comando ToString para fixar 4 casas decimais depois do ponto
            Console.WriteLine("\nO valor da area do circulo e: {0}", area.ToString("F4", CultureInfo.InvariantCulture));
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao3
}//Fim de namespace ExercicioFixacao3
