//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace EntradaDeDados2
namespace EntradaDeDados2
{
    //Classe EntradaDeDados2
    class EntradaDeDados2
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando uma variável do tipo int e utilizando o método int.Parse com o argumento Console.ReadLine() para entrada de um valor do tipo int através do teclado
            int n1 = int.Parse(Console.ReadLine());

            //Declarando uma variável do tipo char e utilizando o método char.Parse com o argumento Console.ReadLine() para entrada de um valor do tipo char através do teclado
            char ch = char.Parse(Console.ReadLine());

            //Declarando uma variável do tipo double e utilizando o método double.Parse com o argumento Console.ReadLine() para entrada de um valor do tipo double através do teclado
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando um vetor de strings e utilizando o método Console.ReadLine().Split(' ') para através do teclado armazenar no vetor palavras nas posições quando forem inseridos espaços em branco na string até que se digite uma quebra de linha
            string[] vet = Console.ReadLine().Split(' ');

            //Declarando variáveis com seus respectivos tipos e inicializando-as com os valores armazenados no vetor vet de acordo com a posição
            string nome = vet[0];

            //Usando o método char.Parse para converter a string em um valor char
            char sexo = char.Parse(vet[1]);

            //Usando o método int.Parse para converter a string em um valor int
            int idade = int.Parse(vet[2]);

            //Usando o método double.Parse para converter a string em um valor double e utilizando o método CultureInfo.InvariantCulture para fixar o ponto separador da parte inteira da parte decimal
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            //Imprime a frase e os valores na tela            
            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\n");

        }//Fim do método Main
    }//Fim da classe EntradaDeDados2
}//Fim do namespace EntradaDeDados2
