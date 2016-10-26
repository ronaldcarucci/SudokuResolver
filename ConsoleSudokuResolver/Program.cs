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
                                {5,3,0,0,7,0,0,0,0},
                                {6,0,0,1,9,5,0,0,0},
                                {0,9,8,0,0,0,0,6,0},
                                {8,0,0,0,6,0,0,0,3},
                                {4,0,0,8,0,3,0,0,1},
                                {7,0,0,0,2,0,0,0,6},
                                {0,6,0,0,0,0,2,8,0},
                                {0,0,0,4,1,9,0,0,5},
                                {0,0,0,0,8,0,0,7,9}
                            };

            grid2 = new Grid(myGrid2);

            Console.WriteLine("Grid 2 Uncompleted : ");
            PrintGrid(grid2);


            Task T1 = new Task(AlwaysPrint);
            T1.Start();

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
        
        static void AlwaysPrint()
        {
            int i = 0;
            while (grid2.CheckGrid() == false)
            {
                if (i % 1500 == 0)
                {
                    Console.Clear();
                    PrintGrid(grid2);
                }
                i++;
            }
        }
    }
}
