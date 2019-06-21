//Utilizando o namespace Composicao.Entities
namespace Composicao.Entities
{
    //Classe Departament
    class Departament
    {
        //Atributo da classe do tipo string com suas auto propriedades get e set
        public string Name { get; set; }

        //Declarando método construtor padrão sem entrada de argumentos
        public Departament ()
        {
        }//Fim do método construtor padrão sem parâmetros

        //Declarando método construtor com um entrada de argumento
        public Departament (string name)
        {
            //Atribuindo ao atributo Name da classe com a palavra-chave this o valor passado para o parâmetro no construtor
            this.Name = name;

        }//Fim do método construtor com um parâmetro

    }//Fim da classe Departament
}//Fim do namespace Composicao.Entities
