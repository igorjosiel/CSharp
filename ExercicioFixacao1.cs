//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao
namespace ExercicioFixacao1
{
    //Classe ExercicioFixacao1
    class ExercicioFixacao1
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Entre com seu nome completo: ");

            //Declarando variável do tipo string e sendo inicializada-a com o valor digitado pelo usuário via teclado
            string nomeCompleto = Console.ReadLine();

            //Imprime a frase na tela
            Console.WriteLine("\nQuantos quartos tem na sua casa? ");

            //Declarando variável do tipo int e inicializando-a com o valor digitado pelo usuário via teclado e convertendo o valor para um valor int com o método int.Parse
            int numQuartos = int.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.WriteLine("\nEntre com um preco de um produto: ");

            //Declarando variável do tipo double e inicializando-a com o valor digitado pelo usuário via teclado e convertendo o valor para um valor double com o método double.Parse
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprime a frase na tela
            Console.WriteLine("\nEntre com seu último nome, idade e altura, respectivamente: ");

            //Declarando vetor de strings usando o método Comando.ReadLine() em uma linha para armazenar as palavras em posições do vetor de acordo com espaços em branco na string até encontrar uma quebra de linha
            string[] vetor = Console.ReadLine().Split(' ');

            //Declarando variáveis com seus respectivos tipos e inicializando-as com os valores armazenados nas posições do vetor
            string ultimoNome = vetor[0];

            //Convertendo o valor em string para um valor int usando o método int.Parse
            int idade = int.Parse(vetor[1]);

            //Convertendo o valor em string para um valor double usando o método double.Parse
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            //Imprime as frases na tela com os valores das respectivas variáveis
            Console.WriteLine("\n");
            Console.WriteLine("Nome completo: " + nomeCompleto);
            Console.WriteLine("Numero de quartos em sua casa: " + numQuartos);
            Console.WriteLine("Preco de um produto: " + precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Ultimo nome: " + ultimoNome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao1
}//Fim do namespace ExercicioFixacao1
