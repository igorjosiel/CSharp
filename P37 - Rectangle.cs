//Usando o namespace ClasseEMetodosAbstratos.Entities.Enums
using ClasseEMetodosAbstratos.Entities.Enums;

//Utilizando o namespace ClasseEMetodosAbstratos.Entities
namespace ClasseEMetodosAbstratos.Entities
{
    //Classe Rectangle herdando ou extendendo da classe abstrata Shape com o operador (:)
    class Rectangle : Shape
    {
        //Atributos da classe dos tipos double com suas propriedades get e set
        public double Width { get; set; }
        public double Heigth { get; set; }

        //Método construtor com entrada de agumento do tipo Color e double aproveitando o código-fonte do método construtor da superclasse Shape com a palavra-chave base
        public Rectangle (Color color, double width, double heigth) : base (color)
        {
            //Atribuindo aos atributos da classe com a palavra-chave this os valores passados como argumento para o parâmetro do método
            this.Width = width;
            this.Heigth = heigth;
            
        }//Fim do método construtor com entrada de argumentos

        //Método do tipo double sendo sobrescrito ou sobreposto com a palavra-chave override
        public override double Area()
        {
            //Retorna ao método chamador a multiplicação dos atributos Width e Heigth
            return Width * Heigth;

        }//Fim do método Area

    }//Fim da classe Rectangle
}//Fim do namespace ClasseEMetodosAbstratos.Entities
