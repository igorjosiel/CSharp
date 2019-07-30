//Usando o namespace XadrezConsole.TabuleiroXadrez
using XadrezConsole.TabuleiroXadrez;

//Utilizando o namespace XadrezConsole.Xadrez
namespace XadrezConsole.Xadrez
{
    //Classe Rei herdando ou extendendo da classe Peca com o operador (:)
    class Rei : Peca
    {
        //Declarando um atributo da classe do tipo PartidaDeXadrez private
        private PartidaDeXadrez Partida;

        //Método construtor com entrada de argumentos dos tipos Tabuleiro, Cor e PartidaDeXadrez, reaproveitando o código-fonte do construtor da superclasse Peca com a palavra-chave base
        public Rei (Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base (tab, cor)
        {
            //Atribuindo ao atributo da classe Partida o valor passado como argumento para o parâmetro do método
            this.Partida = partida;

        }//Fim da método construtor com entrada de argumentos

        //Método ToString do tipo string sendo sobrescrito ou sobreposto com a palavra-chave override
        public override string ToString()
        {
            //Retorna ao método chamador o caracter abaixo
            return "R";

        }//Fim do método sobrescrito ToString

        //Método do tipo bool private recebendo como argumento um valor do tipo Posicao
        private bool PodeMover (Posicao pos)
        {
            //Declarando variável do tipo Peca e atribuindo à mesma o resultado da chamada ao método Peca do objeto Tab
            Peca p = Tab.Peca(pos);

            //Retorna ao método chamador a variável p se a mesma for igual a null ou a cor da mesma for diferente da do objeto em questão
            return p == null || p.Cor != Cor;

        }//Fim do método PodeMover

        //Método do tipo bool private recebendo como argumento um valor do tipo Posicao
        private bool TesteTorreParaRoque(Posicao pos)
        {
            //Declarando variável do tipo Peca e atribuindo à mesma o resultado da chamada ao método Peca do objeto Tab
            Peca p = Tab.Peca(pos);

            //Retorna ao método chamador a variável p se a mesma for diferente de null, a variável p for do tipo Torre, com a palavra-chave is, a cor da mesma for igual da do objeto em questão e o valor do atributo QtdMovimentos for igual a 0
            return p != null && p is Torre && p.Cor == Cor && QtdMovimentos == 0;

        }//Fim do método TesteTorreParaRoque

        //Método do tipo bool sendo sobrescrito ou sobreposto com a palavra-chave override
        public override bool[,] MovimentosPossiveis()
        {
            //Declarando variável mat do tipo bool com a palavra-chave new, passando como argumento para o parâmetro da mesma os valores contidos nos atributos Linha e Coluna, respectivamente
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            //Declarando variável do tipo Posicao com a palavra-chave new inicializando-a com o valor (0, 0)
            Posicao pos = new Posicao(0, 0);

            //Posição acima
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha - 1, Posicao.Coluna)
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);

            //Método condicional if-else simples. Verifica se os métodos do atributo Tab, PosicaoValida e PodeMover, passando como argumentos para os mesmos, o valor da variável pos, resultam em true
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Nordeste
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha - 1, Posicao.Coluna + 1)
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

