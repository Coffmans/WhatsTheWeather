using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsTheWeather.Properties;

namespace WhatsTheWeather
{
    public partial class WeatherServicesWindow : Form
    {
        public AppSettings WeatherServiceSettings = new AppSettings();
        public DialogResult dialogResult = DialogResult.Cancel;

        public WeatherServicesWindow(AppSettings serviceSettings)
        {
            InitializeComponent();

            WeatherServiceSettings = serviceSettings;
        }

        private void WeatherServicesWindow_Load(object sender, EventArgs e)
        {
            LoadWeatherServices();
        }

        private void LoadWeatherServices()
        {
            if (!string.IsNullOrEmpty(WeatherServiceSettings.AccuWeatherApiKey))
            {
                chkAccuWeather.Checked = true;
                txtAccuWeatherAPIKey.Text = WeatherServiceSettings.AccuWeatherApiKey;

            }
            txtAccuWeatherAPIKey.Enabled = chkAccuWeather.Checked;

            if (!string.IsNullOrEmpty(WeatherServiceSettings.OpenWeatherApiKey))
            {
                chkOpenWeather.Checked = true;
                txtOpenWeatherAPIKey.Text = WeatherServiceSettings.OpenWeatherApiKey;
            }

            txtOpenWeatherAPIKey.Enabled = chkOpenWeather.Checked;

            if (!string.IsNullOrEmpty(WeatherServiceSettings.VisualCrossingApiKey))
            {
                chkVisualCrossing.Checked = true;
                txtVisualCrossingAPIKey.Text = WeatherServiceSettings.VisualCrossingApiKey;
            }
            txtVisualCrossingAPIKey.Enabled = chkVisualCrossing.Checked;

            if (!string.IsNullOrEmpty(WeatherServiceSettings.WeatherApiApiKey))
            {
                chkWeatherApi.Checked = true;
                txtWeatherAPIKey.Text = WeatherServiceSettings.WeatherApiApiKey;
            }
            txtWeatherAPIKey.Enabled = chkWeatherApi.Checked;

            if (!string.IsNullOrEmpty(WeatherServiceSettings.WeatherUnlockedAppId))
            {
                chkWeatherUnlocked.Checked = true;
                txtWeatherUnlockedAppId.Text = WeatherServiceSettings.WeatherUnlockedAppId;
                txtWeatherUnlockedAppKey.Text = WeatherServiceSettings.WeatherUnlockedAppKey;
            }
            txtWeatherUnlockedAppId.Enabled = chkWeatherUnlocked.Checked;
            txtWeatherUnlockedAppKey.Enabled = chkOpenWeather.Checked;

            if (!string.IsNullOrEmpty(WeatherServiceSettings.WeatherBitApiKey))
            {
                chkWeatherBit.Checked = true;
                txtWeatherBitAPIKey.Text = WeatherServiceSettings.WeatherBitApiKey;
            }
            txtWeatherBitAPIKey.Enabled = chkWeatherBit.Checked;
        }

        private void chkAccuWeather_CheckedChanged(object sender, EventArgs e)
        {
            txtAccuWeatherAPIKey.Enabled = chkAccuWeather.Checked;
        }

        private void chkOpenWeather_CheckedChanged(object sender, EventArgs e)
        {
            txtOpenWeatherAPIKey.Enabled = chkOpenWeather.Checked;
        }

        private void chkVisualCrossing_CheckedChanged(object sender, EventArgs e)
        {
            txtVisualCrossingAPIKey.Enabled = chkVisualCrossing.Checked;
        }

        private void chkWeatherApi_CheckedChanged(object sender, EventArgs e)
        {
            txtWeatherAPIKey.Enabled = chkWeatherApi.Checked;
        }

        private void chkWeatherUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            txtWeatherUnlockedAppId.Enabled = chkWeatherUnlocked.Checked;
            txtWeatherUnlockedAppKey.Enabled = chkWeatherUnlocked.Checked;
        }

        private void chkWeatherBit_CheckedChanged(object sender, EventArgs e)
        {
            txtWeatherBitAPIKey.Enabled = chkWeatherBit.Checked;
        }

