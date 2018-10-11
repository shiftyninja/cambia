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
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(".\\input.csv");

            try
            {
                // Read single line from file.
                var line = reader.ReadLine();

                // Split the line into individual strings
                var strings = line.Split(',');

                // Sort the strings
                Array.Sort(strings);

                // Create a new line by joining the sorted strings
                var newLine = string.Join(",", strings);

                
                Console.WriteLine(newLine);
            }
            catch
            {
                Console.WriteLine("File is empty");
            }
            finally
            {
                reader.Close();
            }

        }
    }
}
