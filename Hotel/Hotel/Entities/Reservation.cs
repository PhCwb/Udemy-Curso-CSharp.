using System;
using Hotel.Entities.Exceptions;

namespace Hotel.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn); //TimeSpan pra saber a duração. CheckOut.Subtract(CheckIn) vai fazer a diferença entre os dias.
            return (int)duration.TotalDays; //(int) pra converter double para int
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now; // Data atual 
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException ("Reservation dates for update must be future dates");

            }
            if (checkOut <= checkIn) 
            {
                throw new DomainException ("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, Check-in: {CheckIn.ToString("dd/MM/yyyy")} Check-out:{CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

    }
}
