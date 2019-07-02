//Usando o namespace ExercicioFixacao_35.Entities
namespace ExercicioFixacao_35.Entities
{
    //Classe PhysicalPerson herdando ou extendendo da classe Taxpayer com o operador (:)
    class PhysicalPerson : Taxpayer
    {
        //Atributo da classe dos tipo double com suas propriedades get e set
        public double HealthSpending { get; set; }

        //Método construtor sem entrada de argumentos
        public PhysicalPerson ()
        {
        }//Fim do método construtor sem entrada de argumentos

        //Método construtor com entrada de argumentos dos tipos string e double, reutilizando o código fonte do construtor da superclasse Taxpayer com a palavra-chave base
        public PhysicalPerson (double healthSpending, string name, double annualIncome) : base (name, annualIncome)
        {
            //Atribuindo ao atributo da classe com a palavra-chave this o valor passado como argumento para o parâmetro do método
            this.HealthSpending = healthSpending;

        }//Fim do método construtor com entrada de argumentos

        //Método do tipo double sendo sobrescrito ou sobreposto com a palavra-chave override
        public override double TaxCalculation()
        {
            //Método condicional if-else composto. Verifica se o valor do atributo AnnualIncome é menor ou igual ao valor 20000.00. Se for executa o bloco de instruções abaixo. Senão, pula para o próximo teste 
            if (AnnualIncome <= 20000.00)
            {
                //Retorna ao método chamador o valor da expressão abaixo
                return (AnnualIncome * 0.15) - (HealthSpending * 0.50);

            }//Fim do comando if do método condicional if-else composto

            //Senão, executa o bloco de instruções abaixo
            else
            {
                //Retorna ao método chamador o valor da expressão abaixo
                return (AnnualIncome * 0.25) - (HealthSpending * 0.50);

            }//Fim do comando else do método condicional if-else composto

        }//Fim do método TaxCalculation

    }//Fim da classe PhysicalPerson
}//Fim do namespace ExercicioFixacao_35.Entities
