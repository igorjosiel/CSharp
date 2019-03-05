//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao5
namespace ExercicioFixacao5
{
    //Classe ExercicioFixacao5
    class ExercicioFixacao5
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite o nome do funcionario: ");

            //Declarando variável do tipo string e inicializando-a com um valor digitado pelo usuário via teclado
            string nomeFuncionario = Console.ReadLine();

            //Imprime a frase na tela
            Console.WriteLine("Numero de horas trabalhadas por dia: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado, usando o método int.Parse para converter a string em inteiro
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.WriteLine("Valor que recebe por hora: ");

            //Declarando variável do tipo double e inicializando-a com um valor digitado pelo usuário via teclado, usando o método double.Parse para converter a string em double, utilizando o método CultureInfo.InvariantCulture para fixar o ponto separador da parte inteira da parte decimal
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando variável do tipo double para armazenar o valor do produto de horasTrabalhadas, valorPorHora e 30 dias que um mês possui, formando assim o seu salario
            double salario = horasTrabalhadas * valorPorHora * 30;

            //Imprime a frase na tela com os respectivos valores das variáveis utilizando o método de impressão Concatenação e utilizando o método ToString para fixar 2 casas decimais depois do ponto e o método CultureInfo.InvariantCulture para fixar o ponto separador da parte inteira da parte decimal
            Console.WriteLine("\nO funcionario " + nomeFuncionario + " trabalha " + horasTrabalhadas + " horas por dia e recebe U$ " + valorPorHora + " por hora trabalhada, recebendo um salario de U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao5
}//Fim do namespace ExercicioFixacao5
