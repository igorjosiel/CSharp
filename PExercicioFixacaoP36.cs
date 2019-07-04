//Usando os namespaces System, System.Globalization, ExercicioFixacao_36.Exceptions e ExercicioFixacao_36.Entities
using System;
using System.Globalization;
using ExercicioFixacao_36.Exceptions;
using ExercicioFixacao_36.Entities;

//Utilizando o namespace ExercicioFixacao_36
namespace ExercicioFixacao_36
{
    //Classe ExercicioFixacao_36
    class ExercicioFixacao_36
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Palavra-chave try para tentar executar o bloco de intruções abaixo
            try
            {
                //Imprime as frases na tela
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");

                //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
                int number = int.Parse(Console.ReadLine());

                //Imprime a frase na tela
                Console.Write("Holder: ");

                //Declarando e inicializando variável do tipo string com um valor digitado pelo usuário via teclado
                string holder = Console.ReadLine();

                //Imprime a frase na tela
                Console.Write("Initial balance: ");

                //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado, com sua devida formatação de ponto decimal
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Imprime a frase na tela
                Console.Write("Withdraw limit: ");

                //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado, com sua devida formatação de ponto decimal
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Declarando e instanciando um objeto do tipo Account com a palavra-chave new passando como argumento para o parâmetro do método construtor os valores das variáveis digitadas acima
                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                //Salta uma linha
                Console.WriteLine();

                //Imprime a frase na tela
                Console.Write("Enter amount for withdraw: ");

                //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado, com sua devida formatação de ponto decimal
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Acionando o método Withdraw do objeto acc passando como argumento para o parâmetro do método a variável digitada acima
                acc.Withdraw(withdraw);

                //Imprime na tela a frase com o valor do atributo Balance do objeto acc
                Console.WriteLine("New balance: " + acc.Balance);

            }//Fim do bloco try

            //Palavra-chave catch indica que irá capturar uma exceção encontrada no bloco try acima. Declarando um objeto do tipo DomainAccount (Tipo personalizado)
            catch (DomainAccount e)
            {
                //Imprime a frase na tela com a concatenação do valor da propriedade Message do objeto e
                Console.WriteLine("Withdraw error: " + e.Message);

            }//Fim do comando catch

            //Palavra-chave catch indica que irá capturar uma exceção encontrada no bloco try acima. Declarando um objeto do tipo FormatException
            catch (FormatException e)
            {
                //Imprime a frase na tela com a concatenação do valor da propriedade Message do objeto e
                Console.WriteLine("Eror in format: " + e.Message);

            }//Fim do comando catch

            //Palavra-chave catch indica que irá capturar uma exceção encontrada no bloco try acima. Declarando um objeto do tipo Exception (Classe mais geral possível)
            catch (Exception e)
            {
                //Imprime a frase na tela com a concatenação do valor da propriedade Message do objeto e
                Console.WriteLine("Unexpected error: " + e.Message);

            }//Fim do comando catch

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_36
}//Fim do namespace ExercicioFixacao_36
