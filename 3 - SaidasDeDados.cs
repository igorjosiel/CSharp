//Usando o namespace System
using System;
using System.Globalization;

//Utilizando o namespace SaidaDeDados
namespace SaidaDeDados
{
    //Classe 
    class SaidaDeDados
    {
        static void Main(string[] args)
        {
            //Declarações de variáveis com seus respectivos tipos sendo inicializadas
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //Imprimindo na tela com o comando Console.Write e Console.WriteLine respectivamente
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("\n");

            //Imprimindo os valores das variáveis
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine("\n");

            //Imprimindo o valor da variável saldo com delimitações de pontos decimais
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));

            //Imprimindo o valor da variável saldo com um ponto de separador da parte inteira da parte decimal
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("\n");

            //Imprimindo a string pelo método do Placeholders
            Console.WriteLine("{0} tem {1} anos de idade e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine("\n");

            //Imprimindo a string pelo método da interpolação
            Console.WriteLine($"{nome} tem {idade} anos de idade e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine("\n");

            //Imprimindo a string pelo método da concatenação
            Console.WriteLine(nome + " tem " + idade + " anos de idade e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            Console.WriteLine("\n");

        }//Fim do método Main
    }//Fim da classe SaidaDeDados
}//Fim do namespace SaidaDeDados
