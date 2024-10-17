namespace MetTours;
[AttributeUsage(AttributeTargets.Class)]
public class LuxuryTax(int value = 8):Attribute{
    public int Tax{get; set;} = value;
}