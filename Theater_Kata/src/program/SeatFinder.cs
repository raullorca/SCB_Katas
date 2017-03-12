using System.Collections.Generic;

namespace Theater_Kata.src.program
{
    public class SeatFinder
    {
        private readonly Theater Theater;
        private List<Seat> Booked;

        public SeatFinder(Theater theater) : this(theater, new List<Seat>() ) { }

        public SeatFinder(Theater theater, List<Seat> booked)
        {
            Theater = theater;
            Booked = booked;
        }

        public List<Seat> Suggest(int partySize)
        {
            return null;
        }
    }
}
