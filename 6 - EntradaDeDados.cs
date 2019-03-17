//Usando o namespace System
using System;

//Utilizando o namespace EntradaDeDados
namespace EntradaDeDados
{
    //Classe EntradaDeDados
    class EntradaDeDados
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando variáveis do tipo string e inicializando-as com valores digitados pelo usuário via teclado com o comando Console.ReadLine()
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            //Declarando um vetor de strings usando o comando Console.ReadLine() para digitar uma linha inteira de palavras e utilizando o método Split() com um argumento de ' ' para guardar palavras em uma posição toda vez que encontrar um espaço em branco no meio da frase
            string[] v = Console.ReadLine().Split(' ');

            //Declarando variáveis do tipo string, recebendo valores que estão armazenados em posições no vetor de string v
            string a = v[0];
            string b = v[1];
            string c = v[2];

            //Imprimindo os valores das variáveis na tela
            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe EntradaDeDados
}//Fim do namespace EntradaDeDados
