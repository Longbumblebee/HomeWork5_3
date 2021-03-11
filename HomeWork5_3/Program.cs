using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HomeWork5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumbers = Console.ReadLine();
            var inputsArray = randomNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var byteArray = new byte[inputsArray.Length];
            for (int i = 0; i < inputsArray.Length; i++)
            {
                byteArray[i] = byte.Parse(inputsArray[i]);
            }
            File.WriteAllBytes("DZ5.3.bin@", byteArray);
        }
    }
}