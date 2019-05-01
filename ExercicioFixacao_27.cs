//Usando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Utilizando o namespace ExercicioFixacao_27
namespace ExercicioFixacao_27
{
    //Classe ExercicioFixacao_27
    class ExercicioFixacao_27
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime a frase na tela
            Console.WriteLine("-----Criacao de conta-----\n");

            //Declarando variáveis dos tipos int, string e double
            int numero;
            string nome;
            int opcao;
            double valor;

            //Imprime a frase na tela
            Console.Write("Numero da conta: ");

            //Atribuindo um valor via teclado à variável do tipo int numero
            numero = int.Parse(Console.ReadLine());

            //Imprime a frase na tela
            Console.Write("Nome do titular: ");

            //Atribuindo um valor via teclado à variável do tipo string nome
            nome = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Valor do deposito inicial: ");

            //Atribuindo um valor via teclado à variável do tipo double valor, usando o CultureInfo.InvariantCulture para fixar o ponto separador das casas decimais
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando e instanciando um objeto do tipo ContaBancaria utilizando o construtor com três parâmetros para inicializar seus atributos
            ContaBancaria conta1 = new ContaBancaria(numero, nome, valor);
  
            //Imprime o resultado da chamada ao método ToString do objeto na tela
            Console.Write(conta1.ToString());

            //Comando de repetição do while para iterar os comandos até que se digite um valor inválido
            do
            {
                //Imprime a frase na tela
                Console.Write("\nDeseja realizar deposito ou saque? Deposito - (1) / Saque - (2): ");

                //Atribui um valor via teclado à variável do tipo int opcao
                opcao = int.Parse(Console.ReadLine());

                //Comando de repetição if-else encadeado
                //Se o valor da variável opcao for igual a 1, executa o bloco de intruções abaixo
                if (opcao == 1)
                {
                    //Imprime as frases na tela
                    Console.Write("\n-----Operacao de deposito-----\n");
                    Console.Write("\nDeseja depositar quanto? ");

                    //Atribui um valor via teclado à variável do tipo double valor, usando o CultureInfo.InvariantCulture para fixar o ponto separador das casas decimais
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Realiza uma chamada ao método deposito do objeto conta1 passando como argumento o valor da variável valor
                    conta1.Deposito(valor);

                    //Imprime a frase na tela
                    Console.Write("\nDados da conta atualizados: \n");

                    //Imprime o resultado da chamada ao método ToString na tela
                    Console.Write(conta1);

                }//Fim do comando if do método condicional if-else encadeado

                //Senão, se o valor da variável opcao for igual a 2, executa o bloco de instruções abaixo
                else if (opcao == 2)
                {
                    //Imprime as frases na tela
                    Console.Write("\n-----Operacao de saque-----\n");
                    Console.Write("\nDeseja sacar quanto? ");

                    //Atribui um valor via teclado à variável do tipo double valor, usando o CultureInfo.InvariantCulture para fixar o ponto separador das casas decimais
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Realiza uma chamada ao método saque do objeto conta1 passando como argumento o valor da variável valor
                    conta1.Saque(valor);

                    //Imprime a frase na tela
                    Console.Write("\nDados da conta atualizados: \n");

                    //Imprime o resultado da chamada ao método ToString do objeto conta1 na tela
                    Console.Write(conta1);

                }//Fim do comando else if do método condicional if-else encadeado

                //Senão, executa o bloco de instruções abaixo
                else
                {
                    //Imprime a frase na tela
                    Console.Write("\nOperacao inexistente!\n");

                    //Imprime o resultado da chamada ao método ToString do objeto conta1 na tela
                    Console.Write(conta1.ToString());

                }//Fim do comando else do método condicional if-else encadeado

            //Enquanto o valor da variável opcao for igual a 1 ou 2, executa o bloco de instruções acima, quando não mais, termina o método de repetição do while
            } while (opcao == 1 || opcao == 2);

            //Salta uma linha
            Console.Write("\n");

        }//Fim do método principal Main
    }//Fim da classe ExercicioFixacao_27
}//Fim do namespace ExercicioFixacao_27
