//Usando os namespaces System e System.Collections.Generic
using System;
using System.Collections.Generic;

//Utilizando o namespace ExercicioFixacao_31
namespace ExercicioFixacao_31
{
    //Classe ExercicioFixacao_31
    class ExercicioFixacao_31
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando variáveis do tipo int
            int quantAlunos, codigo;

            //Imprime a frase na tela
            Console.WriteLine("-----Cursos ministrados por Joaquim-----");

            //Declarando e instanciando conjuntos do tipo int: A, B, C e D
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> D = new HashSet<int>();

            //Imprime a frase na tela
            Console.Write("\nO curso A possui quantos alunos: ");

            //Inicializando a variável quantAlunos sendo digitado pelo usuário através do teclado
            quantAlunos = int.Parse(Console.ReadLine());

            //Método repetitivo for para adicionar elementos no conjunto A
            for (int i = 0; i < quantAlunos; i ++)
            {
                //Imprime a frase na tela com o valor da variável i acrescentada de 1
                Console.Write("Digite o codigo do " + (i + 1) + "° aluno: ");

                //Atribuindo à variável codigo um valor digitado pelo usuário via teclado
                codigo = int.Parse(Console.ReadLine());

                //Adicionando um elemento ao conjunto A através do método Add passando como argumento o valor da variável codigo
                A.Add(codigo);

                //Adicionando ao conjunto D o último elemento que foi inserido no conjunto A, sem repetições
                D.Add(codigo);

            }//Fim do método repetitivo for

            //Imprime a frase na tela
            Console.Write("\nO curso B possui quantos alunos: ");

            //Inicializando a variável quantAlunos sendo digitado pelo usuário através do teclado
            quantAlunos = int.Parse(Console.ReadLine());

            //Método repetitivo for para adicionar elementos no conjunto B
            for (int i = 0; i < quantAlunos; i++)
            {
                //Imprime a frase na tela com o valor da variável i acrescentada de 1
                Console.Write("Digite o codigo do " + (i + 1) + "° aluno: ");

                //Atribuindo à variável codigo um valor digitado pelo usuário via teclado
                codigo = int.Parse(Console.ReadLine());

                //Adicionando um elemento ao conjunto B através do método Add passando como argumento o valor da variável codigo
                B.Add(codigo);

                //Adicionando ao conjunto D o último elemento que foi inserido no conjunto B, sem repetições
                D.Add(codigo);

            }//Fim do método repetitivo for

            //Imprime a frase na tela
            Console.Write("\nO curso C possui quantos alunos: ");

            //Inicializando a variável quantAlunos sendo digitado pelo usuário através do teclado
            quantAlunos = int.Parse(Console.ReadLine());

            //Método repetitivo for para adicionar elementos no conjunto C
            for (int i = 0; i < quantAlunos; i++)
            {
                //Imprime a frase na tela com o valor da variável i acrescentada de 1
                Console.Write("Digite o codigo do " + (i + 1) + "° aluno: ");

                //Atribuindo à variável codigo um valor digitado pelo usuário via teclado
                codigo = int.Parse(Console.ReadLine());

                //Adicionando um elemento ao conjunto C através do método Add passando como argumento o valor da variável codigo
                C.Add(codigo);

                //Adicionando ao conjunto D o último elemento que foi inserido no conjunto C, sem repetições
                D.Add(codigo);

            }//Fim do método repetitivo for

            //Declarando variável do tipo int e inicializando-a com o valor 0
            int cont = 0;

            //Método repetitivo foreach para iterar pelo conjunto D
            foreach (int alunos in D)
            {
                //A cada iteração do conjunto D acrescenta 1 à variável cont
                cont++;

            }//Fim do método repetitivo foreach

            //Imprime a frase na tela com o valor da variável cont
            Console.WriteLine("\nTotal de alunos: " + cont + "\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_31
}//Fim do namespace ExercicioFixacao_31
