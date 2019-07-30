//Usando o namespace XadrezConsole.TabuleiroXadrez
using XadrezConsole.TabuleiroXadrez;

//Utilizando o namespace XadrezConsole.Xadrez
namespace XadrezConsole.Xadrez
{
    //Classe Bispo herdando ou extendendo da classe Peca com o operador (:)
    class Bispo : Peca
    {
        //Método construtor com entrada de argumentos dos tipos Tabuleiro e Cor reaproveitando o código-fonte do construtor da superclasse Peca com a palavra-chave base
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }//Fim da método construtor com entrada de argumentos

        //Método ToString do tipo string sendo sobrescrito ou sobreposto com a palavra-chave override
        public override string ToString()
        {
            //Retorna ao método chamador o caracter abaixo
            return "B";

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

            //Noroeste
            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha - 1, Posicao.Coluna - 1)
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            //Método repetitivo while para repetir enquanto a expressão Tab.PosicaoValida(pos) && PodeMover(pos) for verdadeira. Ou seja, significa que a posição pos pode mover
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

                //Método condicional if-else simples. Verifica se a expressão Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor é verdadeira. Ou seja, significa que a posição pos da peça Peca do tabuleiro Tab é diferente de nulo com o operador (!=) e a palavra-chave null e se a posição pos da peça Peca do tabuleiro Tab possui uma cor diferente da cor do sistema
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    //Palavra-chave break para interromper o método repetitivo while
                    break;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos passando como argumento os valores pos.Linha - 1, pos.Coluna - 1 para o parâmetro do método
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);

            }//Fim do método repetitivo while

            //Nordeste
            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha - 1, Posicao.Coluna + 1)
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

            //Método repetitivo while para repetir enquanto a expressão Tab.PosicaoValida(pos) && PodeMover(pos) for verdadeira. Ou seja, significa que a posição pos pode mover
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

                //Método condicional if-else simples. Verifica se a expressão Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor é verdadeira. Ou seja, significa que a posição pos da peça Peca do tabuleiro Tab é diferente de nulo com o operador (!=) e a palavra-chave null e se a posição pos da peça Peca do tabuleiro Tab possui uma cor diferente da cor do sistema
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    //Palavra-chave break para interromper o método repetitivo while
                    break;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos passando como argumento os valores pos.Linha - 1, pos.Coluna + 1 para o parâmetro do método
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);

            }//Fim do método repetitivo while

            //Sudeste
            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha + 1, Posicao.Coluna + 1)
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

            //Método repetitivo while para repetir enquanto a expressão Tab.PosicaoValida(pos) && PodeMover(pos) for verdadeira. Ou seja, significa que a posição pos pode mover
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

                //Método condicional if-else simples. Verifica se a expressão Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor é verdadeira. Ou seja, significa que a posição pos da peça Peca do tabuleiro Tab é diferente de nulo com o operador (!=) e a palavra-chave null e se a posição pos da peça Peca do tabuleiro Tab possui uma cor diferente da cor do sistema
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    //Palavra-chave break para interromper o método repetitivo while
                    break;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos passando como argumento os valores pos.Linha + 1, pos.Coluna + 1 para o parâmetro do método
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);

            }//Fim do método repetitivo while

            //Sudoeste
            //Acionando o método DefinirValores da variável pos recebendo como argumento para o parâmetro a expressão (Posicao.Linha + 1, Posicao.Coluna - 1)
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            //Método repetitivo while para repetir enquanto a expressão Tab.PosicaoValida(pos) && PodeMover(pos) for verdadeira. Ou seja, significa que a posição pos pode mover
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

                //Método condicional if-else simples. Verifica se a expressão Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor é verdadeira. Ou seja, significa que a posição pos da peça Peca do tabuleiro Tab é diferente de nulo com o operador (!=) e a palavra-chave null e se a posição pos da peça Peca do tabuleiro Tab possui uma cor diferente da cor do sistema
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    //Palavra-chave break para interromper o método repetitivo while
                    break;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos passando como argumento os valores pos.Linha + 1, pos.Coluna - 1 para o parâmetro do método
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);

            }//Fim do método repetitivo while            

            //Retorna ao método chamador a matriz mat
            return mat;

        }//Fim do método MovimentosPossiveis

    }//Fim da classe Bispo
}//Fim do namespace XadrezConsole.Xadrez