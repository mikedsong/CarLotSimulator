using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

namespace CarLotSimulator
{
    public class Carlot
    {
        public static int numberOfCars;

        public List<Car> ParkingLot { get; set; } = new List<Car>();
    }
    
}
