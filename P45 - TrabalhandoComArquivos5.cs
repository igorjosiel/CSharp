//Usando os namespaces System, System.IO e System.Collections.Generic
using System;
using System.IO;
using System.Collections.Generic;

//Utilizando o namespace TrabalhandoComArquivos5
namespace TrabalhandoComArquivos5
{
    //Classe TrabalhandoComArquivos5
    class TrabalhandoComArquivos5
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e inicializando variável do tipo string com o valor do caminho do diretório da pasta: C:\wamp\myFolder
            string path = @"C:\wamp\myFolder";

            //Palavra chave try que significa que irá executar o bloco de instruções abaixo e, caso surja alguma exceção, a mesma será capturada e tratada no bloco catch, posteriormente
            try
            {
                //Declarando conjunto do tipo IEnumerable com elementos do tipo string, atribuindo ao mesmo, o valor da chamada ao método EnumerateDirectory do tipo Directory, passando como argumento para o parâmetro do mesmo os valores da variável path, da expressão: *.* e do valor AllDirectories do atributo SearchOption do tipo Directory
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                //Imprime na tela a expressão abaixo
                Console.WriteLine("-----FOLDERS-----");

                //Método repetitivo foreach para iterar enquanto existir elementos no conjunto folders do tipo string, usando para isso o apelido s para cada iteração
                foreach (string s in folders)
                {
                    //Imprime na tela o valor da variável s
                    Console.WriteLine(s);

                }//Fim do método repetitivo foreach

                //Declarando conjunto do tipo IEnumerable com elementos do tipo string, atribuindo ao mesmo, o valor da chamada ao método EnumerateDirectory do tipo Directory, passando como argumento para o parâmetro do mesmo os valores da variável path, da expressão: *.* e do valor AllDirectories do atributo SearchOption do tipo Directory
                IEnumerable<string> allFiles = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                //Salta uma linha
                Console.WriteLine();

                //Imprime na tela a expressão abaixo
                Console.WriteLine("-----FILES-----");

                //Método repetitivo foreach para iterar enquanto exixtir elementos no conjunto allFiles do tipo string, usando para isso o apelido s para cada iteração
                foreach (string s in allFiles)
                {
                    //Imprime na tela o valor da variável s
                    Console.WriteLine(s);

                }//Fim do método repetitivo foreach

                //Salta uma linha
                Console.WriteLine();

                //Acionando o método CreateDirectory do tipo Directory, passando como argumentos para o parâmetro do método o valor da variável path concatenado com a expressão de caminho de diretório: \newFolder
                Directory.CreateDirectory(path + @"\newFolder");

            }//Fim do bloco de instruções try

            //Palavra chave catch que indica que caso uma exceção seja encontrada no bloco de intruções try acima, a mesma será capturada e tratada, executando o bloco de instruções abaixo
            catch (IOException e)
            {
                //Imprime a frase abaixo na tela
                Console.WriteLine("An error accurred");

                //Imprime na tela o valor do atributo Message do objeto recém-criado e
                Console.WriteLine(e.Message);

            }//Fim do bloco catch

        }//Fim do método principal Main

    }//Fim da classe TrabalhandoComArquivos5
}//Fim do namespace TrabalhandoComArquivos5
