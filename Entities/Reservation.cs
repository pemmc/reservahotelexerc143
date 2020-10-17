using System;
using System.Globalization;


namespace ReservaHotel.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
            //construtor padrao
        }


        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            //construtor com argumentos
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {

            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;

        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {

                return "Erro na reserva";

            }

            if (checkOut <= checkIn)
            {

                return "Data de saída tem que ser depois da data de checkin";

            }

            CheckIn = checkIn;
            CheckOut = checkOut;

            return null;

        }

        public override string ToString()
        {

            return "Room "
                + RoomNumber
                + ". CheckIn: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ". CheckOut: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";

        }
    }
}
