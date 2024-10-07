using System;
namespace Payroll
{
	class Employee
	{	
	    private int hours;
	    private float rate;
	}
	    public Employee(int h, float r)
		{	
			hours = h;
			rate = r;
		}
		public Employee() : this(0,0) {}

		public int DayWorked
		{
		   get
			{
				return hours / 8;
			}
		   set  {
				hours = 8 * value;
			}
		}

		public float DailyWages
		{	
			get {return 8*rate;}
			set {rate = value/8;}
		}
		public virtual double MonthlyIncome()
		{
			double amount = hours * rate;
			int ot = hours - 180;
			if(ot > 0)
				amount += 50 * ot;
			return amount;
		}
}
