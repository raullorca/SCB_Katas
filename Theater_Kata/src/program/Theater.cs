using System.Collections.Generic;

namespace Theater_Kata.src.program
{
    public class Theater
    {
        public List<string> Rows { get; set; }
        public Dictionary<string,List<int>> Seats { get; set; }

        public Theater(List<string> rows, Dictionary<string, List<int>> seats)
        {
            Rows = rows;
            Seats = seats;
        }

        public static Theater StandardTheater()
        {
            var rows = new List<string>
            {
                "A", "B", "C", "D","E","F","G"
            };

            var seats = new Dictionary<string, List<int>>();
            seats.Add("A", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            seats.Add("B", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            seats.Add("C", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            seats.Add("D", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            seats.Add("E", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            seats.Add("F", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            seats.Add("G", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            return new Theater(rows, seats);
        }
    }
}
