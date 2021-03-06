﻿using System;
using System.Globalization;

using ReservaHotel.Entities;

namespace ReservaHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo idiomaptBR = new CultureInfo("pt-BR");

            DateTime now = DateTime.Now;

            Console.WriteLine("Olá! Hoje é: " + now.ToString("D", idiomaptBR));
            Console.WriteLine();

            Console.WriteLine("Room number: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Check-in date (dd/MM/yyyy): ");

            DateTime checkIn = DateTime.Parse(Console.ReadLine(), idiomaptBR);
 
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");

            DateTime checkOut = DateTime.Parse(Console.ReadLine(), idiomaptBR);

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Data de saída tem que ser depois da data de checkin");

            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);

                Console.WriteLine("Resevation: " + reservation);
                Console.WriteLine();

                Console.WriteLine("Entre com os dados para atualizar a reserva");

                Console.WriteLine("Check-in date (dd/MM/yyyy): ");

                checkIn = DateTime.Parse(Console.ReadLine(), idiomaptBR);

                Console.WriteLine("Check-out date (dd/MM/yyyy): ");

                checkOut = DateTime.Parse(Console.ReadLine(), idiomaptBR);
 
                string error = reservation.UpdateDates(checkIn, checkOut);

                //Tratamento de erro... não é ainda o ideal... melhor tratar na classe reservation
                if (error != null)
                {

                    Console.WriteLine("Error in reservation: " + error);

                }

                else
                {

                    Console.WriteLine("Reservation: " + reservation);

                }

            }

        }
    }
}
