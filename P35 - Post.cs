//Utilizando os namespaces System, System.Collections.Generic e System.Text
using System;
using System.Collections.Generic;
using System.Text;

//Usando o namespace StringBuilder2.Entities
namespace StringBuilder2.Entities
{
    //Classe Post
    class Post
    {
        //Atributos da classe dos tipos DateTime, string e int com suas propriedades get e set
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        //Declarando uma lista do tipo Comment com suas propriedades get e set e sendo iniciada com a palavra-chave new
        public List<Comment> Comments { get; set; } = new List<Comment>();

        //Declarando método construtor padrão sem entrada de argumentos
        public Post ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Declarando método construtor com entrada de quatro argumentos dos tipos DateTime, string e int
        public Post (DateTime moment, string title, string content, int likes)
        {
            //Atributos da classe sendo inicializados com a palavra-chave this com os valores passados como argumentos para o parâmetro
            this.Moment = moment;
            this.Title = title;
            this.Content = content;
            this.Likes = likes;

        }//Fim do método construtor com entrada de quatro argumentos

        //Método do tipo void AddComment recebendo como argumento um objeto do tipo Comment
        public void AddComment (Comment comment)
        {
            //Acionando o método Add da lista para adicionar o objeto do tipo Comment passado como argumento para o parâmetro do método
            Comments.Add(comment);

        }//Fim do método AddComment

        //Método do tipo void RemoveComment recebendo como argumento um objeto do tipo Comment
        public void RemoveComment (Comment comment)
        {
            //Acionando o método Remove da lista para remover o objeto do tipo Comment passado como argumento para o parâmetro do método
            Comments.Remove(comment);

        }//Fim do método RemoveComment

        //Método ToString do tipo string sendo sobrescrito com a palavra-chave override
        public override string ToString()
        {
            //Declarando um objeto do tipo StringBuilder para criar uma string com base nas informações (propriedades) do Post
            StringBuilder sb = new StringBuilder();

            //Acionando os métodos AppendLine e Append do objeto criado do tipo StringBuilder para adicionar strings ao StringBuilder
            //Append: Adiciona mais string ao final do StringBuilder. AppendLine: Adiciona mais string ao final do StringBuilder e salta para a próxima linha
            //Adicionando os valores dos atributos Title e Likes à StringBuilder
            sb.AppendLine(Title);
            sb.Append(Likes);

            //Adicionando uma cadeia de caracteres
            sb.Append(" Likes - ");

            //Adicionando o valor do atributo Moment com o método ToString para formatar o valor de acordo com o argumento especificado
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));

            //Adicionando o valor do atributo Content
            sb.AppendLine(Content);

            //Adicionando uma cadeia de caracteres
            sb.AppendLine("Comments: ");

            //Método repetitivo foreach para iterar pela lista para adicionar cada elemento da mesma à StringBuilder
            foreach (Comment c in Comments)
            {
                //Adicionando à StringBuilder o valor do atributo Text do elemento c da lista
                sb.AppendLine(c.Text);

            }//Fim do método repetitivo foreach

            //Retorna ao método chamador toda a string criada em StringBuilder através do método ToString do objeto sb
            return sb.ToString();

        }//Fim do método ToString

    }//Fim da classe Post
}//Fim do namespace StringBuilder2.Entities
