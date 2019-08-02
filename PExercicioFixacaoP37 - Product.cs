//Usando o namespace ExercicioFixacao_37.Entities
namespace ExercicioFixacao_37.Entities
{
    //Classe Product
    class Product
    {
        //Atributos da classe dos tipos string, double e int, com suas propriedades get e set
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        //Método construtor com entrada de argumentos dos tipos string, double e int
        public Product(string name, double price, int quantity)
        {
            //Atributos da classe recebendo os valores das variáveis passadas como argumentos para o parâmetro do método com a palavra chave this
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;

        }//Fim do método construtor com entrada de argumentos

        //Método do tipo double
        public double Total()
        {
            //Retorna ao método chamador o valor do resultado da multiplicação dos atributos Price e Quantity
            return Price * Quantity;

        }//Fim do método Total

    }//Fim da classe Product
}//Fim do namespace ExercicioFixacao_37.Entities
