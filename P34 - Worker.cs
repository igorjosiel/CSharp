//Usando os namespaces System.Collections.Generic e Composicao.Entities.Enums
using System.Collections.Generic;
using Composicao.Entities.Enums;

//Utilizando o namespace Composicao.Entities
namespace Composicao.Entities
{
    //Classe Worker
    class Worker
    {
        //Atributos da classe dos tipos string, double e WorkerLevel com suas respectivas propriedades get e set
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double SalaryBase { get; set; }

        //Declarando as associações entre entidades (Composição)
        //Propriedade do tipo Departament com suas respectivas auto propriedades get e set
        public Departament Departament { get; set; }

        //Propriedade do tipo List armazenando objetos da entidade HourContracts com suas respectivas propriedades get e set. Instanciando a lista para garantir que a mesma não seja nula com a palavra-chave new
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //Declarando método construtor padrão sem entrada de argumentos
        public Worker ()
        {
        }//Fim do método construtor padrão sem parâmetros

        public Worker(string name, WorkerLevel level, double salaryBase, Departament departament)
        {
            //Atribuindo aos atributos e propriedades da classe com a palavra-chave this os valores passados como argumentos para os parâmetros
            this.Name = name;
            this.Level = level;
            this.SalaryBase = salaryBase;
            this.Departament = departament;

        }//Fim do método construtor com quatro parâmetros

        //Declarando método do tipo void com um parâmetro do tipo HourContract
        public void AddContract (HourContract contract)
        {
            //Adicionando um objeto passado como argumento para o parâmetro do método à lista Contracts com o método Add, passado como argumento o objeto que será adicionado
            Contracts.Add(contract);

        }//Fim do método AddContract

        //Declarando método do tipo void com um parâmetro do tipo HourContract
        public void RemoveContract (HourContract contract)
        {
            //Removendo um objeto passado como argumento para o parâmetro do método da lista Contracts com o método Remove, passado como argumento o objeto que será removido
            Contracts.Remove(contract);

        }//Fim do método RemoveContract

        //Declarando método do tipo double recebendo dois argumentos dos tipos int
        public double Income (int year, int month)
        {
            //Declarando variável do tipo double e inicializando-a com o valor do atributo SalaryBase da classe
            double sum = SalaryBase;

            //Método repetitivo foreach para percorrer por toda a lista Contracts. Declarando como apelido para cada objeto da lista o nome contract
            foreach (HourContract contract in Contracts)
            {
                //Método condicional if-else simples
                //Verifica se os valores passados como argumentos para os parâmetros year e month correspondem à valores armazenados em cada posição do atributo Date da lista, usando para isso o operador lógico And (&&)
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    //Variável sum é atualizada com o acréscimo do TotalValue do ojeto nessa posição
                    sum += contract.TotalValue();

                }//Fim do comando if do método condicional if-else simples
            }//Fim do método repetitivo foreach

            //Retorna ao método chamador o valor da variável sum
            return sum;

        }//Fim do método Income

    }//Fim da classe Worker
}//Fim do namespace Composicao.Entities
