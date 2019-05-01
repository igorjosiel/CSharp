//Utilizando os namespaces System e System.Globalization
using System;
using System.Globalization;

//Usando o namespace Construtores
namespace Construtores
{
    //Classe Produto
    class Produto
    {
        //Atributos da classe dos tipos string, double e int
        private string _nome;

        //Auto Properties com possibilidades de acesso get e não para o set
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Método construtor Produto que inicializa os atributos do objeto através de parâmetros vindos do método chamador
        public Produto(string nome, double preco, int quantidade)
        {
            //Atributos do objeto sendo inicializados com valores dos parâmetros
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

        }//Fim do método construtor Produto


        //Sobrecarga de construtores. Método construtor Produto que inicializa os atributos do objeto através de parâmetros vindos do método chamador
        //Método construtor utilizando apenas dois parâmetros
        public Produto(string nome, double preco)
        {
            //Atributos do objeto sendo inicializados com valores dos parâmetros
            this._nome = nome;
            this.Preco = preco;

        }//Fim do método construtor Produto

        //Propertie customizada com uma lógica de validação para o atributo Nome do objeto
        public string Nome
        {
            //Acesso ao get normal
            get { return _nome; }

            //Acesso ao set com uma lógica de validação que não permite que seja atribuído ao atributo Nome um valor vazio e menor que 1 caracter
            set
            {
                //Estrutura condicional if-else simples para verificar se o valor do atributo Nome não é vazio e se é maior que 1 caracter
                //A palavra-chave value se refere ao atributo que está sendo referenciado na declaração da propertie. No caso o atributo Nome
                if (value != null && value.Length > 1)
                {
                    _nome = value;

                }//Fim do comando if do método condicional if-else

            }//Fim do comando set da propertie
        }//Fim da propertie

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
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }//Fim do método ToString

    }//Fim da classe Produto
}//Fim do namespace Construtores
