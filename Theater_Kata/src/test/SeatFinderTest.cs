using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theater_Kata.src.program;

namespace Theater_Kata.src.test
{
    [TestClass]
    public class SeatFinderTest
    {
        [TestMethod]
        public void FindTwoSeatsOnFrontRow()
        {
            Theater theater = Theater.StandardTheater();
            List<Seat> booked = new List<Seat>
            {
                new Seat("B2"),
                new Seat("B3"),
                new Seat("B4"),
                new Seat("B5")
            };
            SeatFinder seatFinder = new SeatFinder(theater, booked);

            var expected = new List<Seat>
            {
                new Seat("A5"),
                new Seat("A6")
            };

            var actual = seatFinder.Suggest(2);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
