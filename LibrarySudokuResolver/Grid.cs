using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySudokuResolver
{
    public class Grid
    {
        public int[,] Values { get; private set; }

        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public int SumToHave { get; set; }

        public int Lines { get; private set; }

        public int Columns { get; private set; }

        public Grid(int lines = 9, int columns = 9, int minValue = 1, int maxValue = 9, int sumToHave = 49)
        {
            if (lines <= 0 || columns <= 0)
            {
                // ERROR
            }
            else
            {
                Lines = lines;
                Columns = columns;

                Values = new int[Lines,Columns];

                MinValue = minValue;
                MaxValue = maxValue;
                SumToHave = sumToHave;
            }
        }

        public Grid(int[,] values, int minValue = 1, int maxValue = 9, int sumToHave = 45)
        {
            if (values == null)
            {
                // ERROR
            }
            else
            {
                Lines = values.GetLength(0);
                Columns = values.GetLength(0);
                Values = new int[Lines, Columns];

                for (int i = 0 ; i < Lines ; i++)
                    for (int j = 0; j < Columns; j++)
                        Values[i, j] = values[i, j];

                MinValue = minValue;
                MaxValue = maxValue;
                SumToHave = sumToHave;
            }
        }

        public bool CheckGrid()
        {
            


            // Check each Line
            for (int i = 0 ; i < Lines ; i++)
            {
                int tmpSum = 0;

                for (int j = 0 ; j < Columns ; j++)
                    tmpSum += Values[i,j];

                if (tmpSum != SumToHave)
                    return false;
            }

            // Check each Column
            for (int i = 0; i < Columns ; i++)
            {
                int tmpSum = 0;

                for (int j = 0; j < Lines ; j++)
                    tmpSum += Values[j, i];

                if (tmpSum != SumToHave)
                    return false;
            }

            // Check each 9-case Square
            for (int k = 0; k < 3; k++)
                for (int l = 0; l < 3; l++)
                {
                    int tmpSum = 0;

                    for (int i = (0 + (3 * k)); i < (3 + (3 * k)); i++)
                        for (int j = (0 + (3 * l)); j < (3 + (3 * l)); j++)
                            tmpSum += Values[i, j];

                    if (tmpSum != SumToHave)
                        return false;
                }

            return true;
            
        }
        
    }
}
