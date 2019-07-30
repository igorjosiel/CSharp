//Usando o namespace XadrezConsole.TabuleiroXadrez
using XadrezConsole.TabuleiroXadrez;

//Utilizando o namespace XadrezConsole.Xadrez
namespace XadrezConsole.Xadrez
{
    //Classe Peao herdando ou extendendo da classe Peca com o operador (:)
    class Peao : Peca
    {
        //Declarando atributo da classe do tipo PartidaDeXadrez private
        private PartidaDeXadrez Partida;

        //Método construtor com entrada de argumentos dos tipos Tabuleiro, Cor e PartidaDeXadrez reaproveitando o código-fonte do construtor da superclasse Peca com a palavra-chave base
        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            //Atribuindo ao atributo Partida o valor passado como argumento para o parâmetro do método
            this.Partida = partida;

        }//Fim do método construtor com entrada de argumentos

        //Método ToString do tipo string sendo sobrescrito ou sobreposto com a palavra-chave override
        public override string ToString()
        {
            //Retorna ao método chamador o caracter abaixo
            return "P";

        }//Fim do método sobrescrito ToString

        //Método do tipo bool private recebendo como argumento um valor do tipo Posicao
        private bool ExisteInimigo(Posicao pos)
        {
            //Declarando variável do tipo Peca e atribuindo à mesma o resultado da chamada ao método Peca do objeto Tab
            Peca p = Tab.Peca(pos);

            //Retorna ao método chamador a variável p se a mesma for diferente de null e a cor da mesma for diferente da do objeto em questão
            return p != null && p.Cor != Cor;

        }//Fim do método ExisteInimigo

        //Método do tipo bool private recebendo como argumento um valor do tipo Posicao
        private bool Livre(Posicao pos)
        {
            //Retorna ao método chamador a posição pos da peça Peca do tabuleiro Tab igual ao valor booleano null
            return Tab.Peca(pos) == null;

        }//Fim do método Livre

        //Método do tipo bool sendo sobrescrito ou sobreposto com a palavra-chave override
        public override bool[,] MovimentosPossiveis()
        {
            //Declarando variável mat do tipo bool com a palavra-chave new, passando como argumento para o parâmetro da mesma os valores contidos nos atributos Linha e Coluna, respectivamente
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            //Declarando variável do tipo Posicao com a palavra-chave new inicializando-a com o valor (0, 0)
            Posicao pos = new Posicao(0, 0);

            //Método condicional if-else composto. Verifica se o valor do atributo Cor é igual ao valor Branca. Se for, executa o bloco de instruções abaixo. Se não, vai para o próximo teste
            if (Cor == Cor.Branca)
            {
                //Acionando o método DefinirValores da variável pos do tipo Posicao, passando como argumento para o parâmetro do método a expressão Posicao.Linha - 1, Posicao.Coluna
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);

                //Método condicional if-else simples. Testa se a posição pos no tabuleiro Tab é válida e se a posição pos está livre, através do método Livre
                if (Tab.PosicaoValida(pos) && Livre(pos))
                {
                    //Variável mat na posição pos.Linha, pos.Coluna recebe o valor booleano true
                    mat[pos.Linha, pos.Coluna] = true;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos do tipo Posicao, passando como argumento para o parâmetro do método a expressão Posicao.Linha - 2, Posicao.Coluna
                pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);

                //Método condicional if-else simples. Testa se a posição pos no tabuleiro Tab é válida e se a posição pos está livre, através do método Livre e se o valor do atributo QtdMovimentos é igual ao valor 0
                if (Tab.PosicaoValida(pos) && Livre(pos) && QtdMovimentos == 0)
                {
                    //Variável mat na posição pos.Linha, pos.Coluna recebe o valor booleano true
                    mat[pos.Linha, pos.Coluna] = true;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos do tipo Posicao, passando como argumento para o parâmetro do método a expressão Posicao.Linha - 1, Posicao.Coluna - 1
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

                //Método condicional if-else simples. Testa se a posição pos no tabuleiro Tab é válida e se nessa posição existe algum inimigo, através do método ExisteInimigo
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    //Variável mat na posição pos.Linha, pos.Coluna recebe o valor booleano true
                    mat[pos.Linha, pos.Coluna] = true;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos do tipo Posicao, passando como argumento para o parâmetro do método a expressão Posicao.Linha - 1, Posicao.Coluna + 1
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

                //Método condicional if-else simples. Testa se a posição pos no tabuleiro Tab é válida e se nessa posição existe algum inimigo, através do método ExisteInimigo
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    //Variável mat na posição pos.Linha, pos.Coluna recebe o valor booleano true
                    mat[pos.Linha, pos.Coluna] = true;

                }//Fim do comando if do método condicional if-else simples

                //# Jogadaespecial Enpassant
                //Método condicional if-else simples. Testa se o valor do atributo Linha da posição Posicao é igual ao valor 3. Se for, executa o bloco de instruções abaixo
                if (Posicao.Linha == 3)
                {
                    //Declarando, instanciando e inicializando uma variável do tipo Posicao com a palavra chave new, passando como argumento para o parâmetro do método a expressão Posicao.Linha, Posicao.Coluna - 1
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);

                    //Método condicional if-else simples. Testa se a expressão Tab.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tab.Peca(esquerda) == Partida.VulneravelEmPassant é verdadeira. Se for, executa o bloco de instruções abaixo
                    if (Tab.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tab.Peca(esquerda) == Partida.VulneravelEmPassant)
                    {
                        //Atribuindo à variável mat na posição esquerda.Linha - 1, esquerda.Coluna o valor booleano true
                        mat[esquerda.Linha - 1, esquerda.Coluna] = true;

                    }//Fim do comando if do método condicional if-else simples

                    //Declarando, instanciando e inicializando uma variável do tipo Posicao com a palavra chave new, passando como argumento para o parâmetro do método a expressão Posicao.Linha, Posicao.Coluna - 1
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);

