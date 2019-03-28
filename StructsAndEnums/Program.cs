using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnums
{
    class Program
    {
        enum Month
        {
            January, February, March, April, May, June,
            July, August, September, October, November, December
        }

        struct MonthOfYear
        {
            public Month M;
            public Month Next()
            {
                this.M++;
                if (this.M > Month.December) this.M = Month.January;
                return this.M;
            }
        }
        struct Date
        {
            private int year;
            private Month month;
            private int day;

            public Date(int fourDigitYear, Month mm, int dd)
            {
                this.year = fourDigitYear;
                this.month = mm;
                this.day = dd - 1;
            }

            public override string ToString()
            {
                string data = $"{this.day + 1}-{this.month}-{this.year}";
                return data;
            }
        }







        static void doWork()
        {
            MonthOfYear calendarMonth;

            calendarMonth.M = Month.September;
            for (int count = 0; count < 20; count++)
            {
                Console.WriteLine(calendarMonth.M);
                calendarMonth.Next();
            }

            Date defaultDate = new Date();
            Console.WriteLine(defaultDate + "\n");
            Console.WriteLine(defaultDate.ToString() + "\n");

            Date weddingAnniversary = new Date(1986, Month.August, 16);
            Console.WriteLine(weddingAnniversary + "\n");

            Date DonnyvesParty = new Date(2015, Month.September, 30);
            Console.WriteLine(DonnyvesParty + "\n");
        }

        static void Main()
        {
            try
            {
                doWork();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
