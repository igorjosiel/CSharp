//Importa todas as classes da biblioteca System
using System;

//Mecanismo de controle da visibilidade de nomes dentro de um programa
namespace PrimeiroPrograma
{
    //Classe PrimeiroPrograma
    class PrimeiroPrograma
    {
        //Método principal Main
        static void Main()
        {
            //Chamando a classe Console da biblioteca System e utilizando seu método WriteLine() para imprimir na tela a frase
            Console.WriteLine("O meu primeiro programa em C#!");

            //Chamando a classe Console da biblioteca System e utilizando seu método ReadLine() para manter a aplicação aberta
            Console.ReadLine();

        }//Fim do método Main
    }//Fim da classe Programa
}//Fim de namespace
