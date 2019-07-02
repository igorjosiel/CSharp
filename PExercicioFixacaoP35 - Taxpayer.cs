//Usando o namespace System.Globalization
using System.Globalization;

//Usando o namespace ExercicioFixacao_35.Entities
namespace ExercicioFixacao_35.Entities
{
    //Classe Taxpayer abstrata com a palavra-chave abstract. Significa que não pode ser instanciada
    abstract class Taxpayer
    {
        //Atributos da classe dos tipos string e double com suas propriedades get e set
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        //Método construtor sem entrada de argumentos
        public Taxpayer ()
        {
        }//Fim do método construtor sem entrada de argumentos

        //Método construtor com entrada de argumentos dos tipos string e double
        public Taxpayer (string name, double annualIncome)
        {
            //Atribuindo aos atributos da classe com a palavra-chave this os valores passados como argumentos para os parâmetros do método
            this.Name = name;
            this.AnnualIncome = annualIncome;

        }//Fim do método construtor com entrada de argumentos

        //Método do tipo double abstrato com a palavra-chave abstract. Significa que o método não precisa ser implementado na classe, apenas nas suas subclasses
        public abstract double TaxCalculation();

        //Método do tipo string sendo sobrescrito ou sobreposto com a palavra-chave override
        public override string ToString()
        {
            //Retorna ao método chamador a string contendo os valores do atributo Name e método TaxCalculation com sua devida formatação de ponto e casas decimais com a concatenação das seguintes frases
            return "Name: " + Name + " - $ Tax calculation: " + TaxCalculation().ToString("F2", CultureInfo.InvariantCulture);

        }//Fim do método sobrescrito ToString

    }//Fim da classe Taxpayer
}//Fim do namespace ExercicioFixacao_35.Entities
