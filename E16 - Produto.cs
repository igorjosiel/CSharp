//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace SegundoOrientadoAObjetos
namespace SegundoOrientadoAObjetos
{
    //Classe Produto
    class Produto
    {
        //Atributos da classe dos tipos string, double e int
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Método do tipo de retorno double que calcula o valor total em estoque
        public double ValorTotalEmEstoque()
        {
            //Executa a operação e depois retorna o resultado à função chamadora
            return Preco * Quantidade;

        }//Fim do método ValorTotalEmEstoque

        //Método do tipo de retorno void que adiciona produtos na quantidade, de acordo com o valor passado por parâmetro
        public void AdicionarProdutos(int quantidade)
        {
            //Atributo quantidade do objeto é adicionado com o valor passado por parâmetro
            Quantidade += quantidade;

        }//Fim do método AdicionarProdutos

        //Método do tipo void que remove produtos da quantidade, de acordo com o valor passado por parâmetro
        public void RemoverProdutos(int quantidade)
        {
            //Atributo quantidade do ojeto é subtraído pelo valor passado por parâmetro
            Quantidade -= quantidade;

        }//Fim do método RemoverProdutos

        //Método do tipo string sendo sobrescrito com a palavra-chave override da classe Genérica Object para representar o objeto em forma de string
        public override string ToString()
        {
            //Retorna a frase concatenada com os respectivos valores dos atributos do objeto
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }//Fim do método ToString

    }//Fim da classe Produto
}//Fim do namespace SegundoOrientadoAObjetos
