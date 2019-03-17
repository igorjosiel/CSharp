//Usando o namespace System
using System;

//Utilizando o namespace OperadoresLogicos
namespace OperadoresLogicos
{
    //Classe OperadoresLogicos
    class OperadoresLogicos
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando variáveis do tipo bool para armazenar os valores das expressões com operadores lógicos
            bool c1 = 2 > 3 && 4 != 5;
            bool c2 = 2 > 3 || 4 != 5;
            bool c3 = !(2 > 3) && 4 != 5;
            bool c4 = c1 || c2 && c3;

            //Imprime na tela os valores das variáveis
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe OperadoresLogicos
}//Fim do namespace OperadoresLogicos
