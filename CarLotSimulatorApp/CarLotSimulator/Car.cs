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
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            Enginenoise = engineNoise;
            Honknoise = honkNoise;
            Isdriveable = isDriveable;

            public static string EngineNoise(string noise)
            {
                return "Vroom Vroom";
            }

            Publ
        }



    }
}
