//Usando o namespace ExercicioFixacao_33.Entities
namespace ExercicioFixacao_33.Entities
{
    //Classe OutsourcedEmployee herdando ou extendendo da classe Employee
    class OutsourcedEmployee : Employee
    {
        //Atributo da classe do tipo double com suas propriedades get e set
        public double AdditionalCharge { get; set; }

        //Método construtor padrão sem entrada de argumentos
        public OutsourcedEmployee ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Método construtor com entrada de argumentos dos tipos string, int e double e utilizando a palavra-chave base para reaproveitar o código-fonte do método construtor implementado na superclasse Employee
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            //Atribuindo ao atributo AdditionCharge com a palavra-chave this o valor passado como argumento para o parâmetro do método
            this.AdditionalCharge = additionalCharge;

        }//Fim do método construtor com entrada de argumentos dos tipos string, int e double

        //Método sendo sobrescrito com a palavra-chave override
        public override double Payment()
        {
            //Retorna ao método chamador o valor da expressão contida no método Payment original somado com o valor da expressão 1.1 multiplicado pelo valor do atributo da classe AdditionCharge
            return base.Payment() + 1.1 * AdditionalCharge;

        }//Fim do método sobrescrito Payment
        
    }//Fim da classe OutsourcedEmployee
}//Fim do namespace ExercicioFixacao_33.Entities
