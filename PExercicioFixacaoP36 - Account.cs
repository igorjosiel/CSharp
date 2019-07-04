//Usando os namespaces System e ExercicioFixacao_36.Exceptions
using System;
using ExercicioFixacao_36.Exceptions;

//Utilizando o namespace ExercicioFixacao_36.Entities
namespace ExercicioFixacao_36.Entities
{
    //Classe Account
    class Account
    {
        //Atributos da classe dos tipos int, string e double com suas propriedades get e set
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        //Método construtor sem entrada de argumentos
        public Account ()
        {
        }//Fim do método construtor sem entrada de argumentos

        //Método construtor com entrada de argumentos dos tipos int, string e double
        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            //Atribuindo aos atributos da classe os valores passados como argumentos para o parâmetro do método construtor
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
            this.WithdrawLimit = withdrawLimit;

        }//Fim do método construtor

        //Método do tipo void com entrada de argumento do tipo double
        public void Deposit (double amount)
        {
            //Atribuindo ao atributo da classe Balance o valor passado como argumento para o parâmetro do método
            Balance += amount;

        }//Fim do método Deposit

        //Método do tipo void com entrada de argumento do tipo double
        public void Withdraw (double amount)
        {
            //Método condicional if-else encadeado. Verifica se o valor da variável amount passado como argumento para o parâmetro do método Withdraw é maior do que o valor do atributo Balance. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (amount > Balance)
            {
                //Lança uma exceção passando como argumento para o construtor da classe DomainAccount a mensagem abaixo
                throw new DomainAccount("Not enough balance.");

            }//Fim do comando if do método condicional if-else encadeado

            //Método condicional if-else encadeado. Verifica se o valor da variável amount passado como argumento para o parâmetro do método Withdraw é maior do que o valor do atributo WithdrawLimit. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            else if (amount > WithdrawLimit)
            {
                //Lança uma exceção passando como argumento para o construtor da classe DomainAccount a mensagem abaixo
                throw new DomainAccount("The amount exceeds withdraw limit.");

            }//Fim do comando else if do método condicional if-else encadeado

            //Se não, executa o bloco de instruções abaixo
            else
            {
                //Atualiza o valor do atributo Balance, subtraindo o valor passado como argumento para o parâmetro do método Withdraw
                Balance -= amount;

            }//Fim do comando else do método condicional if-else encadeado

        }//Fim do método Withdraw

    }//Fim da classe Account
}//Fim do namespace ExercicioFixacao_36.Entities
