//Usando o namespace System
using System;

//Utilizando o namespace ExcecoesPersonalizadas.Exceptions
namespace ExcecoesPersonalizadas.Exceptions
{
    //Classe DomainException herdando ou extendendo da superclasse ApplicationException, que é uma subclasse da superclasse Exceptions, que é usada para criação de exceções de tratamento personalizadas
    class DomainException : ApplicationException
    {
        //Método construtor com entrada de argumento do tipo string reutilizando o código-fonte do método construtor da superclasse ApplicationException, usando a palavra-chave base
        public DomainException (string message) : base (message)
        {
        }//Fim do método construtor com entrada de argumento

    }//Fim da classe DomainException
}//Fim do namespace ExcecoesPersonalizadas.Exceptions
