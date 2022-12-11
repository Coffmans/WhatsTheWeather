//using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using WhatsTheWeather.Properties;
using static System.Net.Mime.MediaTypeNames;
using Timer = System.Timers.Timer;

namespace WhatsTheWeather
{
    public partial class WhatsTheWeatherMainWindow : Form
    {
        public static AppSettings ServiceSettings = new AppSettings();
        private delegate void InvokeToLastTemperatureTextboxDelegate(string sText);

        private delegate void InvokeToNotifyTrayIconDelegate(string sText);

        private Timer _timerForPollingOfWeather = default!;
        private bool _isPolling = false;

        // P/Invoke declarations
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool AppendMenu(IntPtr hMenu, int uFlags, int uIDNewItem, string lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InsertMenu(IntPtr hMenu, int uPosition, int uFlags, int uIDNewItem, string lpNewItem);

        public WhatsTheWeatherMainWindow()
        {
            InitializeComponent();
        }

        private void WhatsTheWeatherMainWindow_Load(object sender, EventArgs e)
        {
            LoadAppSettings();
            txtZipCode.Text = ServiceSettings.WeatherZipCode;
            LoadServiceComboBox();
        }

        private void LoadAppSettings()
        {
            ServiceSettings = new AppSettings();

            var key = ConfigData.GetConfigData(Resources.Settings_AccuWeatherApiKey);
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.AccuWeatherApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData(Resources.Settings_OpenWeatherApiKey);
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.OpenWeatherApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData(Resources.Settings_VisualCrossingApiKey);
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.VisualCrossingApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData(Resources.WeatherServicesWindow_VerifySettingChanges_WeatherApi);
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.WeatherApiApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData(Resources.Settings_WeatherUnlockedAppId);
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.WeatherUnlockedAppId = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData(Resources.Settings_WeatherUnlockedAppKey);
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.WeatherUnlockedAppKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData(Resources.Settings_WeatherBitApiKey);
            if (!string.IsNullOrEmpty(key))
                ServiceSettings.WeatherBitApiKey = ConfigData.DecryptString(key, Properties.Resources.Pass);

            key = ConfigData.GetConfigData(Resources.Settings_SelectedWeatherProvider);
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
            

            ServiceSettings.WeatherZipCode = ConfigData.GetConfigData(Resources.Settings_PostalCode);
            var hourlyTimer = ConfigData.GetConfigData(Resources.Settings_WeatherHourlyPollTimer);
            if (!string.IsNullOrEmpty(hourlyTimer))
            {
                if (hourlyTimer.All(char.IsDigit) )
                {
                    var timerValue = Int32.Parse(hourlyTimer);
                    ServiceSettings.WeatherHourlyPollTimer = (timerValue < 0 || timerValue > 24) ? 1 : timerValue;
                }
            }

            var showBalloon = ConfigData.GetConfigData(Resources.Settings_WeatherShowBalloon);
            if (showBalloon != null && showBalloon.Equals("true", StringComparison.InvariantCultureIgnoreCase))
            {
                ServiceSettings.WeatherShowBalloon = true;
            }
        }

        private void SaveAppSettings()
        {
            ConfigData.SetConfigData(Resources.Settings_SelectedWeatherProvider, ServiceSettings.WeatherSelection.ToString());

            if (!string.IsNullOrEmpty(ServiceSettings.AccuWeatherApiKey))
            {
                ConfigData.SetConfigData(Resources.Settings_AccuWeatherApiKey,
                    ConfigData.EncryptString(ServiceSettings.AccuWeatherApiKey,
                        Properties.Resources.Pass));
            }
            else
            {
                ConfigData.SetConfigData(Resources.Settings_AccuWeatherApiKey, string.Empty);
            }

            if (!string.IsNullOrEmpty(ServiceSettings.OpenWeatherApiKey))
            {
                ConfigData.SetConfigData(Resources.Settings_OpenWeatherApiKey,
                    ConfigData.EncryptString(ServiceSettings.OpenWeatherApiKey,
                        Properties.Resources.Pass));
            }
            else
            {
                ConfigData.SetConfigData(Resources.Settings_OpenWeatherApiKey, string.Empty);
            }

            if (!string.IsNullOrEmpty(ServiceSettings.VisualCrossingApiKey))
            {
                ConfigData.SetConfigData(Resources.Settings_VisualCrossingApiKey,
                    ConfigData.EncryptString(ServiceSettings.VisualCrossingApiKey,
                        Properties.Resources.Pass));
            }
            else
            {
                ConfigData.SetConfigData(Resources.Settings_VisualCrossingApiKey, string.Empty);
            }

            if (!string.IsNullOrEmpty(ServiceSettings.WeatherApiApiKey))
            {
                ConfigData.SetConfigData(Resources.Settings_WeatherApiApiKey,
                    ConfigData.EncryptString(ServiceSettings.WeatherApiApiKey,
                        Properties.Resources.Pass));
            }
            else
            {
                ConfigData.SetConfigData(Resources.Settings_WeatherApiApiKey, string.Empty);
            }

            if (!string.IsNullOrEmpty(ServiceSettings.WeatherUnlockedAppId) && !string.IsNullOrEmpty(ServiceSettings.WeatherUnlockedAppKey))
            {
                ConfigData.SetConfigData(Resources.Settings_WeatherUnlockedAppId,
                    ConfigData.EncryptString(ServiceSettings.WeatherUnlockedAppId,
                        Properties.Resources.Pass));

                ConfigData.SetConfigData(Resources.Settings_WeatherUnlockedAppKey,
                    ConfigData.EncryptString(ServiceSettings.WeatherUnlockedAppKey,
                        Properties.Resources.Pass));
            }
            else
            {
                ConfigData.SetConfigData(Resources.Settings_WeatherUnlockedAppId, string.Empty);
                ConfigData.SetConfigData(Resources.Settings_WeatherUnlockedAppKey, string.Empty);
            }

            if (!string.IsNullOrEmpty(ServiceSettings.WeatherBitApiKey))
            {
                ConfigData.SetConfigData(Resources.Settings_WeatherBitApiKey,
                    ConfigData.EncryptString(ServiceSettings.WeatherBitApiKey,
                        Properties.Resources.Pass));
            }
            else
            {
                ConfigData.SetConfigData(Resources.Settings_WeatherBitApiKey, string.Empty);
            }

            
            ConfigData.SetConfigData(Resources.Settings_PostalCode, ServiceSettings.WeatherZipCode);
            ConfigData.SetConfigData(Resources.Settings_WeatherHourlyPollTimer, ServiceSettings.WeatherHourlyPollTimer.ToString());
            ConfigData.SetConfigData(Resources.Settings_WeatherShowBalloon, ServiceSettings.WeatherShowBalloon.ToString());
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
                var sWeatherUrl = string.Empty;
                var sLocationUrl = string.Empty;
 

                switch (ServiceSettings.WeatherSelection)
                {
                    case WeatherServiceFlags.AccuWeather:
                    {
                        sWeatherUrl = Resources.AccuWeatherAPI;
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Postal_Code, ServiceSettings.AccuWeatherApiKey);
                        //TODO: Need to pull the GeoCode API to get latitude and longitude
                        //sWeatherURL = sWeatherURL.Replace("{POSTAL_CODE}", ServiceSettings.WeatherZipCode);

                        sLocationUrl = Resources.AccuWeatherLocationAPI;
                        sLocationUrl = sLocationUrl.Replace(Resources.Url_Api_Key, ServiceSettings.AccuWeatherApiKey);
                        sLocationUrl = sLocationUrl.Replace(Resources.Url_Postal_Code, ServiceSettings.WeatherZipCode);
                            break;
                    }
                    case WeatherServiceFlags.WeatherBit:
                    {
                        sWeatherUrl = Resources.WeatherBitAPI;
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Api_Key, ServiceSettings.WeatherBitApiKey);
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Postal_Code, ServiceSettings.WeatherZipCode);
                        break;
                    }
                    case WeatherServiceFlags.OpenWeather:
                    {
                        sWeatherUrl = Resources.OpenWeatherAPI;
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Api_Key, ServiceSettings.OpenWeatherApiKey);
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Postal_Code, ServiceSettings.WeatherZipCode);
                        break;
                    }
                    case WeatherServiceFlags.VisualCrossing:
                    {
                        sWeatherUrl = Resources.VisualCrossingAPI;
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Api_Key, ServiceSettings.VisualCrossingApiKey);
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Postal_Code, ServiceSettings.WeatherZipCode);
                        break;
                    }
                    case WeatherServiceFlags.WeatherApi:
                    {
                        sWeatherUrl = Resources.WeatherAPI;
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Api_Key, ServiceSettings.WeatherApiApiKey);
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Postal_Code, ServiceSettings.WeatherZipCode);
                        break;
                    }
                    case WeatherServiceFlags.WeatherUnlocked:
                    {
                        sWeatherUrl = Resources.WeatherUnlockedAPI;
                        sWeatherUrl = sWeatherUrl.Replace("{APP_ID}", ServiceSettings.WeatherUnlockedAppId);
                        sWeatherUrl = sWeatherUrl.Replace("{APP_KEY}", ServiceSettings.WeatherUnlockedAppKey);
                        sWeatherUrl = sWeatherUrl.Replace(Resources.Url_Postal_Code, ServiceSettings.WeatherZipCode);
                        break;
                    }
                    case WeatherServiceFlags.None:
                    default:
                        return false;

                }

                var pollForWeather = new PollForWeatherFromService();
                string sTemperature = string.Empty;
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
 
                const char degree = (char)176;
                var sUpdate = sTemperature.ToString() + degree + " at " + DateTime.Now;

                InvokeToLastTemperatureTextbox(sUpdate);
                InvokeToNotifyTrayIcon(sUpdate);
            }
            catch (Exception exception)
            {
                if (bTestPoll)
                    MessageBox.Show(exception.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private async void  btnTestWeatherService_Click(object sender, EventArgs e)
        {
            await VerifyValuesAndGetWeather(true);
        }

        private async void btnStartPollForWeather_Click(object sender, EventArgs e)
        {
            await VerifyValuesAndGetWeather(false);
        }

        private async Task<bool> VerifyValuesAndGetWeather(bool testButton)
        {
            var cbSelectedItem = (ComboboxItem)cbWeatherService.SelectedItem;
            if (cbSelectedItem.Value != null)
            {
                ServiceSettings.WeatherSelection = (WeatherServiceFlags)cbSelectedItem.Value;
                if (VerifyValues())
                {
                    SaveAppSettings();
                    if (testButton)
                    {
                        await PollForWeather(true);
                    }
                    else
                    {
                        InvokePollingProcess();
                    }

                    return true;
                }
            }

            return false;
        }
        private bool VerifyValues()
        {
            if (string.IsNullOrEmpty(txtZipCode.Text))
            {
                MessageBox.Show(Resources.WhatsTheWeatherMainWindow_VerifyValues_Please_enter_a_valid_zip_code_, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            if (ServiceSettings.WeatherSelection == WeatherServiceFlags.None)
            {
                MessageBox.Show(Resources.WhatsTheWeatherMainWindow_VerifyValues_Please_select_a_valid_weather_provider_, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            ServiceSettings.WeatherZipCode = txtZipCode.Text;

            return true;

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

        private void InvokeToNotifyTrayIcon(string sText)
        {
            if (txtLastTemperature.InvokeRequired)
            {
                this.Invoke(new InvokeToNotifyTrayIconDelegate(InvokeToNotifyTrayIcon), sText);
                return;
            }

            notifySystemTrayIcon.Text = sText;
            if (ServiceSettings.WeatherShowBalloon)
            {
                notifySystemTrayIcon.BalloonTipText = sText;
                notifySystemTrayIcon.ShowBalloonTip(5000);
            }
        }

        private void EnableControls(bool enable)
        {
            btnTestWeatherService.Enabled = enable;
            btnConfiguration.Enabled = enable;
            cbWeatherService.Enabled = enable;
            txtZipCode.Enabled =enable;
        }

        private void InvokePollingProcess()
        {
            if (_isPolling)
            {
                _timerForPollingOfWeather.Stop();
                EnableControls(true);
                _isPolling = false;
                btnStartPollForWeather.Text = Resources.WhatsTheWeatherMainWindow_InvokePollingProcess_Start;
            }
            else
            {
                SetWeatherPollingTimer();
                EnableControls(false);
                btnStartPollForWeather.Text = Resources.WhatsTheWeatherMainWindow_InvokePollingProcess_Stop;
                _timerForPollingOfWeather.Start();
                _isPolling = true;

            }

        }
        private void SetWeatherPollingTimer()
        {
            _timerForPollingOfWeather = new System.Timers.Timer
            {
                Interval = ServiceSettings.WeatherHourlyPollTimer * 3600 * 1000
            };

            _timerForPollingOfWeather.Elapsed += new ElapsedEventHandler(PollForWeatherTimer!);
            _timerForPollingOfWeather.AutoReset = true;
            _timerForPollingOfWeather.Enabled = true;
        }

        private async void PollForWeatherTimer(object source, ElapsedEventArgs e)
        {
            var returned = await PollForWeather(true);

        }

        private void notifySystemTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void WhatsTheWeatherMainWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;

                notifySystemTrayIcon.Visible = true;
            }
            else
            {
                notifySystemTrayIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
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
