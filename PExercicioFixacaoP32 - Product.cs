//Usando os namespaces System e System.Collections.Generic
using System;
using System.Collections.Generic;

//Utilizando o namespace ExercicioFixacao_32.Entities
namespace ExercicioFixacao_32.Entities
{
    //Classe Product
    class Product
    {
        //Atributos da classe dos tipos string e double com suas propriedades get e set
        public string Name { get; set; }
        public double Price { get; set; }

        //Declarando método construtor padrão sem entrada de argumentos
        public Product ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Declarando método construtor com entrada de argumentos dos tipos string e double
        public Product(string name, double price)
        {
            //Atribuindo aos atributos da classe os valores passados como argumentos para os parâmetros do método construtor usando a palavra-chave this
            this.Name = name;
            this.Price = price;

        }//Fim do método construtor com entrada de argumentos

    }//Fim da classe Product
}//Fim do namespace ExercicioFixacao_32.Entities
