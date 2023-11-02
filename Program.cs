using IndexerExtensionTask.Models;
using System.Text.RegularExpressions;

namespace IndexerExtensionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 
            //Console.WriteLine("Enter The Number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{number} is prime: {number.IsPrime()}");
            //Console.WriteLine($"{number} is power of two: {number.IsPowOfTwo()}");



            Gallery gallery = new Gallery(10);
            gallery[0] = new Car { Name = "Bmw", Color = "Red", ProducedYear = 2023 };
            gallery[1] = new Car { Name = "Audi", Color = "Blue", ProducedYear = 2024 };

            Console.WriteLine("Car  index 0: " + gallery[0]);
            Console.WriteLine("Car  index 1: " + gallery[1]);

            Console.WriteLine("Car1 exists: " + gallery["Car1"]);
            Console.WriteLine("Car3 exists: " + gallery["Car3"]);
        }
    }
}