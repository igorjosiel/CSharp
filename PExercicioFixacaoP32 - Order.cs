//Usando os namespaces System, System.Collections.Generic, System.Text, System.Globalization e ExercicioFixacao_32.Entities.Enums
using System;
using System.Collections.Generic;
using ExercicioFixacao_32.Entities.Enums;
using System.Text;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao_32.Entities
namespace ExercicioFixacao_32.Entities
{
    //Classe Order
    class Order
    {
        //Atributo da classe do tipo DateTime com suas propriedades get e set
        public DateTime Moment { get; set; }

        //Propriedade enum da classe do tipo OrderStatus com suas propriedades get e set
        public OrderStatus Status { get; set; }

        //Propriedade da classe do tipo Client com suas propriedades get e set. Sendo uma composição de classes (entidades)
        public Client Client { get; set; }

        //Declarando uma Lista da classe contendo elementos do tipo OrderStatus com suas propriedades get e set. Instanciando a lista com a palavra-chave new
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        //Declarando método construtor padrão sem entrada de argumentos
        public Order ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Declarando método construtor com entrada de argumentos dos tipos DateTime, OrderStatus e Client
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            //Atribuindo aos atributos da classe os valores passados como argumentos para os parâmetros do método construtor usando a palavra-chave this
            this.Moment = moment;
            this.Status = status;
            this.Client = client;

        }//Fim do método construtor com entrada de argumentos

        //Declarando método do tipo void com entrada de argumento do tipo OrderItem
        public void AddItem (OrderItem item)
        {
            //Acionando o método Add da lista Items para adicionar à mesma o elemento passado como argumento para o parâmetro do método
            Items.Add(item);

        }//Fim do método AddItem

        //Declarando método do tipo void com entrada de argumento do tipo OrderItem
        public void RemoveItem (OrderItem item)
        {
            //Acionando o método Remove da lista Items para remover da mesma o elemento passado como argumento para o parâmetro do método
            Items.Remove(item);

        }//Fim do método RemoveItem

        //Declarando método do tipo double sem entrada de argumentos
        public double Total ()
        {
            //Declarando e inicializando variável do tipo double com o valor 0.0
            double total = 0.0;

            //Método repetitivo foreach para iterar por toda a lista Items, atribuindo à cada posição da mesma o apelido item do tipo OrderItem
            foreach (OrderItem item in Items)
            {
                //Variável total é acrescentada com o valor do método SubTotal do elemento item
                total += item.SubTotal();

            }//Fim do método repetitivo foreach

            //Retorna ao método chamador o valor da variável total
            return total;

        }//Fim do método Total

        //Declarando método do tipo string sendo sobrescrito com a palavra-chave override
        public override string ToString()
        {
            //Declarando e instanciando um objeto do tipo StringBuilder com a palavra-chave new
            StringBuilder sb = new StringBuilder();

            //Utilizando os métodos Append e AppendLine para adicionar ao objeto sb strings ao final da string resultante (o objeto sb)
            //Adicionando strings e valores de atributos do objeto do tipo Order à string resultante. Usando quando necessário o método ToString para converter outros tipos que não sejam string para string
            sb.AppendLine("-----ORDER SUMARY-----");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" - (");
            sb.Append(Client.BirthDate.ToString());
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("\n-----Order items-----");

            //Método repetitivo foreach para iterar por toda a lista Items de elementos do tipo OrderItem
            foreach (OrderItem item in Items)
            {
                //Adicionando strings e valores de atributos do objeto do tipo Order à string resultante. Usando quando necessário o método ToString para converter outros tipos que não sejam string para string e fazendo as devidas formatações
                sb.Append("Product name: ");
                sb.Append(item.Product.Name);
                sb.Append(", Product price: $");
                sb.Append(item.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity.ToString());
                sb.Append(", Subtotal: $");
                sb.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            }//Fim do método repetitivo foreach

            //Adicionando string e valor de atributo do objeto do tipo Order à string resultante. Usando quando necessário o método ToString para converter o tipo que não seja string para string e fazendo a formatação devida
            sb.Append("Total price: $");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));

            //Retorna ao método chamador o valor da string usando o ToString, contido no objeto sb
            return sb.ToString();

        }//Fim do método ToString

    }//Fim da classe Order
}//Fim do namespace ExercicioFixacao_32.Entities
