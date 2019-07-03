//Utilizando os namespaces System e ExcecoesPersonalizadas.Exceptions
using System;
using ExcecoesPersonalizadas.Exceptions;

//Usando o namespace ExcecoesPersonalizadas.Entities
namespace ExcecoesPersonalizadas.Entities
{
    //Classe Reservation
    class Reservation
    {
        //Atributos da classe dos tipos int e DateTime com suas propriedades get e set
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        //Método construtor sem entrada de argumentos
        public Reservation()
        {
        }//Fim do método construtor sem entrada de argumentos

        //Método construtor com entrada de argumentos dos tipos int e DateTime
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            //Método condicional if-else simples. Verifica se o valor da variável checkOut passado como argumento para o parâmetro do método construtor é menor ou igual ao valor da variável checkIn. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (checkOut <= checkIn)
            {
                //Lança uma exceção passando como argumento para o construtor da classe DomainException a mensagem abaixo
                throw new DomainException("Check-out date must be after check-in date");

            }//Fim do comando if do método condicional if-else simples

            //Atribuindo aos atributos da classe os valores passados como argumentos para o parâmetro do método construtor
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;

        }//Fim do método construtor

        //Método do tipo double sem entrada de argumentos
        public double Duration()
        {
            //Declarando variável do tipo TimeSpan e inicializando-a com valor da diferença do atributo CheckOut pelo atributo CheckIn
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            //Retorna ao método chamador o valor da variável duration do tipo TimeSpan convertido no número de dias com o atributo TotalDays e fazendo o casting para o tipo int
            return (int)duration.TotalDays;

        }//Fim do método Duration

        //Método do tipo void com entrada de argumentos do tipo DateTime
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            //Declarando variável do tipo DateTime e atribuindo à mesma o valor da data atual do sistema
            DateTime now = DateTime.Now;

            //Método condicional if-else composto. Verifica se os valores das variáveis checkIn ou checkOut passados como argumento para o parâmetro do método UpdateDates são menores do que o valor da variável now. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (checkIn < now || checkOut < now)
            {
                //Lança uma exceção passando como argumento para o construtor da classe DomainException a mensagem abaixo
                throw new DomainException("Reservation dates for update must be future dates");

            }//Fim do comando if do método condicional if-else composto

            //Verifica se o valor da variável checkOut é menor ou igual ao valor da variável checkin passados como argumento para o parâmetro do método UpdateDates. Se for, executa o bloco de instruções abaixo.
            else if (checkOut <= checkIn)
            {
                // Lança uma exceção passando como argumento para o construtor da classe DomainException a mensagem abaixo
                throw new DomainException("Check-out date must be after check-in date");

            }//Fim do comando else if do método condicional if-else composto

            //Atualiza os valores dos atributos da classe CheckIn e CheckOut com os valores das variáveis checIn e checkOut, respectivamente, passados como argumentos para o parâmetro do método UpdateDates
            CheckIn = checkIn;
            CheckOut = checkOut;

        }//Fim do método UpdateDates

        //Método ToString do tipo string sendo sobrescrito ou sobreposto com a palavra-chave override
        public override string ToString()
        {
            //Retorna ao método chamador a string abaixo contendo as frases concatenadas com os valores dos atributos da classe RoomNumber, CheckIn, CheckOut e do método Duration com suas devidas formatações de casas decimas e ponto separador das casas
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";

        }//Fim do método sobrescrito ToString

    }//Fim da classe Reservation
}//Fim do namespace ExcecoesPersonalizadas.Entities
