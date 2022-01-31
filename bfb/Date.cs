/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class Date
    {
        public Date() { }// Default constructor (has no parameters)

        // Constructor with a string argument
        public Date(string fecha1, int fecha2, int day, int month, int year)//Name is a member of a class in the next line
        {
            this.Fecha1 = fecha1; //this is a keyword that references the current object
            this.Fecha2 = fecha2;
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
        //Define variables
        public string Fecha1; // must represent date: YYYY-MM-DD
        public int Fecha2; // must represent date: YYYYMMDD
        public int Day;
        public int Month;
        public int Year;

        //Method that converts a YYYY-MM-DD into YYYYMMDD
        static void Convert()
        {
            string x = "1990-10-22";
            string result = x.Replace("-", string.Empty);
            int estesi;
            estesi = int.Parse(result);
            Console.WriteLine(result);
            Console.WriteLine(estesi.GetType());
        }

        //Method that converts a YYYYMMDD into YYYY-MM-DD
        static void Convert2()
        {
            string x = "1990-10-22";
            string result = x.Replace("-", string.Empty);
            int estesi;
            estesi = int.Parse(result);
            Console.WriteLine(result);
            Console.WriteLine(estesi.GetType());
        }

        //Method that extracts only the Year from YYYYMMDD
        static void Extractyear()
        {
            string x = "19901022";
            Console.WriteLine(x.Substring(0, 4));
            Console.Read();
        }

        //Method that extracts only the Month from YYYYMMDD
        static void Extractmonth()
        {
            string x = "19901022";
            Console.WriteLine(x.Substring(4, 5));
            Console.Read();
        }

        //Method that extracts only the Day from YYYYMMDD
        static void Extractday()
        {
            string x = "19901022";
            Console.WriteLine(x.Substring(5, 6));
            Console.Read();
        }

    }
}*/