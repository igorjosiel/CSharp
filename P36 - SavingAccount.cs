//Usando o namespace Heranca.Entities
namespace Heranca.Entities
{
    //Classe SavingAccount herdando os atributos e métodos da classe Account com o operador (:)
    //Palavra-chave sealed significa que a classe SavingAccount não poderá ser herdada
    sealed class SavingAccount : Account
    {
        //Atributo da classe do tipo double com suas propriedades get e set
        public double InterestRate { get; set; }

        //Declarando método construtor padrão sem entrada de argumentos
        public SavingAccount ()
        {
        }//Fim do método construtor padrão

        //Declarando método construtor com entrada de argumentos dos tipos int, string e double. Fazendo reuso de código-fonte do construtor da classe Account com o operador (:) e a palavra-chave base
        public SavingAccount (int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            //Atribuindo ao atributo da classe com a palavra-chave this o valor passado como argumento para o parâmetro do método construtor
            this.InterestRate = interestRate;

        }//Fim do método construtor com entrada de argumentos

        //Sobrescrevendo o método do tipo void Withdraw com entrada de argumento do tipo double
        //Palavra-chave sealed significa que o método sobrescrito do tipo void Withdraw não poderá ser novamente sobrescrito em subclasses da classe SavingAccount
        public sealed override void Withdraw(double amount)
        {
            //Com a palavra-chave base é possível reaproveitar o código-fonte do método implementado na superclasse
            base.Withdraw(amount);

            //Atributo da classe Balance é subtraído com o valor 2.0
            Balance -= 2.0;

        }//Fim do método sobrescrito Withdraw

        //Método do tipo void sem entrada de argumento
        public void UpdateBalance ()
        {
            //Atributo da classe Balance é acrescentado conforme  o valor do atributo InterestRate
            Balance += Balance * InterestRate;

        }//Fim do método UpdateBalance

    }//Fim da classe SavingAccount
}//Fim do namespace Heranca.Entities
