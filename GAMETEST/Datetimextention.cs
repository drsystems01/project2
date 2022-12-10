namespace HelloWorld
{
    
    
        public static class  DatetimeExtensions{

            public static bool isweekend (this DateTimeOffset value ){

                return value.DayOfWeek == DayOfWeek.Sunday || value.DayOfWeek==DayOfWeek.Saturday ;


            }
            public static bool isweekday (this DateTimeOffset value ){

                return !isweekend(value);


            }

        }
    
}
