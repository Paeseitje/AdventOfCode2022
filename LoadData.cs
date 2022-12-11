using AdventOfCode2022;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2022
{
    class LoadData
    {
        protected static string GetPath(int day, int puzzle)
        {
            var path = "D:/AdventOfCode/AdventOfCode2022/bin/Debug/netcoreapp3.1/Input/Day_";
            var fullpath = String.Format("{0}{1}/day_{2}_{3}.txt", path, day, day, puzzle);
            return fullpath;
        }

       // load data as 1 long string
       protected static string LoadDataAsString(int day, int puzzle)
        {
            var input = "";
            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        input= sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return input;
        }


        // load data eg 3-7,5-9

        protected static List<List<List<int>>> LoadDataListofListOfListInt(int day, int puzzle)
        {
            var input = LoadData.LoadDataListAsStringList(day, puzzle);
            List<List<List<int>>> result = new List<List<List<int>>> ();

            foreach (var row in input)
            {

                var items = row.Split(",").ToList();

                var list_numbers = new List<List<int>>();
                foreach (var peace in items)
                {
                    List<string> xxx = peace.Split("-").ToList();
                    var number1 = Convert.ToInt32(xxx[0]);
                    var number2 = Convert.ToInt32(xxx[1]);
                    var numbers = new List<int>();
                    numbers.Add(number1);
                    numbers.Add(number2);
                    list_numbers.Add(numbers);
                }
                result.Add(list_numbers);
            }

            return result;

        }


        // load data as a list<int>
        protected static List<int> LoadDataColumnAsIntList(int day, int puzzle)
        {
            List<int> input = new List<int>();
            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        input.Add(int.Parse(sr.ReadLine()));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return input;
        }

        protected static List<int> LoadDataListAsIntList(int day, int puzzle)
        {
            List<int> input = new List<int>();

            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        input.Add(int.Parse(line));
                        //input = line.Split(',').Select(int.Parse).ToList();

                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return input;
        }

        protected static List<int> LoadDataListAsIntListBIS(int day, int puzzle)
        {
            List<int> input = new List<int>();

            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        //input.Add(int.Parse(line));
                        input = line.Split(',').Select(int.Parse).ToList();

                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return input;
        }

        protected static List<int> LoadDataListAsIntListSpace(int day, int puzzle)
        {
            List<int> input = new List<int>();

            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        //input.Add(int.Parse(line));
                        input = line.Split(' ').Select(int.Parse).ToList();

                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return input;
        }

        protected static List<long> LoadDataListAsLongList(int day, int puzzle)
        {
            List<long> input = new List<long>();
            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        input.Add(long.Parse(line));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return input;
        }


        protected static List<long> LoadDataListAsLongListBIS(int day, int puzzle)
        {
            List<long> input = new List<long>();
            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        input = line.Split(',').Select(long.Parse).ToList();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return input;
        }


        protected static List<List<int>> LoadDataListAsIntListList(int day, int puzzle)
        {
            List<List<int>> input = new List<List<int>>();

            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(",").Select(int.Parse).ToList();
                        input.Add(line);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return input;
        }

        

        protected static List<List<int>> LoadDataListAsIntListListBis(int day, int puzzle)
        {
            List<List<int>> input = new List<List<int>>();

            try
            {

                // Read the file and collect the numbers in "curSet" until a blank line is encountered
                List<int> curSet = new List<int>();
                foreach (String line in System.IO.File.ReadLines(GetPath(day, puzzle)))
                {
                    if (line.Trim().Length == 0)
                    {
                        // blank line found, add the current set of numbers to our list,
                        // but only if the current set actually has any numbers in it.
                        if (curSet.Count > 0)
                        {
                            input.Add(curSet);
                            curSet = new List<int>();
                        }
                    }
                    else
                    {
                        int number;
                        if (int.TryParse(line, out number))
                        {
                            curSet.Add(number);
                        }
                    }
                }
                // end of file reached, add a pending set of numbers if it exists
                if (curSet.Count > 0)
                {
                    input.Add(curSet);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return input;
        }



        protected static List<string> LoadDataListAsStringList(int day, int puzzle)
        {
            List<string> input = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        input.Add(sr.ReadLine());

                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return input;
        }

        protected static List<string> LoadDataAsStringListBis(int day, int puzzle)
        {
            var input = new List<string>();
            string line;
            string totalLine = "";
            try
            {
                using StreamReader sr = new StreamReader(GetPath(day, puzzle));
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    if (!string.IsNullOrEmpty(line))
                    {
                        totalLine += line;
                        totalLine += " ";

                    }
                    else
                    {
                        input.Add(totalLine);
                        totalLine = "";
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return input;
        }

        protected static List<List<string>> LoadDataListAsStringListList(int day, int puzzle)
        {
            List<List<string>> list = new List<List<string>>();

            try
            {
                using (StreamReader sr = new StreamReader(GetPath(day, puzzle)))
                {
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine().Split(',').ToList());
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            return list;
        }


        protected static Dictionary<string, int> LoadDataListAsStringIntDict(int day, int puzzle)
        {
            var dict = new Dictionary<string, int>();
            try
            {
                StreamReader sr = new StreamReader(GetPath(day, puzzle));
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                    dict.Add(arr[0], Convert.ToInt32(arr[1]));
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            return dict;
        }


        protected static Dictionary<string, string> LoadDataListAsStringStringDict(int day, int puzzle)
        {
            var dict = new Dictionary<string, string>();
            try
            {
                StreamReader sr = new StreamReader(GetPath(day, puzzle));
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                    dict.Add(arr[0],arr[1]);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            return dict;
        }
    }

}
