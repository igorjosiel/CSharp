//Usando o namespace System
using System;

//Utilizando o namespace TratamentoDeExcecoes
namespace TratamentoDeExcecoes
{
    //Classe TratamentoDeExcecoes
    class TratamentoDeExcecoes
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Palavra-chave try indicando que pode ocorrer dentro do bloco de instruções ababixo uma exceção
            try
            {
                //Imprime a frase na tela
                Console.WriteLine("Enter the first end second numbers: ");

                //Declarando e inicializando duas variáveis do tipo int com valores digitados pelo usuário via tecaldo
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                //Declarando e atribuindo à variável do tipo int result a divisão dos valores armazenados nas variáveis n1 e n2
                int result = n1 / n2;

                //Imprime o valor da variável result na tela
                Console.WriteLine(result);

            }//Fim do comando try

            //Palavra-chave catch para capturar uma exceção. Passando como argumento o tipo da possível exceção
            catch(DivideByZeroException)
            {
                //Imprime a frase na tela
                Console.WriteLine("Division by zero is not allowed!");

            }//Fim do comando catch

            //Palavra-chave catch para capturar uma exceção. Passando como argumento um objeto do tipo da possível exceção
            catch (FormatException e)
            {
                //Imprime a frase na tela com o valor do atributo Message do objeto e
                Console.WriteLine("Format error! " + e.Message);

            }//Fim do comando catch

            //Palavra-chave finally que indica que o bloco de instruções será executado no final do tratamento de exceções, independente de ter ocorrido uma ou não
            finally
            {
                //Imprime a frase na tela
                Console.WriteLine("End!!!");

            }//Fim do comando finally

        }//Fim do método Main
    }//Fim da classe TratamentoDeExcecao
}//Fim do namespace TratamentoDeExcecao
