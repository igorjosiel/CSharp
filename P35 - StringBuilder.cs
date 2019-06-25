//Usando os namespaces System, StringBuilder2.Entities e System.Text
using System;
using StringBuilder2.Entities;
using System.Text;

//Utilizando o namespace StringBuilder
namespace StringBuilder2
{
    //Classe StringBuilder
    class StringBuilder2
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e instanciando dois objetos do tipo Comment com a palavra-chave new, passando como argumento para o construtor suas respectivas strings
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            //Declarando e instanciando um objeto do tipo Post com a palavra-chave new, passando como argumento para o construtor seus respectivos valores de entrada de dados
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zeeland", "I'm going to visit this wonderful country!", 12);

            //Acionando o método AddComment do objeto p1 do tipo Post para adicionar os dois objetos c1 e c2 do tipo Comment ao objeto p1
            p1.AddComment(c1);
            p1.AddComment(c2);

            //Declarando e instanciando dois objetos do tipo Comment com a palavra-chave new passando como argumento para o construtor suas respectivas strings
            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the Force be with you!");

            //Declarando e instanciando um objeto do tipo Post com a palavra-chave new, passando como argumento para o construtor seus respectivos valores de entrada de dados
            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow!", 5);

            //Acionando o método AddComment do objeto p2 do tipo Post para adicionar os dois objetos c3 e c4 do tipo Comment ao objeto p2
            p2.AddComment(c3);
            p2.AddComment(c4);

            //Imprime os objetos na tela
            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }//Fim do método Main
    }//Fim da classe StringBuilder
}//Fim do namespace StringBuilder
