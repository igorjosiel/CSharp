//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace ExercicioFixacao6
namespace ExercicioFixacao6
{
    //Classe ExercicioFixacao6
    class ExercicioFixacao6
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Codigo da peca 1: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, com o método int.Parse para converter a string em int
            int codigo1 = int.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.WriteLine("Numero de pecas 1: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, com o método int.Parse para converter a string em int
            int numPecas1 = int.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.WriteLine("Valor unitario de cada peca 1: ");

            //Declarando variável do tipo double e inicializando-a com um valor digitado pelo usuário via teclado, com o método double.Parse para converter a string em double
            double precoUnitario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprime a frase na tela
            Console.WriteLine("\nCodigo da peca 2: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, com o método int.Parse para converter a string em int
            int codigo2 = int.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.WriteLine("Numero de pecas 2: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, com o método int.Parse para converter a string em int
            int numPecas2 = int.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.WriteLine("Valor unitario de cada peca 2: ");

            //Declarando variável do tipo double e inicializando-a com um valor digitado pelo usuário via teclado, com o método double.Parse para converter a string em double
            double precoUnitario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando variável do tipo double e inicializando-a com o produto do número de peças 1 e a quantidade e o número de peças 2 e a quantidade
            double valorSerPago = numPecas1 * precoUnitario1 + numPecas2 * precoUnitario2;

            //Imprime a frase na tela com o valor da variável valorSerPago com a formatação do ponto separador da parte inteira da parte decimal e duas casas decimais depois do ponto com os métodos ToString() e CultureInfo.InvariantCulture
            Console.WriteLine("\nO valor a ser pago pelas pecas e: " + valorSerPago.ToString("F2", CultureInfo.InvariantCulture));
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao6
}//Fim do namespace ExercicioFixacao6
