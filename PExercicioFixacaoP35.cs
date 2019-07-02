//Usando os namespaces System, System.Collections.Generic, System.Globalization e ExercicioFixacao_35.Entities
using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioFixacao_35.Entities;

//Utilizando o namespace ExercicioFixacao_35
namespace ExercicioFixacao_35
{
    //Classe ExercicioFixacao_35
    class ExercicioFixacao_35
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e instanciando uma lista taxpayers do tipo Taxpayer com a palavra-chave new
            List<Taxpayer> taxpayers = new List<Taxpayer>();

            //Imprime a frase na tela
            Console.Write("Enter the number of tax payers: ");

            //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
            int n = int.Parse(Console.ReadLine());

            //Método repetitivo for para repetir tantas vezes até que o valor da variável i, declarada no mesmo, seja menor ou igual ao valor da variável n
            for (int i = 1; i <= n; i ++)
            {
                //Imprime as frases na tela com o valor da variável i pelo método de impressão de interpolação
                Console.WriteLine($"\nTax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");

                //Declarando e inicializando variável do tipo char com um valor digitado pelo usuário via teclado
                char ch = char.Parse(Console.ReadLine());

                //Imprime a palavra na tela
                Console.Write("Name: ");

                //Declarando e inicializando variável do tipo string com um valor digitado pelo usuário via teclado
                string name = Console.ReadLine();

                //Imprime a frase na tela
                Console.Write("Annual income: ");

                //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Método condicional if-else composto. Verifica se o valor da variável ch do tipo char é igual ao caracter i. Se sim, executa o bloco de instruções abaixo
                if (ch == 'i')
                {
                    //Imprime a frase na tela
                    Console.Write("Health expenditures: ");

                    //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Acionando o método Add da lista taxpayers para adicionar uma nova instância de um objeto do tipo PhysicalPerson, passando como argumento para o método construtor os valores das variáveis inicializadas acima
                    taxpayers.Add(new PhysicalPerson(healthExpenditures, name, annualIncome));

                }//Fim do comando if do método condicional if-else composto

                //Senão, executa o bloco de intruções abaixo
                else
                {
                    //Imprime a frase na tela
                    Console.Write("Number of employees: ");

                    //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    //Acionando o método Add da lista taxpayers para adicionar uma nova instância de um objeto do tipo LegalPerson, passando como argumento para o método construtor os valores das variáveis inicializadas acima
                    taxpayers.Add(new LegalPerson(numberOfEmployees, name, annualIncome));

                }//Fim do comando else do método condicional if-else composto
            }//Fim do método repetitivo for

            //Salta uma linha e imprime a frase na tela
            Console.WriteLine();
            Console.WriteLine("-----TAXES PAID-----");

            //Método repetitivo foreach para iterar pela lista taxpayers de elementos do tipo Taxpayer
            foreach (Taxpayer tax in taxpayers)
            {
                //Para cada iteração do método, imprime na tela o resultado do método ToString de cada elemento
                Console.WriteLine(tax.ToString());

            }//Fim do método repetitivo foreach

            //Salta uma linha
            Console.WriteLine();

            //Declarando e inicializando variável do tipo double com o valor 0.0
            double totalTaxes = 0.0;

            //Método repetitivo foreach para iterar pela lista taxpayers de elementos do tipo Taxpayer
            foreach (Taxpayer tax in taxpayers)
            {
                //Para cada iteração do método, incrementa à variável totalTaxes o resultado do método TaxCalculation de cada elemento da lista taxpayers
                totalTaxes += tax.TaxCalculation();

            }//Fim do método repetitivo foreach

            //Imprime na tela a frase abaixo concatenada com o valor da variável totalTaxes, com suas devidas formatações de casas decimais, e ponto separador das casas
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_35
}//Fim do namespace ExercicioFixacao_35
