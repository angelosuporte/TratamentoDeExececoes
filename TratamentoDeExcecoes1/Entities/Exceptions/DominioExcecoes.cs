using System;
namespace TratamentoDeExcecoes1.Entities.Exceptions
{
    class DominioExcecoes : ApplicationException    //<---Herda da classe AplicationException, que pertense ao próprio sistema
    {
        public DominioExcecoes(string mensagem): base(mensagem)
        {
        }
    }
}