                    //Método condicional if-else simples. Testa se a expressão Tab.PosicaoValida(direita) && ExisteInimigo(direita) && Tab.Peca(direita) == Partida.VulneravelEmPassant é verdadeira. Se for, executa o bloco de instruções abaixo
                    if (Tab.PosicaoValida(direita) && ExisteInimigo(direita) && Tab.Peca(direita) == Partida.VulneravelEmPassant)
                    {
                        //Atribuindo à variável mat na posição direita.Linha - 1, direita.Coluna o valor booleano true
                        mat[direita.Linha - 1, direita.Coluna] = true;

                    }//Fim do comando if do método condicional if-else simples

                }//Fim do comando if do método condicional if-else simples

                //Retorna ao método chamador o valor da variável mat
                return mat;

            }//Fim do comando if do método condicional if-else simples

            //Se a condição anterior if for falsa, executa o bloco de instruções do comando else abaixo
            else
            {
                //Acionando o método DefinirValores da variável pos do tipo Posicao, passando como argumento para o parâmetro do método a expressão Posicao.Linha + 1, Posicao.Coluna
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

                //Método condicional if-else simples. Testa se a posição pos no tabuleiro Tab é válida e se a posição pos está livre, através do método Livre
                if (Tab.PosicaoValida(pos) && Livre(pos))
                {
                    //Variável mat na posição pos.Linha, pos.Coluna recebe o valor booleano true
                    mat[pos.Linha, pos.Coluna] = true;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos do tipo Posicao, passando como argumento para o parâmetro do método a expressão Posicao.Linha + 2, Posicao.Coluna
                pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);

                //Método condicional if-else simples. Testa se a posição pos no tabuleiro Tab é válida e se a posição pos está livre, através do método Livre e se o valor do atributo QtdMovimentos é igual ao valor 0
                if (Tab.PosicaoValida(pos) && Livre(pos) && QtdMovimentos == 0)
                {
                    //Variável mat na posição pos.Linha, pos.Coluna recebe o valor booleano true
                    mat[pos.Linha, pos.Coluna] = true;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos do tipo Posicao, passando como argumento para o parâmetro do método a expressão Posicao.Linha + 1, Posicao.Coluna - 1
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

                //Método condicional if-else simples. Testa se a posição pos no tabuleiro Tab é válida e se nessa posição existe algum inimigo, através do método ExisteInimigo
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    //Variável mat na posição pos.Linha, pos.Coluna recebe o valor booleano true
                    mat[pos.Linha, pos.Coluna] = true;

                }//Fim do comando if do método condicional if-else simples

                //Acionando o método DefinirValores da variável pos do tipo Posicao, passando como argumento para o parâmetro do método a expressão Posicao.Linha + 1, Posicao.Coluna + 1
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

                //Método condicional if-else simples. Testa se a posição pos no tabuleiro Tab é válida e se nessa posição existe algum inimigo, através do método ExisteInimigo
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    //Variável mat na posição pos.Linha, pos.Coluna recebe o valor booleano true
                    mat[pos.Linha, pos.Coluna] = true;

                }//Fim do comando if do método condicional if-else simples

                //# Jogadaespecial Enpassant
                //Método condicional if-else simples. Testa se o valor do atributo Linha da posição Posicao é igual ao valor 4. Se for, executa o bloco de instruções abaixo
                if (Posicao.Linha == 4)
                {
                    //Declarando, instanciando e inicializando uma variável do tipo Posicao com a palavra chave new, passando como argumento para o parâmetro do método a expressão Posicao.Linha, Posicao.Coluna - 1
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);

                    //Método condicional if-else simples. Testa se a expressão Tab.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tab.Peca(esquerda) == Partida.VulneravelEmPassant é verdadeira. Se for, executa o bloco de instruções abaixo
                    if (Tab.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tab.Peca(esquerda) == Partida.VulneravelEmPassant)
                    {
                        //Atribuindo à variável mat na posição esquerda.Linha + 1, esquerda.Coluna o valor booleano true
                        mat[esquerda.Linha + 1, esquerda.Coluna] = true;

                    }//Fim do comando if do método condicional if-else simples

                    //Declarando, instanciando e inicializando uma variável do tipo Posicao com a palavra chave new, passando como argumento para o parâmetro do método a expressão Posicao.Linha, Posicao.Coluna + 1
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);

                    //Método condicional if-else simples. Testa se a expressão Tab.PosicaoValida(direita) && ExisteInimigo(direita) && Tab.Peca(direita) == Partida.VulneravelEmPassant é verdadeira. Se for, executa o bloco de instruções abaixo
                    if (Tab.PosicaoValida(direita) && ExisteInimigo(direita) && Tab.Peca(direita) == Partida.VulneravelEmPassant)
                    {
                        //Atribuindo à variável mat na posição direita.Linha + 1, direita.Coluna o valor booleano true
                        mat[direita.Linha + 1, direita.Coluna] = true;

                    }//Fim do comando if do método condicional if-else simples

                }//Fim do comando else do método condicional if-else composto

                //Retorna ao método chamador o valor da variável mat
                return mat;

            }//Fim do método MovimentosPossiveis

        }//Fim da classe Bispo
    }//Fim do namespace XadrezConsole.Xadrez
}