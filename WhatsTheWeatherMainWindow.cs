//using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WhatsTheWeather.Properties;

namespace WhatsTheWeather
{
    public partial class WhatsTheWeatherMainWindow : Form
    {
        public static AppSettings ServiceSettings = new AppSettings();
        private string? postalCode = string.Empty;
        private delegate void InvokeToLastTemperatureTextboxDelegate(string sText);

        public WhatsTheWeatherMainWindow()
        {
            InitializeComponent();
        }

        private void WhatsTheWeatherMainWindow_Load(object sender, EventArgs e)
        {
            LoadAppSettings();
            txtZipCode.Text = postalCode;
            LoadServiceComboBox();
        }

        private void LoadAppSettings()
        {
            ServiceSettings = new AppSettings();

            var key = ConfigData.GetConfigData("AccuWeatherApiKey");
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.AccuWeatherApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData("OpenWeatherApiKey");
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.OpenWeatherApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData("VisualCrossingApiKey");
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.VisualCrossingApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData("WeatherApiApiKey");
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.WeatherApiApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData("WeatherUnlockedAppId");
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.WeatherUnlockedAppId = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData("WeatherUnlockedAppKey");
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.WeatherUnlockedAppKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData("WeatherBitApiKey");
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.WeatherBitApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData("WeatherSelection");
            if (!string.IsNullOrEmpty(key))
            {
                switch(key)
                {
                    case "AccuWeather":
                    {
                        ServiceSettings.WeatherSelection = WeatherServiceFlags.AccuWeather;
                            break;
                    }
                    case "OpenWeather":
                    {
                        ServiceSettings.WeatherSelection = WeatherServiceFlags.OpenWeather;
                            break;
                    }
                    case "VisualCrossing":
                    {
                        ServiceSettings.WeatherSelection = WeatherServiceFlags.VisualCrossing;
                            break;
                    }
                    case "WeatherAPI":
                    {
                        ServiceSettings.WeatherSelection = WeatherServiceFlags.WeatherApi;
                            break;
                    }
                    case "WeatherUnlocked":
                    {
                        ServiceSettings.WeatherSelection = WeatherServiceFlags.WeatherUnlocked;
                            break;
                    }
                    case "WeatherBit":
                    {
                        ServiceSettings.WeatherSelection = WeatherServiceFlags.WeatherBit;
                        break;
                    }
                    default:
                        ServiceSettings.WeatherSelection = WeatherServiceFlags.None;
                        break;

                }
            }
            

            postalCode = ConfigData.GetConfigData("PostalCode");
        }

