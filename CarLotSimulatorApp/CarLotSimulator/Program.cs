using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.Win32.SafeHandles;

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
            Car a = new Car();
            a.Make = "Volvo";
            a.Year = 2015;
            a.Model = "xc90";
            a.IsDriveable = true;
            a.MakeEngineNoise("vroom");
            a.MakeHonkNoise("honk");




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car b = new Car("Mercedes", "E350", 2012, true);
            b.MakeHonkNoise("Beep");
            b.MakeEngineNoise("Brrr");
            Car c = new Car()
            {
                Make = "Toyota",
                Year = 2005,
                Model = "Camry",
                IsDriveable = false,
            };
            c.MakeHonkNoise("Deet");
            c.MakeEngineNoise("Woosh");


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Carlot d = new Carlot();
            d.aListOfCars.Add(a);
            d.aListOfCars.Add(b);
            d.aListOfCars.Add(c);

            foreach (var cars in d.aListOfCars)
            {
                Console.WriteLine($"this {cars.Make} {cars.Model} is made in {cars.Year}" );
            }
        }
    }
}