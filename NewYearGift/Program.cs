using System;

namespace NewYearGift
{
    class Program
    {
        static void Main(string[] args)
        {
           Services services = new Services();
           services.readFromFile();
           services.createArrayOfSweetness();
           services.printUnsortedArray();
           Console.WriteLine(services.countTotalWeight());
           services.sortArray();
           services.printSortedArray();
           Console.WriteLine(services.countTotalPrice());
           services.writeResultIntoFile();
        }
    }
}