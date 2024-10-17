namespace BankLib;

public static class Loan
{
    public static decimal GetMonthlyInstallment(decimal principle, int duration, float rate)
	{
		double i = rate / 1200;
		int m = 12 * duration;
		double g = i / (1 - Math.Pow(1 + i, -m));
		return (decimal)g * principle;
	}
}