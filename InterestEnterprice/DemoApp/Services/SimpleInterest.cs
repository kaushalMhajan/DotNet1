namespace DemoApp.Services;

public class SimpleInterest: IInterest{
    double simpleInterest = 0;
    public double Interest(int principle,int period,int rate){
        simpleInterest = (principle*period*rate)/100;
        return simpleInterest;
    }
}