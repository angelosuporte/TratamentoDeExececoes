using System;
using System.Collections.Generic;
using System.Text;

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
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public override string ToString()
        {
            return "Room "
                + RoomNumber + ":"
                + "check-in: " + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: " 
                + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " noites";

        }
    }

}
