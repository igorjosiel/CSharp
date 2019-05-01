//Utilizando os namespace System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace ExercicioFixacao_23
namespace ExercicioFixacao_23
{
    //Classe ExercicioFixacao_23
    class ExercicioFixacao_23
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando objeto do tipo Retangulo e instanciando-o com a palavra-chave new
            Retangulo r = new Retangulo();

            //Imprime as frases na tela
            Console.Write("-----Entre com a largura e a altura do retangulo-----\n");
            Console.Write("Largura: ");

            //Atribui um valor à variável Largura do objeto r
            r.Largura = double.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.Write("Altura: ");

            //Atribui um valor à variável Altura do objeto r
            r.Altura = double.Parse(Console.ReadLine());

            //Imprime as frases na tela com as devidas invocações aos métodos do objeto r e com suas formatações
            Console.WriteLine("\nArea: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\nPerimetro: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\nDiagonal: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_23
}//Fim do namespace ExercicioFixacao_23
