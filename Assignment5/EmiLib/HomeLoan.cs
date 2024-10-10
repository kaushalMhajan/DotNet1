namespace EmiCalc;

sealed class HomeLoan: Loan{

    public override float GetRate(){
        float rate = principle<=2000000?0.10F:0.11F;
        return rate; 
    }
}