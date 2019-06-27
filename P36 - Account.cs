//Usando o namespace Heranca.Entities
namespace Heranca.Entities
{
    //Classe Account
    class Account
    {
        //Atributos da classe dos tipos int e string com suas propriedades get e private set (podendo ser alterados somente a partir dessa classe)
        public int Number { get; private set; }
        public string Holder { get; private set; }

        //Atributo da classe do tipo double com suas propriedades get e protected set (podendo ser alterados somente a partir dessa classe ou de suas subclasses)
        public double Balance { get; protected set; }

        //Declarando método construtor padrão sem entrada de argumentos
        public Account ()
        {
        }//Fim do método construtor padrão

        //Declarando método construtor com entrada de argumentos dos tipos int, string e double
        public Account (int number, string holder, double balance)
        {
            //Atribuindo aos atributos da classe com a palavra-chave this os valores passados como argumentos para os parâmetros do método construtor
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;

        }//Fim do método construtor com entrada de argumentos

        //Método do tipo void com uma entrada de argumento do tipo double. Pode ser sobrescrito ou sobreposto nas suas subclasses com a palavra-chave virtual
        public virtual void Withdraw (double amount)
        {
            //Atributo Balance da classe é subtraído com o valor passado como argumento para o parâmetro do método e também com o valor 5
            Balance -= amount + 5;

        }//Fim do método Withdraw

        //Método do tipo void com uma entrada de argumento do tipo double
        public void Deposit (double amount)
        {
            //Atributo Balance da classe é acrescentado com o valor passado como argumento para o parâmetro do método
            Balance += amount;

        }//Fim do método Deposit

    }//Fim da classe Account
}//Fim do namespace Heranca.Entities
