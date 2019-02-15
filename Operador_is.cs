//Utilizando a biblioteca de classes System
using System;

//Mecanismo de controle da visibilidade de nomes dentro de um programa
namespace Operador_is
{
    //Classe Operador_is
    class Operador_is
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Objeto nome do tipo String
            String nome = "Carla Fonseca";

            //Comando condicional if para testar se o objeto nome e do tipo String com o operador is. Se for, imprime a frase na tela
            if (nome is String)
            {
                //Frase que será imprimida na tela caso a condição if seja verdadeira
                Console.WriteLine("A variavel nome e do tipo String!");

            }//Fim do comando if

            //Se o if anterior não for verdadeiro executa as instruções do comando else, caso o mesmo seja verdaeiro
            else
            {
                //Frase que será imprimida na tela caso a condição else seja verdadeira
                Console.WriteLine("A variavel nome nao e do tipo String!");

            }//Fim do comando else

            //Chamando a classe Console da biblioteca System e seu método ReadLine() para manter para manter a aplicação aberta
            Console.ReadLine();

        }//Fim do método Main
    }//Fim da classe Operador_Is
}//Fim de namespace
