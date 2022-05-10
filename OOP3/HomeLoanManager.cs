using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class HomeLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("The home loan payment schedule has been calculated.");
        }
    }
}
