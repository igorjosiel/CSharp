//Usando os namespaces System, XadrezConsole.TabuleiroXadrez e XadrezConsole.Xadrez
using System;
using XadrezConsole.TabuleiroXadrez;
using XadrezConsole.Xadrez;

//Utilizando o namespace XadrezConsole
namespace XadrezConsole
{
    //Classe XadrezConsole
    class XadrezConsole
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Palavra chave try, que significa que tentará rodar o programa, e vasculhar se há excessões, e caso sim, posteriormente, irá tratá-las
            try
            {
                //Declarando e instanciando um novo objeto com a palavra chave new, do tipo PartidaDeXadrez
                PartidaDeXadrez partida = new PartidaDeXadrez();

                //Método repetitivo while, para repetir enquanto o valor do atributo Terminado do objeto partida for falso, com o operador de negação (!)
                while (!partida.Terminado)
                {
                    //Palavra chave try, que significa que tentará rodar o programa, e vasculhar se há excessões, e caso sim, posteriormente, irá tratá-las
                    try
                    {
                        //Limpa a tela
                        Console.Clear();

                        //Acionando o método ImprimirPartida do objeto Tela, passando como argumento para o parâmetro do mesmo o valor contido na variável partida
                        Tela.ImprimirPartida(partida);

                        //Salta uma linha
                        Console.WriteLine();

                        //Imprime as frases na tela com os respectivos valores dos atributos: Turno e JogadorAtual, do objeto partida
                        Console.WriteLine("Turno: " + partida.Turno);
                        Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

                        //Imprime a palavra abaixo na tela
                        Console.Write("Origem: ");

                        //Declarando e inicializando variável do tipo Posicao, com o valor da chamada ao método LerPosicaoXadrez do objeto Tela, acionando o método ToPosicao
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                        //Acionando o método ValidarPosicaoDeOrigem do objeto partida, passando como argumento para o parâmetro do mesmo o valor da variável origem
                        partida.ValidarPosicaoDeOrigem(origem);

                        //Declarando e inicializando variável do tipo bool com o valor da chamada ao método Peca, passando como argumento para o parâmetro do mesmo o valor da variável origem, do objeto Tab da variável partida, acionando também o método MovimentosPossiveis
                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        //Limpa a tela
                        Console.Clear();

                        //Acionando o método ImprimirTabuleiro, passando como argumentos para o parâmetro do mesmo os valores do atributo Tab da variável partida, e da variável posicoesPossiveis
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        //Salta uma linha
                        Console.WriteLine();

                        //Imprime a palavra abaixo na tela
                        Console.Write("Destino: ");

                        //Declarando e inicializando variável do tipo Posicao, com o valor da chamada ao método LerPosicaoXadrez do objeto Tela, acionando o método ToPosicao
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                        //Acionando o método ValidarPosicaoDeDestino do objeto partida, passando como argumentos para o parâmetro do mesmo os valores das variáveis origem e destino
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        //Acioando o método RealizaJogada do objeto partida, passando como argumentos para o parâmetro do mesmo os valores das variáveis origem e destino
                        partida.RealizaJogada(origem, destino);

                    }//Fim do comando try

                    //Palavra chave catch significa que caso uma excessão seja encontrada no bloco try acima, ela será capturada no comando catch e executará o bloco de instruções abaixo
                    catch (TabuleiroException e)
                    {
                        //Imprime na tela o resultado da chamada ao método Message do objeto recém-criado acima e, do tipo TabuleiroException
                        Console.WriteLine(e.Message);

                    }//Fim do bloco catch

                }//Fim do método repetitivo while

                //Limpa a tela
                Console.Clear();

                //Acionando o método ImprimirPartida do objeto Tela, passando como argumento para o parâmetro do método o valor da variável partida
                Tela.ImprimirPartida(partida);

            }//Fim do bloco try

            //Palavra chave catch significa que caso uma excessão seja encontrada no bloco try acima, ela será capturada no comando catch e executará o bloco de instruções abaixo
            catch (TabuleiroException e)
            {
                //Imprime na tela o resultado da chamada ao método Message do objeto recém-criado acima e, do tipo TabuleiroException
                Console.WriteLine(e.Message);

            }//Fim do bloco catch

        }//Fim do método principal Main
        
    }//Fim da classe XadrezConsole
}//Fim do namespace XadrezConsole
