//Usando o namespace enumeracao.Entities.Enums
namespace enumeracao.Entities.Enums
{
    //Enum OrderStatus contendo valores apenas do tipo int
    enum OrderStatus : int
    {
        //Valores possíveis para o enum, de acordo com cada estado da entidade, finalizando-os com uma vírgula
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,

    }//Fim do enum
}//Fim do namespace enumeracao.Entities.Enums
