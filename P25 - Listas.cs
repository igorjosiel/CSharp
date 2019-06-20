//Usando os namespaces using System e using System.Collections.Generic
using System;
using System.Collections.Generic;

//Utilizando o namespace Listas
namespace Listas
{
    //Classe Listas
    class Listas
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e instanciando uma lista do tipo string sem especificar o tamanho
            List<string> lista1 = new List<string>();

            //Adicionando valores à lista com o método Add, passando como argumento o valor da string, que adiciona no final da lista
            lista1.Add("Maria");
            lista1.Add("Alex");
            lista1.Add("Bob");
            lista1.Add("Ana");
            lista1.Add("Igor");
            lista1.Add("Lucas");

            //Inserindo valor à lista com o método Insert, que insere em uma posição específica da lista, passando como argumento o valor da posição e o valor da string
            lista1.Insert(2, "Marco");

            //Imprime a frase na tela
            Console.WriteLine("-----Lista impressa-----");

            //Método repetitivo foreach para iterar por todas as posições da lista
            foreach (string str in lista1)
            {
                //Imprime a string de cada posição
                Console.WriteLine(str);

            }//Fim do método repetitivo foreach

            //Imprime a frase na tela com o valor do método Count da lista, que fornece o tamanho atual da lista
            Console.WriteLine("Tamanho da lista: " + lista1.Count);

            //Declarando variável do tipo string que recebe o valor do método Find da lista, passando como argumento uma expressão que implica que: a variável recebe a primeira string que possuir, na posição 0, a letra A
            string s1 = lista1.Find(x => x[0] == 'A');

            //Imprime a frase na tela com o valor da variável "s1"
            Console.WriteLine("A primeira string na lista que começa com a letra A e: " + s1);

            //Declarando variável do tipo string que recebe o valor do método FindLast da lista, passando como argumento uma expressão que implica que: a variável recebe a última string que possuir, na posição 0, a letra A
            string s2 = lista1.FindLast(x => x[0] == 'A');

            //Imprime a frase na tela com o valor da variável s2
            Console.WriteLine("A ultima string na lista que começa com a letra A e: " + s2);

            ////Declarando variável do tipo int que recebe o valor do método FindIndex da lista, passando como argumento uma expressão que implica que: a variável recebe o índice da primeira string que possuir, na posição 0, a letra A
            int pos1 = lista1.FindIndex(x => x[0] == 'A');

            //Imprime a frase na tela com o valor da variável pos1
            Console.WriteLine("O indice do primeiro elemento que comeca com  a letra A e: " + pos1);

            //Declarando variável do tipo int que recebe o valor do método FindLastIndex da lista, passando como argumento uma expressão que implica que: a variável recebe o índice da última string que possuir, na posição 0, a letra A
            int pos2 = lista1.FindLastIndex(x => x[0] == 'A');

            //Imprime a frase na tela com o valor da variável pos2
            Console.WriteLine("O indice do ultimo elemento que comeca com  a letra A e: " + pos2);

            //Declarando uma lista do tipo string e atribuindo à mesma os valores da lista1 que respeitem a seguinte restrição com o método FindAll da lista1: a lista recebe os valores que possuem tamanho igual a 5, com o método Length da lista1
            List<string> lista2 = lista1.FindAll(x => x.Length == 5);

            //Imprime a frase na tela
            Console.WriteLine("\n-----Lista contendo somente os valores da lista1 que possuem 5 caracteres-----");

            //Método repetitivo foreach para iterar pela lista2
            foreach (string str in lista2)
            {
                //Imprime o valor da string de cada posição
                Console.WriteLine(str);

            }//Fim do método repetitivo foreach

            //Removendo elemento da lista1 através do método Remove, que passa como argumento o valor do elemento
            lista1.Remove("Alex");

            //Imprime a frase na tela
            Console.WriteLine("\n-----Lista1 atualizada-----");

            //Método repetitivo foreach para iterar pela lista1
            foreach (string str in lista1)
            {
                //Imprime o valor da string de cada posição
                Console.WriteLine(str);

            }//Fim do método repetitivo foreach

            //Removendo vários elementos da lista1 através do método RemoveAll, que passa como argumento uma expressão que implica que: o elemento removido será o elemento que possuir na primeira posição a latra A
            lista1.RemoveAll(x => x[0] == 'M');

            //Imprime a frase na tela
            Console.WriteLine("\n-----Lista1 atualizada-----");

            //Método repetitivo foreach para iterar pela lista1
            foreach (string str in lista1)
            {
                //Imprime o valor da string de cada posição
                Console.WriteLine(str);

            }//Fim do método repetitivo foreach

            //Removendo elemento da lista1 através do método RemoveAt que passa como argumento o índice do elemento a ser retirado
            lista1.RemoveAt(0);

            //Imprime a frase na tela
            Console.WriteLine("\n-----Lista1 atualizada-----");

            //Método repetitivo foreach para iterar pela lista1
            foreach (string str in lista1)
            {
                //Imprime o valor da string de cada posição
                Console.WriteLine(str);

            }//Fim do método repetitivo foreach

            //Removendo vários elementos da lista1 através do método RemoveRange que passa como argumento os valores: do índice de início do intervalo a ser eliminado e do índice do término do intervalo
            lista1.RemoveRange(0, 2);

            //Imprime a frase na tela
            Console.WriteLine("\n-----Lista1 atualizada-----");

            //Método repetitivo foreach para iterar pela lista1
            foreach (string str in lista1)
            {
                //Imprime o valor da string de cada posição
                Console.WriteLine(str);

            }//Fim do método repetitivo foreach

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe Listas
}//Fim do namespace Listas
