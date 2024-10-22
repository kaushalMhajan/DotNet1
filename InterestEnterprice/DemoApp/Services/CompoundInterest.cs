namespace DemoApp.Services;

public class CompoundInterest: IInterest{
    double compundinterest = 0;
    public double Interest(int principle,int period,int rate){
        compundinterest = principle*Math.Pow(1+period/rate,period);
        return compundinterest;
    }
}