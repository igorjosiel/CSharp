//Utilizando o namespace ExercicioFixacao_29
namespace ExercicioFixacao_29
{
    //Classe Funcionario
    class Funcionario
    {
        //Declarando atributos da classe dos tipos int, string e double com as propriedades autoimplementadas com suas respectivas operações get e set
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        //Declarando um método construtor com três variáveis de parâmetros: id, nome e salario
        public Funcionario(int id, string nome, double salario)
        {
            //Atribuindo os valores dos parâmetros aos atributos da classe, usando a palavra-chave this
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;

        }//Fim do construtor Funcionario de três parâmetros

        //Método do tipo public void para alterar o valor do salário do funcionário, com uma variável de parâmetro do tipo int
        public void setAumentaSalario(int porcent)
        {
            //Atribuindo ao atributo salario um novo valor com base no valor passado como argumento para a função
            this.Salario += (porcent / 100.0) * this.Salario;

        }//Fim do método AumentarSalario

        //Método do tipo string ToString sendo sobrescrito com os valores de todos os atributos do objeto
        override
        public string ToString()
        {
            //Retornando ao método chamador a string abaixo
            return "\nNome: " + this.Nome + "\nId: " + this.Id + "\nSalario: " + this.Salario;

        }//Fim do método ToString

    }//Fim da classe Funcionario
}//Fim do namespace ExercicioFixacao_29
