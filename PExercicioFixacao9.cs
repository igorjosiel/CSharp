//Usando namespace System
using System;

//Utilizando namespace exercicioFixacao9
namespace ExercicioFixacao9
{
    //Classe ExercicioFixacao9
    class ExercicioFixacao9
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite a hora inicial e a hora final do jogo: ");

            //Declarando variáveis do tipo int e inicializando-as com valores digitados pelo usuário via teclado, utilizando o método int.Parse(Console.ReadLine()) para converter as strings em valores int
            int horaInicial = int.Parse(Console.ReadLine());
            int horaFinal = int.Parse(Console.ReadLine());

            //Declarando variável do tipo int
            int duracao;

            //Usando o método condicional if-else encadeado para testar as condições, se a condição if for verdadeira, executa o bloco de intruções e termina o método, senão, pula para a próxima
            if (horaInicial < horaFinal)
            {
                //Variável duracao recebe o valor da diferença da hora final pela hora inicial
                duracao = horaFinal - horaInicial;

            }//Fim do comando if do método condicional if-else encadeado

            //Se a condição anterior foi falsa, testa a condição else-if, se for verdadeira, executa o bloco de instruções, senão, pula para o próximo
            else if (horaInicial > horaFinal)
            {
                //Variável duracao recebe o valor da diferença de 24 pela hora inicial somando com o valor da hora final
                duracao = (24 - horaInicial) + horaFinal;

            }//Fim do comando else-if do método condicional if-else encadeado

            //Se a condição anteiror foi falsa, executa o bloco de intruções do comando else
            else
            {
                //Variável duracao recebe o valor 24
                duracao = 24;

            }//Fim do comando else do método if-else encadeado

            //Imprime a frase na tela com o valor da variável duracao, usando o método de impressão Concatenação
            Console.WriteLine("\nA duracao do jogo foi de: " + duracao + " horas.\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao9
}//Fim do namespace ExercicioFixacao9
