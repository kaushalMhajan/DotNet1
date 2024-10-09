namespace EmiCalc;

sealed class PersonalLoan : Loan{

    public override float GetRate(){
        float rate = principle<=500000?0.15F:0.16F;
        return rate; 
    }
} 