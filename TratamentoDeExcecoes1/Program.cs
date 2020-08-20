using System;
using TratamentoDeExcecoes1.Entities;

namespace TratamentoDeExcecoes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do quarto: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Erro na reserva: O lançamento do checkOut não pode ser anterior ou igual ao checkIn!" );
            }

            else
            {
                Reservas reserva = new Reservas(number, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva );
                Console.WriteLine();
                Console.WriteLine("Informe os dados para atualização da reserva: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reserva.UpdadeDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine("Erro na reserva: " + error);
                }
                else
                {

                    Console.WriteLine("Reserva: " + reserva);
                }
            }
        }
    }
}
