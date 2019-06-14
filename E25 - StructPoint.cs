//Usando o namespace Struct
namespace Struct
{
    //Struct StructPoint
    struct StructPoint
    {
        //Atributos do struct dos tipos double
        public double x;
        public double y;

        //Método sobrecarregado com a declaração override do tipo string para representar o struct na forma de string
        public override string ToString()
        {
            //Retorna ao método chamador a expressão seguinte com os valores das variáveis x e y do struct
            return "(" + x + ", " + y + ")";

        }//Fim do método ToString

    }//Fim do Struct StructPoint
}//Fim do namespace Struct