        private void SaveAppSettings()
        {
            ConfigData.SetConfigData("PostalCode", postalCode);
            ConfigData.SetConfigData("WeatherSelection", ServiceSettings.WeatherSelection.ToString());
            ConfigData.SetConfigData("AccuWeatherApiKey", "");
            ConfigData.SetConfigData("OpenWeatherApiKey", "");
            ConfigData.SetConfigData("VisualCrossingApiKey", "");
            ConfigData.SetConfigData("WeatherApiApiKey", "");
            ConfigData.SetConfigData("WeatherUnlockedAppId", "");
            ConfigData.SetConfigData("WeatherUnlockedAppKey", "");
            ConfigData.SetConfigData("WeatherBitApiKey", "");

            if (!string.IsNullOrEmpty(ServiceSettings.AccuWeatherApiKey))
            {
                ConfigData.SetConfigData("AccuWeatherApiKey",
                    ConfigData.EncryptString(ServiceSettings.AccuWeatherApiKey,
                        Properties.Resources.Pass));
            }

            if (!string.IsNullOrEmpty(ServiceSettings.OpenWeatherApiKey))
            {
                ConfigData.SetConfigData("OpenWeatherApiKey",
                    ConfigData.EncryptString(ServiceSettings.OpenWeatherApiKey,
                        Properties.Resources.Pass));
            }

            if (!string.IsNullOrEmpty(ServiceSettings.VisualCrossingApiKey))
            {
                ConfigData.SetConfigData("VisualCrossingApiKey",
                    ConfigData.EncryptString(ServiceSettings.VisualCrossingApiKey,
                        Properties.Resources.Pass));
            }

            if (!string.IsNullOrEmpty(ServiceSettings.WeatherApiApiKey))
            {
                ConfigData.SetConfigData("WeatherApiApiKey",
                    ConfigData.EncryptString(ServiceSettings.WeatherApiApiKey,
                        Properties.Resources.Pass));
            }

            if (!string.IsNullOrEmpty(ServiceSettings.WeatherUnlockedAppId) && !string.IsNullOrEmpty(ServiceSettings.WeatherUnlockedAppKey))
            {
                ConfigData.SetConfigData("WeatherUnlockedAppId",
                    ConfigData.EncryptString(ServiceSettings.WeatherUnlockedAppId,
                        Properties.Resources.Pass));

                ConfigData.SetConfigData("WeatherUnlockedAppKey",
                    ConfigData.EncryptString(ServiceSettings.WeatherUnlockedAppKey,
                        Properties.Resources.Pass));
            }

            if (!string.IsNullOrEmpty(ServiceSettings.WeatherBitApiKey))
            {
                ConfigData.SetConfigData("WeatherBitApiKey",
                    ConfigData.EncryptString(ServiceSettings.WeatherBitApiKey,
                        Properties.Resources.Pass));
            }
        }
        private void LoadServiceComboBox()
        {
            cbWeatherService.Items.Clear();
            var cbItem = new ComboboxItem
            {
                Text = "<None>",
                Value = WeatherServiceFlags.None
            };
            cbWeatherService.Items.Add(cbItem);
            cbWeatherService.SelectedItem = cbItem;

            if (!string.IsNullOrEmpty(ServiceSettings.AccuWeatherApiKey))
            {
                cbItem = new ComboboxItem
                {
                    Text = "AccuWeather",
                    Value = WeatherServiceFlags.AccuWeather
                };
                cbWeatherService.Items.Add(cbItem);
                if ((ServiceSettings.WeatherSelection & WeatherServiceFlags.AccuWeather) != 0)
                {
                    cbWeatherService.SelectedItem = cbItem;
                }
            }

            if (!string.IsNullOrEmpty(ServiceSettings.OpenWeatherApiKey))
            {
                cbItem = new ComboboxItem
                {
                    Text = "Open Weather",
                    Value = WeatherServiceFlags.OpenWeather
                };
                cbWeatherService.Items.Add(cbItem);
                if ((ServiceSettings.WeatherSelection & WeatherServiceFlags.OpenWeather) != 0)
                {
                    cbWeatherService.SelectedItem = cbItem;
                }
            }

            if (!string.IsNullOrEmpty(ServiceSettings.VisualCrossingApiKey))
            {
                cbItem = new ComboboxItem
                {
                    Text = "Visual Crossing",
                    Value = WeatherServiceFlags.VisualCrossing
                };
                cbWeatherService.Items.Add(cbItem);
                if ((ServiceSettings.WeatherSelection & WeatherServiceFlags.VisualCrossing) != 0)
                {
                    cbWeatherService.SelectedItem = cbItem;
                }
            }

            if (!string.IsNullOrEmpty(ServiceSettings.WeatherApiApiKey))
            {
                cbItem = new ComboboxItem
                {
                    Text = "Weather API",
                    Value = WeatherServiceFlags.WeatherApi
                };
                cbWeatherService.Items.Add(cbItem);
                if ((ServiceSettings.WeatherSelection & WeatherServiceFlags.WeatherApi) != 0)
                {
                    cbWeatherService.SelectedItem = cbItem;
                }
            }

            if (!string.IsNullOrEmpty(ServiceSettings.WeatherUnlockedAppId))
            {
                cbItem = new ComboboxItem
                {
                    Text = "Weather Unlocked",
                    Value = WeatherServiceFlags.WeatherUnlocked
                };
                cbWeatherService.Items.Add(cbItem);
                if ((ServiceSettings.WeatherSelection & WeatherServiceFlags.WeatherUnlocked) != 0)
                {
                    cbWeatherService.SelectedItem = cbItem;
                }
            }

            if (!string.IsNullOrEmpty(ServiceSettings.WeatherBitApiKey))
            {
                cbItem = new ComboboxItem
                {
                    Text = "WeatherBit.io",
                    Value = WeatherServiceFlags.WeatherBit
                };
                cbWeatherService.Items.Add(cbItem);
                if ((ServiceSettings.WeatherSelection & WeatherServiceFlags.WeatherBit) != 0)
                {
                    cbWeatherService.SelectedItem = cbItem;
                }
            }

        }

