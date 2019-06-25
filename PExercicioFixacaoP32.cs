//Usando os namespaces System, System.Collections.Generic, ExercicioFixacao_32.Entities.Enums, System.Globalization e ExercicioFixacao_32.Entitie
using System;
using System.Collections.Generic;
using ExercicioFixacao_32.Entities;
using ExercicioFixacao_32.Entities.Enums;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao_32
namespace ExercicioFixacao_32
{
    //Classe ExercicioFixacao_32
    class ExercicioFixacao_32
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime as frases na tela
            Console.WriteLine("-----Enter client data-----");
            Console.Write("Nome: ");

            //Declarando e inicializando variável do tipo string com um valor digitado pelo usuário via teclado
            string name = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Email: ");

            //Declarando e inicializando variável do tipo string com um valor digitado pelo usuário via teclado
            string email = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Birth date (DD/MM/YYYY): ");

            //Declarando e inicializando variável do tipo DateTime com um valor digitado pelo usuário via teclado
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //Declarando e instanciando um objeto do tipo Client com a palavra-chave new, passando como argumento os valores das variáveis name, email e birthDate
            Client client = new Client(name, email, birthDate);

            //Imprime as frases na tela
            Console.WriteLine("\n-----Enter order data-----");
            Console.Write("Status: ");

            //Declarando e inicializando um enum do tipo OrderStatus com a palavra-chave out para receber o valor digitado pelo usuário via teclado do tipo string e convertê-lo para enum. Palavra-chave false para considerar as maiúsculas e minúsculas
            Enum.TryParse<OrderStatus>(Console.ReadLine(), false, out OrderStatus orderStatus);

            //Declarando e instanciando um objeto do tipo Order com a palavra-chave new, passando como argumento os valores DateTime.Now, das variáveis orderStatus e o objeto client
            Order order = new Order(DateTime.Now, orderStatus, client);

            //Imprime a frase na tela
            Console.Write("\nHow many items to this order? ");

            //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
            int quant = int.Parse(Console.ReadLine());

            //Método repetitivo for para repetir enquanto o valor da variável i for menor ou igual ao valor da variável quant
            for (int i = 1; i <= quant; i ++)
            {
                //Imprime as frases na tela
                Console.WriteLine($"\n---Enter #{i} item data: ");
                Console.Write("Product name: ");

                //Declarando e inicializando variável do tipo string com um valor digitado pelo usuário via teclado
                string productName = Console.ReadLine();

                //Imprime a frase na tela
                Console.Write("Product price: ");

                //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Declarando e instanciando um objeto do tipo Product com a palavra-chave new, passando como argumento os valores das variáveis productName e productPrice
                Product product = new Product(productName, productPrice);

                //Imprime a frase na tela
                Console.Write("Quantity: ");

                //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
                int quantity = int.Parse(Console.ReadLine());

                //Declarando e instanciando um objeto do tipo OrderItem com a palavra-chave new, passando como argumento os valores das variáveis quantity, productPrice e o objeto product
                OrderItem or = new OrderItem(quantity, productPrice, product);

                //Acionando o método AddItem do obejeto order do tipo Order para adicionar o objeto or do tipo OrderItem instanciado acima à lista de objetos do tipo Order
                order.AddItem(or);

            }//Fim do método repetitivo for

            //Salta uma linha
            Console.WriteLine();

            //Imprime o objeto order do tipo Order
            Console.WriteLine(order);

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_32
}//Fim do namespace ExercicioFixacao_32
