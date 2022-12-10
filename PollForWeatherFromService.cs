using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WhatsTheWeather.Properties;

namespace WhatsTheWeather
{
    public class PollForWeatherFromService
    {
        private HttpClient _client = new HttpClient();

        public PollForWeatherFromService() { }

        public async Task<WeatherBitData?> GetWeatherDataFromWeatherBit(string sServiceUrl)
        {
            try
            {
                var weatherData = await GetWeatherBitData(sServiceUrl);

                return weatherData;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), Resources.Exception, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public async Task<WeatherUnlockedData?> GetWeatherDataFromWeatherUnlocked(string sServiceUrl)
        {
            try
            {
                var weatherData = await GetWeatherUnlockedData(sServiceUrl);

                return weatherData;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), Resources.Exception, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public async Task<OpenWeatherData?> GetWeatherDataFromOpenWeather(string sServiceUrl)
        {
            var weatherData = new OpenWeatherData();
            try
            {
                weatherData = await GetOpenWeatherData(sServiceUrl);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), Resources.Exception, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return weatherData;
        }

        private async Task<OpenWeatherData?> GetOpenWeatherData(string query)
        {
            var weatherData = new OpenWeatherData();
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<OpenWeatherData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return weatherData;
        }

        private async Task<WeatherBitData?> GetWeatherBitData(string query)
        {
            var weatherData = new WeatherBitData();
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherBitData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return weatherData;
        }

        private async Task<WeatherUnlockedData?> GetWeatherUnlockedData(string query)
        {
            var weatherData =  new WeatherUnlockedData();
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherUnlockedData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return weatherData;
        }


        public async Task<WeatherAPIData?> GetWeatherDataFromWeatherAPI(string sServiceUrl)
        {
            var weatherData = new WeatherAPIData();
            try
            {
                weatherData = await GetWeatherApiData(sServiceUrl);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), Resources.Exception, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return weatherData;
        }


        private async Task<WeatherAPIData?> GetWeatherApiData(string query)
        {
            var weatherData = new WeatherAPIData();
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherAPIData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return weatherData;
        }

        public async Task<VisualCrossingData?> GetWeatherDataFromVisualCrossing(string sServiceUrl)
        {
            var weatherData = new VisualCrossingData();
            try
            {
                weatherData = await GetVisualCrossingData(sServiceUrl);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), Resources.Exception, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return weatherData;
        }


        private async Task<VisualCrossingData?> GetVisualCrossingData(string query)
        {
            var weatherData = new VisualCrossingData();
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<VisualCrossingData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return weatherData;
        }

        public async Task<AccuWeatherData?> GetAccuWeatherDataFromVisualCrossing(string sServiceUrl, string sLocationUrl)
        {
            var weatherData = new AccuWeatherData();
            try
            {
                //var locationData = new AccuWeatherLocationData();
                var locationData = await GetAccuWeatherLocation(sLocationUrl);

                if (locationData != null && locationData.Key.Any())
                {
                    sServiceUrl = sServiceUrl.Replace("{LOCATION_KEY}", locationData.Key);

                    weatherData = await GetAccuWeatherData(sServiceUrl);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), Resources.Exception, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return weatherData;
        }

        private async Task<AccuWeatherLocationDataClass?> GetAccuWeatherLocation(string query)
        {
            var locationData = new List<AccuWeatherLocationDataClass>();
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    locationData = JsonConvert.DeserializeObject<List<AccuWeatherLocationDataClass>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return locationData?[0];
        }

        private async Task<AccuWeatherData?> GetAccuWeatherData(string query)
        {
            var weatherData = new List<AccuWeatherData>();
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<List<AccuWeatherData>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return weatherData?[0];
        }

    }
}
