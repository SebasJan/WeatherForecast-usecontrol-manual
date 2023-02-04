using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheaterForecast_UserControl_Manual
{
    public class Forecast
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public double High { get; set; }
        public double Low { get; set; }

        public Forecast(DateTime date, string location, double high, double low)
        {
            Date = date;
            Location = location;
            High = high;
            Low = low;
        }
    }
}
