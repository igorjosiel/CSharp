//Utilizando o namespace System
using System;

//Usando o namespace Struct
namespace Struct
{
    //Classe Struct
    class Struct
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando um objeto p do tipo StructPoint
            StructPoint p;

            //Atribuindo valores aos atributos do objeto p
            p.x = 10.0;
            p.y = 1.00;

            //Imprime na tela o valor do objeto p
            Console.WriteLine(p);

            //Instanciando o objeto p do tipo StructPoint
            p = new StructPoint();

            //Imprime na tela o valor do objeto p
            Console.WriteLine(p);
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe Struct
}//Fim do namespace StructPoint
