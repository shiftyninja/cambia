// The solution must be runnable with a Docker command(i.e., include a Dockerfile).

// Imagine a CSV file called input.csv, which contains a single line of comma-separated strings. This
// single line is terminated with a new line character.Using an appropriate language, write a program
// that reads input.csv, sorts its strings into descending alphabetical order, and writes the sorted
// strings in comma-separated format to a new file called output.csv.

// Here are sample contents of these two files(but your program should handle other content as well):
// • input file: Copenhagen,Stockholm,Oslo
// • output file: Stockholm,Oslo,Copenhagen

using System;
using System.IO;

namespace CambiaTakeHome
{
    class Program
    {
        static int Main(string[] args)
        {
            StreamReader reader = new StreamReader(".\\input.csv");
            string line = null;

            try
            {
                // Read single line from file.
                line = reader.ReadLine();
            }
            catch
            {
                Console.WriteLine("input.csv file is empty");
            }
            finally
            {
                reader.Close();
            }

            if (string.IsNullOrEmpty(line))
                return 1;

            string newLine = SplitAndSortDescendingLine(line);
            WriteLineToFile(newLine);

            return 0;
        }

        private static string SplitAndSortDescendingLine(string line)
        {
            // Split the line into individual strings
            var strings = line.Split(',');

            // Sort the strings in descending order
            Array.Sort(strings, (a, b) => b.CompareTo(a));

            // Create a new line by joining the sorted strings
            return string.Join(",", strings);
        }

        private static void WriteLineToFile(string newLine)
        {
            StreamWriter writer = new StreamWriter(".\\output.csv");
            writer.WriteLine(newLine);
            writer.Close();
        }
    }
}
