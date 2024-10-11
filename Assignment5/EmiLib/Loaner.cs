namespace EmiCalc;

public static class Loaner{

    public static Loan PersonalLoanScheme(int pr,float p){
        var sc = new PersonalLoan();
        sc.principle = pr;
        sc.period = p;
        return sc;
    } 

    public static Loan HomeLoanScheme(int pr,float p){
        var sc = new HomeLoan();
        sc.principle = pr;
        sc.period = p;
        return sc;
    } 

    public static double GetEmI(Loan l){
        if(l is PersonalLoan){
            double  d = l.principle*(1+l.GetRate()*l.period/100)/(12*l.period);
            return d;
        }else if(l is HomeLoan){
            double d = l.principle*(1+l.GetRate()*l.period/100)/(12*l.period);
            return d;
        }else{
            throw new ApplicationException();
        }
    }

    public static double GetDiscountedEmi(Loan hl){
        if(hl is HomeLoan){
            IDisscountable h = hl as IDisscountable;

            double d = h.GetDiscount(); 
            return GetEmI(hl)-(GetEmI(hl)* d);
        }
        return 0;
    }

    public static double GetTaxedEmi(Loan hl){
        if(hl is PersonalLoan){
            ITaxable h = hl as ITaxable;

            double d = h.GetTax(); 
            return GetEmI(hl)+(GetEmI(hl)* d);
        }
        return 0;
    }   
}
