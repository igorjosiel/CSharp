//Utilizando o namespace System
using System;

//Usando o namespace ExercicioFixacao_21
namespace ExercicioFixacao_21
{
    //Classe ExercicioFixacao_21
    class ExercicioFixacao_21
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando dois objetos do tipo Pessoa
            Pessoa p1, p2;

            //Instanciando os objetos com a palavra-chave new
            p1 = new Pessoa();
            p2 = new Pessoa();

            //Imprime as frases na tela
            Console.WriteLine("-----Digite os dados da primeira pessoa-----\n");
            Console.Write("Nome: ");

            //Atribuindo um valor ao atributo nome do objeto p1
            p1.nome = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Idade: ");

            //Atribuindo um valor ao atributo idade do objeto p1
            p1.idade = int.Parse(Console.ReadLine());

            //Imprime as frases na tela
            Console.WriteLine("\n-----Digite os dados da segunda pessoa-----\n");
            Console.Write("Nome: ");

            //Atribuindo um valor ao atributo nome do objeto p2
            p2.nome = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Idade: ");

            //Atribuindo um valor ao atributo idade do objeto p2
            p2.idade = int.Parse(Console.ReadLine());

            //Estrutura condicional if-else composto
            //Se o valor do atributo idade do objeto p1 for maior que o valor do atributo idade do objeto p2 executa o bloco de instruções abaixo
            if (p1.idade > p2.idade)
            {
                //Imprime a frase na tela com a concatenação necessária
                Console.WriteLine("\nPessoa mais velha: " + p1.nome + ".\n");

            }//Fim do comando if da estrutura condicional if-else composto

            //Senão, executa o bloco de instruções abaixo
            else
            {
                //Imprime a frase na tela com a concatenaçaõ necessária
                Console.WriteLine("\nPessoa mais velha: " + p2.nome + ".\n");
                
            }//Fim do comando else da estrutura condicional if-else composto

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_21
}//Fim do namespace ExercicioFixacao_21
