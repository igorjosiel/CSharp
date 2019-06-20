//Usando o namespace System
using System;

//Utilizando o namespace SwitchCase
namespace SwitchCase
{
    //Classe Switch_Case
    class Switch_Case
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.Write("Digite um numero: ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado
            int x = int.Parse(Console.ReadLine());

            //Declarando variável do tipo string
            string dia;

            //Método condicional switch case, que testa a partir do valor de uma variável (x) várias opções de resultados
            switch (x)
            {
                //Caso o valor da variável x seja 1, a variável dia recebe o valor "Sunday"
                case 1: dia = "Sunday";

                    //A palavra-chave break encerra a execução de um case
                    break;

                //Caso o valor da variável x seja 2, a variável dia recebe o valor "Monday"
                case 2: dia = "Monday";

                    //A palavra-chave break encerra a execução de um case
                    break;

                //Caso o valor da variável x seja 3, a variável dia recebe o valor "Tuesday"
                case 3: dia = "Tuesday";

                    //A palavra-chave break encerra a execução de um case
                    break;

                //Caso o valor da variável x seja 4, a variável dia recebe o valor "Wednesday"
                case 4: dia = "Wednesday";

                    //A palavra-chave break encerra a execução de um case
                    break;

                //Caso o valor da variável x seja 5, a variável dia recebe o valor "Thursday"
                case 5: dia = "Thursday";

                    //A palavra-chave break encerra a execução de um case
                    break;

                //Caso o valor da variável x seja 6, a variável dia recebe o valor "Friday"
                case 6: dia = "Friday";

                    //A palavra-chave break encerra a execução de um case
                    break;

                //Caso o valor da variável x seja 7, a variável dia recebe o valor "Saturday"
                case 7: dia = "Saturday";

                    //A palavra-chave break encerra a execução de um case
                    break;

                //Caso o valor da variável x seja diferente de todas as opções possíveis, a variável dia recebe o valor "Invalid Value" através da palavra-chave default
                default: dia = "Invalid value";

                    //A palavra-chave break encerra a execução de um case
                    break;

            }//Fim do método condicional switch case

            //Imprime o valor da variável dia na tela
            Console.WriteLine(dia);
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe Switch_Case
}//Fim do namespace Switch_Case
