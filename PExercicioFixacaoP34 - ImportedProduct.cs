//Usando o namespace System
using System;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao_34.Entities
namespace ExercicioFixacao_34.Entities
{
    //Classe ImportedProduct herdando ou extendendo da classe Product
    class ImportedProduct : Product
    {
        //Atributo da classe do tipo double com suas propriedades get e set
        public double CustomsFee { get; set; }

        //Método construtor padrão sem entrada de argumentos
        public ImportedProduct ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Método construtor com entrada de argumento dos tipos string e double. Usando a palavra-chave base para reaproveitar o código-fonte do construtor da superclasse Product
        public ImportedProduct (string name, double price, double customsFee) : base (name, price)
        {
            //Atribuindo ao atributo da classe com a palavra-chave this o valor do argumento passado como parâmetro para o método construtor
            this.CustomsFee = customsFee;

        }//Fim do método construtor com entrada de argumento dos tipos string e double

        //Método do tipo double sem entrada de argumentos
        public double TotalPrice()
        {
            //Retorna ao método chamador o valor da expressão Price + Customs
            return Price + CustomsFee;

        }//Fim do método TotalPrice

        //Método do tipo string sendo sobrescrito com a palavra-chave override
        public override string PriceTag()
        {
            //Retorna ao método chamador as frases e valor dos atributos da classe ImportedProduct, CustumsFee, Name e do método TotalPrice com suas devidas formatações de casas decimais
            return Name + " - $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";

        }//Fim do método sobrescrito PriceTag

    }//Fim da classe ImportedProduct
}//Fim do namespace ExercicioFixacao_34.Entities
