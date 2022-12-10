using System;

namespace HelloWorld
{
    partial class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor=ConsoleColor.Blue   ;
            Console.BackgroundColor=ConsoleColor.White;
            Console.Clear();


             Console.WriteLine("###############################################################");

            DateTime dt1 = DateTime.Now;

            Console.WriteLine(dt1);
            dt1= new DateTime(2030,01,20,10,5,34);
            
            Console.WriteLine($" new ttime dt1  =  {dt1}  ");



            DateTimeOffset dt= DateTimeOffset.Now;

              Console.WriteLine($" new ttime dt  =  {dt}  ");



               DateTimeOffset dts= DateTimeOffset.UtcNow;

              Console.WriteLine($" TIME UTC dts  =  {dts}  ");

              TimeSpan ts=  new TimeSpan(1,30,15);

              dts  = dts.Add(ts);

              Console.WriteLine($" TIME UTC dts + TS   =  {dts}  ");
               Console.WriteLine("###############################################################");


 Console.WriteLine($" this day is weekend =  {Datetimehelper.isweekend(dts)}  ");
 Console.WriteLine($" this day is week day =  {Datetimehelper.isweekday(dts)}  ");
dts= dts.AddDays(2);

 Console.WriteLine($" this day +2  is weekend =  {Datetimehelper.isweekend(dts)}  ");
 Console.WriteLine($" this day + 2 is week day =  {Datetimehelper.isweekday(dts)}  ");
Console.WriteLine($" this day +2   =  {dts}  ");

dts= dts.AddDays(6);

 Console.WriteLine($" this day + 6 is weekend =  {dts.isweekend()}  ");
 Console.WriteLine($" this day + 6 is week day =  {dts.isweekday() }  ");
Console.WriteLine($" display this day of week  day + 6   =  {dts.DayOfWeek} \n ");
 Console.WriteLine("###############################################################");

Console.WriteLine($" good jobs rachis extention method work  ");
 Console.WriteLine("###############################################################");

 pizza proudct = new pizza();

 proudct.ADDproductA("eduction");
 proudct.ADDproductB("industry");
 proudct.ADDproductC("pizza",dts.isweekday());
proudct.AddToppings("pcb",100);
proudct.ToString();
Console.WriteLine(proudct);
 Console.WriteLine("###############################################################");
proudct.ADDproductA("test1")
       . ADDproductB("test2")
       .ADDproductC("test 3",false)
       .AddToppings("test 4",59) 
       .ToString();



Console.WriteLine(proudct);




            Console.ReadKey();
        }
    }



static class PizzaExtion {
public static pizza ADDproductA(this pizza value , string type) {

value.Content +=$"{type} productA x $17.50";
value.Totalprice +=17.5m ;

return value ;}
public static pizza ADDproductB(this pizza value , string type) {

value.Content +=$"\n{type} productB x $1270.534";
value.Totalprice +=1270.534m ;

return value ;}

public static pizza ADDproductC(this pizza value , string type, bool extra) {

value.Content +=$"\n{  (extra? "extra":" standar "    )  } produc CCC X ${(extra ? "5.60" : "-1.50")}";
value.Totalprice +=extra? 5.6m : -1.5m;

return value ;}

public static pizza AddToppings(this pizza value, string type, decimal price)
        {
            value.Content += $"\n{type} X ${price.ToString("#.##")}";
            value.Totalprice += price;
            return value;
        }


}

class pizza {
  
  public string Content  { get ; set;}
  public decimal Totalprice {get ; set;}

  public override string ToString() {
    return $" {Content}\n----------------------------\ntotal  price :${Totalprice.ToString("# ###.###")} ";


  }



}

}
