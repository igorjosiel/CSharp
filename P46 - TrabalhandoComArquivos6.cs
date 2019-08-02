//Usando os namespaces System e System.IO
using System;
using System.IO;

//Utilizando o namespace TrabalhandoComArquivos6
namespace TrabalhandoComArquivos6
{
    //Classe TrabalhandoComArquivos6
    class TrabalhandoComArquivos6
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e inicializando variável do tipo string com o valor do caminho do diretório do arquivo: C:\wamp\file1.txt
            string path = @"C:\wamp\file1.txt";

            //Imprime na tela as frases abaixo com os respectivos resultados das chamadas aos métodos da classe Path, passando como argumentos para os parâmetros dos mesmos quando necessário, o valor da variável path
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        }//Fim do método principal Main

    }//Fim da classe TrabalhandoComArquivos6
}//Fim do namespace TrabalhandoComArquivos6
