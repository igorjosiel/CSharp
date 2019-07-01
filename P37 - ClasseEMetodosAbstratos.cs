//Usando os namespaces System, System.Collections.Generic, ClasseEMetodosAbstratos.Entities, ClasseEMetodosAbstratos.Entities.Enums e System.Globalization
using System;
using System.Collections.Generic;
using ClasseEMetodosAbstratos.Entities;
using ClasseEMetodosAbstratos.Entities.Enums;
using System.Globalization;

//Utilizando o namespace ClasseEMetodosAbstratos
namespace ClasseEMetodosAbstratos
{
    //Classe ClasseEMetodosAbstratos
    class ClasseEMetodosAbstratos
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e instanciando uma lista do tipo Shape com a palavra-chave new
            List<Shape> shapes = new List<Shape>();

            //Imprime a frase na tela
            Console.Write("Enter the number of shapes: ");

            //Declarando e inicializando variável do tipo int com um valor digitado pelo usuário via teclado
            int n = int.Parse(Console.ReadLine());

            //Método repetitivo for para repetir tantas vezes até o valor da variável i ser menor ou igual ao valor da variável n
            for (int i = 1; i <= n; i ++)
            {
                //Imprime as frases na tela com o valor da variável i pelo método de impressão de interpolação
                Console.WriteLine($"\nShape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");

                //Declarando e inicializando variável do tipo char com um valor digitado pelo usuário via teclado
                char ch = char.Parse(Console.ReadLine());

                //Imprime a frase na tela
                Console.Write("Color (Black/Blue/Red): ");

                //Declarando e inicializando um enum do tipo Color com a palavra-chave out para receber o valor digitado pelo usuário via teclado do tipo string e convertê-lo para enum. Palavra-chave false para considerar as maiúsculas e minúsculas
                Enum.TryParse<Color>(Console.ReadLine(), false, out Color color);

                //Método condicional if-else composto para testar o valor da variável do tipo char ch. Se o valor da variável for igual ao caracter r, executa o bloco de instruções abaixo, senão, pula para o próximo teste
                if (ch == 'r')
                {
                    //Imprime a frase na tela
                    Console.Write("Width: ");

                    //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Imprime a frase na tela
                    Console.Write("Height: ");

                    //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado, com a devida formatação de ponto decimal
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Acionando o método Add da lista shapes para adicionar à mesma uma nova instância de um objeto do tipo Rectangle com a palavra-chave new, passando como argumento para o método construtor, os valores inicializados acima
                    shapes.Add(new Rectangle(color, width, height));

                }//Fim do comando if do método condicional if-else composto

                //Senão, executa o bloco de instruções abaixo
                else
                {
                    //Imprime a palavra na tela
                    Console.Write("Radius: ");

                    //Declarando e inicializando variável do tipo double com um valor digitado pelo usuário via teclado, com a devida formatação de ponto decimal
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Acionando o método Add da lista shapes para adicionar à mesma uma nova instância de um objeto do tipo Circle com a palavra-chave new, passando como argumento para o método construtor, os valores inicializados acima
                    shapes.Add(new Circle(color, radius));

                }//Fim do comando else do método condicional if-else composto
            }//Fim do método repetitivo for

            //Salta uma linha
            Console.WriteLine();

            //Imprime a frase na tela
            Console.WriteLine("-----SHAPE AREAS-----");

            //Método repetitivo foreach para percorrer por tada a lista shapes de objetos Shape, atribuindo a cada elemento da mesma, o apelido shape
            foreach (Shape shape in shapes)
            {
                //Imprime na tela o valor do método Area de cada elemento da lista shapes com suas devidas formatações de casas decimais, e do ponto separador decimal
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));

            }//Fim do método repetitivo foreach

            //Salta uma linha
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe ClasseEMetodosAbstratos
}//Fim do namespace ClasseEMetodosAbstratos
