using System;
using TratamentoDeExcecoes1.Entities.Exceptions;

namespace TratamentoDeExcecoes1.Entities
{
    class Reservas
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservas()
        {
        }

        public Reservas(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn) //Caso haja erro vai capturar uma exceção durante a chamada do construtor
            {
                throw new DominioExcecoes("O lançamento do checkOut não pode ser anterior ou igual ao checkIn!");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);//vai fazer a diferença entre a entrada e saída
            return (int)duration.TotalDays; //Vai retornar a diferença em dias
        }

        public void UpdadeDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime hoje = DateTime.Now;
            if (checkIn < hoje || checkOut < hoje)
            {
                throw new DominioExcecoes(" O check-In e o check-Out devem ser datas futuras!");
            }
            if (checkOut <= checkIn)
            {
                throw new DominioExcecoes("O lançamento do checkOut não pode ser anterior ou igual ao checkIn!");
            }


            CheckIn = checkIn;
            CheckOut = checkOut;
            
        }


        public override string ToString()
        {
            return "Room "
                + RoomNumber + ":"
                + " check-in: " + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: " 
                + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " noites";

        }
    }

}
