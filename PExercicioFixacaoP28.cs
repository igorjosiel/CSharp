//Utilizando o namespace System
using System;

//Usando o namespace ExercicioFixacao_28
namespace ExercicioFixacao_28
{
    //Classe ExercicioFixacao_28
    class ExercicioFixacao_28
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando vetor do tipo Estudante e atribuindo-o através da palavra-chave new tamanho 10
            Estudante[] vetor = new Estudante[10];

            //Imprime a frase na tela
            Console.Write("Quantos quartos serao alugados? ");

            //Declarando variável do tipo int e inicializando-a com um valor através do teclado
            int n = int.Parse(Console.ReadLine());

            //Método de repetição for para percorrer o vetor e inicializar as posições do mesmo
            for (int i = 0; i < n; i ++)
            {
                //Imprime as frases na tela com o valor da variável i acrescentada de 1
                Console.WriteLine("\n-----Aluguel " + (i + 1) + ":-----\n");
                Console.Write("Nome: ");

                //Declarando variável do tipo string e inicializando-a com um valor através do teclado
                string nome = Console.ReadLine();

                //Imprime a frase na tela
                Console.Write("Email: ");

                //Declarando variável do tipo string e inicializando-a com um valor através do teclado
                string email = Console.ReadLine();

                //Imprime a frase na tela
                Console.Write("Quarto: ");

                //Declarando variável do tipo int e inicializando-a com valor através do teclado
                int quarto = int.Parse(Console.ReadLine());

                //Instanciando um novo objeto do tipo Estudante com os devidos valores de argumentos para ser criado e armazenando-o na posição indicada em seu atributo quarto
                vetor[quarto] = new Estudante(nome, email);

            }//Fim do método de repetição for

            //Imprime a frase na tela
            Console.WriteLine("\n-----Quartos ocupados-----\n");

            //Método de repetição for para percorrer pelo vetor
            for (int i = 0; i < 10; i ++)
            {
                //Método condicional if-else simples. Se o valor do vetor na posição i for diferente de nulo, significa que está alocado, portanto executa o bloco de instruções abaixo
                if (vetor[i] != null)
                {
                    //Imprime a frase na tela com o valor da variável i e o resultado da chamada ao método ToString do objeto que está armazenado na posição i
                    Console.Write("Alocacao " + i + ": " + vetor[i].ToString());

                }//Fim do comando if do método condicional if-else simples
            }//Fim do método de repetição for

            //Salta uma linha
            Console.Write("\n");

        }//Fim do método Main

    }//Fim da classe ExercicioFixacao_28
}//Fim do namespace ExercicioFixacao_28
