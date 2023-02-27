using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WheaterForecast_UserControl_Manual.UserControls;

namespace WheaterForecast_UserControl_Manual
{
    public partial class Form1 : Form
    {
        private string[] locations;
        public Form1()
        {
            InitializeComponent();
            // set the layout panel to be scrollable
            this.forecastFlowLayoutPanel.AutoScroll = true;
            this.locations = new string[] { "London", "Paris", "New York", "Tokyo", "Moscow", "Berlin", "Rome", "Madrid", "Barcelona", "Bucharest", "Warsaw", "Vienna", "Budapest", "Prague", "Brussels", "Amsterdam", "Stockholm", "Oslo", "Helsinki", "Dublin", "Copenhagen", "Athens", "Lisbon", "Reykjavik", "Luxembourg", "Zurich", "Geneva", "Ljubljana", "Bratislava", "Valletta", "Vaduz", "Monaco", "Andorra la Vella", "San Marino", "Vatican City" };
        }

        private void addNewForecastButton_Click(object sender, EventArgs e)
        {
            // create a new Forecast object
            Forecast forecast = GenerateNewForecast();

            // create a new WeatherForecastUserControl object
            // pass the forecast as an argument to the constructor of the UC
            WeatherForecastUserControl weatherForecastUserControl = new WeatherForecastUserControl(forecast);

            // add the new UC to the panel
            this.forecastFlowLayoutPanel.Controls.Add(weatherForecastUserControl);
        }

        private Forecast GenerateNewForecast()
        {
            // create a random forecast
            Random random = new Random();
            double high = random.Next(0, 40);
            double low = random.Next(0, 40);
            DateTime date = DateTime.Now;
            string location = this.locations[random.Next(0, locations.Length)];
            Forecast forecast = new Forecast(date, location, high, low);
            return forecast;
        }

        private void updateForecastButton_Click(object sender, EventArgs e)
        {
            foreach (WeatherForecastUserControl weatherForecastUserControl in this.forecastFlowLayoutPanel.Controls)
            {
                // get the forecast from the UC
                Forecast forecast = weatherForecastUserControl.Forecast;

                Random random = new Random();

                // update the forecast 
                forecast.HighTemperature = random.Next(0, 40);
                forecast.LowTemperature = random.Next(0, 40);
                forecast.Date = DateTime.Now;

                weatherForecastUserControl.RefreshForecast();
            }
        }
    }
}
