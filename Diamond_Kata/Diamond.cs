using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Kata
{
    public class Diamond
    {
        public string[] Execute(char value)
        {
            var initial = (int)'A';
            var final = (int)value;



            var quantityLetters = (final - initial) + 1;
            var rows = (final - initial) * 2 + 1;

            var execute = new List<string>();
            for (int row = 1; row <= rows; row++)
            {
                var before = GetBefore(quantityLetters, row, rows);

                var middle = GetMiddle(quantityLetters, row, rows);

                execute.Add(before + middle + before);

            }

            return execute.ToArray();
        }

        private string GetMiddle(int quantityLetters, int row, int rows)
        {
            int spaces;

            if (row == 1 || row == rows)
            {
                spaces = 0;
                row = 1;
            }
            else if (row <= quantityLetters)
            {
                spaces = (row - 1) * 2 - 1;
            }
            else
            {
                row = rows - row + 1;
                spaces = (row - 1) * 2 - 1;
            }

            char currentChar = currentChar = (char)(row + 64);
            if (spaces > 0)
            {
                return currentChar + new string('-', spaces) + currentChar;
            }
            else
            {
                return currentChar.ToString();
            }
        }

        private string GetBefore(int quantityLetters, int row, int rows)
        {
            int spaces = Math.Abs(quantityLetters - row);

            return new string('-', spaces);
        }
    }
}
