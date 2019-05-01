//Usando o namespace System.Globalization
using System.Globalization;

//Utilizando o namespace ExercicioFixacao_27
namespace ExercicioFixacao_27
{
    //Classe ContaBancaria
    class ContaBancaria
    {
        //Atributos da classe ContaBancaria dos tipos int, string e double com os modificadores de acesso public com as devidas restrições de acesso private - Propriedades autoimplementadas
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        //Construtor da classe com a assinatura com dois parâmetros de entrada dos tipos: int e string
        public ContaBancaria(int numConta, string nomeTitular)
        {
            //Atributos da classe com a palavra-chave this sendo inicializados com valores passados como argumentos ao construtor
            this.NumeroConta = numConta;
            this.NomeTitular = nomeTitular;

        }//Fim do construtor ContaBancaria(int numConta, string nomeTitular)

        //Construtor da classe com a assinatura com três parâmetros de entrada dos tipos: int, string e double
        //Construtor reaproveitando a assinatura do construtor anterior com a palavra-chave this
        public ContaBancaria(int numConta, string nomeTitular, double depositoInicial) : this(numConta, nomeTitular)
        {
            //Chamando o método Deposito para inicializar o saldo com valor passado como argumento ao construtor
            Deposito(depositoInicial);

        }//Fim do construtor ContaBancaria(int numConta, string nomeTitular, double depositoInicial)

        //Método deposito do tipo void recebe como parâmetro um valor do tipo double
        public void Deposito(double valorDeposito)
        {
            //Atualiza o valor do atributo saldo com a palavra-chave this com o acréscimo do valor passado por argumento
            this.Saldo += valorDeposito;

        }//Fim do método deposito

        //Método saque do tipo void recebe como parâmetro um valor do tipo double
        public void Saque(double valorSaque)
        {
            //Comando if do método condicional if-else simples
            //Se o valor do atributo saldo for maior ou igual ao valor do parâmetro com o valor de R$ 5.00 de taxa de saque, executa o bloco de instruções abaixo
            if (this.Saldo >= (valorSaque + 5))
            {
                //Atualiza o valor do atributo saldo com a palavra-chave this com o decréscimo do valor passado por argumento mais um valor de R$ 5.00
                this.Saldo -= (valorSaque + 5.00);

            }//Fim do comando if do método condicional if-else simples
        }//Fim do método saque

        //Método sendo sobrescrito com a palavra-chave override do tipo string para representar o objeto da classe na forma de string
        public override string ToString()
        {
            //Retorna os segmentos de string com os valores dos atributos do objeto da classe com as devidas formatações
            return "\nNumero da conta: " + this.NumeroConta + " - Nome do Titular: " + this.NomeTitular + " - Saldo: R$ " + this.Saldo.ToString("F2", CultureInfo.InvariantCulture) + ".\n";

        }//Fim do método ToString

    }//Fim da classe ContaBancaria
}//Fim do namespace ExercicioFixacao_27
