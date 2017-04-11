using System;

namespace CommonToolLibrary.ConsoleApp
{
    using CommonToolLibrary.Extension.Converter;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".ToBase64());
            Console.ReadKey();
        }
    }
}