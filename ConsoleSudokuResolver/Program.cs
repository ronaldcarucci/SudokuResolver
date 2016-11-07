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
        static Grid grid2;
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

            int[,] temp = grid.Values;

            Console.WriteLine("Grid 1 : ");
            PrintGrid(grid);
            
            int[,] myGrid2 = {  // GRID TEST UNCOMPLETED
                                {3,1,0,5,6,4,8,0,0},
                                {0,0,0,0,0,0,0,0,0},
                                {9,0,0,0,7,8,3,0,0},
                                {0,2,4,9,0,0,6,0,0},
                                {7,8,0,2,0,0,0,1,3},
                                {0,0,3,0,5,7,0,0,0},
                                {2,3,0,0,0,9,7,8,0},
                                {0,0,6,7,0,0,0,3,1},
                                {8,7,1,6,2,3,9,5,4}
                            };

            grid2 = new Grid(myGrid2);

            Console.WriteLine("Grid 2 Uncompleted : ");
            PrintGrid(grid2);
            
            grid2.AutoSolve();

            Console.WriteLine("Grid 2 Completed : ");
            PrintGrid(grid2);

        }

        static void PrintGrid(Grid grid)
        {
            for (int i = 0; i < grid.Lines; i++)
            {
                for (int j = 0; j < grid.Columns; j++)
                    Console.Write("{0} ", grid.Values[i, j]);
                Console.WriteLine();
            }
        }
        
    }
}
