
using OOP3;


ILoanManager homeLoanManager = new HomeLoanManager();

ILoanManager vehicleLoanManager = new VehicleLoanManager();


ILoanManager consumerLoanManager= new ConsumerLoanManager();

ILoggerService dataBaseLoggerService = new DatabaseLoggerService();

ILoggerService fileLoggerService = new FileLoggerService();

LoanApplicationManager loanApplicationManager = new LoanApplicationManager();

loanApplicationManager.Apply(homeLoanManager, dataBaseLoggerService);

List<ILoanManager> loans = new List<ILoanManager>() {consumerLoanManager,vehicleLoanManager };

//loanApplicationManager.MakeLoanNotification(loans);


