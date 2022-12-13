using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Puzzles
{
    class Day_11 : LoadData
    {
        public static long Puzzle1()
        {
            var monkey_0 = new List<long>() { 72, 64, 51, 57, 93, 97, 68 };
            var monkey_1 = new List<long>() { 62 };
            var monkey_2 = new List<long>() { 57, 94, 69, 79, 72 };
            var monkey_3 = new List<long>() { 80, 64, 92, 93, 64, 56 };
            var monkey_4 = new List<long>() { 70, 88, 95, 99, 78, 72, 65, 94 };
            var monkey_5 = new List<long>() { 57, 95, 81, 61 };
            var monkey_6 = new List<long>() { 79, 99 };
            var monkey_7 = new List<long>() { 68, 98, 62 };

            var monkeys = new List<List<long>>() { monkey_0, monkey_1, monkey_2, monkey_3, monkey_4, monkey_5, monkey_6, monkey_7};
            long monkey_0Handels = 0;
            long monkey_1Handels = 0;
            long monkey_2Handels = 0;
            long monkey_3Handels = 0;
            long monkey_4Handels = 0;
            long monkey_5Handels = 0;
            long monkey_6Handels = 0;
            long monkey_7Handels = 0;



            for (int i = 1; i <= 20; i++)
            {
                // proces monkey's

                for (int j = 0; j <= monkeys.Count; j++)
                {
                    int count_list = 0;
                    switch (j)
                    {
                        case 0: // monkey_0
                            
                            count_list = monkey_0.Count();

                            if (count_list > 0)

                            {
                                foreach (long item in monkey_0)
                                {
                                    long worry = getWorry(item, 0);

                                    if (worry % 17 == 0)
                                    {
                                        monkey_4.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_7.Add(worry);
                                    }
                                    monkey_0Handels++;
                                }
                                monkey_0.RemoveRange(0, count_list);
                                
                            }
                            else { break; }
                            break;
                        case 1: // monkey_1
                            count_list = monkey_1.Count();

                            if (count_list > 0)

                            {
                                foreach (long item in monkey_1)
                                {
                                    long worry = getWorry(item, 1);

                                    if (worry % 3 == 0)
                                    {
                                        monkey_3.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_2.Add(worry);
                                    }
                                    monkey_1Handels++;
                                }
                                monkey_1.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 2: // monkey_2
                            count_list = monkey_2.Count();

                            if (count_list > 0)

                            {
                                foreach (long item in monkey_2)
                                {
                                    long worry = getWorry(item, 2);


                                    if (worry % 19 == 0)
                                    {
                                        monkey_0.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_4.Add(worry);
                                    }
                                    monkey_2Handels++;
                                }
                                monkey_2.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 3: // monkey_3
                            count_list = monkey_3.Count();

                            if (count_list > 0)

                            {
                                foreach (long item in monkey_3)
                                {
                                    //monkey_3.Remove(item);
                                    long worry = getWorry(item, 3);

                                    if (worry % 7 == 0)
                                    {
                                        monkey_2.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_0.Add(worry);
                                    }
                                    monkey_3Handels++;
                                }
                                monkey_3.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 4: // monkey_4
                            count_list = monkey_4.Count();

                            if (count_list > 0)

                            {
                                foreach (long item in monkey_4)
                                {
                                    long worry = getWorry(item, 4);

                                    if (worry % 2 == 0)
                                    {
                                        monkey_7.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_5.Add(worry);
                                    }
                                    monkey_4Handels++;
                                }
                                monkey_4.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 5: // monkey_5
                            count_list = monkey_5.Count();

                            if (count_list > 0)

                            {
                                foreach (long item in monkey_5)
                                {
                                    //monkey_3.Remove(item);
                                    long worry = getWorry(item, 5);

                                    if (worry % 5 == 0)
                                    {
                                        monkey_1.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_6.Add(worry);
                                    }
                                    monkey_5Handels++;
                                }
                                monkey_5.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 6: // monkey_6
                            count_list = monkey_6.Count();

                            if (count_list > 0)

                            {
                                foreach (long item in monkey_6)
                                {
                                    long worry = getWorry(item, 6);

                                    if (worry % 11 == 0)
                                    {
                                        monkey_3.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_1.Add(worry);
                                    }
                                    monkey_6Handels++;
                                }
                                monkey_6.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 7: // monkey_7
                            count_list = monkey_7.Count();

                            if (count_list > 0)

                            {
                                foreach (long item in monkey_7)
                                {
                                    long worry = getWorry(item, 7);

                                    if (worry % 13 == 0)
                                    {
                                        monkey_5.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_6.Add(worry);
                                    }
                                    monkey_7Handels++;
                                }
                                monkey_7.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        default:
                            break;
                    }
                }
            }

            var handles = new List<long>() { monkey_0Handels, monkey_1Handels, monkey_2Handels, monkey_3Handels, monkey_4Handels, monkey_5Handels, monkey_6Handels, monkey_7Handels };

            long max1 = -1L;
            long max2 = -1;
            foreach (int num in handles)
            {
                if (num > max1) { max2 = max1; max1 = num; }
                else if (num > max2) { max2 = num; }
            }

            
            long result = max1 * max2;
            return result;
        }

        public static long Puzzle2()
        {
            var monkey_0 = new List<long>() { 72, 64, 51, 57, 93, 97, 68 };
            var monkey_1 = new List<long>() { 62 };
            var monkey_2 = new List<long>() { 57, 94, 69, 79, 72 };
            var monkey_3 = new List<long>() { 80, 64, 92, 93, 64, 56 };
            var monkey_4 = new List<long>() { 70, 88, 95, 99, 78, 72, 65, 94 };
            var monkey_5 = new List<long>() { 57, 95, 81, 61 };
            var monkey_6 = new List<long>() { 79, 99 };
            var monkey_7 = new List<long>() { 68, 98, 62 };

            var monkeys = new List<List<long>>() { monkey_0, monkey_1, monkey_2, monkey_3, monkey_4, monkey_5, monkey_6, monkey_7 };
            long monkey_0Handels = 0;
            long monkey_1Handels = 0;
            long monkey_2Handels = 0;
            long monkey_3Handels = 0;
            long monkey_4Handels = 0;
            long monkey_5Handels = 0;
            long monkey_6Handels = 0;
            long monkey_7Handels = 0;



            for (int i = 1; i <= 10000; i++)
            {
                // proces monkey's

                for (int j = 0; j <= monkeys.Count; j++)
                {
                    int count_list = 0;
                    long denominator = 0;

                    switch (j)
                    {
                        case 0: // monkey_0

                            count_list = monkey_0.Count();
                            // find common denominator for this list
                            denominator = GCD(monkey_0);

                            if (count_list > 0)

                            {
                                foreach (long item in monkey_0)
                                {
                                    long worry = getWorry2(item, 0, denominator);

                                    if (worry % 17 == 0)
                                    {
                                        monkey_4.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_7.Add(worry);
                                    }
                                    monkey_0Handels++;
                                }
                                monkey_0.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 1: // monkey_1
                            count_list = monkey_1.Count();
                            // find common denominator for this list
                            denominator = GCD(monkey_1);
                            if (count_list > 0)

                            {
                                foreach (long item in monkey_1)
                                {
                                    long worry = getWorry2(item, 1, denominator);

                                    if (worry % 3 == 0)
                                    {
                                        monkey_3.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_2.Add(worry);
                                    }
                                    monkey_1Handels++;
                                }
                                monkey_1.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 2: // monkey_2
                            count_list = monkey_2.Count();
                            // find common denominator for this list
                            denominator = GCD(monkey_2);
                            if (count_list > 0)

                            {
                                foreach (long item in monkey_2)
                                {
                                    long worry = getWorry2(item, 2, denominator);


                                    if (worry % 19 == 0)
                                    {
                                        monkey_0.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_4.Add(worry);
                                    }
                                    monkey_2Handels++;
                                }
                                monkey_2.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 3: // monkey_3
                            count_list = monkey_3.Count();
                            // find common denominator for this list
                            denominator = GCD(monkey_3);
                            if (count_list > 0)

                            {
                                foreach (long item in monkey_3)
                                {
                                    //monkey_3.Remove(item);
                                    long worry = getWorry2(item, 3, denominator);

                                    if (worry % 7 == 0)
                                    {
                                        monkey_2.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_0.Add(worry);
                                    }
                                    monkey_3Handels++;
                                }
                                monkey_3.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 4: // monkey_4
                            count_list = monkey_4.Count();
                            // find common denominator for this list
                            denominator = GCD(monkey_4);
                            if (count_list > 0)

                            {
                                foreach (long item in monkey_4)
                                {
                                    long worry = getWorry2(item, 4, denominator);

                                    if (worry % 2 == 0)
                                    {
                                        monkey_7.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_5.Add(worry);
                                    }
                                    monkey_4Handels++;
                                }
                                monkey_4.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 5: // monkey_5
                            count_list = monkey_5.Count();
                            // find common denominator for this list
                            denominator = GCD(monkey_5);
                            if (count_list > 0)

                            {
                                foreach (long item in monkey_5)
                                {
                                    //monkey_3.Remove(item);
                                    long worry = getWorry2(item, 5, denominator);

                                    if (worry % 5 == 0)
                                    {
                                        monkey_1.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_6.Add(worry);
                                    }
                                    monkey_5Handels++;
                                }
                                monkey_5.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 6: // monkey_6
                            count_list = monkey_6.Count();
                            // find common denominator for this list
                            denominator = GCD(monkey_6);
                            if (count_list > 0)

                            {
                                foreach (long item in monkey_6)
                                {
                                    long worry = getWorry2(item, 6, denominator);

                                    if (worry % 11 == 0)
                                    {
                                        monkey_3.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_1.Add(worry);
                                    }
                                    monkey_6Handels++;
                                }
                                monkey_6.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        case 7: // monkey_7
                            count_list = monkey_7.Count();
                            // find common denominator for this list
                            denominator = GCD(monkey_7);
                            if (count_list > 0)

                            {
                                foreach (long item in monkey_7)
                                {
                                    long worry = getWorry2(item, 7, denominator);

                                    if (worry % 13 == 0)
                                    {
                                        monkey_5.Add(worry);
                                    }
                                    else
                                    {
                                        monkey_6.Add(worry);
                                    }
                                    monkey_7Handels++;
                                }
                                monkey_7.RemoveRange(0, count_list);

                            }
                            else { break; }
                            break;
                        default:
                            break;
                    }
                }
            }

            var handles = new List<long>() { monkey_0Handels, monkey_1Handels, monkey_2Handels, monkey_3Handels, monkey_4Handels, monkey_5Handels, monkey_6Handels, monkey_7Handels };

            long max1 = -1L;
            long max2 = -1;
            foreach (int num in handles)
            {
                if (num > max1) { max2 = max1; max1 = num; }
                else if (num > max2) { max2 = num; }
            }


            long result = max1 * max2;
            return result;
        }


        private static long getWorry2(long item, int monkey, long denominator)
        {
            double worry = 0;

            switch (monkey)
            {
                case 0:
                    worry = item * 19;
                    break;
                case 1:
                    worry = item * 11;
                    break;
                case 2:
                    worry = item + 6;
                    break;
                case 3:
                    worry = item + 5;
                    break;
                case 4:
                    worry = item + 7;
                    break;
                case 5:
                    worry = item * item;
                    break;
                case 6:
                    worry = item + 2;
                    break;
                case 7:
                    worry = item + 3;
                    break;
                default:
                    break;
            }

            long result = (long)Math.Floor(worry / denominator);
            return result;
        }



        static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static long GCD(List<long> integerSet)
        {
            return integerSet.Aggregate(GCD);
        }

        private static long getWorry(long item, int monkey)
        {
            double worry = 0;

                switch (monkey)
                {
                    case 0:
                        worry = item * 19;
                        break;
                    case 1:
                        worry = item * 11;
                        break;
                    case 2:
                        worry = item + 6;
                        break;
                    case 3:
                        worry = item + 5;
                        break;
                    case 4:
                        worry = item + 7;
                        break;
                case 5:
                        worry = item * item;
                        break;
                    case 6:
                        worry = item + 2;
                        break;
                    case 7:
                        worry = item + 3;
                        break;
                    default:
                        break;
                }
            long result = (long)Math.Floor(worry / 3);
            return result;
        }

    }
}
