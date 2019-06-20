//Usando o namespace System.Globalization
using System.Globalization;

//Utilizando o namespace ExercicioFixacao_24
namespace ExercicioFixacao_24
{
    //Classe Funcionario
    class Funcionario
    {
        //Atributos da classe dos tipos string e double
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        //Método do tipo double para calcular o salário líquido do funcionário
        public double SalarioLiquido()
        {
            //Retorna o resultado da expressão ao método chamador
            return SalarioBruto - Imposto;

        }//Fim do método SalarioLiquido

        //Método do tipo void para aumentar o salário do funcionário com base em uma porcentagem passada por parâmetro do tipo double
        public void AumentarSalario(double porcentagem)
        {
            //Altera o valor do atributo SalarioBruto com base no resultado da expressão abaixo
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));

        }//Fim do método AumentarSalario

        //Método do tipo string sendo sobrescrito da classe Object para representar o objeto em forma de uma string
        public override string ToString()
        {
            //Retorna ao método chamador a string abaixo
            return "Nome: " + Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

        }//Fim do método ToString

    }//Fim da classe Funcionario
}//Fim do namespace ExercicioFixacao_24
