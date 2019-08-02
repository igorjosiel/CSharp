//Usando os namespaces System e System.IO
using System;
using System.IO;

//Utilizando o namespace TrabalhandoComArquivos3
namespace TrabalhandoComArquivos3
{
    //Classe TrabalhandoComArquivos3
    class TrabalhandoComArquivos3
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e atribuindo à variável do tipo string o valor do caminho do diretório do arquivo: C:\wamp\file1.txt
            string path = @"C:\wamp\file1.txt";

            //Palavra chave try que significa que ao executar o programa, se houver alguma exceção no bloco de instruções abaixo, a mesma será tratada no bloco catch, posteriormente
            try
            {
                //Palavra chave using que significa que depois que executar o bloco de instruções abaixo, todos os recursos criados no mesmo serão excluídos do sistema. Um objeto do tipo StreamReader é criado com o valor da chamada ao método OpenText do tipo File, passando como argumento para o parâmetro do método o valor da variável path
                using (StreamReader sr = File.OpenText(path))
                {
                    //Método repetitivo while, sendo repetido enquanto o valor do atributo EndOfStream do objeto sr for falso, com o operador de negação (!)
                    while (!sr.EndOfStream)
                    {
                        //Declarando e inicializando variável do tipo string com a chamada ao método ReadLine do objeto sr
                        string line = sr.ReadLine();

                        //Imprime na tela o valor da variável line
                        Console.WriteLine(line);

                    }//Fim do método repetitivo while

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

    }//Fim da classe TrabalhandoComArquivos3
}//Fim do namespace TrabalhandoComArquivos3