        private void btnWeatherProviders_Click(object sender, EventArgs e)
        {
            var weatherServiceWindow = new WeatherServicesWindow(ServiceSettings);

            if(weatherServiceWindow.ShowDialog() == DialogResult.OK )
            {
                ServiceSettings = weatherServiceWindow.WeatherServiceSettings;

                LoadServiceComboBox();

                SaveAppSettings();
            }
        }

        private async Task<bool> PollForWeather(bool bTestPoll)
        {
            try
            {
                var sWeatherUrl = "";
                var sLocationUrl = "";
 

                switch (ServiceSettings.WeatherSelection)
                {
                    case WeatherServiceFlags.AccuWeather:
                    {
                        sWeatherUrl = Resources.AccuWeatherAPI;
                        sWeatherUrl = sWeatherUrl.Replace("{API_KEY}", ServiceSettings.AccuWeatherApiKey);
                        //TODO: Need to pull the GeoCode API to get latitude and longitude
                        //sWeatherURL = sWeatherURL.Replace("{POSTAL_CODE}", postalCode);

                        sLocationUrl = Resources.AccuWeatherLocationAPI;
                        sLocationUrl = sLocationUrl.Replace("{API_KEY}", ServiceSettings.AccuWeatherApiKey);
                        sLocationUrl = sLocationUrl.Replace("{POSTAL_CODE}", postalCode);
                            break;
                    }
                    case WeatherServiceFlags.WeatherBit:
                    {
                        sWeatherUrl = Resources.WeatherBitAPI;
                        sWeatherUrl = sWeatherUrl.Replace("{API_KEY}", ServiceSettings.WeatherBitApiKey);
                        sWeatherUrl = sWeatherUrl.Replace("{POSTAL_CODE}", postalCode);
                        break;
                    }
                    case WeatherServiceFlags.OpenWeather:
                    {
                        sWeatherUrl = Resources.OpenWeatherAPI;
                        sWeatherUrl = sWeatherUrl.Replace("{API_KEY}", ServiceSettings.OpenWeatherApiKey);
                        sWeatherUrl = sWeatherUrl.Replace("{POSTAL_CODE}", postalCode);
                        break;
                    }
                    case WeatherServiceFlags.VisualCrossing:
                    {
                        sWeatherUrl = Resources.VisualCrossingAPI;
                        sWeatherUrl = sWeatherUrl.Replace("{API_KEY}", ServiceSettings.VisualCrossingApiKey);
                        sWeatherUrl = sWeatherUrl.Replace("{POSTAL_CODE}", postalCode);
                        break;
                    }
                    case WeatherServiceFlags.WeatherApi:
                    {
                        sWeatherUrl = Resources.WeatherAPI;
                        sWeatherUrl = sWeatherUrl.Replace("{API_KEY}", ServiceSettings.WeatherApiApiKey);
                        sWeatherUrl = sWeatherUrl.Replace("{POSTAL_CODE}", postalCode);
                        break;
                    }
                    case WeatherServiceFlags.WeatherUnlocked:
                    {
                        sWeatherUrl = Resources.WeatherUnlockedAPI;
                        sWeatherUrl = sWeatherUrl.Replace("{APP_ID}", ServiceSettings.WeatherUnlockedAppId);
                        sWeatherUrl = sWeatherUrl.Replace("{APP_KEY}", ServiceSettings.WeatherUnlockedAppKey);
                        sWeatherUrl = sWeatherUrl.Replace("{POSTAL_CODE}", postalCode);
                        break;
                    }
                    case WeatherServiceFlags.None:
                    default:
                        return false;

                }

                var pollForWeather = new PollForWeatherFromService();
                string sTemperature = "";
                if (ServiceSettings.WeatherSelection == WeatherServiceFlags.WeatherBit)
                {
                    //weatherBit = await pollForWeather.GetWeatherDataFromWeatherBit(sWeatherURL);
                    var weatherData = await pollForWeather.GetWeatherDataFromWeatherBit(sWeatherUrl);
                    if (weatherData == null)
                    {
                        InvokeToLastTemperatureTextbox("Error at " + DateTime.Now);
                        return false;
                    }
                    double temp = weatherData.data[0].temp;
                    temp = temp * 9 / 5;
                    temp += 32;
                    sTemperature = Convert.ToInt32(temp).ToString();

                }
                else if (ServiceSettings.WeatherSelection == WeatherServiceFlags.WeatherUnlocked)
                {
                    var weatherData = await pollForWeather.GetWeatherDataFromWeatherUnlocked(sWeatherUrl);
                    if (weatherData == null)
                    {
                        InvokeToLastTemperatureTextbox("Error at " + DateTime.Now);
                        return false;
                    }

                    sTemperature = weatherData.temp_f.ToString(CultureInfo.InvariantCulture);
                }
                else if (ServiceSettings.WeatherSelection == WeatherServiceFlags.OpenWeather)
                {
                    var weatherData = await pollForWeather.GetWeatherDataFromOpenWeather(sWeatherUrl);
                    if (weatherData == null)
                    {
                        InvokeToLastTemperatureTextbox("Error at " + DateTime.Now);
                        return false;
                    }

                    sTemperature = weatherData.main.temp.ToString(CultureInfo.InvariantCulture);
                }
                else if (ServiceSettings.WeatherSelection == WeatherServiceFlags.WeatherApi)
                {
                    var weatherData = await pollForWeather.GetWeatherDataFromWeatherAPI(sWeatherUrl);
                    if (weatherData == null)
                    {
                        InvokeToLastTemperatureTextbox("Error at " + DateTime.Now);
                        return false;
                    }

                    sTemperature = weatherData.current.temp_f.ToString(CultureInfo.InvariantCulture);
                }
                else if (ServiceSettings.WeatherSelection == WeatherServiceFlags.VisualCrossing)
                {
                    var weatherData = await pollForWeather.GetWeatherDataFromVisualCrossing(sWeatherUrl);
                    if (weatherData == null)
                    {
                        InvokeToLastTemperatureTextbox("Error at " + DateTime.Now);
                        return false;
                    }
                    sTemperature = weatherData.days[0].temp.ToString(CultureInfo.InvariantCulture);
                }
                else if (ServiceSettings.WeatherSelection == WeatherServiceFlags.AccuWeather)
                {
                    var weatherData = await pollForWeather.GetAccuWeatherDataFromVisualCrossing(sWeatherUrl, sLocationUrl);
                    if (weatherData == null)
                    {
                        InvokeToLastTemperatureTextbox("Error at " + DateTime.Now);
                        return false;
                    }
                    sTemperature = weatherData.Temperature.Imperial.Value.ToString();
                }
                else
                {
                    InvokeToLastTemperatureTextbox("Error at " + DateTime.Now);
                    return false;
                }
 
                var degree = (char)176;
                var sUpdate = sTemperature.ToString() + degree + " at " + DateTime.Now;
                InvokeToLastTemperatureTextbox(sUpdate);
            }
            catch (Exception exception)
            {
                if (bTestPoll)
                    MessageBox.Show(exception.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private async void btnTestWeatherService_Click(object sender, EventArgs e)
        {
            postalCode = txtZipCode.Text;

            ComboboxItem cbSelectedItem = new ComboboxItem();
            cbSelectedItem = (ComboboxItem)cbWeatherService.SelectedItem;
            if (cbSelectedItem != null && cbSelectedItem.Value != null)
            {
                ServiceSettings.WeatherSelection = (WeatherServiceFlags)cbSelectedItem.Value;

                var returned = await PollForWeather(true);
            }
        }

        private void btnStartPollForWeather_Click(object sender, EventArgs e)
        {
            postalCode = txtZipCode.Text;
            ComboboxItem cbSelectedItem = new ComboboxItem();
            cbSelectedItem = (ComboboxItem)cbWeatherService.SelectedItem;
            if (cbSelectedItem != null && cbSelectedItem.Value != null)
            {
                ServiceSettings.WeatherSelection = (WeatherServiceFlags)cbSelectedItem.Value;
                SaveAppSettings();
            }
        }

        private void InvokeToLastTemperatureTextbox(string sText)
        {
            if (txtLastTemperature.InvokeRequired)
            {
                this.Invoke(new InvokeToLastTemperatureTextboxDelegate(InvokeToLastTemperatureTextbox), sText);
                return;
            }

            txtLastTemperature.Text = sText;
        }

    }
    public class ComboboxItem
    {
        public string? Text { get; set; }
        public object? Value { get; set; }

        public override string? ToString()
        {
            return Text;
        }
    }
}
