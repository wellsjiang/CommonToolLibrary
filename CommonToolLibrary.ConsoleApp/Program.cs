using System;

namespace CommonToolLibrary.ConsoleApp
{
    using System.Threading.Tasks;
    using CommonToolLibrary.Extension.Converter;

    class Program
    {
        static void Main(string[] args)
        {
            //AsyncMethod();
            Console.WriteLine("Hello World!".ToBase64());
            Console.ReadKey();
        }


        static async void AsyncMethod()
        {
            Console.WriteLine("Async Begin");
            var result = await MyMethod();
            Console.WriteLine("Async End");
        }

        static async Task<int> MyMethod()
        {
            var ss = "21325465756";
            for (var index = 0; index < 10000000; index++)
            {
                ss.ToInt();
            }
            return 0;
        }
    }
}