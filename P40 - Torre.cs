//Usando o namespace XadrezConsole.TabuleiroXadrez
using XadrezConsole.TabuleiroXadrez;

//Utilizando o namespace XadrezConsole.Xadrez
namespace XadrezConsole.Xadrez
{
    //Classe Torre herdando ou extendendo da classe Peca com o operador (:)
    class Torre : Peca
    {
        //Método construtor com entrada de argumentos dos tipos Tabuleiro e Cor reaproveitando o código-fonte do construtor da superclasse Peca com a palavra-chave base
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }//Fim do método construtor com entrada de argumentos

        //Método ToString do tipo string sendo sobrescrito ou sobreposto com a palavra-chave override
        public override string ToString()
        {
            //Retorna ao método chamador o caracter abaixo
            return "T";

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

            //Posição acima
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha - 1, Posicao.Coluna)
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);

            //Método repetitivo while para repetir enquanto os métodos do atributo Tab, PosicaoValida e PodeMover passando como argumento para os parâmetros o valor da variável pos for verdadeiro em ambos os casos, com o operador lógico (&&)
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

                //Método condicional if-else simples. Verifica se a propriedade Peca do atributo Tab é diferente de null e a cor do objeto é diferente da do objeto em questão
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    //Interrompe a execução do método repetitivo while com a palavra-chave break
                    break;

                }//Fim do comando if do método condicional if-else simpels

                //Atribui à propriedade Linha da variável pos um decremento de 1
                pos.Linha = pos.Linha - 1;

            }//Fim do método repetitivo while

            //Ababixo
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha + 1, Posicao.Coluna)
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

            //Método repetitivo while para repetir enquanto os métodos do atributo Tab, PosicaoValida e PodeMover passando como argumento para os parâmetros o valor da variável pos for verdadeiro em ambos os casos, com o operador lógico (&&)
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

                //Método condicional if-else simples. Verifica se a propriedade Peca do atributo Tab é diferente de null e a cor do objeto é diferente da do objeto em questão
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    //Interrompe a execução do método repetitivo while com a palavra-chave break
                    break;

                }//Fim do comando if do método condicional if-else simpels

                //Atribui à propriedade Linha da variável pos um incremento de 1
                pos.Linha = pos.Linha + 1;

            }//Fim do método repetitivo while

            //Esquerda
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha, Posicao.Coluna + 1)
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

            //Método repetitivo while para repetir enquanto os métodos do atributo Tab, PosicaoValida e PodeMover, passando como argumento para os parâmetros o valor da variável pos for verdadeiro em ambos os casos, com o operador lógico (&&)
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

                //Método condicional if-else simples. Verifica se a propriedade Peca do atributo Tab é diferente de null e a cor do objeto é diferente da do objeto em questão
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    //Interrompe a execução do método repetitivo while com a palavra-chave break
                    break;

                }//Fim do comando if do método condicional if-else simpels

                //Atribui à propriedade Coluna da variável pos um incremento de 1
                pos.Coluna = pos.Coluna + 1;

            }//Fim do método repetitivo while

            //Direita
            //Acionando o método DefinirValores da variável pos passando como argumento para o parâmetro a expressão (Posicao.Linha, Posicao.Coluna - 1)
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

            //Método repetitivo while para repetir enquanto os métodos do atributo Tab, PosicaoValida e PodeMover, passando como argumento para os parâmetros o valor da variável pos for verdadeiro em ambos os casos, com o operador lógico (&&)
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //Variável mat na posição [pos.Linha, pos.Coluna] recebe o valor booleano true
                mat[pos.Linha, pos.Coluna] = true;

                //Método condicional if-else simples. Verifica se a propriedade Peca do atributo Tab é diferente de null e a cor do objeto é diferente da do objeto em questao
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    //Interrompe a execução do método repetitivo while com a palavra-chave break
                    break;

                }//Fim do comando if do método condicional if-else simpels

                //Atribui à propriedade Coluna da variável pos um decremento de 1
                pos.Coluna = pos.Coluna - 1;

            }//Fim do método repetitivo while

            //Retorna ao método chamador o valor da variável mat
            return mat;

        }//Fim do método MovimentosPossiveis

    }//Fim da classe Torre
}//Fim do namespace XadrezConsole.Xadrez
