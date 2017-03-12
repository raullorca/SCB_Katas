using System;

namespace Theater_Kata.src.program
{
    public class Seat
    {
        public String Row { get; set; }
        public int SeatNumber { get; set; }

        public Seat(string row, int seatNumber)
        {
            Row = row;
            SeatNumber = seatNumber;
        }

        public Seat(string seatString) : this(seatString.Substring(0, 1), int.Parse(seatString.Substring(1, 1))) { }

        public override string ToString()
        {
            return Row + SeatNumber;
        }
    }
}
