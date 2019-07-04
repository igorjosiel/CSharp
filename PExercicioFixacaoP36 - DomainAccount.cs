//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao_36.Exception
namespace ExercicioFixacao_36.Exceptions
{
    //Classe DomainAccount herdando ou extendendo da superclasse ApplicationException, que é uma subclasse da superclasse Exceptions, que é usada para criação de exceções de tratamento personalizada
    class DomainAccount : ApplicationException
    {
        //Método construtor com entrada de argumento do tipo string reutilizando o código-fonte do método construtor da superclasse ApplicationException, usando a palavra-chave base
        public DomainAccount (string message) : base (message)
        {
        }//Fim do método construtor com entrada de argumento

    }//Fim da classe DomainAccount
}//Fim do namespace ExercicioFixacao_36.Exception
