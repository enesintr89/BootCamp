﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class VehicleLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("The vehicle loan payment schedule has been calculated.");
        }
    }
}
