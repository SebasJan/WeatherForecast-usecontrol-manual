using System;
using System.Windows.Forms;

namespace WheaterForecast_UserControl_Manual.UserControls
{
    public partial class WeatherForecastUserControl : UserControl
    {
        private Forecast forecast;
        public Forecast Forecast
        {
            get { return forecast; }
        }
        public WeatherForecastUserControl(Forecast forecast)
        {
            InitializeComponent();
            this.forecast = forecast;                               
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
            this.highLabel.Text = forecast.HighTemperature.ToString() + "°C";
            this.lowLabel.Text = forecast.LowTemperature.ToString() + "°C";
        }

        public void RefreshForecast()
        {
            UpdateLabels();
        }
    }
}
