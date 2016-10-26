using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySudokuResolver;

namespace ConsoleSudokuResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myGrid = {   // GRID TEST WITHOUT ERROR
                                {5, 6, 7, 2, 4, 9, 3, 8, 1 },
                                {8, 4, 3 ,1 ,5 ,7, 2, 6, 9 },
                                {1, 2, 9, 6, 3, 8, 5, 4, 7 },
                                {2, 7, 4, 3, 9, 1, 6, 5, 8 },
                                {3, 8, 1, 5, 7, 6, 4, 9, 2 },
                                {9, 5, 6, 8, 2, 4, 7, 1, 3 },
                                {4, 3, 8, 7, 1, 5, 9, 2, 6 },
                                {7, 1, 5, 9, 6, 2, 8, 3, 4 },
                                {6, 9, 2, 4, 8, 3, 1 ,7, 5 }
                            };

            Grid grid = new Grid (myGrid);

            Console.WriteLine("RESOLVED ? {0}", grid.CheckGrid());

            int[,] myGrid2 = {  // GRID TEST WITH ERROR IN [8,7] AND [8,8] ( 5 <=> 7 )
                                {5, 6, 7, 2, 4, 9, 3, 8, 1 },
                                {8, 4, 3 ,1 ,5 ,7, 2, 6, 9 },
                                {1, 2, 9, 6, 3, 8, 5, 4, 7 },
                                {2, 7, 4, 3, 9, 1, 6, 5, 8 },
                                {3, 8, 1, 5, 7, 6, 4, 9, 2 },
                                {9, 5, 6, 8, 2, 4, 7, 1, 3 },
                                {4, 3, 8, 7, 1, 5, 9, 2, 6 },
                                {7, 1, 5, 9, 6, 2, 8, 3, 4 },
                                {6, 9, 2, 4, 8, 3, 1 ,5, 7 }
                            };

            Grid grid2 = new Grid(myGrid2);

            Console.WriteLine("RESOLVED ? {0}", grid2.CheckGrid());

            int[,] myGrid3 = {  // GRID TEST UNCOMPLETED ([3,7],[5,1],[8,3] EMPTY (SETTED TO 0))
                                {5, 6, 7, 2, 4, 9, 3, 8, 1 },
                                {8, 4, 3 ,1 ,5 ,7, 2, 6, 9 },
                                {1, 2, 9, 6, 3, 8, 5, 4, 7 },
                                {2, 7, 4, 3, 9, 1, 6, 0, 8 },
                                {3, 8, 1, 5, 7, 6, 4, 9, 2 },
                                {9, 0, 6, 8, 2, 4, 7, 1, 3 },
                                {4, 3, 8, 7, 1, 5, 9, 2, 6 },
                                {7, 1, 5, 9, 6, 2, 8, 3, 4 },
                                {6, 9, 2, 0, 8, 3, 1 ,5, 7 }
                            };

            Grid grid3 = new Grid(myGrid3);

            Console.WriteLine("RESOLVED ? {0}", grid3.CheckGrid());
        }
    }
}
