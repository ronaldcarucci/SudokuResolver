using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySudokuResolver
{
    public class Grid
    {
        /// <summary>
        /// The multidimensional array containing all the Values of the grid.
        /// </summary>
        public int[,] Values { get; private set; }

        /// <summary>
        /// The minimal value accepted in the grid.
        /// </summary>
        public int MinValue { get; set; }

        /// <summary>
        /// The maximal value accepted in the grid.
        /// </summary>
        public int MaxValue { get; set; }

        /// <summary>
        /// The total of each test.
        /// </summary>
        public int SumToHave { get; set; }

        /// <summary>
        /// The number of Lines.
        /// </summary>
        public int Lines { get; private set; }

        /// <summary>
        /// The number of Columns.
        /// </summary>
        public int Columns { get; private set; }

        /// <summary>
        /// Contruct an empty Sudoku Grid 
        /// </summary>
        /// <param name="lines">Number of Lines</param>
        /// <param name="columns">Number of Columns</param>
        /// <param name="minValue">Accepted Minimal Value</param>
        /// <param name="maxValue">Accepted Maximal Value</param>
        /// <param name="sumToHave">Total to have for each Test</param>
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

        /// <summary>
        /// Contruct a Sudoky Grid from a Array
        /// </summary>
        /// <param name="values">Array containing values.</param>
        /// <param name="minValue">Accepted Minimal Value</param>
        /// <param name="maxValue">Accepted Maximal Value</param>
        /// <param name="sumToHave">Total to have for each Test</param>
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

        /// <summary>
        /// Check if the grid is completed and valid
        /// </summary>
        /// <returns>True/False</returns>
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

        /// <summary>
        /// Solve automaticaly the grid
        /// </summary>
        public void AutoSolve()
        {
            List<int[,]> zeros = SearchZeros();

            foreach (int[,] zero in zeros)
                Values[zero[0, 0], zero[0, 1]] = 1;

            ProcessAutoSolve(zeros);
        }

        /// <summary>
        /// Search the next zero-value in the grid
        /// </summary>
        /// <param name="fromLine">beginning index</param>
        /// <param name="fromColumn">endinf index</param>
        /// <returns>The position of the next zero-value</returns>
        public int[,] NextZero(int fromLine = 0, int fromColumn = 0)
        {
            int[,] Nullvalue = { { -1, -1 } };

            for (int i = fromLine; i < Lines; i++)
                for (int j = fromColumn; j < Columns; j++)
                    if (Values[i, j] == 0)
                    {
                        int[,] value = { { i, j } };
                        return value;
                    }
            return Nullvalue;
        }

        /// <summary>
        /// Search every zero-values
        /// </summary>
        /// <returns>The list of zero-value</returns>
        public List<int[,]> SearchZeros()
        {
            List<int[,]> result = new List<int[,]>();

            int[,] zero = { { -1, -1 } };

            for (int i = 0; i < Lines; i++)
                for (int j = 0; j < Columns; j++)
                    if (Values[i, j] == 0)
                    {
                        int[,] value = { { i, j } };
                        result.Add(value);
                    }

            return result;
        }
        
        private void ProcessAutoSolve(List<int[,]> zeros, int current = 0)
        {
            while (CheckGrid() == false)
            {
                Increase(zeros);
            }
        }

        private void CancelAutoSolve(List<int[,]> zeros)
        {
            foreach (int[,] zero in zeros)
                Values[zero[0, 0], zero[0, 1]] = 0;
        }

        private void Increase(List<int[,]> zeros, int index = 0)
        {
            Values[zeros[index][0, 0], zeros[index][0, 1]]++;
            if (Values[zeros[index][0, 0], zeros[index][0, 1]] == 10)
            {
                Values[zeros[index][0, 0], zeros[index][0, 1]] = 1;
                if (index < zeros.Count - 1)
                    Increase(zeros, index + 1);
            }
        }
    }
}
