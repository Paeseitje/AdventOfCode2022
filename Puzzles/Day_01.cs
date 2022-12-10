using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2022.Puzzles
{
    class Day_01 : LoadData

    {
        public static int Puzzle1()
        {

            var input = LoadDataListAsIntListListBis(1, 1);

            var result = 1;

            var max = 0;

            foreach (var lijst in input)
            {
                var total= lijst.Sum(x => Convert.ToInt32(x));
                if (total > max)
                {
                    max = total;
                }
            }

            result = max;
            return result;
        }


        public static int Puzzle2()
        {
            var result = 0;
            var input = LoadDataListAsIntListListBis(1, 1);

            var calories = new List<int>();

            var max_1 = 0;
            var max_2 = 0;
            var max_3 = 0;

            foreach (var lijst in input)
            {
                var total = lijst.Sum(x => Convert.ToInt32(x));
                if (total > max_1)
                {
                    max_3 = max_2;
                    max_2 = max_1;
                    max_1 = total;
                }
                else if (total < max_1 && total > max_2)
                {
                    max_3 = max_2;
                    max_2 = total;
                }
                else if (total < max_1 && total < max_2 && total > max_3)
                {
                    max_3 = total;
                }
            }



            calories.Add(max_1);
            calories.Add(max_2);
            calories.Add(max_3);

            result = calories.Sum(x => Convert.ToInt32(x));

            return result;
        }

    }
}
