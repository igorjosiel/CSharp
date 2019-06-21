//Usando os namespaces System, Composicao.Entities.Enums, Composicao.Entities e System.Globalization
using System;
using Composicao.Entities.Enums;
using Composicao.Entities;
using System.Globalization;

//Utilizando o namespace Composicao
namespace Composicao
{
    //Classe Composicao
    class Composicao
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Enter departament's name: ");

            //Declarando e inicializando variável do tipo string com um valor digitado pelo usuário via teclado
            string deptName = Console.ReadLine();

            //Imprime as frases na tela
            Console.Write("\nEnter worker data: ");
            Console.Write("\nName: ");

            //Declarando e inicializando variável do tipo string com um valor digitado pelo usuário via teclado
            string name = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Level (Junior/ MidLevel/ Senior): ");

            //Declarando e inicializando variável do tipo WorkerLevel com o resultado da conversão do valor digitado pelo usuário via teclado do tipo string para WorkerLevel (enumeração)
            //Método TryParse para converter. <Entre os caracteres de menor e maior o tipo de enumeração para a qual se quer converter>
            //Argumentos: (A representação de cadeia de caracteres do nome de enumeração ou do valor subjacente a ser convertido/ true para ignorar as maiúsculas e minúsculas, false considerar as maiúsculas e minúsculas/ contém um objeto do tipo TEnum cujo valor é representado por value caso a operação de análise seja bem-sucedida)
            Enum.TryParse<WorkerLevel>(Console.ReadLine(), false, out WorkerLevel level);

            //Imprime a frase na tela
            Console.Write("Base salary: ");

            //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado, com sua devida formatação de ponto decimal com o método CultureInfo.InvariantCulture
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando um objeto do tipo Departament com a palavra-chave new passando como argumento para o parâmetro do construtor o valor da variável deptName
            Departament dept = new Departament(deptName);

            //Instanciando um objeto do tipo Worker com a palavra-chave new passando como argumento para o parâmetro do construtor os valores das variáveis name, level, salaryBase e dept
            Worker worker = new Worker(name, level, baseSalary, dept);

            //Imprime a frase na tela
            Console.Write("\nHow many contracts to this worker: ");

            //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
            int n = int.Parse(Console.ReadLine());

            //Método repetitivo for para iterar n vezes (valor armazenado na variável n). Declarando e inicializando variável do tipo int com o valor 1 para ser a variável contadora do laço repetitivo e incrementando-a a cada iteração
            for (int i = 1; i <= n; i ++)
            {
                //Imprime a frase na tela com o valor da variável i através do método de impressão interpolação, com o caracter de cifrão antes da string
                Console.WriteLine($"\nEnter #{i} contract data: ");

                //Imprime a frase na tela
                Console.Write("Date (DD/MM/YYYY): ");

                //Declarando e inicializando variável do tipo DateTime com um valor digitado pelo usuário via teclado
                DateTime date = DateTime.Parse(Console.ReadLine());

                //Imprime a frase na tela
                Console.Write("Value per hour: ");

                //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado com sua devida formatação de ponto decimal
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Imprime a frase na tela
                Console.Write("Duration (hours): ");

                //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
                int hours = int.Parse(Console.ReadLine());

                //Instanciando um objeto do tipo HourContract com a palavra-chave new passando como argumento para o parâmetro do construtor os valores das variáveis date, valuePerHour e hours
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //Acionando o método AddContract do objeto worker passando como argumento o objeto recém-criado contract
                worker.AddContract(contract);

            }//Fim do método repetitivo for

            //Salta uma linha
            Console.WriteLine();

            //Imprime a frase na tela
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            //Declarando e inicializando variável do tipo string com um valor digitado pelo usuário via teclado
            string monthAndYear = Console.ReadLine();

            //Declarando e inicializando variável do tipo int com um valor recortado da variável monthAndYear através do método Substring passando como argumento os valores: 0 e 2 (recorta da posição 0 à 2)
            int month = int.Parse(monthAndYear.Substring(0, 2));

            //Declarando e inicializando variável do tipo int com um valor recortado da variável monthAndYear através do método Substring passando como argumento o valor 3 (recorta da posição 3 em diante)
            int year = int.Parse(monthAndYear.Substring(3));

            //Imprime as frases na tela com os valores dos atributos Name e Departament - Name - do objeto worker
            Console.Write("\n\nName: " + worker.Name);
            Console.Write("\nDepartament: " + worker.Departament.Name);

            //Imprime a frase na tela com os valores das variáveis monthAndYear e a chamada ao método Income do objeto worker passando como argumento os valores das variáveis month e year com suas devidas formatações de ponto decimal
            Console.Write("\nIncome for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture) + "\n\n");

        }//Fim do método Main
    }//Fim da classe Composicao
}//Fim do namespace Composicao
