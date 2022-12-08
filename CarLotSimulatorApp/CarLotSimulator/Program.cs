using System;
using CarLotSimulator;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            // Custom Constructor
            Car car1 = new Car(1999, "Honda", "Civic", true);

            car1.EngineNoise("Vroom Vroom");
            car1.HonkNoise("Beep Beep");

            // Dot Notation
            Car car2 = new Car();
            car2.Year = 2005;
            car2.Make = "Ford";
            car2.Model = "Focus";
            car2.Isdriveable = false;

            car2.EngineNoise("pfttt");
            car2.HonkNoise("honk honk");



            // Object Initializer
            Car car3 = new Car()
            {
                Year = 2017,
                Make = "Toyota",
                Model = "Corola",
                Isdriveable = true,

            };

            car3.EngineNoise("hrhrh");
            car3.HonkNoise("peeeeep");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
