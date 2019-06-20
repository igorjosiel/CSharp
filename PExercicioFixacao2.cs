//Usando o namespace System
using System;

//Usando o namespace ExercicioFixacao2
namespace ExercicioFixacão2
{
    //Classe ExercicioFixacao2
    class ExercicioFixacao2
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite dois numeros inteiros: ");

            //Declarando variáveis do tipo int e inicializando-as com valores digitados pelo usuário via teclado e convertendo os valores de string para int com o método int.Parse
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            //Declarando variável do tipo int e incilaizando-a com o valor da soma entre num1 e num2
            int resultado = num1 + num2;

            //Imprime a frase com os respectivos valores das variáveis num1, num2 e resultado utilizando o método de impressão Placeholders
            Console.WriteLine("\nA soma de {0} e {1} e: {2}", num1, num2, resultado);
            Console.WriteLine("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao2
}//Fim do namespace ExercicioFixacao2
