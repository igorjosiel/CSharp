//Utilizando o namespace ExercicioFixacao_25
namespace ExercicioFixacao_25
{
    //Classe Aluno
    class Aluno
    {
        //Atributos da classe dos tipos string, double e vetor
        public string Nome;
        public double[] Notas = new double[3];
        public double NotaTotal;

        //Declarando variável do tipo int
        int i;

        //Método do tipo string para certificar que o aluno foi aprovado ou reprovado
        public string ResultadoAluno()
        {
            //Estrutura de repetição for para iterar pelo vetor todo
            for (i = 0; i < 3; i ++)
            {
                //Atributo NotaTotal é somado com os valores das posições do vetor
                NotaTotal += Notas[i];

            }//Fim do método de repetição for

            //Método condicional if-else composto
            //Se o valor do atributo NotaTotal for maior ou igual a 60, executa o bloco de instruções abaixo
            if (NotaTotal >= 60)
            {
                //Retorna a string abaixo ao método chamador
                return "APROVADO";

            }//Fim do comando if do método condicional if-else composto

            //Senão, executa o bloco de instruções abaixo
            else
            {
                //Retorna a string abaixo ao método chamador
                return "REPROVADO";

            }//Fim do comando else do método condicional if-else composto

        }//Fim do método ResultadoAluno

        //Método do tipo double que verifica quantos pontos de pendencia o aluno possui para ser aprovado
        public double VerificaPendencia()
        {
            //Método condicional if-else composto
            //Se o valor do atributo NotaTotal for menor que 60, executa o bloco de instruções abaixo
            if (NotaTotal < 60)
            {
                //Retorna o resultado da expressão abaixo ao método chamador
                return 60 - NotaTotal;

            }//Fim do comando if do método condicional if-else composto

            //Senão, executa o bloco de instruções abaixo
            else
            {
                //Retorna o valor 0.0 ao método chamador
                return 0.0;

            }//Fim do comando else do método if-else composto

        }//Fim do método VerificaPendencia
    }//Fim da classe Aluno
}//Fim do namespace ExercicioFixacao_25
