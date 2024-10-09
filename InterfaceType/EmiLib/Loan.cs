namespace EmiCalc;

public abstract class Loan
{
    public int principle{get; internal set;}
    public float period{get; internal set;}

    public abstract float GetRate();
}
