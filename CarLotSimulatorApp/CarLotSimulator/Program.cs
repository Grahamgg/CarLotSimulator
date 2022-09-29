using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            
            
           
            var prius = new Car();
            prius.Year = 2006;
            prius.Make = "Toyota";
            prius.Model = "Prius";
            prius.EngineNoise = "zoom";
            prius.HonkNoise = "uwu";
            prius.IsDriveable = true;

            lot.Cars.Add(prius);

            var mazda = new Car()
            {
                Year = 2015,
                Make = "Mazda",
                Model = "CX-5",
                EngineNoise = "brrr",
                HonkNoise = "lol",
            IsDriveable = true,
            };

            lot.Cars.Add(mazda);

            var chevy = new Car(2006, "Chevy", "Impala", "reeeee" , "lmao", true);

            
            lot.Cars.Add(chevy);

            prius.MakeEngineNoise(prius.EngineNoise);
            mazda.MakeEngineNoise(mazda.EngineNoise);
            chevy.MakeEngineNoise(chevy.EngineNoise);

            prius.MakeHonkNoise(prius.HonkNoise);
            mazda.MakeEngineNoise(mazda.HonkNoise);
            chevy.MakeHonkNoise(chevy.HonkNoise);

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($" Year: {car.Year} Make: {car.Make} Model { car.Model}" );
            }

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
