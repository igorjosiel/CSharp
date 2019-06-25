//Usando o namespace StringBuilder2.Entities
namespace StringBuilder2.Entities
{
    //Classe Comment
    class Comment
    {
        //Atributo da classe do tipo string com suas propriedades get e set
        public string Text { get; set; }

        //Declarando método construtor padrão sem entrada de argumentos
        public Comment ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Declarando método construtor com entrada de um argumento do tipo string
        public Comment (string text)
        {
            //Atributo da classe sendo inicializado com a palavra-chave this com valor passado como argumento para o parâmetro do método
            this.Text = text;

        }//Fim do método construtor com entrada de um argumento

    }//Fim da classe Comment
}//Fim do namespace StringBuilder2.Entities
