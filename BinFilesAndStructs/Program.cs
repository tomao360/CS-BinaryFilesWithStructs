using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinFilesAndStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadWriteBinFile readWriteBinFile = new ReadWriteBinFile();

            for (int i = 1; i <= 5; i++)
            {
                Car car = new Car();
                car.ID = i;
                car.Name = $"Car {i}";
                car.Description = $"Description {i}";
                car.KM = 100 * i;
                readWriteBinFile.WriteToBinFile(car);
            }

            Car[] cars = readWriteBinFile.ReadFromBinFile();
            foreach (Car car in cars)
            {
                Console.WriteLine($"Car ID: {car.ID.ToString()}, Car Name: {car.Name}, Car Description {car.Description}, Car KN: {car.KM.ToString()}");
            }

            Console.ReadLine();
        }
    }
}
