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
            return l.principle*(1+l.GetRate()*l.period/100)/(12*l.period);
        }else if(l is HomeLoan){
            return l.principle*(1+l.GetRate()*l.period/100)/(12*l.period);
        }else{
            throw new InvalidArgumentException();
        }
    }
}