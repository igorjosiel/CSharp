//Usando o namespace System
using System;

//Utilizando o namespace MembrosEstaticos
namespace MembrosEstaticos
{
    //Classe Calculadora
    class Calculadora
    {
        //Declarando variável do tipo double como estática e inicializando-a com o valor 3.14
        public static double PI = 3.14;

        //Método do tipo double como sendo estático e recebendo como argumento uma variável double
        public static double Circunferencia(double r)
        {
            //Retorna o resultado da operação abaixo ao método chamador
            return 2 * PI * r;

        }//Fim do método Circunferencia

        //Método do tipo double como sendo estático e recebendo como argumento uma variável double
        public static double Volume(double r)
        {
            //Retorna o resultado da operação abaixo ao método chamador
            return 4.0 / 3.0 * PI * Math.Pow(r, 3);

        }//Fim do método Volume

    }//Fim da classe Calculadora
}//Fim do namespace MembrosEstaticos
