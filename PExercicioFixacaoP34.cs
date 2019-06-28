//Usando os namespaces System, System.Collections.Generic, ExercicioFixacao_34.Entities e System.Globalization
using System;
using System.Collections.Generic;
using ExercicioFixacao_34.Entities;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao_34
namespace ExercicioFixacao_34
{
    //Classe ExercicioFixacao_34
    class ExercicioFixacao_34
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e instanciando uma lista do tipo Product com a palavra-chave new
            List<Product> list = new List<Product>();

            //Imprime a frase na tela
            Console.Write("Enter the number of products: ");

            //Declarando e inicializando a variável do tipo int com um valor digitado pelo usuário via teclado
            int n = int.Parse(Console.ReadLine());

            //Salta uma linha
            Console.WriteLine();

            //Método repetitivo for para repetir tantas vezes enquanto o valor da variável i ser menor ou igual ao valor da variável n
            for (int i = 1; i <= n; i ++)
            {
                //Imprime as frases na tela com o valor da variável i com o método de impressão de interpolação
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i): ");

                //Declarando e inicializando a variável do tipo int com um valor digitado pelo usuário via teclado
                char ch = char.Parse(Console.ReadLine());

                //Imprime a palavra na tela
                Console.Write("Name: ");

                //Declarando e inicializando a variável do tipo int com um valor digitado pelo usuário via teclado
                string name = Console.ReadLine();

                //Imprime a palavra na tela
                Console.Write("Price: ");

                //Declarando e inicializando a variável do tipo int com um valor digitado pelo usuário via teclado
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Método condicional if-else encadeado para testar os possíveis valores da variável ch do tipo char
                //Se o valor da variável ch for igual ao caracter i executa o bloco de instruções abaixo, senão pula para a próxima verificação
                if (ch == 'i')
                {
                    //Imprime a frase na tela
                    Console.Write("Customs fee: ");

                    //Declarando e inicializando a variável do tipo double com um valor digitado pelo usuário via teclado
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Acionando o método Add da lista list para adicionar o objeto do tipo ImportedProduct à mesma, passando como argumento para o construtor os valores inicializados acima
                    list.Add(new ImportedProduct(name, price, customsFee));

                }//Fim do comando if do método condicional if-else encadeado

                //Se o valor da variável ch for igual ao caracter u executa o bloco de instruções abaixo, senão pula para a próxima verificação
                else if (ch == 'u')
                {
                    //Imprime a frase na tela
                    Console.Write("Manufacture date: ");

                    //Declarando e inicializando a variável do tipo DateTime com um valor digitado pelo usuário via teclado
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    //Acionando o método Add da lista list para adicionar o objeto do tipo UsedProduct à mesma, passando como argumento para o construtor os valores inicializados acima
                    list.Add(new UsedProduct(name, price, manufactureDate));

                }//Fim do comando else if do método condicional if-else encadeado

                //Senão, executa o bloco de instruções abaixo
                else
                {
                    //Acionando o método Add da lista list para adicionar o objeto do tipo Product à mesma, passando como argumento para o construtor os valores inicializados acima
                    list.Add(new Product(name, price));

                }//Fim do comando else do método condicional if-else encadeado

                //Salta uma linha
                Console.WriteLine();

            }//Fim do método repetitivo for

            //Salta uma linha e imprime a frase na tela
            Console.WriteLine();
            Console.WriteLine("Price Tags: ");

            //Método repetitivo foreach para iterar por tada a lista list de elementos do tipo Product
            foreach (Product prod in list)
            {
                //Imprime na tela o resultado da chamada ao método PriceTag() de todos os elementos da lista
                Console.WriteLine(prod.PriceTag());

            }//Fim do método repetitivo foreach

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_34
}//Fim do namespace ExercicioFixacao_34
