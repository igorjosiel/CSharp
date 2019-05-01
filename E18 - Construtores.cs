//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace Construtores
namespace Construtores
{
    //Classe Construtores
    class Construtores
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Imprime as frases na tela
            Console.WriteLine("-----Entre com os dados do produto-----\n");
            Console.Write("Nome: ");

            //Declarando variável do tipo string e atribuindo um valor à mesma
            string nome = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Preco: ");

            //Declarando variável do tipo double e atribuindo um valor à mesma com a seguinte formatação
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprime a frase na tela
            Console.Write("Quantidade no estoque: ");

            //Declarando variável do tipo int e atribuindo um valor à mesma
            int quantidade = int.Parse(Console.ReadLine());

            //Declarando um objeto do tipo Produto e instanciando-o com a palavra-chave new e passando como argumentos os valores das variáveis nome, preco e quantidade
            Produto p = new Produto(nome, preco, quantidade);

            //Imprime a frase na tela com a devida concatenação do valor da representação do objeto p
            Console.WriteLine("\nDados do produto: " + p + ".\n");

            //Imprime a frase na tela
            Console.WriteLine("Digite o numero de produtos a ser adicionado no estoque: ");

            //Declarando uma variável do tipo int e atribuindo um valor à mesma
            int add = int.Parse(Console.ReadLine());

            //Chamando o método AdicionarProdutos do objeto p passando como argumento o valor da variável add
            p.AdicionarProdutos(add);

            //Imprime a frase na tela com a devida concatenação do valor da representação do objeto p
            Console.WriteLine("\nDados atualizados: " + p + ".\n");

            //Imprime a frase na tela
            Console.WriteLine("Digite o numero de produtos a ser removidos do estoque: ");

            //Declarando uma variável do tipo int e atribuindo um valor à mesma
            int remov = int.Parse(Console.ReadLine());

            //Chamando o método RemoverProdutos do objeto p passando como argumento o valor da variável remov
            p.RemoverProdutos(remov);

            //Imprime a frase na tela com a devida concatenação do valor da representação do objeto p
            Console.WriteLine("\nDados atualizados: " + p + ".\n");

        }//Fim do método Main
    }//Fim da classe Construtores
}//Fim do namespace Construtores

