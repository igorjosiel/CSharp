//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace Vetores_Parte_2
namespace Vetores_Parte_2
{
    //Classe Vetores_Parte_2
    class Vetores_Parte_2
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um numero: ");

            //Declara uma variável do tipo int e inicializa-a com um valor digitado via teclado
            int num = int.Parse(Console.ReadLine());

            //Declara um vetor do tipo Produto e informa o seu tamanho de acordo com o valor da variável num
            Produto[] vetor = new Produto[num];

            //Imprime a frase na tela
            Console.WriteLine("\n-----Preencha o vetor-----\n");

            //Método de repetição for para iterar pelo vetor em todas as posições. Declarando variável do tipo int para ser a variável controladora das iterações do vetor
            for (int i = 0; i < num; i ++)
            {
                //Imprime a frase na tela com o respectivo valor da variável i
                Console.Write("Nome do produto do elemento " + i + ": ");

                //Declarando variável do tipo string e inicializa-a com um valor via teclado
                string nome = Console.ReadLine();

                //Imprime a frase na tela com o respectivo valor da variável i
                Console.Write("Preco do produto do elemento " + i + ": ");

                //Declarando variável do tipo double e inicializa-a com um valor via teclado com as devidas formatações
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Instanciando um novo objeto, passando como parâmetro os valores das variáveis acima para inicializar o mesmo
                vetor[i] = new Produto { Nome = nome, Preco = preco };

                //Salta uma linha
                Console.Write("\n");

            }//Fim do método de repetição for

            //Declarando variável do tipo double e sendo inicializada com o valor 0.0
            double soma = 0.0;

            //Método de repetição for para percorrer por todo o vetor de objetos em todas as posições. Declarando variável do tipo int para ser a variável controladora das iterações do vetor
            for (int i = 0; i < num; i ++)
            {
                //Variável soma sendo acrescida com o valor do atributo preco de todos os objetos do vetor nas respectivas posições
                soma += vetor[i].Preco;

            }//Fim do método de repetição for

            //Declarando variável double que armazena o valor da soma dividindo pela quantidade de elementos que o vetor possui
            double media = soma / num;

            //Imprime a frase na tela com o valor da variável media com suas devidas formatações
            Console.WriteLine("\nO preco medio de todos os objetos do vetor e: " + media.ToString("F2", CultureInfo.InvariantCulture) + "\n");

        }//Fim do método Main

    }//Fim da classe Vetores_Parte_2
}//Fim do namespace Vetores_Parte_2
