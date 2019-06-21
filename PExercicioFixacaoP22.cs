//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace ExercicioFixacao_22
namespace ExercicioFixacao_22
{
    //Classe ExercicioFixacao_22
    class ExercicioFixacao_22
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando dois objetos do tipo Funcionario
            Funcionario f1, f2;

            //Instanciando os dois objetos do tipo Funcionario com a palavra-chave new
            f1 = new Funcionario();
            f2 = new Funcionario();

            //Imprime as frases na tela
            Console.WriteLine("-----Digite os dados do primeiro funcionario-----\n");
            Console.Write("Nome: ");

            //Inicializando o atributo nome do objeto f1 pelo usuário através do teclado
            f1.nome = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Salario: ");

            //Inicializando o atributo salario do objeto f1 pelo usuário através do teclado
            f1.salario = double.Parse(Console.ReadLine());

            //Imprime as frases na tela
            Console.WriteLine("\n-----Digite os dados do segundo funcionario-----\n");
            Console.Write("Nome: ");

            //Inicializando o atributo nome do objeto f2 pelo usuário através do teclado
            f2.nome = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Salario: ");

            //Inicializando o atributo salario do objeto f2 pelo usuário através do teclado
            f2.salario = double.Parse(Console.ReadLine());

            //Declarando e inicializando variável do tipo double com a soma dos resultados dos atributos salario dos objetos f1 e f2 e dividido por 2.00
            double mediaSalario = (f1.salario + f2.salario) / 2.00;

            //Imprime a frase na tela com o valor da variável mediaSalario com as devidas formatações através do método ToString
            Console.WriteLine("\nA media dos salarios dos funcionarios e: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture) + ".\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_22
}//Fim do namespace ExercicioFixacao_22
