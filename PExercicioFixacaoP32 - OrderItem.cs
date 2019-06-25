//Usando os namespaces System e System.Collections.Generic
using System;
using System.Collections.Generic;

//Utilizando o namespace ExercicioFixacao_32.Entities
namespace ExercicioFixacao_32.Entities
{
    //Classe OrderItem
    class OrderItem
    {
        //Atributos da classe dos tipos int, double com suas propriedades get e set
        public int Quantity { get; set; }
        public double Price { get; set; }

        //Propriedade do tipo Product da classe com suas propriedades get e set. Sendo estabelecida uma composição de classes (entidades)
        public Product Product { get; set; }

        //Declarando método construtor padrão sem entrada de argumentos
        public OrderItem ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Declarando método construtor com entrada de argumentos dos tipos int, double e Product
        public OrderItem (int quantity, double price, Product product)
        {
            //Atribuindo aos atributos da classe os valores passados como argumentos para os parâmetros do método construtor usando a palavra-chave this
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;

        }//Fim do método construtor com entrada de argumentos

        //Declarando método do tipo double sem entrada de argumentos
        public double SubTotal ()
        {
            //Retorna ao método chamador a multiplicação dos atributos da classe Quantity e Price
            return Quantity * Price;

        }//Fim do método SubTotal

    }//Fim da classe OrderItem
}//Fim do namespace ExercicioFixacao_32.Entities
