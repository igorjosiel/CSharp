//Utilizando os namespaces System, System.Globalization, System.IO e ExercicioFixacao_37.Entities
using System;
using System.Globalization;
using System.IO;
using ExercicioFixacao_37.Entities;

//Usando o namespace ExercicioFixacao_37
namespace ExercicioFixacao_37
{
    //Classe ExercicioFixacao_37
    class ExercicioFixacao_37
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime na tela a frase abaixo
            Console.Write("Enter file full path: ");

            //Declarando e atribuindo à variável do tipo string com a chamada ao método ReadLine da classe Console
            string sourceFilePath = Console.ReadLine();

            //Palavra chave try que significa que tentará rodar o programa, e se houver alguma exceção, a mesma será capturada e tratada com o bloco catch, posteriormente
            try
            {
                //Declarando e inicializando variável do tipo vetor string com a chamada ao método ReadAllLines da classe File, passando como argumento para o parâmetro do mesmo o valor da variável sourceFilePath
                string[] lines = File.ReadAllLines(sourceFilePath);

                //Declarando e atribuindo às variáveis do tipo string os valores da chamada aos respectivos métodos abaixo
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                //Acionando o método CreateDirectory da classe Directory, passando como argumento para o parâmetro do mesmo o valor da variável targetFolderPath
                Directory.CreateDirectory(targetFolderPath);

                //Palavra chave using que significa que os recursos criados no bloco de instruções abaixo serão automaticamente eliminados após o término do bloco
                //Declarando variável do tipo StreamWriter com a chamada ao método AppendText da classe File, passando como argumento para o parâmetro do mesmo o valor da variável targetFilePath
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    //Método repetitivo foreach sendo repetido enquanto houver elementos na variável lines do tipo string, usando para isso o apelido line
                    foreach (string line in lines)
                    {
                        //Declarando e atribuindo à variável do tipo string o valor da chamada ao método line.Split, passando como argumento para o parâmetro do mesmo o caracter ,
                        string[] fields = line.Split(',');

                        //Declarando e atribuindo à variável do tipo string o valor da variável fields na posição 0
                        string name = fields[0];

                        //Declarando e atribuindo às variáveis dos tipos double e int os valores da chamada aos métodos Parse do tipo double, passando como argumento para o parâmetro do método o valor da variável fields[1] e a chamada ao atributo InvariantCulture do tipo CultureInfo e Parse do tipo int, passando como argumento para o parâmetro do método o valor da variável fields[2]
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        //Declarando e instanciando um objeto do tipo Product com a palavra chave new, passando como argumento para o parâmetro do método os valores das variáveis name, price e quantity
                        Product prod = new Product(name, price, quantity);

                        //Acionando o método WriteLine da variável sw, passando como argumento para o parâmetro do método a expressão: prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture
                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));

                    }//Fim do método repetitivo foreach

                }//Fim do bloco de instruções using

            }//Fim do bloco de instruções try

            //Palavra chave catch que significa que caso exista alguma exceção no bloco de instruções acima, a mesma será capturada e tratada com o bloco de instruções abaixo
            catch (IOException e)
            {
                //Imprime a frase abaixo na tela
                Console.WriteLine("An error occurred");

                //Imprime na tela o valor do atributo Message da variável recém-criada e
                Console.WriteLine(e.Message);

            }//Fim do bloco de instruções catch

        }//Fim do método principal Main

    }//Fim da classe ExercicioFixacao_37
}//Fim do namespace ExercicioFixacao_37
