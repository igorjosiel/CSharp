//Utilizando os namespaces System e Heranca.Entities
using System;
using Heranca.Entities;

//Usando o namespace Heranca
namespace Heranca
{
    //Classe Heranca
    class Heranca
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e instanciando um objeto do tipo BusinessAccount com a palavra-chave new passando valores como argumentos para o construtor da classe
            BusinessAccount acount = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            //Imprime na tela o valor do atributo Balance do objeto acount
            Console.WriteLine(acount.Balance);

            //acount.Balance = 200.0 (Não é possível realizar essa operação, pois o atributo Balance da classe está protegido com o modificador de acesso protected, o que impede que o mesmo seja alterado fora da própria classe que foi implementado ou de suas subclasses)

            //Declarando e instanciando um objeto do tipo Account com a palavra-chave new passando valores como argumentos para o construtor da classe
            Account acc = new Account(1001, "Alex", 0.0);

            //Objeto acc acionando o seu método Withdraw passando como argumento para o método o valor 10.0
            acc.Withdraw(10.0);

            //Imprime na tela o valor do atributo Balance do objeto acc
            Console.WriteLine(acc.Balance);

            //Declarando e instanciando um objeto do tipo BusinessAccount com a palavra-chave new passando valores como argumentos para o construtor da classe
            BusinessAccount bcc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            //Fazendo converções de objetos dos tipos das subclasses (BusinessAccount, SavingAccount) para objetos da superclasse Account. Que é possível já que as classes derivadas são uma forma de Account
            Account acc1 = bcc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING

            //Fazendo converção de objeto do tipo da superclasse Account para objeto da subclasse BusinessAccount. Para que isso seja possível é necessário fazer um downcasting, que é colocar entre parênteses o nome da classe a qual será convertida na frente do objeto "doador da atribuição"
            BusinessAccount acc4 = (BusinessAccount)acc2;

            //Objeto acc4 recebendo para o seu atributo Loan o valor 100.0
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3. Resulta em um erro, pois acc3 é do tipo SavingAccount e não é possível atribuí-lo a um objeto do tipo BusinessAccount

            //Método condicional if-else simples. Verifica se o objeto acc3 é do tipo BusinessAccount com a palavra-chave is
            if (acc3 is BusinessAccount)
            {
                //Faz a converção do objeto acc3 para o objeto recém-criado acc5, que ambos são do tipo BusinessAccount
                BusinessAccount acc5 = (BusinessAccount)acc3;

                //BusinessAccount acc5 = acc3 as BusinessAccount. Sintaxe alternativa para fazer o casting entre as classes com a palavra-chave as

                //Objeto acc5 recebendo para o seu atributo Loan o valor 200.0
                acc5.Loan(200.0);

                //Imprime a palavra na tela
                Console.WriteLine("Loan!");

            }//Fim do comando if do método condicional if-else simples

            //Método condicional if-else simples. Verifica se o objeto acc3 é do tipo SavingAccount com a palavra-chave is
            if (acc3 is SavingAccount)
            {
                //Faz a converção do objeto acc3 para o objeto recém-criado acc5, que ambos são do tipo SavingAccount
                SavingAccount acc5 = (SavingAccount)acc3;

                //SavingAccount acc5 = acc3 as SavingAccount. Sintaxe alternativa para fazer o casting entre as classes com a palavra-chave as

                //Objeto acc5 acionando o seu método UpdateBalance
                acc5.UpdateBalance();

                //Objeto acc5 acionando o seu método Withdraw passando como argumento para o método o valor 10.0
                acc5.Withdraw(10.0);

                //Imprime na tela o valor do atributo Balance do objeto acc5
                Console.WriteLine(acc5.Balance);

                //Imprime a palavra na tela
                Console.WriteLine("Update!");

            }//Fim do comando if do método condicional if-else simples

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe Heranca
}//Fim do namespace Heranca
