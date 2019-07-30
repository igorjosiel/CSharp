//Usando o namespace XadrezConsole.TabuleiroXadrez
using XadrezConsole.TabuleiroXadrez;

//Utilizando o namespace XadrezConsole.Xadrez
namespace XadrezConsole.Xadrez
{
    //Classe Cavalo herdando ou extendendo da classe Peca com o operador (:)
    class Cavalo : Peca
    {
        //Método construtor com entrada de argumentos dos tipos Tabuleiro e Cor reaproveitando o código-fonte do construtor da superclasse Peca com a palavra-chave base
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }//Fim do método construtor com entrada de argumentos

        //Método ToString do tipo string sendo sobrescrito ou sobreposto com a palavra-chave override
        public override string ToString()
        {
            //Retorna ao método chamador o caracter abaixo
            return "C";

        }//Fim do método sobrescrito ToString

        //Método do tipo bool private recebendo como argumento um valor do tipo Posicao
        private bool PodeMover(Posicao pos)
        {
            //Declarando variável do tipo Peca e atribuindo à mesma o resultado da chamada ao método Peca do objeto Tab
            Peca p = Tab.Peca(pos);

            //Retorna ao método chamador a variável p se a mesma for igual a null ou a cor da mesma for diferente da do objeto em questão
            return p == null || p.Cor != Cor;

        }//Fim do método PodeMover

        //Método do tipo bool sendo sobrescrito ou sobreposto com a palavra-chave override
        public override bool[,] MovimentosPossiveis()
        {
            //Declarando variável mat do tipo bool com a palavra-chave new, passando como argumento para o parâmetro da mesma os valores contidos nos atributos Linha e Coluna, respectivamente
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            //Declarando variável do tipo Posicao com a palavra-chave new inicializando-a com o valor (0, 0)
            Posicao pos = new Posicao(0, 0);

            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha - 1, Posicao.Coluna - 2)
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);

            //Método condicional if-else simples. Verifica se a posição pos no tabuleiro Tab é válida, usando para isso o método PosicaoValida. E se a posição pos pode mover através do método PodeMover
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha - 2, Posicao.Coluna - 1)
            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna - 1);

            //Método condicional if-else simples. Verifica se a posição pos no tabuleiro Tab é válida, usando para isso o método PosicaoValida. E se a posição pos pode mover através do método PodeMover
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha - 2, Posicao.Coluna + 1)
            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna + 1);

            //Método condicional if-else simples. Verifica se a posição pos no tabuleiro Tab é válida, usando para isso o método PosicaoValida. E se a posição pos pode mover através do método PodeMover
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha - 1, Posicao.Coluna + 2)
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 2);

            //Método condicional if-else simples. Verifica se a posição pos no tabuleiro Tab é válida, usando para isso o método PosicaoValida. E se a posição pos pode mover através do método PodeMover
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha + 1, Posicao.Coluna + 2)
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 2);

            //Método condicional if-else simples. Verifica se a posição pos no tabuleiro Tab é válida, usando para isso o método PosicaoValida. E se a posição pos pode mover através do método PodeMover
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha + 2, Posicao.Coluna + 1)
            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna + 1);

            //Método condicional if-else simples. Verifica se a posição pos no tabuleiro Tab é válida, usando para isso o método PosicaoValida. E se a posição pos pode mover através do método PodeMover
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha + 2, Posicao.Coluna - 1)
            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna - 1);

            //Método condicional if-else simples. Verifica se a posição pos no tabuleiro Tab é válida, usando para isso o método PosicaoValida. E se a posição pos pode mover através do método PodeMover
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha + 1, Posicao.Coluna - 2)
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 2);

            //Método condicional if-else simples. Verifica se a posição pos no tabuleiro Tab é válida, usando para isso o método PosicaoValida. E se a posição pos pode mover através do método PodeMover
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Retorna ao método chamador o valor da variável mat
            return mat;

        }//Fim do método MovimentosPossiveis

    }//Fim da classe Bispo
}//Fim do namespace XadrezConsole.Xadrez
