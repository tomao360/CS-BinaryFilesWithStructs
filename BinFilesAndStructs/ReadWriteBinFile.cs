using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinFilesAndStructs
{
    internal class ReadWriteBinFile
    {
        public ReadWriteBinFile() { }

        private string FileName = "D:\\Programming\\Zionet\\C#\\BinFilesAndStructs\\BinFilesAndStructs\\file.bin";

        public void WriteToBinFile(Car car)
        {
            using(FileStream stream = new FileStream(FileName, FileMode.Append))
            {
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(stream, car);
            }
        }

        public Car[] ReadFromBinFile()
        {
            using (FileStream stream = new FileStream(FileName, FileMode.Open))
            {
                BinaryFormatter binary = new BinaryFormatter();
                List<Car> carList = new List<Car>();
                while (stream.Position < stream.Length)
                {
                    Car car = (Car)binary.Deserialize(stream);
                    carList.Add(car);
                }
               
                return carList.ToArray();
            }
        }
    }
}
