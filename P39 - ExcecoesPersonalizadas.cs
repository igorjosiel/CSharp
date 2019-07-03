//Usando o namespace System, ExcecoesPersonalizadas.Entities e ExcecoesPersonalizadas.Exceptions
using System;
using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Exceptions;

//Utilizando o namespace ExcecoesPersonalizadas
namespace ExcecoesPersonalizadas
{
    //Classe ExcecoesPersonalizadas
    class ExcecoesPersonalizadas
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Palavra-chave try para tentar executar o bloco de intruções abaixo
            try
            {
                //Imprime a frase na tela
                Console.Write("Room number: ");

                //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
                int number = int.Parse(Console.ReadLine());

                //Imprime a frase na tela
                Console.Write("Check-in date (dd/MM/yyyy): ");

                //Declarando e inicializando variável do tipo DateTime com um valor digitado pelo usuário via teclado
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                //Imprime a frase na tela
                Console.Write("Check-out date (dd/MM/yyyy): ");

                //Declarando e inicializando variável do tipo DateTime com um valor digitado pelo usuário via teclado
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                //Declarando e instanciando um objeto do tipo Reservation com a palavra-chave new passando como argumento para o parâmetro do método construtor os valores das variáveis digitadas cima
                Reservation reservation = new Reservation(number, checkIn, checkOut);

                //Imprime a frase na tela
                Console.WriteLine("Reservation: " + reservation);

                //Salta uma linha
                Console.WriteLine();

                //Imprime as frases na tela
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");

                //Declarando e atribuindo à variável do tipo DateTime um valor digitado pelo usuário via teclado
                checkIn = DateTime.Parse(Console.ReadLine());

                //Imprime a frase na tela
                Console.Write("Check-out date (dd/MM/yyyy): ");

                //Declarando e atribuindo à variável do tipo DateTime um valor digitado pelo usuário via teclado
                checkOut = DateTime.Parse(Console.ReadLine());

                //Acionando o método UpdateDates do objeto reservation passando como argumento para o parâmetro do método os valores atualizados das variáveis checkIn e chckOut, respectivamente
                reservation.UpdateDates(checkIn, checkOut);

                //Imprime a palavra na tela concatenada com o valor do objeto reservation
                Console.WriteLine("Reservation: " + reservation);

            }//Fim do bloco try

            //Palavra-chave catch indica que irá capturar uma exceção encontrada no bloco try acima. Declarando um objeto do tipo FormatException
            catch (FormatException e)
            {
                //Imprime a frase na tela com a concatenação do valor da propriedade Message do objeto e
                Console.WriteLine("Error in format: " + e.Message);

            }//Fim do comando catch

            //Palavra-chave catch indica que irá capturar uma exceção encontrada no bloco try acima. Declarando um objeto do tipo DomainException (Tipo personalizado)
            catch (DomainException e)
            {
                //Imprime a frase na tela com a concatenação do valor da propriedade Message do objeto e
                Console.WriteLine("Error in reservation: " + e.Message);

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
    }//Fim da classe ExcecoesPersonalizadas
}//Fim do namespace ExcecoesPersonalizadas
