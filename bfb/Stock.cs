using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class Stock
    {
        public string Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Adjclose { get; set; }
        public double Volume { get; set; }
        public Stock(string date, double open, double high, double low, double close, double adjclose, double volume)
        {
            Date = date;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Adjclose = adjclose;
            Volume = volume;
        }
    }
    
}
