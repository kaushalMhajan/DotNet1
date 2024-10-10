using EmiCalc;

try{
	Loan pl = Loaner.PersonalLoanScheme(220100,5);
   	Console.WriteLine("your PersonalLoan emi is : {0:0.00} ",Loaner.GetEmI(pl));

   	Loan hl = Loaner.HomeLoanScheme(220100,5);
   	Console.WriteLine("your HomeLoan emi is : {0:0.00} ",Loaner.GetEmI(hl));
}
catch(Exception ex){
	Console.WriteLine(ex.Message);
}
