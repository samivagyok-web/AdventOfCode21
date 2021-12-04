using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // such ugly code lol
        }

        public static void SecondStar()
        {
            TextReader file = new StreamReader(@"3.in");
            var values = file.ReadToEnd().Split(Environment.NewLine).ToList();
            List<string> values2 = new();
            values2.AddRange(values);

            var oxygRating = "";
            var coRating = "";

            for (int i = 0; i < 12; i++)
            {
                int oneCount = 0;

                for (int j = 0; j < values.Count; j++)
                {                    
                    if (values[j][i] == '1')
                        oneCount++;
                }

                if (oneCount > values.Count - oneCount)
                    values.RemoveAll(p => p[i] == '0');
                else if (oneCount < values.Count - oneCount)
                    values.RemoveAll(p => p[i] == '1');
                else
                {
                    values.RemoveAll(p => p[i] == '0');
                    
                    if (values.Count == 2)
                    {
                        oxygRating = values.First(p => p[i] == '1');
                        break;
                    }
                    else if (values.Count == 1)
                    {
                        oxygRating = values[0];
                        break;
                    }
                }                    
            }

            for (int i = 0; i < 12; i++)
            {
                int oneCount = 0;

                for (int j = 0; j < values2.Count; j++)
                {
                    if (values2[j][i] == '1')
                        oneCount++;
                }

                if (oneCount < values2.Count - oneCount)
                    values2.RemoveAll(p => p[i] == '0');
                else if (oneCount > values2.Count - oneCount)
                    values2.RemoveAll(p => p[i] == '1');
                else
                {
                    values2.RemoveAll(p => p[i] == '1');
                    
                    if (values2.Count == 2)
                    {
                        coRating = values2.First(p => p[i] == '0');
                        break;
                    } 
                    else if (values2.Count == 1)
                    {
                        coRating = values2[0];
                    }
                }                                   
            }

            var result = BinaryToDec(coRating) * BinaryToDec(oxygRating);
        }

        public static void FirstStar()
        {
            TextReader file = new StreamReader(@"3.in");

            string line;
            int lineCount = 0;
            int[] oneCount = new int[12];

            while ((line = file.ReadLine()) != null)
            {
                lineCount++;

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '1')
                        oneCount[i]++;
                }
            }

            string gamma = "";
            string epsilon = "";

            for (int i = 0; i < oneCount.Length; i++)
            {
                if (oneCount[i] > lineCount / 2)
                {
                    gamma += "1";
                    epsilon += "0";
                } 
                else
                {
                    gamma += "0";
                    epsilon += "1";
                }
            }

            double result = BinaryToDec(gamma) * BinaryToDec(epsilon);
            Console.WriteLine(result);
        }

        public static double BinaryToDec(string binary)
        {
            double dec = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    dec += Math.Pow(2, binary.Length - 1 - i);
                }
            }

            return dec;
        }
    }
}
