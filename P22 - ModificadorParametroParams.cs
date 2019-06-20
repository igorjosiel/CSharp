//Usando o namespace System
using System;

//Usando o namespace ModificadorParametroParams
namespace ModificadorParametroParams
{
    //Classe ModificadorParametroParams
    class ModificadorParametroParams
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e inicializando uma variavel do tipo int com o valor da chamada ao método Soma da classe SomaVariavel passando como argumento 2 valores
            int s1 = SomaVariavel.Soma(2, 3);

            //Imprime a frase na tela com o valor da variável s1
            Console.WriteLine("\nA soma dos valores 2 e 3 e: " + s1);

            //Declarando e inicializando uma variavel do tipo int com o valor da chamada ao método Soma da classe SomaVariavel passando como argumento 3 valores
            int s2 = SomaVariavel.Soma(2, 3, 4);

            //Imprime a frase na tela com o valor da variável s2
            Console.WriteLine("\nA soma dos valores 2, 3 e 4 e: " + s2);

        }//Fim do método Main
    }//Fim da classe ModificadorParametroParams
}//Fim do namespace ModificadorParametroParams
