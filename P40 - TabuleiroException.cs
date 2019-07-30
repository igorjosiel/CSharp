//Usando o namespace System
using System;

//Utilizando o namespace XadrezConsole.TabuleiroXadrez
namespace XadrezConsole.TabuleiroXadrez
{
    //Classe TabuleiroException herdando ou extendendo da superclasse Exception
    class TabuleiroException : Exception
    {
        //Método construtor com entrada de argumento do tipo string reutilizando o código-fonte do construtor da superclasse Exception com a palavra-chave base
        public TabuleiroException (string msg) : base (msg)
        {
        }//Fim do método construtor com entrada de argumento

    }//Fim da classe TabuleiroException
}//Fim do namespace XadrezConsole.TabuleiroXadrez
