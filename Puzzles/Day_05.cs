using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Puzzles
{
    class Day_05 : LoadData
    {

        public static string Puzzle1()
        {


            var lijst_1 = new List<string>() { "T", "D", "W", "Z", "V", "P" };
            var lijst_2 = new List<string>() { "L", "S", "W", "V", "F", "J", "D" };
            var lijst_3 = new List<string>() { "Z", "M", "L", "S", "V", "T", "B", "H"};
            var lijst_4 = new List<string>() { "R", "S", "J"};
            var lijst_5 = new List<string>() { "C", "Z", "B", "G", "F", "M", "L", "W" };
            var lijst_6 = new List<string>() { "Q", "W", "V", "H", "Z", "R", "G", "B" };
            var lijst_7 = new List<string>() { "V", "J", "P", "C", "B", "D", "N" };
            var lijst_8 = new List<string>() { "P", "T", "B", "Q"};
            var lijst_9 = new List<string>() { "H", "G", "Z", "R", "c" };

            var input = LoadDataListAsStringList(5, 1);

            var workorderList = new List<List<int>>();

            foreach (var order in input)
            {
                var workorder = string.Concat(order.Where(Char.IsDigit));
                var numbers = new List<int>();
                foreach (char number in workorder)
                {
                    numbers.Add((int)char.GetNumericValue(number));
                }
                workorderList.Add(numbers);
            }


            foreach (var order in workorderList)
            {

                // loop elk order na en voor uit wat er moet gebeuren
                int aantal = order[0];
                int from_stack = order[1];
                int to_stack = order[2];

                for (int i = 1; i <= aantal; i++)
                {
                    // take last box from stack en place it on the dedicated stack
                    // take last box from stack
                    var take_from_stack = from_stack == 1 ? lijst_1 : from_stack == 2 ? lijst_2 :
                        from_stack == 3 ? lijst_3 : from_stack == 4 ? lijst_4 : from_stack == 5 ? lijst_5 : from_stack == 6 ? lijst_6 : from_stack == 7 ? lijst_7 : from_stack == 8 ? lijst_8 : lijst_9;
                    var add_to_stack = to_stack == 1 ? lijst_1 : to_stack == 2 ? lijst_2 :
                        to_stack == 3 ? lijst_3 : to_stack == 4 ? lijst_4 : to_stack == 5 ? lijst_5 : to_stack == 6 ? lijst_6 : to_stack == 7 ? lijst_7 : to_stack == 8 ? lijst_8 : lijst_9;

                    var box = take_from_stack.Last();
                    take_from_stack.RemoveAt(take_from_stack.Count -1) ;
                    add_to_stack.Add(box);
                }

            }

            var last_1 = lijst_1.Last();
            var last_2 = lijst_2.Last();
            var last_3 = lijst_3.Last();
            var last_4 = lijst_4.Last();
            var last_5 = lijst_5.Last();
            var last_6 = lijst_6.Last();
            var last_7 = lijst_7.Last();
            var last_8 = lijst_8.Last();
            var last_9 = lijst_9.Last();



            var result = string.Concat(last_1, last_2, last_3,last_4, last_5,last_6, last_7, last_8, last_9);

            return result;
        }

        public static int Puzzle2()
        {
            var result = 1;
            return result;
        }

    }
}
