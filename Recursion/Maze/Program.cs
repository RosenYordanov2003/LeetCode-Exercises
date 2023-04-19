using System;

namespace Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] maze = new char[5, 5];
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Replace(" ", "").ToCharArray();
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    maze[row, col] = input[col];
                }
            }
            string path = string.Empty;
            bool[,] visitedCells = new bool[5, 5];
            FindPath(maze, startRow, startCol, path, visitedCells);
        }

        static void FindPath(char[,] maze, int startRow, int startCol, string path, bool[,] visitedCells)
        {
            visitedCells[startRow, startCol] = true;
            //Console.WriteLine(new String('-', 30));
            //PrintMatrix(maze);
            //Console.WriteLine(new String('-', 30));
            if (maze[startRow, startCol] == 'E')
            {
                Console.WriteLine("You found the exit!");
                Console.WriteLine(path);
                maze[startRow, startCol] = 'F';
                PrintMatrix(maze);
                return;
            }
            maze[startRow, startCol] = 'V';
            //down
            if (isValidCell(startRow + 1, startCol, visitedCells, maze))
            {
                FindPath(maze, startRow + 1, startCol, path + "Down ", visitedCells);
            }
            //up
            if (isValidCell(startRow - 1, startCol, visitedCells, maze))
            {
                FindPath(maze, startRow - 1, startCol, path + "Up ", visitedCells);
            }
            //right
            if (isValidCell(startRow, startCol + 1, visitedCells, maze))
            {
                FindPath(maze, startRow, startCol + 1, path + "Right ", visitedCells);
            }
            if (isValidCell(startRow, startCol - 1, visitedCells, maze))
            {
                FindPath(maze, startRow, startCol - 1, path + "Left ", visitedCells);
            }
        }

        static void PrintMatrix(char[,] maze)
        {
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    Console.Write($"{maze[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        static bool isValidCell(int startRow, int startCol, bool[,] visitedCells, char[,] maze)
        {
            if (startRow < 0 || startRow >= maze.GetLength(0) || startCol < 0 || startCol >= maze.GetLength(1))
            {
                return false;
            }
            if (maze[startRow, startCol] == '|' || visitedCells[startRow, startCol] == true)
            {
                return false;
            }
            return true;
        }
    }
}
