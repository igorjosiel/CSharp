//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace ExercicioFixacao_25
namespace ExercicioFixacao_25
{
    //Classe ExercicioFixacao_25
    class ExercicioFixacao_25
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando um objeto do tipo Aluno e instanciando-o com a palavra-chave new
            Aluno a = new Aluno();

            //Declarando variável do tipo int
            int i;

            //Imprime as frases na tela
            Console.WriteLine("-----Preencha os dados do aluno-----\n");
            Console.Write("Nome: ");

            //Atribui um valor ao atributo Nome do objeto a
            a.Nome = Console.ReadLine();

            //Imprime a frase na tela
            Console.WriteLine("Digite as tres notas do aluno - ");

            //Comando de repetição for que é usado para preencher o atributo vetor do objeto a
            for (i = 0; i < 3; i ++)
            {
                //Preenche a posição do vetor a cada iteração
                a.Notas[i] = double.Parse(Console.ReadLine());

            }//Fim do comando de repetição for

            //Imprime a frase na tela com as devidas formatações e invocações de método e atributo do objeto a
            Console.Write("\n" + a.ResultadoAluno() + "\nA nota total do aluno durante o ano letivo foi: " + a.NotaTotal.ToString("F2", CultureInfo.InvariantCulture) + " pontos.\n");

            //Imprime a frase na tela com as devidas formatações e invocação de método do objeto a
            Console.Write("\nFaltaram " + a.VerificaPendencia().ToString("F2", CultureInfo.InvariantCulture) + " pontos para o aluno ser aprovado.\n\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_25
}//Fim do namespace ExercicioFixacao_25
