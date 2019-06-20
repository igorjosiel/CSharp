//Usando o namespace System
using System;

//Utilizando o namespace LacoForeach
namespace LacoForeach
{
    //Classe LacoForeach
    class LacoForeach
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando vetor do tipo string e inicializando-o com 3 elementos
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            //Imprime a frase na tela
            Console.WriteLine("-----Vetor de strings-----");

            //Laço repetitivo foreach. Atribuindo um apelido para cada elemento do vetor vect
            foreach (string str in vect)
            {
                //Imprime o elemento do vetor com o seu apelido
                Console.WriteLine(str);

            }//Fim do laço repetitivo foreach

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe LacoForeach
}//Fim do namespace LacoForeach
