using System;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            bool z = true; 
            char[,] grid = new char[5, 5] {
                {'_', '_', '_', '_', '_'}, 
                {'|', '.', ' ', ' ', '|'}, 
                {'|', ' ', ' ', ' ', '|'}, 
                {'|', ' ', ' ', ' ', '|'}, 
                {'_', '_', '_', '_', '_'}
            };
            int[] position = {1, 1};
            for(int i = 0; i < 5; i++) {
                for(int j = 0; j < 5; j++) {
                    Console.Write(grid[i, j]);
                }
                Console.Write('\n');
            }
            while(z) {
                if (Console.KeyAvailable) {
                    var input = Console.ReadKey(true);
                    switch (input.Key) {
                        case ConsoleKey.S:
                            if (position[0] < 3) {
                                grid[position[0], position[1]] = ' ';
                                grid[position[0] + 1, position[1]] = '.';
                                position[0]++;
                            }
                            break;
                        case ConsoleKey.W:
                            if (position[0] > 1) {
                                grid[position[0], position[1]] = ' ';
                                grid[position[0] - 1, position[1]] = '.';
                                position[0]--;
                            }
                            break;
                        case ConsoleKey.D:
                            if (position[1] < 3) {
                                grid[position[0], position[1]] = ' ';
                                grid[position[0], position[1] + 1] = '.';
                                position[1]++;
                            }
                            break;
                        case ConsoleKey.A:
                            if (position[1] > 1) {
                                grid[position[0], position[1]] = ' ';
                                grid[position[0], position[1] - 1] = '.';
                                position[1]--;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (position[0] < 3) {
                                grid[position[0], position[1]] = ' ';
                                grid[position[0] + 1, position[1]] = '.';
                                position[0]++;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (position[0] > 1) {
                                grid[position[0], position[1]] = ' ';
                                grid[position[0] - 1, position[1]] = '.';
                                position[0]--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (position[1] < 3) {
                                grid[position[0], position[1]] = ' ';
                                grid[position[0], position[1] + 1] = '.';
                                position[1]++;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (position[1] > 1) {
                                grid[position[0], position[1]] = ' ';
                                grid[position[0], position[1] - 1] = '.';
                                position[1]--;
                            }
                            break;
                        case ConsoleKey.Q:
                            z = false;
                            break;
                        default:
                            break;

                    }
                    Console.Clear();
                    for(int i = 0; i < 5; i++) {
                    for(int j = 0; j < 5; j++) {
                        Console.Write(grid[i, j]);
                    }
                    Console.Write('\n');
            }
                }
            }
        }
    }
}
