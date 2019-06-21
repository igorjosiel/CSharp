//Utilizando os namespaces System e enumeracao.Entities.Enums
using System;
using enumeracao.Entities.Enums;

//Usando o namespace enumeracao.Entities
namespace enumeracao.Entities
{
    //Classe Order
    class Order
    {
        //Atributo da classe do tipo int com sua auto propriedade get e set
        public int Id { get; set; }

        //Atributo da classe do tipo DateTime que irá receber o valor de uma data e hora com sua auto propriedade get e set
        public DateTime Moment { get; set; }

        //Atributo da classe dos tipos OrderStatus que irá armazenar o estado do objeto (enumeração) com sua auto propriedade get e set
        public OrderStatus status { get; set; }

        //Método sendo sobrescrito com a palavra-chave override do tipo string para representar o objeto em forma de string
        public override string ToString()
        {
            //Retorna ao método chamador a string contendo os valores dos atributos do objeto concatenados com vírgulas separando-os
            return Id + ", " + Moment + ", " + status;

        }//Fim do método ToString

    }//Fim da classe Order
}//Fim do namespace enumeracao.Entities
