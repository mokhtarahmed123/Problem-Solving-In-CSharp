using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Employees
    {
        public int Id { get; set; }
        public int securitlevel { get; set; }
        public double salary { get; set; }

     
        class Hiring
        {
            public int day { get; set; }
            public int month { get; set; }
            public int year { get; set; }
            public Hiring()
            {
                day = 1;
                month = 1;
                year = 2005;
            }
            public Hiring(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;

            }
        }
        enum Gender
        {
            Male,
            Female,
        }
    }
}
