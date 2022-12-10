namespace HelloWorld
{
    partial class Program
    {
        public static class  Datetimehelper{

            public static bool isweekend (DateTimeOffset value ){

                return value.DayOfWeek == DayOfWeek.Sunday || value.DayOfWeek==DayOfWeek.Saturday ;


            }
            public static bool isweekday (DateTimeOffset value ){

                return !isweekend(value);


            }

        }
    }
}
