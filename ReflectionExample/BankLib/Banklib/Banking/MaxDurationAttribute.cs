namespace BankLib;
[AttributeUsage(AttributeTargets.Method)]
public class MaxDurationAttribute(int value = 1,int uplimit = 10):Attribute{
    public int LowerLimit{get;} = value;
    public int Upperlimit{get; set;} = uplimit;
    

}