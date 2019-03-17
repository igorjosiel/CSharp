//Utilizando o namespace System
using System;

//Usando o namespace ExercicioFixacao4
namespace ExercicioFixacao4
{
    //Classe ExercicioFixacao4
    class ExercicioFixacao4
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite 4 numeros inteiros: ");

            //Declarando variáveis do tipo int e inicializando-as com valores digitados pelo usuário via teclado usando o método int.Parse para converter string em valores int
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            //Declarando variável do tipo int para armazenar a diferença do produto dos valores de a e b pelo produto de c e d
            int diferenca = (a * b - c * d);

            //Imprime a frase na tela e os valores das variáveis respectivamente a, b, c, d e diferenca usando o método de impressão Placeholders
            Console.WriteLine("\nA diferenca do produto de {0} e {1} pelo produto de {2} e {3} e: {4}", a, b, c, d, diferenca);
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao4
}//Fim do namespace ExercicioFixacao4
