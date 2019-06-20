//Utilizando o namespace System
using System;

//Usando o namespace ExercicioFixacao_23
namespace ExercicioFixacao_23
{
    //Classe Retangulo
    class Retangulo
    {
        //Atributos da classe do tipo double
        public double Largura;
        public double Altura;

        //Método da classe para calcular a área do retângulo
        public double Area()
        {
            //Retorna ao método chamador o resultado da expressão
            return Largura * Altura;

        }//Fim do método Area

        //Método para calcular o perímetro do retângulo
        public double Perimetro()
        {
            //Retorna ao método chamador o resultado da expressâo
            return 2 * (Largura + Altura);

        }//Fim do método Perimetro

        //Método para calcular a diagonal do retângulo
        public double Diagonal()
        {
            //Declarando variável do tipo double
            double x;

            //Inicializando a variável x com a expressão abaixo
            x = Math.Pow(Largura, 2) + Math.Pow(Altura, 2);

            //Retorna ao método chamador o resultado da expressão
            return Math.Sqrt(x);

        }//Fim do método Diagonal

    }//Fim da classe Retangulo
}//Fim do namespace ExercicioFixacao_23
