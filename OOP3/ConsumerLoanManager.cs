using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ConsumerLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("The consumer loan payment schedule has been calculated.");
        }
    }
}
