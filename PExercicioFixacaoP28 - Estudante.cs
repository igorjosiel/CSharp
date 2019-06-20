//Utilizando o namespace ExercicioFixacao_28
namespace ExercicioFixacao_28
{
    //Classe Estudante
    class Estudante
    {
        //Atributos da classe do tipo string com suas devidas auto propriedades get e set
        public string Nome { get; set; }
        public string Email { get; set; }

        //Método construtor com dois parâmetros como entrada
        public Estudante(string nome, string email)
        {
            //Atribui os valores dos parâmetros aos atributos do objeto usando a palavra-chave this
            this.Nome = nome;
            this.Email = email;

        }//Fim do método construtor com dois parâmetros

        //Método sendo sobrescrito com a palavra-chave override do tipo string que retorna ao método chamador a representação do objeto na forma de string
        public override string ToString()
        {
            //Retorna a frase abaixo com os devidos valores dos atributos do objeto
            return "Nome: " + this.Nome + " - Email: " + this.Email + ".\n";

        }//Fim do método ToString

    }//Fim da classe Estudantes
}//Fim do namespace ExercicioFixacao_28
