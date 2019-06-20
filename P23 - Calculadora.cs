//Usando o namespace ModificadorParametroRefEOut
namespace ModificadorParametroRefEOut
{
    //Classe Calculadora
    class Calculadora
    {
        //Declarando método public static do tipo void com o valor de parâmetro do tipo int como referência ao argumento usando a palavra-chave ref
        public static void TripleRef(ref int x)
        {
            //Alterando o valor da variável de argumento através da variável de referência x, multiplicando-a por 3
            x = x * 3;

        }//Fim do método Triple

        //Declarando método public static do tipo void com o valor de parâmetro do tipo int e uma variável do tipo int para referenciar a variável de argumento não inicializada com a palavra-chave out
        public static void TripleOut(int origin, out int result)
        {
            //Atribuindo valor à variável de argumento não inicializada através da variável "result"
            result = origin * 3;

        }//Fim do método TripleOut

    }//Fim da classe Calculadora
}//Fim do namespace ModificadorParametroRefEOut
