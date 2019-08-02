//Usando os namespaces System e System.IO
using System;
using System.IO;

//Utilizando o namespace TrabalhandoComArquivos4
namespace TrabalhandoComArquivos4
{
    //Classe TrabalhandoComArquivos4
    class TrabalhandoComArquivos4
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e atribuindo à variável do tipo string o valor do caminho do diretório do arquivo: C:\wamp\file1.txt
            string sourcePath = @"C:\wamp\file1.txt";

            //Declarando e atribuindo à variável do tipo string o valor do caminho do diretório do arquivo: C:\wamp\newfile.txt
            string targetPath = @"C:\wamp\newfile.txt";

            //Palavra chave try que significa que ao executar o programa, se houver alguma exceção no bloco de instruções abaixo, a mesma será tratada no bloco catch, posteriormente
            try
            {
                //Declarando e inicializando variável do tipo vetor de strings o valor da chamada ao método ReadAllLines do tipo File, passando como argumento para o parâmetro do método o valor da variável sourcePath
                string[] lines = File.ReadAllLines(sourcePath);

                //Palavra chave using que significa que depois que executar o bloco de instruções abaixo, todos os recursos criados no mesmo serão excluídos do sistema. Um objeto do tipo StreamWriter é criado com o valor da chamada ao método AppendText do tipo File, passando como argumento para o parâmetro do método o valor da variável targetPath
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    //Método repetitivo foreach, sendo repetido enquanto houver elementos na lista de elementos lines do tipo string, usando para isso, o apelido line para cada iteração
                    foreach (string line in lines)
                    {
                        //Imprime na tela o resultado da chamada ao método ToUpper do apelido line a cada iteração
                        sw.WriteLine(line.ToUpper());

                    }//Fim do método repetitivo foreach

                }//Fim do bloco de intruções using

            }//Fim do bloco de instruções try

            //Palavra chave catch que significa que, caso uma exceção no bloco de instruções acima seja encontrada, a mesma será capturada e tratada através do bloco de intruções abaixo
            catch (IOException e)
            {
                //Imprime na tela a frase abaixo
                Console.WriteLine("An error occurred");

                //Imprime na tela o resultado da chamada ao atributo Message do objeto recém-criado e
                Console.WriteLine(e.Message);

            }//Fim do bloco de instruções catch

        }//Fim do método principal Main

    }//Fim da classe TrabalhandoComArquivos4
}//Fim do namespace TrabalhandoComArquivos4