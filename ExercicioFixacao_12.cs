//Usando os namespaces System e System.Globalization 
using System;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao12
namespace ExercicioFixacao12
{
    //Classe ExercicioFixacao12
    class ExercicioFixacao12
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("Digite o seu salario: ");

            //Declarando a variável double e inicializando-a com um valor digitado pelo usuário via teclado, usando o método double.Parse(Console.ReadLine()) para converter a string em um valor do tipo double
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando variável do tipo double
            double imposto;

            //Usando método condicional if-else encadeado para testar as condições. Se a condição no comando if for verdadeira, executa o bloco de instruções e termina o método, senão, pula para o próximo teste
            if (salario > 0.0 && salario <= 2000.00)
            {
                //Imprime a frase na tela com a quebra de linha
                Console.WriteLine("\nIsento do imposto de renda.\n");

                //Variável imposto recebe o valor double 0.0
                imposto = 0.0;

            }//Fim do comando if do método if-else encadeado

            //Se a condição no if anterior foi falsa, testa a condição no comando else if a seguir. Se a condição for verdadeira, executa o bloco de instruções, senão, pula para o próximo treste
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                //Variável imposto recebe o valor salario subtraindo 2000.00 multiplicando por 8 %
                imposto = (salario - 2000.00) * 0.08;

            }//Fim do comando else if do método if-else encadeado

            //Se a condição no else if anterior foi falsa, testa a condição no else if a seguir. Se a condição for verdadeira, executa o bloco de instruções, senão, pula para o próximo teste
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                //Variável imposto recebe o valor 3000.00 subtraindo 2000.00 multiplicando por 8 % somando com salario subtraindo 3000.00 e multiplicando por 18 %
                imposto = ((3000.00 - 2000.00) * 0.08) + (salario - 3000.00) * 0.18;

            }//Fim do comando else if do método if-else encadeado

            //Se a condição no else if anterior foi falsa, executa o bloco de instruções do comando else
            else
            {
                //Variável imposto recebe 4500.00 subtraindo 2000.00, multiplicando por 18 % somando com a subtração do salario por 4500.00 e multiplicando por 28 %
                imposto = ((4500.00 - 2000.00) * 0.18) + (salario - 4500.00) * 0.28;

            }//Fim do comando else do método if-else encadeado

            //Imprime a frase na tela com o valor da variável imposto e utilizando o método ToString("F2", CultureInfo.InvariantCulture) para fixar duas casas decimais depois do ponto decimal e fixar o ponto separador da parte inteira da parte decimal e com a quebra de linha
            Console.WriteLine("\nO imposto a ser pago por voce e: R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture) + ".\n");

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao12
}//Fim do namespace ExercicioFixacao12
