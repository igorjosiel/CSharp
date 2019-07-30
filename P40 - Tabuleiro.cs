//Usando o namespace XadrezConsole.TabuleiroXadrez
namespace XadrezConsole.TabuleiroXadrez
{
    //Classe Tabuleiro
    class Tabuleiro
    {
        //Atributos da classe do tipo int com suas propriedades get e set
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        //Declarando uma matriz private chamada Pecas do tipo Peca
        private Peca[,] Pecas;

        //Método construtor com entrada de argumentos para o parâmetro do método do tipo int
        public Tabuleiro (int linhas, int colunas)
        {
            //Atribuindo aos atributos da classe com a palavra-chave this os valores passados como argumentos para os parâmetros do método
            this.Linhas = linhas;
            this.Colunas = colunas;

            //Instanciando uma matriz com a palavra-chave new passando para o construtor os valores passados como argumentos para o parâmetro do método
            Pecas = new Peca[Linhas, Colunas];

        }//Fim do método construtor com entrada de argumentos

        //Método do tipo Peca recebendo como argumento para o parâmetro do método valores do tipo int
        public Peca Peca (int linha, int coluna)
        {
            //Retorna ao método chamador a matriz Pecas na posicao [linha, coluna], conforme os valores passados como argumentos para o parâmetro do método
            return Pecas[linha, coluna];

        }//Fim do método Peca

        //Sobrecarga do método Peca do tipo Peca recebendo um valor do tipo Posicao como argumento para o parâmetro do método
        public Peca Peca (Posicao pos)
        {
            //Retorna ao método chamador a matriz na posição [pos.Linha, pos.Coluna]
            return Pecas[pos.Linha, pos.Coluna];

        }//Fim do método Peca

        //Método do tipo void recebendo como entrada de argumentos para os parâmetros do método os tipos Peca e Posicao
        public void ColocarPeca (Peca p, Posicao pos)
        {
            //Método condicional if-else simples. Faz a verificação se em uma dada posição pos existe uma peça, através do método ExistePeca e se for verdade executa o bloco de instruções abaixo
            if (ExistePeca(pos))
            {
                //Palavra-chave throw lança uma exceção com a palavra-chave new passando a frase abaixo como argumento para o construtor da classe TabuleiroException
                throw new TabuleiroException("Ja existe uma peca nessa posicao");

            }//Fim do comando if do método condicional if-else simples
            
            //Atribui à matriz Pecas a posição com base nos valores passados como argumentos para os parâmetros do método, referente à posição da peça p
            Pecas[pos.Linha, pos.Coluna] = p;

            //Atribuindo ao atributo Posicao da peça p o valor contido na variável pos
            p.Posicao = pos;

        }//Fim do método ColocarPeca

        //Método do tipo Peca com entrada de argumento do tipo Posicao
        public Peca RetirarPeca (Posicao pos)
        {
            //Método condicional if-else composto. Verifica se Peca de tal posição pos o valor é null. Se sim, significa que não há peça, e executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (Peca(pos) == null)
            {
                //Retorna ao método chamador o valor null
                return null;

            }//Fim do comando if do método condicional if-else composto

            //Se não, executa o bloco de instruções abaixo
            else
            {
                //Declarando e inicializando variável do tipo Peca com o valor obtido em Peca(pos)
                Peca aux = Peca(pos);

                //Atributo posicao da variável aux recebe o valor null
                aux.Posicao = null;

                //Pecas na posição [pos.Linha, pos.Coluna] recebe o valor null
                Pecas[pos.Linha, pos.Coluna] = null;

                //Retorna ao método chamador a variável aux
                return aux;

            }//Fim do comando else do método condicional if-else composto

        }//Fim do método RetirarPeca

        //Método do tipo bool recebendo como argumento uma variável do tipo Posicao para o parâmetro do método
        public bool PosicaoValida (Posicao pos)
        {
            //Método condicional if-else composto. Faz as verificações adequadas e se for verdade executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                //Retorna ao método chamador o valor bool false
                return false;

            }//Fim do comando if do método condicional if-else composto

            //Se não, executa o bloco de instruções abaixo
            else
            {
                //Retorna ao método chamador o valor bool true
                return true;

            }//Fim do comando else do método condicional if-else

        }//Fim do método PosicaoValida

        //Método do tipo void recebendo como argumento para o parâmetro uma variável do tipo Posicao
        public void ValidarPosicao (Posicao pos)
        {
            //Método condicional if-else simples. Verifica se o valor do método PosicaoValida é negativo com o operador de negação (!), indicando que o mesmo é inválido
            if (!PosicaoValida(pos))
            {
                //Palavra-chave throw lança uma exceção com a palavra-chave new passando a frase abaixo como argumento para o construtor da classe TabuleiroException
                throw new TabuleiroException("Posicao invalida");

            }//Fim do comando if do método condicional if-else

        }//Fim do método ValidarPosicao

        //Método do tipo bool recebendo como argumento uma variável do tipo Posicao para o parâmetro do método
        public bool ExistePeca (Posicao pos)
        {
            //Acionando o método ValidarPosicao da variável pos
            ValidarPosicao(pos);

            //Retorna ao método chamador Peca na posição pos diferente de nulo com a palavra-chave null
            return Peca(pos) != null;

        }//Fim do método ExistePeca

    }//Fim da classe Tabuleiro
}//Fim do namespace XadrezConsole.TabuleiroXadrez
