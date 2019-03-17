//Usando o namespace System
using System;

//Utilizando o namespace ExercicioFixacao8
namespace ExercicioFixacao8
{
    //Classe ExercicioFixacao8
    class ExercicioFixacao8
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite dois numeros inteiros: ");

            //Declarando variáveis do tipo int e inicializando-as com valores digitados pelo usuário via teclado, através do método int.Parse(Console.ReadLine()) para converter as strings em valores int
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //Usando o método condicional if-else composto para testar a condição, se verdadeira, executa o bloco de intruções do comando if e termina a execução do método
            if (a % b == 0 || b % a == 0)
            {
                //Imprime a frase na tela com os respectivos valores das variáveis pelo método de impressão Concatenação
                Console.WriteLine("\nOs numeros " + a + " e " + b + " sao multiplos entre si.");
                
                //Quebra de linha
                Console.Write("\n");

            }//Fim do comando if do método if-else composto

            //Se a condição anterior foi falsa, executa o bloco de intruções do comando else
            else
            {
                //Imprime a frase na tela com os respectivos valores das variáveis usando o método de impressão Concatenação
                Console.WriteLine("\nOs numeros " + a + " e " + b + " nao sao múltiplos entre si.");
                
                //Quebra de linha
                Console.Write("\n");

            }//Fim do comando else do método if-else composto

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao8
}//Fim do namespace ExercicioFixacao8
