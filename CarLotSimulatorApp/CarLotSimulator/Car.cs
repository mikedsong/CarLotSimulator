using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

namespace CarLotSimulator
{

    public class Car
    {

        public Car()
        {

        }


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(String enNoise)
        {
            EngineNoise = enNoise;
            Console.WriteLine($"This {Make} {Model} has an engine noise of {enNoise}");
        }

        public void MakeHonkNoise(String honNoise)
        {
            HonkNoise = honNoise;
            Console.WriteLine($"This {Make} {Model} has an engine noise of {honNoise}");
        }

        public Car(String Ma, String Mo, int y, bool isD)
        {
            Make = Ma;
            Model = Mo;
            Year = y;
            IsDriveable = isD;

        }


    }
}