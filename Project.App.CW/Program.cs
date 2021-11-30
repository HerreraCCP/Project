using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.App.CW
{
    class Program
    {
        static async Task Main(string[] args)
        {

            int [] intList = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IList<String> mixList = new List<string> { "Rodrigo", "1", "2", "3", "4"};

            EvenRepository evenRepository = new EvenRepository();

            var result = await evenRepository.GetAllByEvenNumber(intList);
            var result2 = await evenRepository.GetAllByEvenString(mixList);

            if (result.Length != 0) Console.WriteLine($"the first result is {result} and the second {result2}.");
            else Console.WriteLine($"the first result is empty and the second {result2}.");

            Console.ReadKey();
        }
    }
}
