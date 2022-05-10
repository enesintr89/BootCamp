using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class LoanApplicationManager
    {
        public void Apply(ILoanManager loanManager,ILoggerService loggerService)
        {
            loanManager.Calculate();
            loggerService.Log();

        }

        public void MakeLoanNotification(List<ILoanManager> loans)
        { foreach (var loan in loans)
            {
                loan.Calculate();
            }

        }

    }
}
