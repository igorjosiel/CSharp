//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace Vetores_Parte_1
namespace Vetores_Parte_1
{
    //Classe Vetores_Parte_1
    class Vetores_Parte_1
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um valor: ");

            //Declarando variável do tipo int e inicializando-a com um valor via teclado
            int tam = int.Parse(Console.ReadLine());

            //Declarando vetor do tipo double e firmando seu tamanho com o valor da variável tam
            double[] vetor = new double[tam];

            //Imprime a frase na tela
            Console.WriteLine("\n-----Preencha o vetor-----\n");

            //Método de repetição for para percorrer pelo vetor. Declarando uma variável do tipo int para ser a variável controladora das iterações que vão percorrer o vetor
            for (int i = 0; i < tam; i ++)
            {
                //Imprime a frase na tela com o valor da variável i em cada iteração do vetor
                Console.Write("Elemento " + i + ": ");

                //Inicializa o elemento do vetor na posição equivalente ao valor da variável i com as devidas formatações
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }//Fim do método de repetição for

            //Declarando variáveis do tipo double e inicializando-as com o valor 0.0
            double soma = 0.0;
            double media = 0.0;

            //Método de repetição for para percorrer pelo vetor. Declarando uma variável do tipo int para ser a variável controladora das iterações que vão percorrer o vetor
            for (int i = 0; i < tam; i ++)
            {
                //Variável soma é acrescentada com o valor do elemento na posição do vetor
                soma += vetor[i];

            }//Fim do método de repetição for

            //Imprime a frase na tela com o valor da variável soma com suas devidas formatações
            Console.WriteLine("\nA media dos valores do vetor e: " + media.ToString("F2", CultureInfo.InstalledUICulture) + "\n");

        }//Fim do método Main

    }//Fim da classe Vetores_Parte_1
}//Fim do namespace Vetores_Parte_1
