using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Check if the correct number of arguments is provided
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: Program.exe inputFile outputFile");
            return;
        }

        // Get the input and output file paths from command-line arguments
        string inputFile = args[0];
        string outputFile = args[1];

        try
        {
            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                string line;
                int lineNumber = 1;

                // Read each line from the input file, add line numbers, and write to the output file
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine($"{lineNumber}: {line}");
                    lineNumber++;
                }
            }

            Console.WriteLine($"File '{inputFile}' has been processed and saved as '{outputFile}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
