//Usando o namespace XadrezConsole.TabuleiroXadrez
namespace XadrezConsole.TabuleiroXadrez
{
    //Classe Posicao
    class Posicao
    {
        //Atributos da classe do tipo int com suas propriedades get e set
        public int Linha { get; set; }
        public int Coluna { get; set; }

        //Método construtor com entrada de argumentos do tipo int
        public Posicao (int linha, int coluna)
        {
            //Atribuindo aos atributos da classe com a palavra-chave this os valores passados como argumentos para os parâmetros do método
            this.Linha = linha;
            this.Coluna = coluna;

        }//Fim do método construtor com entrada de argumentos

        //Método ToString sendo sobrescrito ou sobreposto com a palavra-chave override
        public override string ToString()
        {
            //Retorna ao método chamador os valores dos atributos Linha e Coluna com o fragmento de frase
            return Linha + ", " + Coluna;

        }//Fim do método ToString

        //Método do tipo void com entada de argumentos dos tipos int
        public void DefinirValores (int linha, int coluna)
        {
            //Atribuindo aos atributos da classe com a palavra-chave this os valores passados como argumentos para os parâmetros do método
            this.Linha = linha;
            this.Coluna = coluna;

        }//Fim do método DefinirValores

    }//Fim da classe Posicao
}//Fim do namespace XadrezConsole.TabuleiroXadrez
