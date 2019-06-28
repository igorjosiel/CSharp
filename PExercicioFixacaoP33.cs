//Usando os namespaces System, System.Collections.Generic, ExercicioFixacao_33.Entities e System.Globalization
using System;
using System.Collections.Generic;
using ExercicioFixacao_33.Entities;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao_33
namespace ExercicioFixacao_33
{
    //Classe ExercicioFixacao_33
    class ExercicioFixacao_33
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Enter the number of employees: ");

            //Declarando e inicializando variável do tipo int com um valor digitado palo usuário via teclado
            int n = int.Parse(Console.ReadLine());

            //Salta uma linha
            Console.WriteLine();

            //Declarando e instanciando uma lista do tipo Employee com a palavra-chave new
            List <Employee> list = new List <Employee>();

            //Método repetitivo for para repetir várias vezes enquanto o valor da variável i for menor ou igual ao valor da variável n
            for (int i = 1; i <= n; i ++)
            {
                //Imprime as frases na tela com o valor da variável i utilizando-se o método de impressão de interpolação
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("\nOutsourced (y/n)? ");

                //Declarando e inicializando variável do tipo char com um valor digitado pelo usuário via teclado
                char ch = char.Parse(Console.ReadLine());

                //Imprime a frase na tela
                Console.Write("Name: ");

                //Declarando e inicializando variável do tipo string com um valor digitado pelo usuário via teclado
                string name = Console.ReadLine();

                //Imprime a frase na tela
                Console.Write("Hours: ");

                //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
                int hours = int.Parse(Console.ReadLine());

                //Imprime a frase na tela
                Console.Write("Value per hour: ");

                //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado, com a devida formatação para dígito dos decimais
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Método condicional if-else composto para testar se o valor da variável ch é igual a y ou a n
                if (ch == 'y')
                {
                    //Imprime a frase na tela
                    Console.Write("Additional charge: ");

                    //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado com a devida formatação para dígito dos decimais
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Acionando o método Add da lista list para adicionar a nova instância do objeto do tipo OutsourcedEmployee passando como argumento para o construtor os valores das variáveis name, hours, valuePerHour e additionalCharge
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));

                }//Fim do comando if do método condicional if-else composto

                //Comando else do método condicional if-else composto
                else
                {
                    //Acionando o método Add da lista list para adicionar a nova instância do objeto do tipo Employee passando como argumento para o construtor os valores das variáveis name, hours e valuePerHour
                    list.Add(new Employee(name, hours, valuePerHour));

                }//Fim do comando else do método condicional if-else composto

                //Salta uma linha
                Console.WriteLine();

            }//Fim do método repetitivo for

            //Imprime a frase na tela
            Console.WriteLine("-----PAYMENTS-----");

            //Método repetitivo foreach para iterar pela lista para acessar atributo e método de todos os elementos da mesma
            foreach (Employee emp in list)
            {
                //Imprime a frase na tela com os valores do atributo Name e do método Payment, com a devida formatação de casas decimais, de todos os elementos da lista
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));

            }//Fim do método repetitivo foreach

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_33
}//Fim do namespace ExercicioFixacao_33
