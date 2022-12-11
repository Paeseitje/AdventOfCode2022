using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Puzzles
{
    class Day_06 : LoadData
    {
        public static int Puzzle1()
        {
            string input = LoadData.LoadDataAsString(6, 1);
            //var start_set = input.Substring(0, 4);
            var found_it = false;
            int result = 0;

            for (int i = 0; i < input.Length && found_it == false; i++)
            {
                // check for duplicates in set
                // if yes -> volgende set
                var set = input.Substring(i, 4);

                found_it = IsUnique(set);

                result = i + 4;
            }
            return result;
        }

        public static bool IsUnique(string s)
        {
            int[] count = new int[256];
            Array.Clear(count, 0, count.Length - 1);
            foreach (char c in s)
            {
                if(++count[c] > 1)
                {
                    return false;
                }
            }
                return true;
        }

        public static int Puzzle2()
        {
            string input = LoadData.LoadDataAsString(6, 1);
            //var start_set = input.Substring(0, 4);
            var found_it = false;
            int result = 0;

            for (int i = 0; i < input.Length && found_it == false; i++)
            {
                // check for duplicates in set
                // if yes -> volgende set
                var set = input.Substring(i, 14);

                found_it = IsUnique(set);

                result = i + 14;
            }
            return result;
        }

    }
}
