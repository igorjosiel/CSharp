//Utilizando a biblioteca de classes System
using System;

//Mecanismo de controle da visibilidade de nomes dentro de um programa
namespace OperadorCondicional
{
    //Classe OperadorCondicional
    class OperadorCondicional
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Variável x do tipo inteiro sendo inicializada com o valor 20
            int x = 20;

            //Variável y do tipo inteiro sendo inicializada com o valor da condição ? :
            //Se a variável x for maior que 10, y recebe 5. Senão, y recebe 7
            int y = (x > 10) ? 5 : 7;

            //Imprime a frase concatenando com o valor da variável y
            Console.WriteLine("O valor de y e " + y);

            //Mantém a aplicação aberta
            Console.ReadLine();

        }//Fim do método Main
    }//Fim da classe OperadorCondicional
}//Fim de namespace
