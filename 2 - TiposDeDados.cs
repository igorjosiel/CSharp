//Usando o namespace System
using System;

//Utilizando o namespace TiposDeDados
namespace TiposDeDados
{
    //Classe 
    class TiposDeDados
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarações de diversas variáveis com seus tipos sendo inicializadas
            sbyte n1 = 100;
            byte n2 = 0;
            int n3 = 1000;
            long n4 = 10999230449L;
            bool completo = false;
            char genero = 'F';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj = "Alex Brown";

            //Imprimindo na tela os valores respectivos das variáveis
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(nome);
            Console.WriteLine(obj);

        }//Fim do método Main
    }//Fim da classe TiposDeDados
}//Fim do namespace TiposDeDados
