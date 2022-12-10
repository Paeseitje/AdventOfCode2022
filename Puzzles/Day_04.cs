using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2022.Puzzles
{
    class Day_04 : LoadData
    {

        public static int Puzzle1()
        {

            var input = LoadData.LoadDataListofListOfListInt(4, 1);

            // is left in right => first number L >=  first number R en second numer L <= second number R 
            //  or
            // first number R >= first numer L and second numer R <= second number

            var result = 0;


            foreach (var lijt in input)
            {
                List<int> lijst_1 = lijt[0];
                List<int> lijst_2 = lijt[1];

                // zit vervat
                if (  (lijst_1[0] >= lijst_2[0] && lijst_1[1] <= lijst_2[1])  ||  (lijst_2[0] >= lijst_1[0] && lijst_2[1] <= lijst_1[1])) 
                {
                    result++;
                }
            }


            return result;
        }

        public static int Puzzle2()
        {
            var input = LoadData.LoadDataListofListOfListInt(4, 1);

            // first number L is >= first number R  && first number L <= second number R 
            // second number L is >= first number R && scond number L <= second number R

            // first number R >= first number L && first number R <= second number L
            // second number R >= first number L &&  second number R <= second number L

            var result = 0;


            foreach (var lijt in input)
            {
                List<int> lijst_1 = lijt[0];
                List<int> lijst_2 = lijt[1];

                if 
                    (
                        (lijst_1[0] >= lijst_2[0] && lijst_1[0] <= lijst_2[1]) ||
                        (lijst_1[1] >= lijst_2[0] && lijst_1[1] <= lijst_2[1]) ||
                        (lijst_2[0] >= lijst_1[0] && lijst_2[0] <= lijst_1[1]) ||
                        (lijst_2[1] >= lijst_1[0] && lijst_2[1] <= lijst_1[1])
                    )
                {
                    result++;
                }

                //// zit vervat
                //if ((lijst_1[0] >= lijst_2[0] && lijst_1[1] <= lijst_2[1]) || (lijst_2[0] >= lijst_1[0] && lijst_2[1] <= lijst_1[1]))
                //{
                //    result++;
                //}
            }


            return result;
        }
    }
}
