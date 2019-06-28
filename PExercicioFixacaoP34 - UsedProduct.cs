//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace ExercicioFixacao_34.Entities
namespace ExercicioFixacao_34.Entities
{
    //Classe UsedProduct herdando ou extendendo da classe Product
    class UsedProduct : Product
    {
        //Atributo da classe do tipo DateTime com suas propriedades get e set
        public DateTime ManufactureDate { get; set; }

        //Método construtor padrão sem entrada de argumentos
        public UsedProduct ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Método construtor com entrada de argumento dos tipos string, double e DateTime. Usando a palavra-chave base para reaproveitar o código-fonte do construtor da superclasse Product
        public UsedProduct (string name, double price, DateTime manufactureDate) : base (name, price)
        {
            //Atribuindo ao atributo da classe com a palavra-chave this o valor do argumento passado como parâmetro para o método construtor
            this.ManufactureDate = manufactureDate;

        }//Fim do método construtor com entrada de argumento dos tipos string, double e DateTime

        //Método do tipo string sendo sobrescrito com a palavra-chave override
        public override string PriceTag()
        {
            //Retorna ao método chamador a frase abaixo com os valores dos atributos Name e Price da classe com as devidas formatações, de casas decimais depois do ponto separador
            //Método ToShortDateString usado para formatar a data apenas com os valores da data 'dd/MM/yyyy'
            return Name + " (used) - $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToShortDateString() + ")";

        }//Fim do método sobrescrito PriceTag

    }//Fim da classe UsedProduct
}//Fim do namespace ExercicioFixacao_34.Entities
