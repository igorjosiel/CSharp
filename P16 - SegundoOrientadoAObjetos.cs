//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace SegundoOrientadoAObjetos
namespace SegundoOrientadoAObjetos
{
    //Classe SegundoOrientadoAObjetos
    class SegundoOrientadoAObjetos
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando um objeto do tipo Produto e instanciando-o com a palavra-chave new
            Produto p = new Produto();

            //Imprime as frases na tela
            Console.WriteLine("-----Entre com os dados do produto-----\n");
            Console.Write("Nome: ");

            //Atribui um valor ao atributo Nome do objeto p
            p.Nome = Console.ReadLine();

            //Imprime a frase na tela
            Console.Write("Preco: ");

            //Atribui um valor ao atributo Preco do objeto p com a seguinte formatação
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprime a frase na tela
            Console.Write("Quantidade no estoque: ");

            //Atribui um valor ao atributo Quantidade do objeto p
            p.Quantidade = int.Parse(Console.ReadLine());

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
    }//Fim da classe SegundoOrientadoAObjetos
}//Fim do namespace SegundoOrientadoAObjetos
