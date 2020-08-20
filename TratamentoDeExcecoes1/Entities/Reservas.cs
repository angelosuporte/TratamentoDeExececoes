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

        public string UpdadeDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime hoje = DateTime.Now;
            if (checkIn < hoje || checkOut < hoje)
            {
                return " O check-In e o check-Out devem ser datas futuras!";
            }
            if (checkOut <= checkIn)
            {
                return "O lançamento do checkOut não pode ser anterior ou igual ao checkIn!";
            }
            //Se não houver erros na execução da lógica acima, será feito updade

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null; //<---Esse retorno garente que não houve erros
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
