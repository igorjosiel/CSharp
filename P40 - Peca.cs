//Usando o namespace XadrezConsole.TabuleiroXadrez
namespace XadrezConsole.TabuleiroXadrez
{
    //Classe Peca abstrata. Significa que a mesma não poderá ser instanciada. Apenas suas subclasses
    abstract class Peca
    {
        //Atributos da classe dos tipos Posicao (Uma associação de classes : Peca e Posicao), Cor (Tipo enum), int e Tabuleiro (Uma associação de classes: Peca e Tabuleiro), com suas propriedades get e set e protected set (Significa que podem ser acessados apenas pela mesma classe ou pelas subclasses)
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        //Método construtor recebendo como entrada de argumentos para os parâmetros os tipos Tabuleiro e Cor
        public Peca (Tabuleiro tab, Cor cor)
        {
            //Atribuindo aos atributos da classe os valores null e passados como argumento para os parâmetros do método, com a palavra-chave this
            this.Posicao = null;
            this.Tab = tab;
            this.Cor = cor;

            //Atributo QtdMovimentos é iniciado com o valor 0
            this.QtdMovimentos = 0;

        }//Fim do método construtor com entrada de argumentos

        //Método do tipo bool sem entrada de argumentos
        public bool ExisteMovimentosPossiveis ()
        {
            //Declarando variável do tipo bool e sendo atribuída com o valor do método MovimentosPossiveis
            bool[,] mat = MovimentosPossiveis();

            //Método repetitivo for externo para repetir enquanto o valor da variável recém-criada i for menor do que o valor do atributo Linhas de Tab
            for (int i = 0; i < Tab.Linhas; i ++)
            {
                //Método repetitivo for interno para repetir enquanto o valor da variável recém-criada j for menor do que o valor do atributo Colunas de Tab
                for (int j = 0; j < Tab.Colunas; j ++)
                {
                    //Método condicional if-else simples. Verifica se a variável mat na posição [i, j] é igual a true
                    if (mat[i, j])
                    {
                        //Retornando ao método chamador o valor true
                        return true;

                    }//Fim do comando if do método condicional if-else simples

                }//Fim do método repetitivo for interno

            }//Fim do método repetitivo for externo

            //Retornando ao método chamador o valor false
            return false;

        }//Fim do método ExisteMovimentosPossiveis

        //Método do tipo void sem entrada de argumentos
        public void IncrementarQtdMovimentos ()
        {
            //Incrementa 1 ao atributo QtdMovimentos
            QtdMovimentos++;

        }//Fim do método IncrementarQtdMovimentos

        //Método do tipo void sem entrada de argumentos
        public void DecrementarQtdMovimentos()
        {
            //Decrementa 1 ao atributo QtdMovimentos
            QtdMovimentos--;

        }//Fim do método DecrementarQtdMovimentos

        //Método do tipo bool abstrato. Significa que o mesmo não tem implementação na classe, apenas nas subclasses da mesma
        public abstract bool[,] MovimentosPossiveis();

        //Método do tipo bool recebendo como argumento um valor do tipo Posicao
        public bool MovimentoPossivel (Posicao pos)
        {
            //Retornando ao método chamador o valor do método MovimentosPossiveis na posição [pos.Linha, pos.Coluna]
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];

        }//Fim do método MovimentosPossiveis

    }//Fim da classe Peca
}//Fim do namespace XadrezConsole.TabuleiroXadrez
