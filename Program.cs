using System;

namespace DayOfWeekIfElse
{
    class Program
    {
        static void Main(string[] args)

        {
            if ((DateTime.Now.Date.ToShortDateString()) == "13/10/2021")
                Console.WriteLine($"Day is 13 / 10 / 2021, today is wednesday of October");

            else if ((DateTime.Now.Date.ToShortDateString()) == "14/10/2021")
                Console.WriteLine($"Day is 14 / 10 / 2021, today is Thursday of October");

            else if ((DateTime.Now.Date.ToShortDateString()) == "15/10/2021")
                Console.WriteLine($"Day is 15 / 10 / 2021, today is fryday of October");

            else if ((DateTime.Now.Date.ToShortDateString()) == "16/10/2021")
                Console.WriteLine($"Day is 16 / 10 / 2021, today is Saturday of October");

            else if ((DateTime.Now.Date.ToShortDateString()) == "17/10/2021")
                Console.WriteLine($"Day is 17 / 10 / 2021, today is Sunday of October");

            else if ((DateTime.Now.Date.ToShortDateString()) == "18/10/2021")
                Console.WriteLine($"Day is 1810 / 2021, today is Monday of October");

            if ((DateTime.Now.Date.ToShortDateString()) == "19/10/2021")
                Console.WriteLine($"Day is 19 / 10 / 2021, today is Tuesday of October");


        }
    }
}

