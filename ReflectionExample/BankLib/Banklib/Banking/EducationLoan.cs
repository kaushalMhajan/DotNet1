namespace BankLib;

public class EducationLoan{
	[MaxDuration(4)]
    public float Common(decimal amount, int period)=> 6;

	[MaxDuration(3,10)]
	public float Scholar(decimal amount, int period)=> 4;
}