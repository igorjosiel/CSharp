//Utilizando os namespace System e System.Globalization
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
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("-----Digite os dados do primeiro funcionario-----\n");
            Console.Write("Nome: ");

            f1.nome = Console.ReadLine();

            Console.Write("Salario: ");

            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("\n-----Digite os dados do segundo funcionario-----\n");
            Console.Write("Nome: ");

            f2.nome = Console.ReadLine();

            Console.Write("Salario: ");

            f2.salario = double.Parse(Console.ReadLine());

            double mediaSalario = (f1.salario + f2.salario) / 2.00;

            Console.WriteLine("\nA media dos salarios dos funcionarios e: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture) + ".\n");
        }
    }
}
