namespace MetTours;

public class EconomyTours
{
    public double getDaysRent(int days , int noPersons){
        double rate = 500*days*noPersons;

        if(days > 6 || noPersons >=4){
            return rate-(days*500);
        }

        return rate;
    } 
}
