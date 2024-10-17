namespace MetTours;

[LuxuryTax(10)]
public class PrimiumTours{

    public double getPerDayRentForCommon(int days , int noPersons){
        double rate = 1200*days*noPersons;

        if(days > 6 || noPersons >=4){
            return rate-(days*1200);
        }

        return rate;
    }
	public double getPerDayRentForSeniors(int days , int noPersons) => getPerDayRentForCommon(days,noPersons) - 100;
	public double getPerDayRentForWoman(int days , int noPersons) => getPerDayRentForCommon(days,noPersons) - 200;
}
