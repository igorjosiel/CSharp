//Utilizando o namespace ModificadorParametroParams
namespace ModificadorParametroParams
{
    //Classe SomaVariavel
    class SomaVariavel
    {
        //Declarando um método public static do tipo int Soma com entrada de parâmetros do tipo vetor com valores int e com a palavra-chave params para especificar que o método pode receber uma quantidade variável de argumentos
        public static int Soma(params int[] numbers)
        {
            //Declara uma variável do tipo int e inicializando-a com o valor 0
            int soma = 0;

            //Método repetitivo for para iterar por todo o vetor recebido como parâmetro até encontrar a posição final do vetor, feito com o atributo Length
            for (int i = 0; i < numbers.Length; i ++)
            {
                //Variável soma é inrementada com o valor do vetor na posição i
                soma += numbers[i];

            }//Fim do método de repetição for

            //Retorna ao método chamador o valor da variável soma
            return soma;

        }//Fim do método Soma
    }//Fim da classe SomaVariável
}//Fim do namespace ModificadorParametroParams
