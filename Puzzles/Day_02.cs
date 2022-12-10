using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2022.Puzzles
{
    class Day_02 : LoadData

    {
        public static int Puzzle1()
        {

            //var input = LoadDataListAsStringStringDict(2, 1);
            var input = LoadDataListAsStringList(2, 1);

            var result = 1;

            var elements = new Dictionary<string, string>();
            elements.Add("A", "Rock");
            elements.Add("B", "Paper");
            elements.Add("C", "Cissor");

            var defence = new Dictionary<string, string>();
            defence.Add("X", "Rock");
            defence.Add("Y", "Paper");
            defence.Add("Z", "Cissor");

            var win = 6;
            var draw = 3;
            var loss = 0;

            var X = 1;
            var Y = 2;
            var Z = 3;


            result = 0;

            foreach (var item in input)
            {
                var keyValue = item.Split(",");
                string Key = keyValue[0];
                string Value =keyValue[1];

                if (elements[Key] == defence[Value])  //both are the same
                {
                    // this is a draw
                    result += draw;

                }
                // rock (A) wins of cissors (Z)
                // Paper (B) wins of rock (X)
                // Cissors (C) wins of paper (Y)
                // lose
                else if ((Key == "A" && Value == "Z") || (Key == "B" && Value == "X") || (Key == "C" && Value == "Y"))
                {
                    // this is a loss
                    result += loss;
                }
                else
                {
                    // this is a win
                    result += win;
                }

                // add the value for the item played in defence
                var addition = Value == "X" ? X : Value == "Y" ? Y : Z;

                result += addition;
            }

            return result;
        }


        public static int Puzzle2()
        {
            var input = LoadDataListAsStringList(2, 1);

            var result = 1;

            //var elements = new Dictionary<string, string>();
            //elements.Add("A", "Rock");
            //elements.Add("B", "Paper");
            //elements.Add("C", "Cissor");

            //var defence = new Dictionary<string, string>();
            //defence.Add("X", "Rock");
            //defence.Add("Y", "Paper");
            //defence.Add("Z", "Cissor");

            var win = 6;
            var draw = 3;
            var loss = 0;

            var X = 1;
            var Y = 2;
            var Z = 3;


            result = 0;

            foreach (var item in input)
            {
                var keyValue = item.Split(",");
                string Key = keyValue[0];
                string Value = keyValue[1];

                int counter = 0;

                switch (Value)
                {

                    case "X":
                        // Lose
                        // rock (A) wins from cissors (Z)
                        // paper (B) wins from rock (X)
                        // scissors (C) wins from paper (Y)

                        result += loss;

                        result += Key == "A" ? Z : Key == "B" ?  X: Y;

                        break;
                    case "Y":
                        // Draw
                        result += draw;
                        result += Key == "A" ? X : Key == "B" ? Y : Z;

                        break;
                    case "Z":
                        // Win
                        result += win;
                        result += Key == "A" ? Y : Key == "B" ? Z : X;

                        break;
                    default:
                        // code block
                        break;
                }

            }

            return result;

        }

    }
}