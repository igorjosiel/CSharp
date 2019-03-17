//Usando o namespace System
using System;

//Utilizando o namespae OperadoresAritméticos
namespace OperadoresAritméticos
{
    //Classe OperadoresAritméticos
    class OperadoresAritméticos
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarações de variáveis com seus respectivos tipos sendo inicializadas com operações aritméticas
            int n1 = 3 + 4 * 2;

            //Utilizando parênteses para forçar a precedência
            int n2 = (3 + 4) * 2;

            //Operador mod (%) para capturar o resto da divisão
            int n3 = 17 % 3;

            //Utilizando o comando de conversão cast para converter o número 10 que é int em double
            double n4 = (double) 10 / 8;

            //Declarando três variáveis do tipo double na mesma linha após vírgulas
            double a = 1.0, b = -3.0, c = -4.0;

            //Declarando variável delta do tipo double recebendo o valor da operação
            //O comando Math.Pow(base, expoente) é usado para calcular exponenciação
            double delta = Math.Pow(b, 2.0) - 4 * a * c;

            //Variáveis x1 e x2 recebendo os valores das operações
            //O comando Math.Sqrt(número) é usado para calcular a raíz quadrada de um número
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            //Imprimindo os valores das variáveis na tela
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            
            //Quebra de linha
            Console.Write("\n");

        }//Fim do método Main
    }//Fim da classe OperadoresAritméticos
}//Fim de namespace OperadoresAritméticos
