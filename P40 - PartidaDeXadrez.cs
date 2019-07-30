//Usando os namespaces XadrezConsole.TabuleiroXadrez e System.Collections.Generic
using XadrezConsole.TabuleiroXadrez;
using System.Collections.Generic;

//Utilizando o namespace XadrezConsole.Xadrez
namespace XadrezConsole.Xadrez
{
    //Classe PartidaDeXadrez
    class PartidaDeXadrez
    {
        //Atributos da classe dos tipos Tabuleiro, Cor, e Peca - (Associação de classes), e os tipos int e bool, com suas propriedades get e private set
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminado { get; private set; }
        public bool Xeque { get; private set; }
        public Peca VulneravelEmPassant { get; private set; }

        //Atributos da classe do tipo HashSet. Listas de elementos do tipo Peca
        private HashSet<Peca> Pecas;
        private HashSet<Peca> Capturadas;

        //Método construtor sem entrada de argumentos
        public PartidaDeXadrez ()
        {
            //Inicializando os atributos da classe com os respectivos valores abaixo
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminado = false;
            VulneravelEmPassant = null;
            Xeque = false;

            //Instanciando novos objetos com a palavra chave new
            Tab = new Tabuleiro(8, 8);
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();

            //Chamada ao método ColocarPeca
            ColocarPecas();

        }//Fim do método construtor da classe sem entrada de argumentos

        //Método do tipo void com entrada de argumentos dos tipos Posicao e Peca
        public void DesfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada)
        {
            //Declarando e inicializando variável do tipo Peca, com o valor da chamada ao método RetirarPeca do atributo Tab, passando como argumento para o parâmetro do método o valor contido na variável destino
            Peca p = Tab.RetirarPeca(destino);

            //Acionando o método DecrementarQtdMovimentos da variável p
            p.DecrementarQtdMovimentos();

            //Método condicional if-else simples. Verifica se o valor contido na variável pecaCapturada é diferente de nulo com o operador de diferente (!=) e a palavra chave null
            if (pecaCapturada != null)
            {
                //Acionando o método ColocarPeca do atributo da classe Tab, passando como argumento para o parâmetro do mesmo, os valores das variáveis pecaCapturada e destino
                Tab.ColocarPeca(pecaCapturada, destino);

                //Acionando o método Remove do atributo da classe Capturadas, passando como argumento para o parâmetro do mesmo o valor da variável pecaCapturada
                Capturadas.Remove(pecaCapturada);

            }//Fim do comando if do método condicional if-else simples

            //Acionando o método ColocarPeca do atributo da classe Tab, passando como argumentos para o parâmetro do mesmo os valores das variáveis p e origem
            Tab.ColocarPeca(p, origem);

            //# Jogadaespecial roque pequeno
            //Método condicional if-else simples. Verifica se a variável p é do tipo Rei com a palavra chave is e se o valor do atributo Coluna da variável destino é igual ao valor do atributo Coluna da variável origem somado com 2
            if (p is Rei && destino.Coluna == origem.Coluna + 2)
            {
                //Declarando e instanciando objetos do tipo Posicao, passando como argumento para o parâmetro dos métodos construtores seus respectivos valores abaixo com a palavra chave new
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna + 1);

                //Declarando e atribuindo à variável do tipo Peca o valor contido na chamada ao método RetirarPeca do atributo da classe Tab, passando como argumento para o parâmetro do mesmo o valor da variável origemT
                Peca T = Tab.RetirarPeca(origemT);

                //Acionando o método DecrementarQtdMovimentos da variável T
                T.DecrementarQtdMovimentos();

                //Acionando o método ColocarPeca do atributo da classe Tab, passando como argumento para o parâmetro do mesmo os valores das variáveis T e origem
                Tab.ColocarPeca(T, origem);

            }//Fim do comando if do método condicional if-else simples

