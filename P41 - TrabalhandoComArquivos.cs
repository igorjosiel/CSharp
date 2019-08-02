//Usando os namespaces System e System.IO
using System;
using System.IO;

//Utilizando o namespace TrabalhandoComArquivos
namespace TrabalhandoComArquivos
{
    //Classe TrabalhandoComArquivos
    class TrabalhandoComArquivos
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e inicializando uma variável do tipo string com o valor do caminho do diretório: C:\wamp\file1.txt
            string sourcePath = @"C:\wamp\file1.txt";

            //Declarando e inicializando uma variável do tipo string com o valor do caminho do diretório: C:\wamp\file2.txt
            string targetPath = @"C:\wamp\file2.txt";

            //Palavra chave try que significa que tentará rodar o programa e caso alguma exceção exista, a mesma será tratada nos blocos catch, posteriormente
            try
            {
                //Declarando e instanciando um objeto do tipo FileInfo com a palavra chave new, passando como argumento para o parâmetro do método o valor da variável sourcePath
                FileInfo fileInfo = new FileInfo(sourcePath);

                //Acionando o método CopyTo do objeto fileInfo, passando como argumento para o parâmetro do mesmo o valor da variável targetPath
                fileInfo.CopyTo(targetPath);

                //Declarando e inicializando um objeto do tipo vetor de string, com a chamada ao método ReadAllLines da classe File, passando como argumento para o parâmetro do método o valor da variável sourcePath
                string[] lines = File.ReadAllLines(sourcePath);

                //Método repetitivo foreach, sendo repetido enquanto houver elementos no vetor de objetos do tipo string lines. Atribuindo o apelido line a cada elemento
                foreach (string line in lines)
                {
                    //Imprime na tela o valor do objeto da iteração atual através do apelido line
                    Console.WriteLine(line);

                }//Fim do método repetitivo foreach

            }//Fim do bloco de instruções try

            //Palavra chave catch que significa que uma exceção pode ser capturada, executando o bloco de instruções abaixo
            catch (IOException e)
            {
                //Imprime a frase abaixo na tela
                Console.WriteLine("An error accurred");

                //Acionando o atributo Message do objeto e recém-criado acima
                Console.WriteLine(e.Message);

            }//Fim do bloco catch

        }//Fim do método Main

    }//Fim da classe TrabalhandoComArquivos
}//Fim do namespace TrabalhandoComArquivos
