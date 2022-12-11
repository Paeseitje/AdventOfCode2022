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
            var lijst_9 = new List<string>() { "H", "G", "Z", "R", "C" };

            var input = LoadDataListAsStringList(5, 1);

            var workorderList = new List<List<int>>();

            foreach (var order in input)
            {
                var numbers = new List<int>();

                string[] values = Regex.Split(order, @"\D+");
                foreach (string value in values)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        int i = int.Parse(value);
                        numbers.Add(i);
                    }
                }
                workorderList.Add(numbers);
            }

            foreach (var order in workorderList)
            {
                // loop elk order na en voor uit wat er moet gebeuren
                int aantal = order[0];
                int from_stack = order[1];
                int to_stack = order[2];
                var box = "";
                for (int i = aantal; i > 0; i--)
                {
                    switch (from_stack)
                    {
                        case 1 :
                            box = lijst_1.Last();
                            lijst_1.RemoveAt(lijst_1.Count -1) ;
                            break;
                        case 2:
                            box = lijst_2.Last();
                            lijst_2.RemoveAt(lijst_2.Count - 1);
                            break;
                        case 3:
                            box = lijst_3.Last();
                            lijst_3.RemoveAt(lijst_3.Count - 1);
                            break;
                        case 4:
                            box = lijst_4.Last();
                            lijst_4.RemoveAt(lijst_4.Count - 1);
                            break;
                        case 5:
                            box = lijst_5.Last();
                            lijst_5.RemoveAt(lijst_5.Count - 1);
                            break;
                        case 6:
                            box = lijst_6.Last();
                            lijst_6.RemoveAt(lijst_6.Count - 1);
                            break;
                        case 7:
                            box = lijst_7.Last();
                            lijst_7.RemoveAt(lijst_7.Count - 1);
                            break;
                        case 8:
                            box = lijst_8.Last();
                            lijst_8.RemoveAt(lijst_8.Count - 1);
                            break;
                        case 9:
                            box = lijst_9.Last();
                            lijst_9.RemoveAt(lijst_9.Count - 1);
                            break;
                        default:
                            break;
                    }

                    switch (to_stack)
                    {
                        case 1:
                            lijst_1.Add(box);
                            break;
                        case 2:
                            lijst_2.Add(box);
                            break;
                        case 3:
                            lijst_3.Add(box);
                            break;
                        case 4:
                            lijst_4.Add(box);
                            break;
                        case 5:
                            lijst_5.Add(box);
                            break;
                        case 6:
                            lijst_6.Add(box);
                            break;
                        case 7:
                            lijst_7.Add(box);
                            break;
                        case 8:
                            lijst_8.Add(box);
                            break;
                        case 9:
                            lijst_9.Add(box);
                            break;
                        default:
                            break;
                    }


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
