using MetTours;
using System.Reflection;


try
{
    int days = int.Parse(args[2]);
    int noPersons = int.Parse(args[3]);
    Type classtype = Type.GetType($"MetTours.{args[0]},MetTour", true);

    object obj = Activator.CreateInstance(classtype);

    MethodInfo m = classtype.GetMethod(args[1]);

    Console.WriteLine("Your Total Rate is : {0}", m.Invoke(obj, [days, noPersons]));

    var ltax = m.GetCustomAttribute<LuxuryTax>();
    int tax = ltax?.Tax ?? 8;
    Console.WriteLine("Total Tax applied is : {0}",((double)m.Invoke(obj,[days,noPersons])*tax/100));
}
catch (Exception ex)
{
    Console.WriteLine("Error : {0}", ex.Message);
}
