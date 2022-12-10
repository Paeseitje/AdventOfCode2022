using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2022.Puzzles
{
    class Day_03 : LoadData
    {

        public static int Puzzle1()
        {
            var input = LoadDataListAsStringList(3, 1);
            int result = 0;

            foreach (var item in input)
            {
                // make a list for both compartments
                var length = item.Length;
                var comp_1 = item.Substring(0, length / 2);
                var comp_2 = item.Substring(length / 2, length - length / 2);

                var common = comp_1.Intersect(comp_2).ToList();
                var common_letter = common[0];

                bool Upper = char.IsUpper(common_letter);
                int number = 0;
                if (!Upper)
                {
                    number = char.ToUpper(common_letter) - 64;
                }
                else
                {
                    number = char.ToUpper(common_letter) - 64 + 26;
                }
                result += number;
            }


            return result;
        }

        public static int Puzzle2()
        {

            var input = LoadDataListAsStringList(3, 1);
            int result = 0;

            int length = input.Count();

            for (int i = 0; i < length; i+=3)
            {
                // take 3
                var set_1 = input[i];
                var set_2 = input[i + 1];
                var set_3 = input[i + 2];

                var common = set_1.Intersect(set_2).Intersect(set_3).ToList();
                var common_letter = common[0];

                bool Upper = char.IsUpper(common_letter);
                int number = 0;
                if (!Upper)
                {
                    number = char.ToUpper(common_letter) - 64;
                }
                else
                {
                    number = char.ToUpper(common_letter) - 64 + 26;
                }
                result += number;

            }

            return result; 
        }
    }
}
