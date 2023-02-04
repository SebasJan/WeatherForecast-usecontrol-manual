using System;
using System.Windows.Forms;

namespace WheaterForecast_UserControl_Manual.UserControls
{
    public partial class WeatherForecastUserControl : UserControl
    {
        public Forecast forecast;
        public WeatherForecastUserControl(Forecast forecast)
        {
            this.forecast = forecast;
            InitializeComponent();                      
        }

        private void WeatherForecastUserControl_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            // set the values of the labels
            this.dateLabel.Text = forecast.Date.ToString("dd/MM/yyyy HH:mm:ss");
            this.locationLabel.Text = forecast.Location;
            this.highLabel.Text = forecast.High.ToString() + "°C";
            this.lowLabel.Text = forecast.Low.ToString() + "°C";
        }

        public void UpdateForecast(Forecast forecast)
        {
            this.forecast = forecast;
            UpdateLabels();
        }
    }
}
