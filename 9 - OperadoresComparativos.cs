//Usando o namespace System
using System;

//Utilizando o namespace OperadoresComparativos
namespace OperadoresComparativos
{
    //Classe OperadoresComparativos
    class OperadoresComparativos
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando variável do tipo int e inicializando-a com o valor 10
            int a = 10;

            //Declarando variáveis do tipo bool para armazenar o valor lógico das expressões com base nos operadores lógicos
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;
            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            //Imprime os valores das variáveis na tela
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
            Console.WriteLine("\n");

        }//Fim do método Main
    }//Fim da classe OperadoresComparativos
}//Fim do namespace OperadoresComparativos
