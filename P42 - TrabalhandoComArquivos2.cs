//Usando os namespaces System e System.IO
using System;
using System.IO;

//Utilizando o namespace TrabalhandoComArquivos2
namespace TrabalhandoComArquivos2
{
    //Classe TrabalhandoComArquivos2
    class TrabalhandoComArquivos2
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e inicializando variável do tipo string com o valor do caminho do diretório do arquivo: C:\wamp\file1.txt
            string path = @"C:\wamp\file1.txt";

            //Declarando e inicializando variável do tipo FileStream com o valor null
            FileStream fs = null;

            //Declarando e inicializando variável do tipo StreamReader com o valor null
            StreamReader sr = null;

            //Palavra chave try que significa que tentará executar o programa e, caso surja alguma exceção, a mesma será capturada e tratada no bloco catch posteriormente
            try
            {
                //Instanciando o objeto fs com a palavra chave new, passando como argumento para o parâmetro do método construtor os valores da variável path, e do valor Open do atributo enumerado FileMode
                fs = new FileStream(path, FileMode.Open);

                //Instanciando o objeto sr com a palavra chave new, passando como argumento para o parâmetro do método construtor o valor da variável fs
                sr = new StreamReader(fs);

                //Método repetitivo while sendo repetido enquanto o valor do atributo EndOfStream do objeto sr for falso, com o operador de negação (!)
                while (!sr.EndOfStream)
                {
                    //Declarando e inicializando variável do tipo string com o valor da chamada ao método ReadLine do objeto sr
                    string line = sr.ReadLine();

                    //Imprime na tela o valor da variável line a cada iteração do método while
                    Console.WriteLine(line);

                }//Fim do método repetitivo while

            }//Fim do bloco de instruções try

            //Palavra chave catch que significa que a exceção que existir no bloco de instruções acima será capturada e tratada através do bloco de instruções abaixo
            catch (IOException e)
            {
                //Imprime a frase abaixo na tela
                Console.WriteLine("An error acurred");

                //Imprime o resultado do atributo Message do objeto recém-criado e
                Console.WriteLine(e.Message);

            }//Fim do bloco de instruções catch

            //Palavra chave finally que significa que o bloco de instruções abaixo será executado de qualquer forma, independente dos resultados acima
            finally
            {
                //Método condicional if-else simples. Verifica se o valor da variável sr é diferente do valor nulo com a palavra chave null
                if (sr != null)
                {
                    //Acionando o método Close do objeto sr
                    sr.Close();

                }//Fim do comando if do método condicional if-else simples

                //Método condicional if-else simples. Verifica se o valor da variável fs é diferente do valor nulo com a palavra chave null
                if (fs != null)
                {
                    //Acionando o método Close do objeto fs
                    fs.Close();

                }//Fim do comando if do método condicional if-else simples

            }//Fim do bloco de instruções finally

        }//Fim do método principal Main

    }//Fim da classe TrabalhandoComArquivos2
}//Fim do namespace TrabalhandoComArquivos2
