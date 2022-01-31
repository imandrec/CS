using System;
using System.IO; // to import file 
using System.Collections.Generic; //to import file 
using System.Linq; //to read file 
using System.Windows.Forms; //Message Box
using System.Collections;
using static nuevo.Stock;

namespace nuevo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask file name
            string fileName;
            Console.WriteLine("Please enter the file name: ");
            fileName = Console.ReadLine();

            bool correctFile = true;
            while (correctFile == true)
            {
                if (fileName == "FB.csv")
                {
                    Readfile.openfile();
                    
                    break;
                }
                else
                {
                    MessageBox.Show("The file name is not correct");
                    break;
                }
            }
        }
    }

    public class Readfile
    {
        //Open file and create a List of stocks
        public static void openfile()
        {
            List<Stock> members = new List<Stock>();
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\demo\FB.csv"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace(" ", "");
                        string[] tmp = line.Split(',');
                        string date = tmp[0];
                        double open = Convert.ToDouble(tmp[1]);
                        double high = Convert.ToDouble(tmp[2]);
                        double low = Convert.ToDouble(tmp[3]);
                        double close = Convert.ToDouble(tmp[4]);
                        double adjclose = Convert.ToDouble(tmp[5]);
                        double volume = Convert.ToDouble(tmp[6]);
                        members.Add(new Stock(date, open, high, low, close, adjclose, volume));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            foreach (var item in members)
            {
                Console.WriteLine($"{item.Open}");
            }
            //Valores.MeanPrice();
        }
    }
    public class Valores
    {
        //Mean value
        //must return a double
        public static void MeanPrice()
        {

            //return mean;        }
        }

        //Highest value

        public static void HighestPrice()
        {

        }

        public static void LowestPrice()
        {

        }
    }
}