        private void btnCancelWeatherServices_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveWeatherServices_Click(object sender, EventArgs e)
        {
            if (VerifySettingChanges())
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool VerifySettingChanges()
        {
            if (!string.IsNullOrEmpty(WeatherServiceSettings.AccuWeatherApiKey) && !chkAccuWeather.Checked)
            {
                if (DialogResult.No ==
                    MessageBox.Show(
                        Resources.WeatherServicesWindow_VerifySettingChanges_VerifyAccuWeather,
                        Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return false;
                }

                WeatherServiceSettings.AccuWeatherApiKey = "";
            }
            else
            {
                if (chkAccuWeather.Checked)
                {
                    if (!txtAccuWeatherAPIKey.Text.Any())
                    {
                        MessageBox.Show(Resources.WeatherServicesWindow_VerifySettingChanges_AccuWeather_API_Key_Missing,
                            Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                    WeatherServiceSettings.AccuWeatherApiKey = txtAccuWeatherAPIKey.Text;

                }
            }


            if (!string.IsNullOrEmpty(WeatherServiceSettings.OpenWeatherApiKey) && !chkOpenWeather.Checked)
            {
                if (DialogResult.No ==
                    MessageBox.Show(
                        Resources.WeatherServicesWindow_VerifySettingChanges_OpenWeather,
                        Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return false;
                }

                WeatherServiceSettings.OpenWeatherApiKey = "";
            }
            else
            {
                if (chkOpenWeather.Checked)
                {
                    if (!txtOpenWeatherAPIKey.Text.Any())
                    {
                        MessageBox.Show(Resources.WeatherServicesWindow_VerifySettingChanges_Open_Weather_API_Key_Missing,
                            Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                    WeatherServiceSettings.OpenWeatherApiKey = txtOpenWeatherAPIKey.Text;
                }

            }


            if (!string.IsNullOrEmpty(WeatherServiceSettings.VisualCrossingApiKey) && !chkVisualCrossing.Checked)
            {
                if (DialogResult.No ==
                    MessageBox.Show(
                        Resources.WeatherServicesWindow_VerifySettingChanges_VisualCrossing,
                        Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return false;
                }
                WeatherServiceSettings.VisualCrossingApiKey = "";
            }
            else
            {
                if (chkVisualCrossing.Checked)
                {
                    if (!txtVisualCrossingAPIKey.Text.Any())
                    {
                        MessageBox.Show(Resources.WeatherServicesWindow_VerifySettingChanges_Visual_Crossing_API_Key_Missing,
                            Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                    WeatherServiceSettings.VisualCrossingApiKey = txtVisualCrossingAPIKey.Text;
                }

            }


            if (!string.IsNullOrEmpty(WeatherServiceSettings.WeatherApiApiKey) && !chkWeatherApi.Checked)
            {
                if (DialogResult.No ==
                    MessageBox.Show(
                        Resources.WeatherServicesWindow_VerifySettingChanges_WeatherApi,
                        Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return false;
                }
                WeatherServiceSettings.WeatherApiApiKey = "";
            }
            else
            {
                if (chkWeatherApi.Checked)
                {
                    if (!txtWeatherAPIKey.Text.Any())
                    {
                        MessageBox.Show(Resources.WeatherServicesWindow_VerifySettingChanges_Weather_API_API_Key_Missing,
                            Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                    WeatherServiceSettings.WeatherApiApiKey = txtWeatherAPIKey.Text;
                }

            }


            if (!string.IsNullOrEmpty(WeatherServiceSettings.WeatherUnlockedAppId) && !chkWeatherUnlocked.Checked)
            {
                if (DialogResult.No ==
                    MessageBox.Show(
                        Resources.WeatherServicesWindow_VerifySettingChanges_WeatherUnlocked,
                        Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return false;
                }
                WeatherServiceSettings.WeatherUnlockedAppId = "";
            }
            else
            {
                if (chkWeatherUnlocked.Checked)
                {
                    if (!txtWeatherUnlockedAppId.Text.Any() || !txtWeatherUnlockedAppKey.Text.Any())
                    {
                        MessageBox.Show(Resources.WeatherServicesWindow_VerifySettingChanges_Weather_Unlocked_API_Key_Missing,
                            Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                    WeatherServiceSettings.WeatherUnlockedAppId = txtWeatherUnlockedAppId.Text;
                    WeatherServiceSettings.WeatherUnlockedAppKey = txtWeatherUnlockedAppKey.Text;
                }

            }

            if (!string.IsNullOrEmpty(WeatherServiceSettings.WeatherBitApiKey) && !chkWeatherBit.Checked)
            {
                if (DialogResult.No ==
                    MessageBox.Show(
                        Resources.WeatherServicesWindow_VerifySettingChanges_WeatherBit,
                        Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return false;
                }
                WeatherServiceSettings.WeatherBitApiKey = "";
            }
            else
            {
                if (chkWeatherBit.Checked)
                {
                    if (!txtWeatherBitAPIKey.Text.Any())
                    {
                        MessageBox.Show(Resources.WeatherServicesWindow_VerifySettingChanges_WeatherBit_API_Key_Missing,
                            Resources.WeatherServicesWindow_VerifySettingChanges_Warning, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                    WeatherServiceSettings.WeatherBitApiKey = txtWeatherBitAPIKey.Text;
                }

            }

            return true;
        }
    }
}