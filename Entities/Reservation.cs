using System;

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

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;

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
