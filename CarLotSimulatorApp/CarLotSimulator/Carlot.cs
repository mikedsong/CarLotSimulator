using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

namespace CarLotSimulator
{
    public class Carlot
    {
        public Carlot()
        {
            
        }

        public List<Car> aListOfCars
        {
            get; set;
        } = new List<Car>();
    }
}
