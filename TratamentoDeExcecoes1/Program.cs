using System;
using TratamentoDeExcecoes1.Entities;
using TratamentoDeExcecoes1.Entities.Exceptions;

namespace TratamentoDeExcecoes1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Número do quarto: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Console.WriteLine();

                Reservas reserva = new Reservas(number, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Informe os dados para atualização da reserva: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reserva.UpdadeDates(checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva);
            }
            catch (DominioExcecoes e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro no formato: " + e.Message); //neste caso vai gerar uma mensagem do próprio VS
            }
            catch (Exception e) 
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}