            //# Jogadaespecial roque grande
            //Método condicional if-else simples. Verifica se a variável p é do tipo Rei com a palavra chave is e se o valor do atributo Coluna da variável destino é igual ao valor do atributo Coluna da variável origem subtraído por 2
            if (p is Rei && destino.Coluna == origem.Coluna - 2)
            {
                //Declarando e instanciando objetos do tipo Posicao, passando como argumentos para os parâmetros dos métodos construtores seus respectivos valores abaixo com a palavra chave new
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna - 4);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna - 1);

                //Declarando e atribuindo à variável do tipo Peca o valor contido na chamada ao método RetirarPeca do atributo da classe Tab, passando como argumento para o parâmetro do mesmo o valor da variável origemT
                Peca T = Tab.RetirarPeca(origemT);

                //Acionando o método IncrementarQtdMovimentos da variável T
                T.IncrementarQtdMovimentos();

                //Acionando o método ColocarPeca do atributo da classe Tab, passando como argumento para o parâmetro do mesmo os valores das variáveis T e origem
                Tab.ColocarPeca(T, origem);

            }//Fim do comando if do método condicional if-else simples

            //# Jogadaespecial En passant
            //Método condicional if-else simples. Verifica se a variável p é do tipo Peao com a palavra chave is
            if (p is Peao)
            {
                //Método condicional if-else simples. Verifica se o valor do atributo Coluna da variável origem é diferente do valor do atributo Coluna da variável destino e se o valor da variável pecaCapturada é igual ao valor do atributo VulneravelEmPassant
                if (origem.Coluna != destino.Coluna && pecaCapturada == VulneravelEmPassant)
                {
                    //Declarando e inicializando variável do tipo Peca com o valor da chamada ao método RetirarPeca do atributo da classe Tab, passando para o parâmetro do mesmo o valor da variável destino como argumento
                    Peca peao = Tab.RetirarPeca(destino);

                    //Declarando variável do tipo Posicao
                    Posicao posP;

                    //Método condicional if-else composto. Verifica se o valor do atributo Cor da variável p é igual ao valor Branca do atributo Cor da classe. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
                    if (p.Cor == Cor.Branca)
                    {
                        //Instanciando um objeto com a palavra chave new, passando como argumento para o parâmetro do método construtor a expressão: 3, destino.Coluna
                        posP = new Posicao(3, destino.Coluna);

                    }//Fim do comando if do método condicional if-else composto

                    //Se o comando if anterior for falso, executa o bloco de instruções abaixo
                    else
                    {
                        //Instanciando um objeto com a palavra chave new, passando como argumento para o parâmetro do método construtor a expressão: 4, destino.Coluna
                        posP = new Posicao(4, destino.Coluna);

                    }//Fim do comando else do método condicional if-else composto

                    //Acionando o método ColocarPeca do atributo da classe Tab, passando como argumentos para o parâmetro do mesmo os valores das variáveis peao e posP
                    Tab.ColocarPeca(peao, posP);

                }//Fim do comando if do método condicional if-else simples
            }//Fim do comando if do método condicional if-else simples

        }//Fim do método DesfazMovimento

        //Método do tipo void com entrada de argumentos do tipo Posicao
        public void RealizaJogada (Posicao origem, Posicao destino)
        {
            //Declarando e inicializando variável do tipo Peca com o valor da chamada ao método ExecutaMovimento, passando como argumentos para o parâmetro do mesmo os valores das variáveis origem e destino
            Peca pecaCapturada = ExecutaMovimento(origem, destino);

            //Método condicional if-else simples. Verifica se o valor do método EstaEmXeque, passando como argumento para o parâmetro do mesmo o valor do atributo da classe JogadorAtual, é verdadeiro
            if (EstaEmXeque(JogadorAtual))
            {
                //Acionando o método DesfazMovimento, passando como argumentos para o parâmetro do mesmo, os valores das variáveis origem, destino e pecaCapturada
                DesfazMovimento(origem, destino, pecaCapturada);

                //Lança uma excessão com a palavra chave throw new, passando como argumento para o parâmetro do método construtor a frase abaixo
                throw new TabuleiroException("Voce nao pode se colocar em xeque!");

            }//Fim do comando if do método condicional if-else simples

            //Declarando variável do tipo Peca com o valor da chamada ao método Peca do atributo da classe Tab, passando como argumento para o parâmetro do mesmo o valor da variável destino
            Peca p = Tab.Peca(destino);

            //# Jogadaespecial promoção
            //Método condicional if-else simples. Verifica se a variável p é do tipo Peao com a palavra chave is
            if (p is Peao)
            {
                //Método condicional if-else simples. Verifica se a expressão p.Cor == Cor.Branca && destino.Linha == 0 || p.Cor == Cor.Preta && destino.Linha == 7 é verdadeira
                if (p.Cor == Cor.Branca && destino.Linha == 0 || p.Cor == Cor.Preta && destino.Linha == 7)
                {
                    //Atribuindo à variável p o valor da chamada ao método RetirarPeca do atributo da classe Tab, passando como argumento para o parâmetro o valor da variável destino
                    p = Tab.RetirarPeca(destino);

                    //Acionando o método Remove do atributo da classe Pecas, passando como argumento para o parâmetro o valor da variável p
                    Pecas.Remove(p);

                    //Declarando e instanciando um objeto do tipo Peca com a palavra chave new, passando como argumento para o parâmetro do método construtor os valores do atributo Tab e Cor do objeto p
                    Peca dama = new Dama(Tab, p.Cor);

                    //Acionando o método ColocarPeca do atributo da classe Tab, passando como argumento para o parâmetro do mesmo os valores das variáveis dama e destino
                    Tab.ColocarPeca(dama, destino);

                    //Acionando o método Add do atributo Pecas, passando como argumento para o parâmetro do mesmo o valor da variável dama
                    Pecas.Add(dama);

                }//Fim do comando if do método condicional if-else simples
            }//Fim do comando if do método condicional if-else simples

            //Método condicional if-else composto. Verifica se o valor do método EstaEmXeque do atributo Adversario do atributo JogadorAtual, é verdadeiro. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (EstaEmXeque(Adversaria(JogadorAtual)))
            {
                //Atributo da classe Xeque recebe o valor booleano true
                Xeque = true;

            }//Fim do comando if do método condicional if-else composto

            //Se o comando anterior for falso, executa o bloco de intruções abaixo
            else
            {
                //Atributo da classe Xeque recebe o valor booleano false
                Xeque = false;

            }//Fim do comando else do método condicional if-else composto

            //Método condicional if-else composto. Verifica se o valor do método TestaXequeMate do atributo Adversario do atributo JogadorAtual, é verdadeiro. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (TesteXequeMate(Adversaria(JogadorAtual)))
            {
                //Atributo da classe Terminado recebe o valor booleano true
                Terminado = true;

            }//Fim do comando if do método condicional if-else composto

            //Se o comando anterior for falso, executa o bloco de instruções abaixo
            else
            {
                //Atributo da classe Turno é incrementado com 1 com o operador ++
                Turno++;

                //Acionando o método MudaJogador
                MudaJogador();

            }//Fim do comando if do método condicional if-else composto

            //#Jogadaespecial en passant
            //Método condicional if-else composto. Verifica se a variável p é do tipo Peca com a palavra chave is e se o valor do atributo Linha da variável destino é igual ao valor do atributo Linha da variável origem - 2 ou + 2. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (p is Peca && destino.Linha == origem.Linha - 2 || destino.Linha == origem.Linha + 2)
            {
                //Atributo da classe VulneravelEmPassant recebe o valor da variável p
                VulneravelEmPassant = p;

            }//Fim do comando if do método condicional if-else composto

            //Se o comando anterior for falso. Executa o bloco de intruções abaixo
            else
            {
                //Atributo da classe VulneravelEmPassant recebe o valor null
                VulneravelEmPassant = null;

            }//Fim do comando else do método condicional if-else composto

        }//Fim do método RealizaJogada

        //Método do tipo private void
        private void MudaJogador ()
        {
            //Método condicional if-else composto. Verifica se o valor do atributo da classe JogadorAtual é igual ao valor Branca do atributo Cor do objeto. Se for, executa o bloco de instruções abixo. Se não, pula para o próximo teste
            if (JogadorAtual == Cor.Branca)
            {
                //Atributo JogadorAtual recebe o valor Preta para o atributo Cor do objeto
                JogadorAtual = Cor.Preta;

            }//Fim do comando if do método condicional if-else composto

            //Se o comando if anterior for falso, executa o bloco de instruções abaixo
            else
            {
                //Atributo JogadorAtual recebe o valor Branca para o atributo Cor do objeto
                JogadorAtual = Cor.Branca;

            }//Fim do comando else do método condicional if-else composto

        }//Fim do método MudaJogador

        //Método do tipo bool recebendo como argumento para o parâmetro um valor do tipo Cor
        public bool TesteXequeMate (Cor cor)
        {
            //Método condicional if-else simples. Verifica se o método EstaEmXeque, passando como argumento para o parâmetro do mesmo a variável cor é falso com o operador de negação (!)
            if (!EstaEmXeque(cor))
            {
                //Retorna ao método chamador o valor booleano false
                return false;

            }//Fim do comando if do método condicional if-else simples

            //Método repetitivo foreach sendo repetido enquanto existir elementos na lista PecasEmJogo a cada iteração, passando como argumento para o parâmetro do método o valor da variável cor
            foreach (Peca x in PecasEmJogo(cor))
            {
                //Declarando e inicializando variável do tipo bool atribuindo à mesma o valor da chamada ao método MovimentosPossiveis da variável x
                bool[,] mat = x.MovimentosPossiveis();

                //Método repetitivo for externo. Será repetido enquanto o valor do atributo Linhas do atributo Tab for maior que o valor da recém-criada variável i
                for (int i = 0; i < Tab.Linhas; i ++)
                {
                    //Método repetitivo for interno. Será repetido enquanto o valor do atributo Colunas do atributo Tab for maior que o valor da recém-criada variável j
                    for (int j = 0; j < Tab.Colunas; j ++)
                    {
                        //Método condicional if-else simples. Verifica se a variável mat na posição i, j é verdadeiro
                        if (mat[i, j])
                        {
                            //Declarando e inicializando variável do tipo Posicao com o valor da chamada ao atributo Posicao da variável x
                            Posicao origem = x.Posicao;

                            //Declarando e instanciando variável do tipo Posicao com a palavra chave new, passando como argumentos para o parâmetro do método construtor os valores das variáveis i e j
                            Posicao destino = new Posicao(i, j);

                            //Declarando e inicializando variável do tipo Peca com o valor da chamada ao método ExecutaMovimento, passando como argumentos para o parâmetro os valores das variáveis origem e destino
                            Peca pecaCapturada = ExecutaMovimento(origem, destino);

                            //Declarando e inicializando variável do tipo bool com o valor da chamada ao método EstaEmXeque, passando como argumento para o parâmetro o valor da variável cor
                            bool TesteXeque = EstaEmXeque(cor);

                            //Acionando o método DesfazMovimento, passando como argumentos para o parâmetro do mesmo os valores das variáveis: origem, destino e pecaCapturada
                            DesfazMovimento(origem, destino, pecaCapturada);

                            //Método condicional if-else simples. Verifica se o método TesteXeque é falso com o operador de negação (!)
                            if (!TesteXeque)
                            {
                                //Retorna ao método chamador o valor booleano false
                                return false;

                            }//Fim do comando if do método condicional if-else simples
                        }//Fim do comando if do método condicional if-else simples

                    }//Fim do método repetitivo for interno
                }//Fim do método repetitivo for externo

            }//Fim do método repetitivo foreach

            //Retorna ao método chamador o valor booleano false
            return false;

        }//Fim do método TesteXequeMate

        //Método do tipo void recebendo como argumento para o parâmetro do mesmo um valor do tipo Posicao
        public void ValidarPosicaoDeOrigem (Posicao pos)
        {
            //Método condicional if-else simples. Verifica se o valor do atributo Peca do atributo Tab, passando como argumento para o parâmetro do método o valor da variável pos é igual a null com a palavra chave null, é verdadeiro
            if (Tab.Peca(pos) == null)
            {
                //Lança uma excessão com a palavra chave throw new, passando como argumento para o parâmetro do método construtor a frase abaixo
                throw new TabuleiroException("Nao existe peca na posicao de origem escolhida.");

            }//Fim do comando if do método condicional if-else simples

            //Método condicional if-else simples. Verifica se o valor do atributo JogadorAtual é diferente do valor do método Peca do atributo Tab, passando como argumento para o parâmetro do método o valor da variável pos .Cor
            if (JogadorAtual != Tab.Peca(pos).Cor)
            {
                //Lança uma excessão com a palavra chave throw new, passando como argumento para o parâmetro do método construtor a frase abaixo
                throw new TabuleiroException("A peca de origem escolhida nao e sua.");

            }//Fim do comando if do método condicional if-else simples

            //Método condicional if-else simples. Verifica se o valor do método ExisteMovimentosPossiveis do atributo Peca do atributo Tab, passando como argumento para o parâmetro do mesmo, o valor da variável pos, é falso, com o operador de negação (!)
            if (!Tab.Peca(pos).ExisteMovimentosPossiveis())
            {
                //Lança uma excessão com a palavra chave throw new, passando como argumento para o parâmetro do método construtor a frase abaixo
                throw new TabuleiroException("Nao ha movimentos possiveis para a peca de origem escolhida.");

            }//Fim do comando if do método condicional if-else simples

        }//Fim do método ValidarPosicaoDeOrigem

        //Método do tipo void recebendo como argumento para o parâmetro valores do tipo Posicao
        public void ValidarPosicaoDeDestino (Posicao origem, Posicao destino)
        {
            //Método condicional if-else simples. Verifica se o valor do método MovimentoPossivel do atributo Peca do atributo Tab, passando como argumentos para os parâmetros dos mesmos, os valores das variáveis origem e destino, é falso, com o operador de negação (!)
            if (!Tab.Peca(origem).MovimentoPossivel(destino))
            {
                //Lança uma excessão com a palavra chave throw new, passando como argumento para o parâmetro do método construtor a frase abaixo
                throw new TabuleiroException("Posicao de destino invalida.");

            }//Fim do comando if do método condicional if-else simples

        }//Fim do método ValidarPosicaoDeDestino

        //Método do tipo HashSet com elementos do tipo Peca recebendo como argumento para o parâmetro um valor do tipo Cor
        public HashSet<Peca> PecasCapturadas (Cor cor)
        {
            //Declarando e instanciando variável do tipo HashSet com a palavra chave new, com elementos do tipo Peca
            HashSet<Peca> aux = new HashSet<Peca>();

            //Método repetitivo foreach para repetir enquanto houver elementos na lista Capturadas
            foreach (Peca x in Capturadas)
            {
                //Método condicional if-else simples. Verifica se o valor do atributo Cor da variável x é igual ao valor da variável cor
                if (x.Cor == cor)
                {
                    //Acionando o método Add da variável aux, passando como argumento para o parâmetro do mesmo o valor da variável x
                    aux.Add(x);

                }//Fim do comando if do método condicional if-else simples

            }//Fim do método repetitivo foreach

            //Retorna ao método chamador o valor da variável aux
            return aux;

        }//Fim do método PecasCapturadas

        //Método do tipo HashSet com elementos do tipo Peca recebendo como argumento para o parâmetro um valor do tipo Cor
        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            //Declarando e instanciando variável do tipo HashSet com a palavra chave new, com elementos do tipo Peca
            HashSet<Peca> aux = new HashSet<Peca>();

            //Método repetitivo foreach para repetir enquanto houver elementos na lista Pecas
            foreach (Peca x in Pecas)
            {
                //Método condicional if-else simples. Verifica se o valor do atributo Cor da variável x é igual ao valor da variável cor
                if (x.Cor == cor)
                {
                    //Acionando o método Add da variável aux, passando como argumento para o parâmetro do mesmo o valor da variável x
                    aux.Add(x);

                }//Fim do comando if do método condicional if-else simples

            }//Fim do método repetitivo foreach

            //Acionando o método ExceptWith, passando como argumento para o parâmetro do mesmo o valor do método PecasCapturadas, passando como argumento para o parâmetro o valor da variável cor
            aux.ExceptWith(PecasCapturadas(cor));

            //Retorna ao método chamador o valor da variável aux
            return aux;

        }//Fim do método PecasEmJogo

        //Método do tipo Cor recebendo como argumento para o parâmetro um valor do tipo Cor
        private Cor Adversaria (Cor cor)
        {
            //Método condicional if-else composto. Verifica se o valor da variável cor é igual ao valor Branca do atributo Cor. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (cor == Cor.Branca)
            {
                //Retorna ao método chamador o valor Preta para o atributo Cor do objeto
                return Cor.Preta;

            }//Fim do comando if do método condicional if-else composto

            //Se o comando if anterior for falso, executa o bloco de instruções abaixo
            else
            {
                //Retorna ao método chamador o valor Branca para o atributo Cor do objeto
                return Cor.Branca;

            }//Fim do comando else do método condicional if-else composto

        }//Fim do método Adversaria

        //Método do tipo Peca recebendo como argumento para o parâmetro um valor do tipo Cor
        private Peca Rei (Cor cor)
        {
            //Método repetitivo foreach para repetir enquanto houver elementos no atributo PecasEmJogo, passando como argumento para o parâmetro do método o valor da variável cor
            foreach (Peca x in PecasEmJogo(cor))
            {
                //Método condicional if-else simples. Verifica se a variável x é do tipo Rei com a palavra chave is
                if (x is Rei)
                {
                    //Retorna ao método chamador o valor da variável x
                    return x;

                }//Fim do comando if do método condicional if-else simples

            }//Fim do método repetitivo foreach

            //Retorna ao método chamador o valor null
            return null;

        }//Fim do método Peca

        //Método do tipo bool recebendo como argumento para o parâmetro um valor do tipo Cor
        public bool EstaEmXeque (Cor cor)
        {
            //Declarando e inicializando variável do tipo Peca com a chamada ao método Rei, passando como argumento para o parâmetro do método construtor o valor da variável cor
            Peca r = Rei(cor);

            //Método condicional if-else simples. Verifica se o valor da variável r é igual ao valor null, com a palavra chave null
            if (r == null)
            {
                //Lança uma excessão com a palavra chave throw new, passando como argumento para o parâmetro do método construtor a frase abaixo
                throw new TabuleiroException("Nao tem rei da cor " + cor + " no tabuleiro.");

            }//Fim do comando if do método condicional if-else simples

            //Método repetitivo foreach para iterar pelo atributo PecasEmJogo da propriedade Adversaria de tal Cor, enquanto existir
            foreach (Peca x in PecasEmJogo(Adversaria(cor)))
            {
                //Declarando e atribuindo à variável do tipo bool o valor da chamada ao método MovimentosPossiveis da variável x
                bool[,] mat = x.MovimentosPossiveis();

                //Método condicional if-else simples. Verifica se o valor da variável mat na posição r.Posicao.Linha e r.Posicao.Coluna é verdadeiro
                if (mat[r.Posicao.Linha, r.Posicao.Coluna])
                {
                    //Retorna ao método chamador o valor booleano true
                    return true;

                }//Fim do comando if do método condicional if-else simples

            }//Fim do método repetitivo foreach

            //Retorna ao método chamador o valor booleano false
            return false;

        }//Fim do método EstaEmXeque

        //Método do tipo Peca recebendo como argumentos para o parâmetro variáveis do tipo Posicao
        public Peca ExecutaMovimento (Posicao origem, Posicao destino)
        {
            //Declarando e atribuindo à variável do tipo Peca o valor da chamada ao método RetirarPeca, passando como argumento para o parâmetro do método o valor da variável origem, do atributo Tab
            Peca p = Tab.RetirarPeca(origem);

            //Acionando o método IncrementarQtdMovimentos da variável p
            p.IncrementarQtdMovimentos();

            //Declarando e atribuindo à variável do tipo Peca o valor da chamada ao método RetirarPeca, passando como argumento para o parâmetro do método o valor da variável destino, do atributo Tab
            Peca pecaCapturada = Tab.RetirarPeca(destino);

            //Acionando o método ColocarPeca do atributo Tab, passando como argumentos para o parâmetro do mesmo os valores das variáveis: p e destino
            Tab.ColocarPeca(p, destino);

            //Método condicional if-else simples. Verifica se o valor da variável pecaCapturada é diferente de null, com o operador (!=) e a palavra chave null
            if (pecaCapturada != null)
            {
                //Acionando o método Add do atributo Capturadas, passando como argumento para o parâmetro do mesmo o valor da variável pecaCapturada
                Capturadas.Add(pecaCapturada);

            }//Fim do comando if do método condicional if-else simples

            //# Jogadaespecial roque pequeno
            //Método condicional if-else simples. Verifica se a variável p é do tipo Rei com a palavra chave is e se o valor do atributo Coluna da variável destino é igual ao valor do atributo Coluna da variável origem somado com 2
            if (p is Rei && destino.Coluna == origem.Coluna + 2)
            {
                //Declarando e inicializando variáveis do tipo Posicao com a palavra chave new, passando como argumentos para o parâmetro do método construtor os valores das expressões: origem.Linha, origem.Coluna + 3 e origem.Linha, origem.Coluna + 1
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna + 1);

                //Declarando e inicializando variável do tipo Peca, com o valor da chamada ao método RetirarPeca do atributo Tab, passando como argumento para o parâmetro do método o valor da variável origemT
                Peca T = Tab.RetirarPeca(origemT);

                //Acionando o método IncrementarQtdMovimentos da variável T
                T.IncrementarQtdMovimentos();

                //Acionando o método ColocarPeca do atributo Tab, passando como argumentos para o parâmetro do mesmo os valores das variáveis: T e destino
                Tab.ColocarPeca(T, destino);

            }//Fim do comando if do método condicional if-else simples

            //# Jogadaespecial roque grande
            //Método condicional if-else simples. Verifica se a variável p é do tipo Rei com a palavra chave is e se o valor do atributo Coluna da variável destino é igual ao valor do atributo Coluna da variável origem subtraído com 2
            if (p is Rei && destino.Coluna == origem.Coluna - 2)
            {
                //Declarando e inicializando variáveis do tipo Posicao com a palavra chave new, passando como argumentos para o parâmetro do método construtor os valores das expressões: origem.Linha, origem.Coluna - 4 e origem.Linha, origem.Coluna - 1
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna - 4);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna - 1);

                //Declarando e inicializando variável do tipo Peca, com o valor da chamada ao método RetirarPeca do atributo Tab, passando como argumento para o parâmetro do método o valor da variável origemT
                Peca T = Tab.RetirarPeca(origemT);

                //Acionando o método IncrementarQtdMovimentos da variável T
                T.IncrementarQtdMovimentos();

                //Acionando o método ColocarPeca do atributo Tab, passando como argumentos para o parâmetro do mesmo os valores das variáveis: T e destino
                Tab.ColocarPeca(T, destino);

            }//Fim do comando if do método condicional if-else simples

            //# Jogadaespecial en passant
            //Método condicional if-else simples. Verifica se a variável p é do tipo Peao com a palavra chave is
            if (p is Peao)
            {
                //Método condicional if-else simples. Verifica se o valor do atributo Coluna da variável origem é diferente do valor do atributo Coluna da variável destino e se o valor da variável pecaCapturada é igual a null com a palavra chave null
                if (origem.Coluna != destino.Coluna && pecaCapturada == null)
                {
                    //Declarando variável do tipo Posicao
                    Posicao posP;

                    //Método condicional if-else composto. Verifica se o valor do atributo Cor da variável p é igual ao valor Branca do atributo Cor. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
                    if (p.Cor == Cor.Branca)
                    {
                        //Instanciando um objeto com a palavra chave new, passando como argumento para o parâmetro do método construtor o valor da expressão: destino.Linha + 1, destino.Coluna
                        posP = new Posicao(destino.Linha + 1, destino.Coluna);

                    }//Fim do comando if do método condicional if-else composto

                    //Se o comando if anterior for falso, executa o bloco de instruções abaixo
                    else
                    {
                        //Instanciando um objeto com a palavra chave new, passando como argumento para o parâmetro do método construtor o valor da expressão: destino.Linha - 1, destino.Coluna
                        posP = new Posicao(destino.Linha - 1, destino.Coluna);

                    }//Fim do comando else do método condicional if-else composto

                    //Atribuindo à variável pecaCapturada o valor da chamada ao método RetirarPeca do atributo Tab, passando como argumento para o parâmetro do mesmo o valor da variável posP
                    pecaCapturada = Tab.RetirarPeca(posP);

                    //Acionando o método Add do atributo Capturadas, passando como argumento para o parâmetro o valor da variável pecaCapturada
                    Capturadas.Add(pecaCapturada);

                }//Fim do comando if do método condicional if-else simples

            }//Fim do comando if do método condicional if-else simples

            //Retorna ao método chamador o valor da variável pecaCapturada
            return pecaCapturada;

        }//Fim do método ExecutaMovimento

        //Método do tipo void recebendo como entrada de argumentos para o parâmetro valores dos tipos: char, int e Peca
        public void ColocarNovaPeca (char coluna, int linha, Peca peca)
        {
            //Acionando o método ColocarPeca do atributo Tab, passando como argumentos para o parâmetro do mesmo o valor da variável peca e uma instância de um objeto do tipo PosicaoXadrez com a palavra chave new
            Tab.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ToPosicao());

            //Acionando o método Add do atributo Pecas, passando como argumento para o parâmetro do mesmo o valor da variável peca
            Pecas.Add(peca);
            
        }//Fim do método ColocarNovaPeca

        //Método do tipo void
        private void ColocarPecas()
        {
            //Acionando o método ColocarNovaPeca, passando como argumentos para o parâmetro do método os respectivos valores dos tipos: char, int e uma instância de um novo objeto com a palavra chave new
            ColocarNovaPeca('a', 1, new Torre(Tab, Cor.Branca));
            ColocarNovaPeca('b', 1, new Cavalo(Tab, Cor.Branca));
            ColocarNovaPeca('c', 1, new Bispo(Tab, Cor.Branca));
            ColocarNovaPeca('d', 1, new Dama(Tab, Cor.Branca));
            ColocarNovaPeca('e', 1, new Rei(Tab, Cor.Branca, this));
            ColocarNovaPeca('f', 1, new Bispo(Tab, Cor.Branca));
            ColocarNovaPeca('g', 1, new Cavalo(Tab, Cor.Branca));
            ColocarNovaPeca('h', 1, new Torre(Tab, Cor.Branca));
            ColocarNovaPeca('a', 2, new Peao(Tab, Cor.Branca, this));
            ColocarNovaPeca('b', 2, new Peao(Tab, Cor.Branca, this));
            ColocarNovaPeca('c', 2, new Peao(Tab, Cor.Branca, this));
            ColocarNovaPeca('d', 2, new Peao(Tab, Cor.Branca, this));
            ColocarNovaPeca('e', 2, new Peao(Tab, Cor.Branca, this));
            ColocarNovaPeca('f', 2, new Peao(Tab, Cor.Branca, this));
            ColocarNovaPeca('g', 2, new Peao(Tab, Cor.Branca, this));
            ColocarNovaPeca('h', 2, new Peao(Tab, Cor.Branca, this));

            //Acionando o método ColocarNovaPeca, passando como argumento para o parâmetro do método os respectivos valores dos tipos: char, int e uma instância de um novo objeto com a palavra chave new
            ColocarNovaPeca('a', 8, new Torre(Tab, Cor.Preta));
            ColocarNovaPeca('b', 8, new Cavalo(Tab, Cor.Preta));
            ColocarNovaPeca('c', 8, new Bispo(Tab, Cor.Preta));
            ColocarNovaPeca('d', 8, new Dama(Tab, Cor.Preta));
            ColocarNovaPeca('e', 8, new Rei(Tab, Cor.Preta, this));
            ColocarNovaPeca('f', 8, new Bispo(Tab, Cor.Preta));
            ColocarNovaPeca('g', 8, new Cavalo(Tab, Cor.Preta));
            ColocarNovaPeca('h', 8, new Torre(Tab, Cor.Preta));
            ColocarNovaPeca('a', 7, new Peao(Tab, Cor.Preta, this));
            ColocarNovaPeca('b', 7, new Peao(Tab, Cor.Preta, this));
            ColocarNovaPeca('c', 7, new Peao(Tab, Cor.Preta, this));
            ColocarNovaPeca('d', 7, new Peao(Tab, Cor.Preta, this));
            ColocarNovaPeca('e', 7, new Peao(Tab, Cor.Preta, this));
            ColocarNovaPeca('f', 7, new Peao(Tab, Cor.Preta, this));
            ColocarNovaPeca('g', 7, new Peao(Tab, Cor.Preta, this));
            ColocarNovaPeca('h', 7, new Peao(Tab, Cor.Preta, this));

        }//Fim do método ColocarPecas

    }//Fim da classe PartidaDeXadrez
}//Fim do namespace XadrezConsole.Xadrez
