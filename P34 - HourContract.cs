//Usando o namespace System
using System;

//Utilizando o namespace Composicao.Entities
namespace Composicao.Entities
{
    //Classe HourContract
    class HourContract
    {
        //Atributos da classe dos tipos DateTime, double e int com suas respectivas auto propriedades get e set
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Declarando método construtor padrão sem entrada de argumentos
        public HourContract ()
        {
        }//Fim do método construtor padrão sem parâmetros

        //Declarando método construtor com três entradas de argumentos dos tipos DateTime, double e int
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            //Atribuindo aos atributos da classe com a palavra-chave this os valores passados como argumentos para os parâmetros
            this.Date = date;
            this.ValuePerHour = valuePerHour;
            this.Hours = hours;

        }//Fim do método construtor com três parâmetros

        //Declarando método do tipo double
        public double TotalValue ()
        {
            //Retorna ao método chamador o valor da expressão ValuePerHour * Hours
            return ValuePerHour * Hours;

        }//Fim do método TotalValue

    }//Fim da classe HourContract
}//Fim do namespace Composicao.Entities
