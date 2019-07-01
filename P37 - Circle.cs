//Usando os namespaces ClasseEMetodosAbstratos.Entities.Enums e System
using ClasseEMetodosAbstratos.Entities.Enums;
using System;

//Utilizando o namespace ClasseEMetodosAbstratos.Entities
namespace ClasseEMetodosAbstratos.Entities
{
    //Classe Circle herdando ou extendendo da classe abstrata Shape com o operador (:)
    class Circle : Shape
    {
        //Atributo da classe do tipo double com suas propriedades get e set
        public double Radius { get; set; }

        //Método construtor com entrada de agumento do tipo Color e double aproveitando o código-fonte do método construtor da superclasse Shape com a palavra-chave base
        public Circle (Color color, double radius) : base (color)
        {
            //Atribuindo ao atributo da classe com a palavra-chave this o valor passado como argumento para o parâmetro do método
            this.Radius = radius;

        }//Fim do método construtor com entrada de argumentos

        //Método do tipo double sendo sobrescrito ou sobreposto com a palavra-chave override
        public override double Area()
        {
            //Retorna ao método chamador a multiplicação do PI, utilizando-se a classe Math, com o quadrado do atributo Radius
            return Math.PI * Radius * Radius;

        }//Fim do método Area

    }//Fim da classe Circle
}//Fim do namespace ClasseEMetodosAbstratos.Entitie
