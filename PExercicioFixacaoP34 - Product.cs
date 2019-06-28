//Usando o namespace System.Globalization
using System.Globalization;

//Usando o namespace ExercicioFixacao_34.Entities
namespace ExercicioFixacao_34.Entities
{
    //Classe Product
    class Product
    {
        //Atributos da classe dos tipos string e double com suas propriedades get e set
        public string Name  { get; set; }
        public double Price { get; set; }

        //Método construtor padrão sem entrada de argumentos
        public Product ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Método construtor com entrada de argumento dos tipos string e double
        public Product (string name, double price)
        {
            //Atribuindo aos atributos da classe com a palavra-chave this os valores dos argumentos passados como parâmetros para o método construtor
            this.Name = name;
            this.Price = price;

        }//Fim do método construtor com entrada de argumento dos tipos string e double

        //Método do tipo string sem entrada de argumento. Utilizando a palavra-chave virtual para especificar que o método PriceTag pode ser sobrescrito ou sobreposto por uma subclasse da classe Product
        public virtual string PriceTag()
        {
            //Retorna ao método chamador a frase abaixo com os valores dos atributos Name e Price da classe com as devidas formatações, de casas decimais depois do ponto separador
            return Name + " - $ " + Price.ToString("F2", CultureInfo.InvariantCulture);

        }//Fim do método PriceTag

    }//Fim da classe Product
}//Fim do namespace ExercicioFixacao_34.Entities
