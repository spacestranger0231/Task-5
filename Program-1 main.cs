using System;
using System.IO;

namespace таск_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\c#\таск 5\таск 5\Text.txt";
            try
            {
                StreamReader f = new StreamReader(path);
                Strings v = new Strings();
                v.input(f);
                v.output();
                v.change();
                Console.WriteLine("\n");
                v.output();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
