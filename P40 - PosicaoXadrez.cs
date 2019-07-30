//Usando o namespace XadrezConsole.TabuleiroXadrez
using XadrezConsole.TabuleiroXadrez;

//Utilizando o namespace XadrezConsole.Xadrez
namespace XadrezConsole.Xadrez
{
    //Classe PosicaoXadrez
    class PosicaoXadrez
    {
        //Atributos da classe dos tipos int e char com suas propriedades get e set
        public char Coluna { get; set; }
        public int Linha { get; set; }

        //Método construtor com entrada de argumentos dos tipos char e int
        public PosicaoXadrez(char coluna, int linha)
        {
            //Atribuindo aos atributos da classe os valores das variáveis passados como argumento para o parâmetro do método
            this.Coluna = coluna;
            this.Linha = linha;

        }//Fim do método construtor

        //Método do tipo Posicao sem entrada de argumento
        public Posicao ToPosicao()
        {
            //Retorna ao método chamador uma nova instância do tipo Posicao com a palavra-chave new, passando como argumento para o parâmetro o valor da expressão: (8 - Linha, Coluna - 'a')
            return new Posicao(8 - Linha, Coluna - 'a');

        }//Fim do método ToPosicao

        //Método do tipo string sendo sobrescrito ou sobreposto com a palavra-chave override
        public override string ToString()
        {
            //Retorna ao método chamador a string contendo os valores dos atributos Coluna e Linha
            return "" + Coluna + Linha;

        }//Fim do método ToString

    }//Fim da classe PosicaoXadrez
}//Fim do namespace XadrezConsole.Xadrez
