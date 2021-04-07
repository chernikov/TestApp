using System;
using System.IO;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllText("description.txt");
            Console.WriteLine(file);
        }
    }
}
