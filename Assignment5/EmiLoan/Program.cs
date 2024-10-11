using EmiCalc;

try{



Loan jack = Loaner.PersonalLoanScheme(220100,10);
Loan tushar = Loaner.PersonalLoanScheme(250100,5);

Loan jill = Loaner.HomeLoanScheme(230100,15);
Loan rocky = Loaner.HomeLoanScheme(240100,25);


Console.WriteLine("Jack PersonalLoan emi is : {0:0.00} ",Loaner.GetEmI(jack));
Console.WriteLine("Jack personal Loan with tax : {0:0.00} ",Loaner.GetTaxedEmi(jack));

Console.WriteLine("=======================================");

Console.WriteLine("Tushar PersonalLoan emi is : {0:0.00} ",Loaner.GetEmI(tushar));
Console.WriteLine("Tushar personal Loan with tax : {0:0.00} ",Loaner.GetTaxedEmi(tushar));

Console.WriteLine("=======================================");


Console.WriteLine("Jill Home Loan emi is : {0:0.00} ",Loaner.GetEmI(jill));
Console.WriteLine("Jill Home Loan with discount : {0:0.00} ",Loaner.GetDiscountedEmi(jill));

Console.WriteLine("=======================================");


Console.WriteLine("Rocky Home Loan emi is : {0:0.00} ",Loaner.GetEmI(rocky));
Console.WriteLine("Rocky Home Loan with discount : {0:0.00} ",Loaner.GetDiscountedEmi(rocky));

Console.WriteLine("=======================================");


Console.WriteLine("total taxed applied is : {0:0.00} ",GetTotalTax(jack,tushar));
Console.WriteLine("total Discount Given : {0:0.00} ",GetTotalDiscount(jill,rocky));




}catch(Exception ex){
    Console.WriteLine("Error : {0}",ex.Message);
}



double GetTotalDiscount(params Loan[] hl){
    double totaldiscount = 0;
    foreach (Loan discount in hl)
    {
        totaldiscount = totaldiscount + ((Loaner.GetEmI(discount)-Loaner.GetDiscountedEmi(discount)));
    }
    return totaldiscount;  
}

double GetTotalTax(params Loan[] hl){
    double totalTax = 0;
    foreach (Loan discount in hl)
    {
        totalTax = totalTax + ((Loaner.GetTaxedEmi(discount)-Loaner.GetEmI(discount)));
    }
    return totalTax;  
}


 
