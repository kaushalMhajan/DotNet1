using System.Data;
using Microsoft.Data.SqlClient;

string customername = args[0];
int productno = int.Parse(args[1]);
int Quantity = int.Parse(args[2]);

using var connection = new SqlConnection("Data Source=iitdac.met.edu;Database=Shop1;User Id=dac1;Password=Dac1@1234;Trust Server Certificate = True");

connection.Open();

using var command = connection.CreateCommand();
command.CommandText = "PlaceOrder";
command.CommandType = CommandType.StoredProcedure;

command.Parameters.AddWithValue("@Customer",customername);
command.Parameters.AddWithValue("@Product",productno);
command.Parameters.AddWithValue("@Quantity",Quantity);
var orderid = command.Parameters.Add("@OrderId",SqlDbType.Int);
orderid.Direction = ParameterDirection.Output;


try
{
    command.ExecuteNonQuery();
    Console.WriteLine("Order Placed Successfully order no is : {0}",orderid.Value);
}
catch (Exception ex)
{
    Console.WriteLine("Order Failed : {0}",ex.Message);
}






