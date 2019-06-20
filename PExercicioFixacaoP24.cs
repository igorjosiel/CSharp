//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace ExercicioFixacao_24
namespace ExercicioFixacao_24
{
    //Classe ExercicioFixacao_24
    class ExercicioFixacao_24
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando objeto do tipo Funcionario e instanciando-o com a palavra-chave new
            Funcionario f = new Funcionario();

            //Imprime as frases na tela
            Console.WriteLine("-----Preencha os dados do funcionario-----\n");
            Console.Write("Nome: ");

            //Atribui um valor ao atributo Nome do objeto f
            f.Nome = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Salario Bruto: ");

            //Atribui um valor ao atributo SalarioBruto do objeto f
            f.SalarioBruto = double.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.Write("Imposto: ");

            //Atribui um valor ao atributo Imposto do objeto f
            f.Imposto = double.Parse(Console.ReadLine());

            //Imprime a frase na tela com a concatenação do método ToString do objeto f
            Console.Write("\n" + f.ToString() + "\n");

            //Imprime a frase na tela
            Console.Write("\nDigite uma porcentagem de aumento no salario bruto do funcionario: ");

            //Declarando variável do tipo double e inicializando-a com um valor digitado pelo usuário
            double porcent = double.Parse(Console.ReadLine());

            //Acionando o método AumentarSalario do objeto f passando como parâmetro o valor da variável percent
            f.AumentarSalario(porcent);

            //Imprime a frase na tela com a concatenação do método ToString do objeto f
            Console.Write("\n" + f.ToString() + "\n");
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_24
}//Fim do namespace ExercicioFixacao_24
