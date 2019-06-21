//Utilizando os namespaces enumeracao.Entities, enumeracao.Entities.Enums e System
using enumeracao.Entities;
using enumeracao.Entities.Enums;
using System;

//Usando o namespace enumeracao
namespace enumeracao
{
    //Classe enumeracao
    class enumeracao
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando, instanciando com a palavra-chave new e inicializando um objeto do tipo Order
            Order order = new Order { Id = 1080, Moment = DateTime.Now, status = OrderStatus.PendingPayment};

            //Imprime na tela o objeto order
            Console.WriteLine(order);

            //Declarando e inicializando variável do tipo string com o resultado da conversão do enumerador OrderStatus.PendingPayment para string através do método ToString
            string txt = OrderStatus.PendingPayment.ToString();

            //Imprime a variável txt na tela
            Console.WriteLine(txt);
            
        }//Fim do método Main
    }//Fim da classe Enumeracao
}//Fim do namespace Enumeracao
