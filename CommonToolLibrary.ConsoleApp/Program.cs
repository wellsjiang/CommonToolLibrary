using System;

namespace CommonToolLibrary.ConsoleApp
{
    using System.Threading.Tasks;

    using CommonToolLibrary.Common.Model;
    using CommonToolLibrary.Extension.Converter;
    using CommonToolLibrary.Extension.Log;

    class Program
    {
        static void Main(string[] args)
        {
            //AsyncMethod();
            LogService.Instance.Log(new LogRecordEntity(),true);
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