//Usando o namespace ExercicioFixacao_35.Entities
namespace ExercicioFixacao_35.Entities
{
    //Classe LegalPerson herdando ou extendendo da classe Taxpayer com o operador (:)
    class LegalPerson : Taxpayer
    {
        //Atributo da classe dos tipo int com suas propriedades get e set
        public int NumberOfEmployees;

        //Método construtor sem entrada de argumentos
        public LegalPerson ()
        {
        }//Fim do método construtor sem entrada de argumentos

        //Método construtor com entrada de argumentos dos tipos int, string e double, reutilizando o código fonte do construtor da superclasse Taxpayer com a palavra-chave base
        public LegalPerson (int numberOfEmployees, string name, double annualIncome) : base (name, annualIncome)
        {
            //Atribuindo ao atributo da classe com a palavra-chave this o valor passado como argumento para o parâmetro do método
            this.NumberOfEmployees = numberOfEmployees;

        }//Fim do método construtor com entrada de argumentos

        //Método do tipo double sendo sobrescrito ou sobreposto com a palavra-chave override
        public override double TaxCalculation()
        {
            //Método condicional if-else composto. Verifica se o valor do atributo NumberOfEmployees é maior ao valor 10. Se for executa o bloco de instruções abaixo. Senão, pula para o próximo teste
            if (NumberOfEmployees > 10)
            {
                //Retorna ao método chamador o valor da expressão abaixo
                return AnnualIncome * 0.14;

            }//Fim do comando if do método condicional if-else composto

            //Senão, executa o bloco de instruções abaixo
            else
            {
                //Retorna ao método chamador o valor da expressão abaixo
                return AnnualIncome * 0.16;

            }//Fim do comando else do método condicional if-else composto

        }//Fim do método TaxCalculation

    }//Fim da classe LegalPerson
}//Fim do namespace ExercicioFixacao_35.Entities
