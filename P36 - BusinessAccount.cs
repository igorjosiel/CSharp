//Utilizando o namespace Heranca.Entities
namespace Heranca.Entities
{
    //Classe BusinessAccount herdando os atributos e métodos da classe Account com o operador (:)
    class BusinessAccount : Account
    {
        //Atributo da classe do tipo double com suas propriedades get e set
        public double LoanLimit { get; set; }

        //Declarando método construtor padrão sem entrada de argumentos
        public BusinessAccount ()
        {
        }//Fim do método construtor padrão

        //Declarando método construtor com entrada de argumentos dos tipos int, string e double. Fazendo reuso de código-fonte do construtor da classe Account com o operador (:) e a palavra-chave base
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base (number, holder, balance)
        {
            //Atribuindo ao atributo da classe com a palavra-chave this o valor passado como argumento para o parâmetro do método construtor
            this.LoanLimit = loanLimit;

        }//Fim do método construtor com entrada de argumentos

        //Método do tipo void com entrada de argumento do tipo double
        public void Loan (double amount)
        {
            //Método condicional if-else simples para testar se o valor passado como argumento para o parâmetro do método é menor ou igual ao valor do atributo LoanLimit. Se for, executa o bloco de instruções abaixo. Senão, termina o método
            if (amount <= LoanLimit)
            {
                //Atributo da classe Balance é acrescentado com o valor da variável passada como argumento para o parâmetro do método
                Balance += amount;

            }//Fim do comando if do método condicional if-else simples
        }//Fim do método Loan

    }//Fim da classe BusinessAccount
}//Fim do namespace Heranca.Entities
