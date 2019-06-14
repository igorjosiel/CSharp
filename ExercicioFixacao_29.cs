//Usando os namespaces System e System.Collections.Generic
using System;
using System.Collections.Generic;

//Utilizando o namespace ExercicioFixacao_29
namespace ExercicioFixacao_29
{
    //Classe ExercicioFixacao_29
    class ExercicioFixacao_29
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando variáveis dos tipos string, int e double
            string nome;
            int id;
            double salario;

            //Imprime a frase na tela
            Console.Write("Quantos funcionarios deseja cadastrar? ");

            //Declarando variável do tipo int e inicializando-a com um valor digitado pelo usuário via teclado
            int quant = int.Parse(Console.ReadLine());

            //Declarando e instanciando uma lista do tipo Funcionario
            List<Funcionario> funcio = new List<Funcionario>();

            //Comando repetitivo for para iterar pela lista inserindo objetos na mesma
            for (int i = 0; i < quant; i ++)
            {
                //Imprime a frase na tela com o valor da variável i somado com 1
                Console.WriteLine("\n---" + (i + 1) + "° Funcionario---");

                //Imprime a frase na tela
                Console.Write("Nome: ");

                //Inicializa a variável com um valor digitado pelo usuário via teclado
                nome = Console.ReadLine();

                //Imprime a frase na tela
                Console.Write("Id: ");

                //Inicializa a variável com um valor digitado pelo usuário via teclado
                id = int.Parse(Console.ReadLine());

                //Imprime a frase na tela
                Console.Write("Salario: ");

                //Inicializa a variável com um valor digitado pelo usuário via teclado
                salario = double.Parse(Console.ReadLine());

                //Instanciando um objeto do tipo Funcionario passando como argumento para o construtor as três variáveis inicializadas
                Funcionario f = new Funcionario(id, nome, salario);

                //Inserindo na lista funcio o objeto instanciado anteriormente através do método Insert passando como argumento o índice que será inserido, o valor de i, e o objeto a ser inserido
                funcio.Insert(i, f);

            }//Fim do comando repetitivo for

            //Imprime a frase na tela
            Console.Write("\nDigite o valor do Id de um funcionario: ");

            //Alterando o valor da variável id pelo usuário via teclado
            id = int.Parse(Console.ReadLine());

            //Declarando variável do tipo int e inicializando-a com o valor 0
            int cont = 0;

            //Método repetitivo for para iterar pela lista
            //Atributo Count da lista armazena o tamanho da mesma
            for (int i = 0; i < funcio.Count; i ++)
            {
                //Comando condicional if-else simples. Verifica se a lista na posição i possui o Id do objeto igual ao valor da variável id
                if (funcio[i].Id == id)
                {
                    //Imprime as frases na tela com o valor do atributo Nome do objeto inserido na posição i da lista
                    Console.WriteLine("\n---Funcionario encontrado---");
                    Console.Write("Deseja aumentar o salario do(a) " + funcio[i].Nome + " em quanto? Digite em porcentagem: ");

                    //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
                    int porcento = int.Parse(Console.ReadLine());

                    //Acessando o método setAumentaSalario do objeto presente na posição i da lista passando como argumento o valor da variável porcent
                    funcio[i].setAumentaSalario(porcento);

                    //Incrementa a variável cont
                    cont++;

                }//Fim do comando if do método simples if-else
            }//Fim do método repetitivo for

            //Comando condicional if-else simples. Verifica se a variável cont possui valor igual a 0
            if (cont == 0)
            {
                //Imprime a frase na tela
                Console.WriteLine("\nFuncionario nao encontrado.\n");

            }//Fim do comando condicional if-else siples

            //Imprime a frase na tela
            Console.WriteLine("\n-----Listagem atualizada dos funcionarios-----");

            //Método repetitivo foreach para iterar pela lista
            foreach (Funcionario f in funcio)
            {
                //A cada iteração da lista acessa o método ToString() do objeto na iteração atual
                Console.WriteLine(f.ToString());

            }//Fim do método repetitivo foreach

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe ExercicioFixacao_29
}//Fim do namespace ExercicioFixacao_29
