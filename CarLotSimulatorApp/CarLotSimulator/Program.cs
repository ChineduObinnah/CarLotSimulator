using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
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

            var mustang = new Car();
            mustang.Make = "Ford";
            mustang.Model = "Mustang";
            mustang.Year = 2020;
            mustang.EngineNoise = "GRRRRR";
            mustang.HonkNoise = "Honk Honk";
            mustang.IsDriveable = true;

            carLot.ParkingLot.Add(mustang);

            var honda = new Car()
            {
                Make = "Honda",
                Model = "fit",
                Year = 2020,
                EngineNoise = "Rumble",
                HonkNoise = "Beep",
                IsDriveable = true

            };
            carLot.ParkingLot.Add(honda);
            var corolla = new Car()
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2020,
                EngineNoise = "Rumble",
                HonkNoise = "Beep",
                IsDriveable = false

            };
            carLot.ParkingLot.Add(corolla);
            carLot.CheckCars();
        }

        //*************BONUS X 2*************//
         
        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console


    }
}
