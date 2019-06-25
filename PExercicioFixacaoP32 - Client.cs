//Usando os namespaces System e System.Collections.Generic
using System;
using System.Collections.Generic;

//Utilizando o namespace ExercicioFixacao_32.Entities
namespace ExercicioFixacao_32.Entities
{
    //Classe Client
    class Client
    {
        //Atributos da classe dos tipos string e DateTime com suas propriedades get e set
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        //Declarando método construtor padrão sem entrada de argumentos
        public Client ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Declarando método construtor com entrada de argumentos dos tipos string e DateTime
        public Client (string name, string email, DateTime birthDate)
        {
            //Atribuindo aos atributos da classe os valores passados como argumentos para os parâmetros do método construtor usando a palavra-chave this
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;

        }//Fim do método construtor com entrada de argumentos

    }//Fim da classe Client
}//Fim do namespace ExercicioFixacao_32.Entities
