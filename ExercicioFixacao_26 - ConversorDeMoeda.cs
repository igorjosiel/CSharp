//Utilizando o namespace ExercicioFixacao_26
namespace ExercicioFixacao_26
{
    //Classe ConversorDeMoeda
    class ConversorDeMoeda
    {
        //Declarando atributo estático do tipo double e inicializando-o com o valor 6.0
        public static double iof = 6.0;

        //Método do tipo double como sendo estático recebendo como argumento dois valores do tipo double
        public static double PagarDolar(double cotacao, double compraDolar)
        {
            //Declarando variável do tipo double para armazenar na mesma o valor da conversão do dolar
            double total = cotacao * compraDolar;

            //Retornando o resultado da expressão abaixo ao método chamador
            return total + total * iof/100;

        }//Fim do método PagarDolar

    }//Fim da classe ConversorDeMoeda
}//Fim do namespace ExercicioFixacao_26
