using System;
using System.IO;

namespace pito
{
    class Program
    {
        static void Main(string[] args)
        {

            string readText = File.ReadAllText(@"../../../Greetings/1.txt");
            Console.WriteLine(readText);
        }
    }
}
