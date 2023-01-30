// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace Ahmad_Make
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'start' to begin writing in Captain's journal.");
            string input = Console.ReadLine();

            if (input == "start")
            {
                Console.WriteLine("Enter 'stop' to end writing in Captain's journal.");
                string content = "";

                while (input != "stop")
                {
                    input = Console.ReadLine();
                    if (input != "stop")
                    {
                        content += input + "\n";
                    }
                }

                string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                File.WriteAllText(fileName, "Captain's log\nStardate " + DateTime.Now.ToString("yyyy-MM-dd") + "\n" + content);
                Console.WriteLine("Journal entry saved as " + fileName);
            }
        }
    }
}

