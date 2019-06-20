//Usando os namespaces System e System.Collections.Generic
using System;
using System.Collections.Generic;

//Utilizando o namespace Conjuntos
namespace Conjuntos
{
    //Classe Conjuntos
    class Conjuntos
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e instanciando dois conjuntos dos tipos int A e B
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            //Adicionando elementos no conjunto A com o método Add passando como argumento o valor do elemento
            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            //Adicionando elementos no conjunto B com o método Add passando como argumento o valor do elemento
            B.Add(3);
            B.Add(4);
            B.Add(5);

            //Removendo elemento do conjunto B com o método Remove passando como argumento o valor do elemento
            B.Remove(5);

            //Imprime a frase na tela
            Console.WriteLine("-----Conjunto A-----");

            //Método repetitivo foreach para iterar o conjunto A
            foreach (int con in A)
            {
                //Imprime o elemento do conjunto em cada iteração
                Console.WriteLine(con);

            }//Fim do método repetitivo foreach

            //Imprime a frase na tela
            Console.WriteLine("\n-----Conjunto B-----");

            //Método repetitivo foreach para iterar o conjunto B
            foreach (int con in B)
            {
                //Imprime o elemento do conjunto em cada iteração
                Console.WriteLine(con);

            }//Fim do método repetitivo foreach

            //Imprime a frase na tela
            Console.Write("\nDigite um numero: ");

            //Declarando e inicializando variável do tipo int com valor digitado pelo usuário via teclado
            int num = int.Parse(Console.ReadLine());

            //Método condicional if-else composto. Verifica se o conjunto B possui o valor digitado na variável num através do método Contains passando como argumento o valor da variável num
            if (B.Contains(num))
            {
                //Imprime a frase na tela com o valor da variável num
                Console.WriteLine("\nO valor " + num + " pertence ao conjunto B\n");

            }//Fim do comando if do método condicional if-else composto

            //Se o conjunto B não possui o valor digitado na variável num
            else
            {
                //Imprime a frase na tela com o valor da variável num
                Console.WriteLine("\nO valor " + num + " nao pertence ao conjunto B\n");
            }//Fim do comando else do método condicional if-else composto

            //Verificando a diferença entre os conjuntos A e B através do método ExceptWith passando como argumento o conjunto que se deseja subtrair
            A.ExceptWith(B);

            //Imprime a frase na tela
            Console.WriteLine("\n-----Conjunto A atualizado: (A - B)-----");

            //Método repetitivo foreach para iterar o conjunto A
            foreach (int con in A)
            {
                //Imprime o elemento do conjunto em cada iteração
                Console.WriteLine(con);

            }//Fim do método repetitivo foreach

            //Verificando a união entre os conjuntos A e B através do método UnionWith passando como argumento algum dos conjuntos
            A.UnionWith(B);

            //Imprime a frase na tela
            Console.WriteLine("\n-----Conjunto A atualizado: (A U B)-----");

            //Método repetitivo foreach para iterar o conjunto A
            foreach (int con in A)
            {
                //Imprime o elemento do conjunto em cada iteração
                Console.WriteLine(con);

            }//Fim do método repetitivo foreach

            //Verificando a interseção entre os conjuntos A e B através do método IntersectWith passando como argumento algum dos conjuntos
            A.IntersectWith(B);

            //Imprime a frase na tela
            Console.WriteLine("\n-----Conjunto A atualizado: (A V B)-----");

            //Método repetitivo foreach para iterar o conjunto A
            foreach (int con in A)
            {
                //Imprime o elemento do conjunto em cada iteração
                Console.WriteLine(con);

            }//Fim do método repetitivo foreach

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe Conjuntos
}//Fim do namespace Conjuntos
