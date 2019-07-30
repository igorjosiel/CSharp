//Usando os namespaces System, XadrezConsole.TabuleiroXadrez, XadrezConsole.Xadrez e System.Collections.Generic
using System;
using XadrezConsole.TabuleiroXadrez;
using XadrezConsole.Xadrez;
using System.Collections.Generic;

//Utilizando o namespace XadrezConsole
namespace XadrezConsole
{
    //Classe Tela
    class Tela
    {
        //Método do tipo static (significa que não precisa de uma instância para acioná-lo) void, recebendo como argumento para o parâmetro um valor do tipo Tabuleiro
        public static void ImprimirTabuleiro (Tabuleiro tab)
        {
            //Método repetitivo for externo. Repete enquanto o valor da variável i recém-criada for menor do que o valor do atributo Linhas da variável tab
            for (int i = 0; i < tab.Linhas; i ++)
            {
                //Imprime na tela o valor da expressão: 8 - o valor da variável i com o espaço em branco
                Console.Write(8 - i + " ");

                //Método repetitivo for interno. Repete enquanto o valor da variável j recém-criada for menor do que o valor do atributo Colunas da variável tab
                for (int j = 0; j < tab.Colunas; j ++)
                {
                    //Acionando o método ImprimirPeca, passando como argumento para o parâmetro do mesmo o valor da chamada ao método Peca da variável tab, com os valores das variáveis i e j, como argumento para o parâmetro do método
                    ImprimirPeca(tab.Peca(i, j));
                    
                }//Fim do método repetitivo for interno

                //Salta uma linha
                Console.WriteLine();

            }//Fim do método repetitivo for externo

            //Imprime a expressão na tela:  a b c d e f g h
            Console.WriteLine("  a b c d e f g h");

        }//Fim do método ImprimirPeca

        //Método do tipo static (significa que não precisa de uma instância para acioná-lo) void ImprimirTabuleiro, passando como argumentos para o parâmetro do método valores dos tipos Tabuleiro e bool
        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            //Declarando variáveis do tipo ConsoleColor e atribuindo às mesmas os valores contidos em Console.BackgroundColor e ConsoleColor.DarkGray
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            //Método repetitivo for externo. Repete enquanto o valor da variável i recém-criada for menor do que o valor do atributo Linhas da variável tab
            for (int i = 0; i < tab.Linhas; i++)
            {
                //Imprime na tela o valor da expressão: 8 - o valor da variável i com o espaço em branco
                Console.Write(8 - i + " ");

                //Método repetitivo for interno. Repete enquanto o valor da variável j recém-criada for menor do que o valor do atributo Colunas da variável tab
                for (int j = 0; j < tab.Colunas; j++)
                {
                    //Método condicional if-else composto. Verifica se o valor da chamada ao método posicoesPossiveis, passando como argumento para o parâmetro do mesmo os valores das variáveis i e j é verdadeiro. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
                    if (posicoesPossiveis[i, j])
                    {
                        //Atribuindo à variável Console.BackgroundColor o valor contido na variável fundoAlterado
                        Console.BackgroundColor = fundoAlterado;

                    }//Fim do comando if do método condicional if-else simples

                    //Se o comando if anterior for falso, executa o bloco de instruções abaixo
                    else
                    {
                        //Atribuindo à variável Console.BackgroundColor o valor contido na variável fundoOriginal
                        Console.BackgroundColor = fundoOriginal;

                    }//Fim do comando else do método condicional if-else composto

                    //Acionando o método ImprimirPeca, passando como argumento para o parâmetro do mesmo o valor da chamada ao método Peca da variável tab, sendo os valores das variáveis i e j, passados para o parâmetro como argumentos
                    ImprimirPeca(tab.Peca(i, j));

                    //Atribui à variável Console.BackgroundColor o valor contido na variável fundoOriginal
                    Console.BackgroundColor = fundoOriginal;

                }//Fim do método repetitivo for interno

                //Salta uma linha
                Console.WriteLine();

            }//Fim do método repetitivo for externo

            //Imprime na tela a expressão: a b c d e f g h
            Console.WriteLine("  a b c d e f g h");

            //Atribui à variável Console.BackgroundColor o valor contido na variável fundoOriginal
            Console.BackgroundColor = fundoOriginal;

        }//Fim do método ImprimirTabuleiro

        //Método do tipo static (significa que não precisa de uma instância de um objeto para ser acionado) void, recebendo como argumento para o parâmetro do método um valor do tipo PartidaDeXadrez
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            //Acionando o método ImprimirTabuleiro, passando como argumento para o parâmetro do mesmo o valor do atributo Tab da variável partida
            ImprimirTabuleiro(partida.Tab);

            //Salta uma linha
            Console.WriteLine();

            //Acionando o método ImprimirPecasCapturadas, passando como argumento para o parâmetro do mesmo o valor da variável partida
            ImprimirPecasCapturadas(partida);

            //Imprime na tela a palavra abaixo seguida do valor contido no atributo Turno da variável partida
            Console.WriteLine("Turno: " + partida.Turno);

            //Método condicional if-else composto. Verifica se o valor do atributo Terminado da variável partida é falso com o operador de negação (!). Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (!partida.Terminado)
            {
                //Imprime na tela a frase abaixo seguida do valor do atributo JogadorAtual da variável partida
                Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

                //Método condicional if-else simples. Verifica se o valor do atributo Xeque da variável partida é verdadeiro
                if (partida.Xeque)
                {
                    //Imprime a palavra abaixo na tela
                    Console.WriteLine("Xeque");

                }//Fim do comando if do método condicional if-else simples

            }//Fim do comando if do método condicional if-else composto

