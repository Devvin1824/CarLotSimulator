using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {

        }

        
        public Car(int year, string make, string model, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            Isdriveable = isDriveable;
        }
        
        public void EngineNoise(string noise)
        {
            Console.WriteLine(noise);
        }

        public void HonkNoise(string noise2)
        {
            Console.WriteLine(noise2);
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Enginenoise { get; set; }
        public string Model { get; set; }

        public string Honknoise { get; set; }
        public bool Isdriveable { get; set; }





    }
}
