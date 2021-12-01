using System;
using System.IO;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void SecondStar()
        {
            TextReader file = new StreamReader(@"1.in");
            var values = file.ReadToEnd().Split(Environment.NewLine).Select(p => int.Parse(p)).ToArray();

            int prevVal = values[0] + values[1] + values[2];

            int counter = 0;
            for (int i = 1; i < values.Length / 3 * 3; i++)
            {
                if (values[i] + values[i + 1] + values[i + 2] > prevVal)
                    counter++;

                prevVal = values[i] + values[i + 1] + values[i + 2];
            }
        }

        public static void FirstStar()
        {
            TextReader file = new StreamReader(@"1.in");
            int prevValue = int.Parse(file.ReadLine());
            int counter = 0;

            string line;
            while ((line = file.ReadLine()) != null)
            {
                if (int.Parse(line) > prevValue)
                    counter++;

                prevValue = int.Parse(line);
            }
        }
    }
}
