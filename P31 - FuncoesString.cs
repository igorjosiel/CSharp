//Usando o namespace System
using System;

//Utilizando o namespace FuncoesString
namespace FuncoesString
{
    //Classe FuncoesString
    class FuncoesString
    {
        //Método principal Main
        static void Main(string[] args)
        {
            //Declarando e inicializando variável do tipo string com vários caracteres
            string original = "abcde FGHIJ ABC abc DEFG   ";

            //Declarando e inicializando variável do tipo string com o resultado da chamada ao método ToUpper() da variável original, que converte todos os caracteres da string para maiúsculos
            string s1 = original.ToUpper();

            //Declarando e inicializando variável do tipo string com o resultado da chamada ao método ToLower() da variável original, que converte todos os caracteres da string para minúsculos
            string s2 = original.ToLower();

            //Declarando e inicializando variável do tipo string com o resultado da chamada ao método Trim() da variável original, que elimina todos os caracteres de espaço em branco da string
            string s3 = original.Trim();

            //Declarando e inicializando variável do tipo int com o resultado da chamada ao método IndexOf() da variável original, passando como argumento um caracter ou uma string contida na string original, que localiza o índice da primeira aparição do argumento na string
            int n1 = original.IndexOf("bc");

            //Declarando e inicializando variável do tipo int com o resultado da chamada ao método LastIndexOf() da variável original, passando como argumento um caracter ou uma string contida na string original, que localiza o índice da última aparição do argumento na string
            int n2 = original.LastIndexOf("bc");

            //Declarando e inicializando variável do tipo string com o resultado da chamada ao método Substring() da variável original, passando como argumento um valor que indica de onde a string original será recortada. Do índice (3)
            string s4 = original.Substring(3);

            //Declarando e inicializando variável do tipo string com o resultado da chamada ao método Substring() da variável original, passando como argumento um valor que indica de onde a string original será recortada, e um valor que indica até onde a mesma será recortada. Do índice (3, 5)
            string s5 = original.Substring(3, 5);

            //Declarando e inicializando variável do tipo string com o resultado da chamada ao método Replace() da variável original, passando como argumento um valor que indica o caracter que será substituído (a) na string, e um valor que indica o caracter que será sobreposto no lugar do anterior (x)
            string s6 = original.Replace('a', 'x');

            //Declarando e inicializando variável do tipo string com o resultado da chamada ao método Replace() da variável original, passando como argumento um valor que indica a string que será substituída (abc) na string, e um valor que indica a string que será sobreposta no lugar da anterior (xy)
            string s7 = original.Replace("abc", "xy");

            //Declarando e inicializando variável do tipo bool com o resultado da chamada ao método IsNullOrEmpty da classe String, passando como argumento a string original, que indica se a mesma está nula ou vazia, retornando falso ou verdadeiro
            bool b1 = String.IsNullOrEmpty(original);

            //Declarando e inicializando variável do tipo bool com o resultado da chamada ao método IsNullOrWhiteSpace da classe String, passando como argumento a string original, que indica se a mesma está nula ou só possui espaços em branco, retornando falso ou verdadeiro
            bool b2 = String.IsNullOrWhiteSpace(original);

            //Imprime as frases na tela com os respectivos valores das variáveis
            Console.WriteLine("String original: -" + original + "-");
            Console.WriteLine("String maiúscula: -" + s1 + "-");
            Console.WriteLine("String minúscula: -" + s2 + "-");
            Console.WriteLine("String sem espacos em branco: -" + s3 + "-");
            Console.WriteLine("Primeira aparicao do termo ('bc') na string: " + n1);
            Console.WriteLine("Última aparicao do termo ('bc') na string: " + n2);
            Console.WriteLine("Recorta a string do indice (3) em diante: " + s4);
            Console.WriteLine("Recorta a string do indice (3, 5): " + s5);
            Console.WriteLine("Substituindo ('a', 'x'): " + s6);
            Console.WriteLine("Substituindo ('abc', 'xy'): " + s7);
            Console.WriteLine("String nula ou vazia: " + b1);
            Console.WriteLine("String nula ou somente com espacos em branco: " + b2);
            Console.WriteLine();

        }//Fim do método Main
    }//Fim da classe FuncoesString
}//Fim do namespace FuncoesString