            //Método condicional if-else simples. Verifica se os métodos do atributo Tab PosicaoValida e PodeMover, passando como argumentos para os mesmos o valor da variável pos, resultam em true
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Direita
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha, Posicao.Coluna + 1)
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

            //Método condicional if-else simples. Verifica se os métodos do atributo Tab, PosicaoValida e PodeMover, passando como argumentos para os mesmos o valor da variável pos, resultam em true
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Sudeste
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha + 1, Posicao.Coluna + 1)
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

            //Método condicional if-else simples. Verifica se os métodos do atributo Tab, PosicaoValida e PodeMover passando como argumentos para os mesmos o valor da variável pos, resultam em true
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Abaixo
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha + 1, Posicao.Coluna)
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

            //Método condicional if-else simples. Verifica se os métodos do atributo Tab, PosicaoValida e PodeMover, passando como argumentos para os mesmos o valor da variável pos, resultam em true
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Sudoeste
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha + 1, Posicao.Coluna - 1)
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            //Método condicional if-else simples. Verifica se os métodos do atributo Tab, PosicaoValida e PodeMover, passando como argumentos para os mesmos o valor da variável pos, resultam em true
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Esquerda
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha, Posicao.Coluna - 1)
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

            //Método condicional if-else simples. Verifica se os métodos do atributo Tab, PosicaoValida e PodeMover, passando como argumentos para os mesmos o valor da variável pos, resultam em true
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //Noroeste
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha - 1, Posicao.Coluna - 1)
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            //Método condicional if-else simples. Verifica se os métodos do atributo Tab, PosicaoValida e PodeMover, passando como argumentos para os mesmos o valor da variável pos, resultam em true
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor true
                mat[pos.Linha, pos.Coluna] = true;

            }//Fim do comando if do método condicional if-else simples

            //#Jogadaespecial roque
            //Método condicional if-else simples. Verifica se o valor do atributo QtdMovimentos é igual a 0 e se o atributo Xeque da propriedade Partida é falso, com o operador de negação (!)
            if (QtdMovimentos == 0 && !Partida.Xeque)
            {
                //#Jogadaespecial roque pequeno
                //Declarando, instanciando e inicializando um objeto do tipo Posicao com a palavra-chave new, passando para o parâmetro do método construtor a expressão Posicao.Linha, Posicao.Coluna + 3 como argumento de entrada
                Posicao posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);

                //Método condicional if-else simples. Verifica se o método TesteTorreParaRoque do objeto criado anteriormente é verdadeiro
                if (TesteTorreParaRoque(posT1))
                {
                    //Declarando, instanciando e inicializando objetos do tipo Posicao com a palavra-chave new, passando para o parâmetro do método construtor a expressão Posicao.Linha, Posicao.Coluna + 1 ou Posicao.Coluna + 2, como argumentos de entrada
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                    //Método condicional if-else simples. Verifica se o valor do método Peca do atributo Tab dos objetos p1 e p2 são iguais a null
                    if (Tab.Peca(p1) == null && Tab.Peca(p2) == null)
                    {
                        //Atribuindo à variável mat na posição Posicao.Linha, Posicao.Coluna + 2 o valor booleano true
                        mat[Posicao.Linha, Posicao.Coluna + 2] = true;

                    }//Fim do comando if do método condicional if-else simples
                }//Fim do comando if do método condicional if-else simples    
                
            }//Fim do comando if do método condicional if-else simples

            //#Jogadaespecial roque grande
            //Método condicional if-else simples. Verifica se o valor do atributo QtdMovimentos é igual a 0 e se o atributo Xeque da propriedade Partida é falso, com o operador de negação (!)
            if (QtdMovimentos == 0 && !Partida.Xeque)
            {
                //#Jogadaespecial roque pequeno
                //Declarando, instanciando e inicializando um objeto do tipo Posicao com a palavra-chave new, passando para o parâmetro do método construtor a expressão Posicao.Linha, Posicao.Coluna - 4 como argumento de entrada
                Posicao posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);

                //Método condicional if-else simples. Verifica se o método TesteTorreParaRoque do objeto criado anteriormente é verdadeiro
                if (TesteTorreParaRoque(posT2))
                {
                    //Declarando, instanciando e inicializando objetos do tipo Posicao com a palavra-chave new, passando para o parâmetro do método construtor a expressão Posicao.Linha, Posicao.Coluna - 1 ou Posicao.Coluna - 2 ou Posicao.Coluna - 3, como argumentos de entrada
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                    //Método condicional if-else simples. Verifica se o valor do método Peca do atributo Tab dos objetos p1, p2 e p3 são iguais a null
                    if (Tab.Peca(p1) == null && Tab.Peca(p2) == null && Tab.Peca(p3) == null)
                    {
                        //Atribuindo à variável mat na posição Posicao.Linha, Posicao.Coluna - 2 o valor booleano true
                        mat[Posicao.Linha, Posicao.Coluna - 2] = true;

                    }//Fim do comando if do método condicional if-else simples
                }//Fim do comando if do método condicional if-else simples

            }//Fim do comando if do método condicional if-else simples

            //Retorna ao método chamador o valor da variável mat
            return mat;

        }//Fim do método MovimentosPossiveis

    }//Fim da classe Rei
}//Fim do namespace XadrezConsole.Xadrez
