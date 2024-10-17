using System.Reflection;
using BankLib;
using RateFunc = System.Func<decimal, int, float>;


try
{
    //input 1st argument (principle);
    decimal principle = decimal.Parse(args[0]);

    //args[1] = 2nd argument input as ClASS TYPE for eg: HomeLoan
    //Type.GetType = takes the input of TYPE CLASS in the format
    //GetType(<namespace.Type,assembly>,bool);
    Type t = Type.GetType($"BankLib.{args[1]},BankLib", true);

    //Acivator.CreateInstance is use to create instance of class Type and returns the object type.
    //dynamic is use to prevent checking of the methods in the Object class.
    object obj = Activator.CreateInstance(t);

    //getting an information of method at runtime.
    MethodInfo m1 = t.GetMethod(args[2]);

    //creting an delegate as Func<decimal,int,float>.
    var rf = m1.CreateDelegate<RateFunc>(obj);

    //using Attribute created as Maxduration.
    var m2 = m1.GetCustomAttribute<MaxDurationAttribute>();

    int m = m2?.LowerLimit ?? 1;
    int m3 = m2?.Upperlimit ?? 20;

    for (int i = m; i <= m3; ++i)
    {
        //Common method of Class Type is called.
        // float b = (float)m1.Invoke(obj, [principle, i]);
        float b = rf(principle, i);
        decimal emi = Loan.GetMonthlyInstallment(principle, i, b);
        Console.WriteLine("{0, -8}{1, 20:0.00}", i, emi);
    }

}
catch (Exception ex)
{
    Console.WriteLine("Error : {0}", ex.Message);
}








