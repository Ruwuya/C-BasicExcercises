using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise29
    {
        // File size in bytes
        // Example: 1 KB = 1024 bytes, 1 MB = 1048576 bytes

        public static void FileSizeInBytes()
        {
            Console.WriteLine("File size in bytes: ");
            Console.Write("Input file size (e.g., 10 KB, 5 MB): ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            // Validate input
            if (parts.Length != 2)
            {
                // Invalid input
                Console.WriteLine("Invalid input format. Please use the format 'size unit' (e.g., '10 KB').");
                return;
            }
            double size;
            // Parse size
            if (!double.TryParse(parts[0], out size))
            {
                Console.WriteLine("Invalid size value.");
                return;
            }
            // Parse unit and convert to bytes
            string unit = parts[1].ToUpper();
            double bytes = unit switch
            {
                // Convert based on unit
                "B" => size,
                "KB" => size * 1024,
                "MB" => size * 1048576,
                "GB" => size * 1073741824,
                // Invalid unit
                _ => -1
            };
            // Output result
            if (bytes == -1)
            {
                // Invalid unit
                Console.WriteLine("Invalid unit. Please use B, KB, MB, or GB.");
            }
            else
            {
                // Valid input, display file size in bytes
                Console.WriteLine($"File size in bytes: {bytes}");
            }
        }
    }
}
