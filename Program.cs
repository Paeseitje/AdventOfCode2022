using AdventOfCode2022.Puzzles;
using System;

namespace AdventOfCode2022
{
    class Program : LoadData
    {
        public const string INPUT_FILE_DIR = "Input/Day_";

        static void Main(string[] args)
        {

            int day = 5;
            int puzzle = 1;

            if (puzzle == 1)
            {
                Console.WriteLine("Starting puzzle 1");
                var solve1 = Day_05.Puzzle1();
                Console.WriteLine("Solution to puzzle 1 of day {0}: {1}", day, solve1);
            }
            else
            {
                Console.WriteLine("starting puzzle 2");
                var solve2 = Day_05.Puzzle2();
                Console.WriteLine("solution to puzzle 2 of day {0}: {1}", day, solve2);
                
            }
        }
    }
}