using System;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondStar();
        }

        public static void SecondStar()
        {
            TextReader file = new StreamReader(@"2.in");
            int forward = 0;
            int depth = 0;
            int aim = 0;

            string line;
            while ((line = file.ReadLine()) != null)
            {
                var coord = line.Split(" ");

                if (coord[0].Equals("forward"))
                {
                    forward += int.Parse(coord[1]);
                    depth += aim * int.Parse(coord[1]);
                }
                else if (coord[0].Equals("up"))
                {
                    aim -= int.Parse(coord[1]);
                }
                else
                {
                    aim += int.Parse(coord[1]);
                }
            }

            Console.WriteLine(forward * depth);
        }

        public static void FirstStar()
        {
            TextReader file = new StreamReader(@"2.in");
            int forward = 0;
            int depth = 0;

            string line;
            while ((line = file.ReadLine()) != null)
            {
                var coord = line.Split(" ");

                if (coord[0].Equals("forward"))
                {
                    forward += int.Parse(coord[1]);
                }
                else if (coord[0].Equals("up"))
                {
                    depth -= int.Parse(coord[1]);
                }
                else
                {
                    depth += int.Parse(coord[1]);
                }
            }
        }
    }
}
