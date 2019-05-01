//Utilizando o namespace System
using System;

//Usando o namespace PrimeiroOrientadoAObjetos
namespace PrimeiroOrientadoAObjetos
{
    //Classe Triangulo
    class Triangulo
    {
        //Atributos da classe do tipo double sendo declarados como public
        public double A;
        public double B;
        public double C;

        //Declarando método public Area do tipo double
        public double Area()
        {
            //Declarando variável p do tipo double
            double p = (A + B + C) / 2.0;

            //Retorna à função chamadora o resultado da operação
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }//Fim do método Area()

    }//Fim da classe Triangulo
}//Fim do namespace PrimeiroOrientadoAObjetos
