//Usando o namespace ClasseEMetodosAbstratos.Entities.Enums
using ClasseEMetodosAbstratos.Entities.Enums;

//Utilizando o namespace ClasseEMetodosAbstratos.Entities
namespace ClasseEMetodosAbstratos.Entities
{
    //Classe Shape do tipo abstrata, com a palavra-chave abstract. Significa que a mesma não poderá ser instanciada
    abstract class Shape
    {
        //Atributo da classe do tipo enum Color com suas propriedades get e set
        public Color Color { get; set; }

        //Método construtor com entrada de agumento do tipo Color
        public Shape (Color color)
        {
            //Atribuindo ao atributo Color da classe o valor passado como argumento para o parâmetro do método
            this.Color = color;

        }//Fim do método construtor com entrada de argumento

        //Método Area do tipo double sendo declarado com a palavra-chave abstract. Significa que o mesmo não precisa de implementação na classe em que é declarado, apenas em suas subclasses
        public abstract double Area();

    }//Fim da classe Shape
}//Fim do namespace ClasseEMetodosAbstratos.Entities
