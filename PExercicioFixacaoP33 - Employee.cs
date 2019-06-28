//Usando o namespace ExercicioFixacao_33.Entities
namespace ExercicioFixacao_33.Entities
{
    //Classe Employee
    class Employee
    {
        //Atributos da classe dos tipos string, int e double com suas propriedades get e set
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        //Método construtor padrão sem entrada de argumentos
        public Employee ()
        {
        }//Fim do método construtor padrão sem entrada de argumentos

        //Método construtor com entrada de argumentos dos tipos string, int e double
        public Employee(string name, int hours, double valuePerHour)
        {
            //Atribuindo aos atributos da classe com a palavra-chave this os valores passados como argumentos para o parâmetro do método
            this.Name = name;
            this.Hours = hours;
            this.ValuePerHour = valuePerHour;

        }//Fim do método construtor com entrada de argumentos dos tipos string, int e double

        //Método do tipo double sem entrada de argumentos. Usando a palavra-chave virtual para que o método possa ser sobrescrito em subclasses da classe Employee
        public virtual double Payment ()
        {
            //Retorna ao método chamador o valor da expressão Hours multiplicado pelo ValuePerHour
            return Hours * ValuePerHour;

        }//Fim do método Payment

    }//Fim da classe Employee
}//Fim do namespace ExercicioFixacao_33.Entities
