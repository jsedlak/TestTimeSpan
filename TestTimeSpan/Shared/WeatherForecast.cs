using System;
using System.Collections.Generic;
using System.Text;

namespace TestTimeSpan.Shared
{
    public class WeatherForecast
    {
        public TimeSpan ForecastLength { get; set; } = TimeSpan.FromMinutes(60);

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