            //Se o comando if anterior for falso, executa o bloco de instruções abaixo
            else
            {
                //Imprime as palavras abaixo na tela com o valor do atributo JogadorAtual da variável partida
                Console.WriteLine("XEQUEMATE!");
                Console.WriteLine("Vencedor: " + partida.JogadorAtual);

            }//Fim do comando else do método condicional if-else composto
            
        }//Fim do método ImprimirPartida

        //Método do tipo static (significa que não é preciso uma instância de um objeto para acioná-lo) void, recebendo como argumento para o parâmetro do método um valor do tipo PartideDeXadrez
        public static void ImprimirPecasCapturadas (PartidaDeXadrez partida)
        {
            //Imprime na tela as frases abaixo
            Console.WriteLine("Pecas capturadas: ");
            Console.Write("Brancas: ");

            //Acionando o método ImprimirConjunto, passando como argumento para o parâmetro do mesmo o valor da chamada ao método PecasCapturadas da variável partida, passando como argumento para o parâmetro do método o valor Branca do atributo Cor
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));

            //Salta uma linha e imprime a palavra abaixo na tela
            Console.WriteLine();
            Console.Write("Pretas: ");

            //Declarando e inicializando variável do tipo ConsoleColor, com o valor da chamada ao atributo ForegroundColor da classe Console
            ConsoleColor aux = Console.ForegroundColor;

            //Atribuindo ao atributo ForegroundColor da classe Console, o valor Yellow contido no atributo ConsoleColor
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Acionando o método ImprimirConjunto, passando como argumento para o parâmetro do mesmo o valor da chamada ao método PecasCapturadas da variável partida, passando como argumento para o parâmetro do método o valor Preta do atributo Cor
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));

            //Atribui ao atributo ForegroundColor o valor da variável aux
            Console.ForegroundColor = aux;

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método ImprimirPecasCapturadas

        //Método do tipo static (significa que não é preciso uma instância de um objeto para acioná-lo) void, recebendo como argumento para o parâmetro do método um valor do tipo HashSet contendo elementos do tipo Peca
        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            //Imprime o caracter [ na tela
            Console.Write("[");

            //Método repetitivo foreach para iterar pela lista de elementos do tipo Peca conjunto enquanto existir elementos
            foreach (Peca x in conjunto)
            {
                //Imprime na tela o valor da variável x seguido do espaço em branco
                Console.Write(x + " ");

            }//Fim do método repetitivo foreach

            //Imprime na tela o caracter ]
            Console.WriteLine("]");

        }//Fim do método ImprimirConjunto

        //Método do tipo static (significa que não é preciso uma instância de um objeto para acioná-lo) void, recebendo como argumento para o parâmetro do método um valor do tipo Peca
        public static void ImprimirPeca (Peca peca)
        {
            //Método condicional if-else composto. Verifica se o valor da variável pecas é igual ao valor nulo com a palavra chave null. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
            if (peca == null)
            {
                //Imprime na tela o caracter - seguido do espaço em branco
                Console.Write("- ");

            }//Fim do comando if do método condicional if-else composto

            //Se o comando if anterior for falso, executa o bloco de instruções abaixo
            else
            {
                //Método condicional if-else composto. Verifica se o valor do atributo Cor da variável peca é igual ao valor Branca do atributo Cor. Se for, executa o bloco de instruções abaixo. Se não, pula para o próximo teste
                if (peca.Cor == Cor.Branca)
                {
                    //Imprime na tela o valor da variável peca seguido pelo espaço em branco
                    Console.Write(peca + " ");

                }//Fim do comando if do método condicional if-else composto

                //Se o comando if anterior for falso, executa o bloco de instruções abaixo
                else
                {
                    //Declarando variável do tipo ConsoleColor e atribui à mesma o valor contido no atributo ForegroundColor da classe Console
                    ConsoleColor aux = Console.ForegroundColor;

                    //Atribuindo ao atributo ForegroundColor da classe Console o valor Yellow do atributo ConsoleColor
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    //Imprime na tela o valor da variável peca seguido do espaço em branco
                    Console.Write(peca + " ");

                    //Atribuindo ao atributo ForegroundColor da classe Console o valor da variável aux
                    Console.ForegroundColor = aux;

                }//Fim do comando if do método condicional if-else composto

            }//Fim do comando if do método condicional if-else composto

        }//Fim do método ImprimirPeca

        //Método do tipo static (significa que não é preciso uma instância de um objeto para acioná-lo), recebendo como argumento para o parâmetro do método um valor do tipo PosicaoXadrez
        public static PosicaoXadrez LerPosicaoXadrez ()
        {
            //Declarando e atribuindo à variável do tipo string o valor da chamada ao método ReadLine da classe Console
            string s = Console.ReadLine();

            //Declarando e atribuindo à variável do tipo char o valor contido na variável s recém-criada na posição 0
            char coluna = s[0];

            //Declarando e atribuindo à variável do tipo int o valor da chamada ao método Parse, passando como argumento para o parâmetro do mesmo o valor da variável s na posição i, convertendo-a para um valor do tipo int com a palavra chave int
            int linha = int.Parse(s[1] + "");

            //Retorna ao método chamador uma instância de um novo objeto do tipo PosicaoXadrez com a palavra chave new, passando como argumento para o parâmetro do método os valores das variáveis coluna e linha
            return new PosicaoXadrez(coluna, linha);

        }//Fim do método PosicaoXadrez

    }//Fim da classe Tela
}//Fim do namespace XadrezConsole
