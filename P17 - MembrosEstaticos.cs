//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace MembrosEstaticos
namespace MembrosEstaticos
{
    //Classe MembrosEstaticos
    class MembrosEstaticos
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Entre com o valor do raio: ");

            //Declarando variável do tipo double e inicializando-a com um valor digitado pelo usuário
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando variáveis do tipo double e inicializando-as com os resultados das chamadas aos métodos Circunferencia e volume passando como parâmetro o valor da variável raio
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            //Imprime as frases na tela com as devidas formatações e valores das variáveis circ, volume e PI
            Console.WriteLine("\nCircunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));
            
        }//Fim do método Main
    }//Fim da classe MembrosEstaticos
}//Fim do namespace MembrosEstaticos
