using System;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            bool z = true; 
            char[] line = {'|', '.', ' ', ' ', ' ', ' ', '|'};
            int position = 1;
            Console.WriteLine(line);
            while(z) {
                if (Console.KeyAvailable) {
                    var input = Console.ReadKey(true);
                    // char x = Convert.ToChar(input);
                                // Console.Clear();
                                // Console.WriteLine("r");
                    switch (input.Key) {
                        case ConsoleKey.D:
                            if (position < 5) {
                                line[position] = ' ';
                                line[position + 1] = '.';
                                position++;
                            }
                            break;
                        case ConsoleKey.A:
                            if (position > 1) {
                                line[position] = ' ';
                                line[position - 1] = '.';
                                position--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (position < 5) {
                                line[position] = ' ';
                                line[position + 1] = '.';
                                position++;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (position > 1) {
                                line[position] = ' ';
                                line[position - 1] = '.';
                                position--;
                            }
                            break;
                        case ConsoleKey.Q:
                            z = false;
                            break;
                        default:
                            break;

                    }
                    Console.Clear();
                    Console.WriteLine(line);
                }
            }
        }
    }
}
