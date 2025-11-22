using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

namespace CarLotSimulator
{

    public class Car
    {
 
        public Car()
        {
            Carlot.numberOfCars++;
        }


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string enNoise)
        {
            EngineNoise = enNoise;
            Console.WriteLine($"This {Make} {Model} has an engine noise of {enNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"This {Make} {Model} has an engine noise of {honkNoise}");
        }

        public Car(string ma, string mo, int y, bool isD)
        {
            Make = ma;
            Model = mo;
            Year = y;
            
            IsDriveable = isD;

            Carlot.numberOfCars++; 

        }


    }
}