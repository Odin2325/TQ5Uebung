using System.Reflection;

namespace IODateien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///
            /// </summary>
            string input = "";
            do
            {
                Console.WriteLine("Enter 'W' to write to an existing file, 'R' to read a file and 'Q' to end:");
                input = Console.ReadLine().ToLower();
                if (input == "w")
                    WriteFile();
                else if (input == "r")
                    ReadFile();
                else if (input != "q")
                    Console.WriteLine("Invalid input, try again");
            } while (input != "q");
            Console.WriteLine("Programm execution aborted.");
            Console.ReadLine();
        }

        static void WriteFile()
        {
            string validPath = GetValidFilepath();
            Console.WriteLine("Enter the text you want to append:");
            string text = Console.ReadLine();
            File.AppendAllText(validPath, text);
        }
        static void ReadFile()
        {
            GetValidFilepath();
            Console.WriteLine("read file");
        }

        static string GetValidFilepath()
        {
            string enteredPath = "";
            try
            {
                Console.WriteLine("Enter the path of the file you want to edit:");
                do
                {
                    enteredPath = Console.ReadLine();
                } while (!File.Exists(enteredPath));

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No valid path was entered.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File doesn't exist.");
            }
            return enteredPath;
        }
    }
}
