//Utilizando a biblioteca de classes System
using System;

//Mecanismo de controle da visibilidade de nomes dentro de um programa
namespace VariavelLogica
{
    //Classe VariavelLogica
    class VariavelLogica
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Variáeis do tipo lógico bool sendo atribuído valores
            bool fimDeSemana = true;
            bool namorada = false;
            bool tenisHoje = true;

            //Comando condicional if para testar se a variável fimDeSemana negada é verdadeira utilizando o operador de negação unário Not (!). Se for, imprime na tela a frase
            if (!fimDeSemana)
            {
                //Frase que será imprimida na tela caso a condição seja verdadeira
                Console.WriteLine("Nunca mais e fim de semana, que seca.");

            }//Fim do comando if

            //Comando condicional if para testar se a variável fimDeSemana e namorada são ambas verdadeiras utilizando o operador binário e lógico And (&&). Se for, imprime a frase na tela
            if (fimDeSemana && namorada)
            {
                //Frase que será imprimida na tela caso a condição seja verdadeira
                Console.WriteLine("Vamos passear com a cara metade.");

            }//Fim do comando if

            //Comando condicional if para testar se a variável fimDeSemana ou namorada são verdadeiras utilizando o operador binário ou lógico Or (||). Se as duas ou pelo menos uma for, imprime a frase na tela
            if (namorada || tenisHoje)
            {
                //Frase que será imprimida na tela caso a condição seja verdadeira
                Console.WriteLine("Hoje e um bom dia!");

            }//Fim do comando if

            //Chamando a classe Console da biblioteca System e utilizando seu método ReadLine() para manter a aplicação aberta
            Console.ReadLine();

        }//Fim do método Main
    }//Fim da classe VariavelLogica
}//Fim de namespace
