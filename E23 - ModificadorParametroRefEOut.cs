//Usando o namespace System
using System;

//Utilizando o namespace ModificadorParametroRefEOut
namespace ModificadorParametroRefEOut
{
    //Classe ModificadorParametroRefEOut
    class ModificadorParametroRefEOut
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e inicializando uma variável do tipo int com o valor 10
            int a = 10;

            //Chamando o método TripleRef da classe Calculadora passando como argumento o valor da variável "a" por referência com a palavra-chave ref
            Calculadora.TripleRef(ref a);

            //Imprime na tela o valor da variável "a"
            Console.WriteLine("O valor da variavel a e: " + a);

            //Declarando e inicializando variáveis do tipo int. Inicializando "b" com o valor 20
            int b = 20;
            int triple;

            //Chamando o método TripleOut da classe Calculadora passando por argumento o valor da variável "a", a variável que será referenciada com palavra-chave out
            Calculadora.TripleOut(b, out triple);

            //Imprime na tela o valor da variável "triple"
            Console.WriteLine("O valor da variavel triple e: " + triple);

            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe ModificadorParametroRefEOut
}//Fim do namespace ModificadorParametroRefEOut
