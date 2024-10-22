using DemoApp.Services;

namespace DemoApp.Endpoints;

public class Greetings{
    public static async Task Welcome(HttpContext context){
        await context.Response.WriteAsync($"""
                <html>
                    <head>
                        <title> DemoApp </title>
                    </head>
                    <body>
                        <b> Name </b>
                        <form method="POST" action="Interest">
                            <input type="text" name="principle"/>
                            <input type="text" name="period"/>
                            <input type="text" name="rate"/>
                            <input type="submit" value="Get Interest"/>
                        </form>
                    </body>
                </html>
                """);
    } 
    public static async Task Interest(HttpContext context,IInterest interest){
        int principle = int.Parse(context.Request.Form["principle"]);
        int rate = int.Parse(context.Request.Form["rate"]);
        int period = int.Parse(context.Request.Form["period"]);


        double SimpleInterest = interest.Interest(principle,period,rate);
        await context.Response.WriteAsync($"""
                <html>
                    <head>
                        <title> DemoApp </title>
                    </head>
                    <body>
                        <b> Calculated Simple Interest is :  </b>
                        <b> {SimpleInterest}</b>
                    </body>
                </html>
                """);
    } 
}