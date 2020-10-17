using System;

namespace ReservaHotel.Entities.Exceptions
{
    //Tratamento da EXCECAO PERSONALIZADA
    public class DomainException : ApplicationException
    {

        //construtor
        public DomainException(string message) : base(message)
        {



        }

    }
}
