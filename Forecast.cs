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
        public double HighTemperature { get; set; }
        public double LowTemperature { get; set; }

        public Forecast(DateTime date, string location, double highTemperature, double lowTemperature)
        {
            Date = date;
            Location = location;
            HighTemperature = highTemperature;
            LowTemperature = lowTemperature;
        }
    }
}
