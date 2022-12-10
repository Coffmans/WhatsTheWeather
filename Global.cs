using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsTheWeather
{
    public class ConfigData
    {
        public static string? GetConfigData(string sKey)
        {
            return ConfigurationManager.AppSettings[sKey];
        }

        public static void SetConfigData(string sKey, string? sValue)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(sKey);
            config.AppSettings.Settings.Add(sKey, sValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        #region Encryption

        //https://www.findandsolve.com/articles/encrypt-and-decrypt-string-in-asp-dot-net-core-dot-net-5
        public static string? EncryptString(string message, string passphrase)
        {
            var iv = new byte[16];
            byte[] array;
            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(passphrase);
                aes.IV = iv;
                var encrypted = aes.CreateEncryptor(aes.Key, aes.IV);
                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream((Stream)memoryStream, encrypted, CryptoStreamMode.Write))
                    {
                        using (var streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(message);
                        }
                        array = memoryStream.ToArray();
                    }
;
                }

            }
            return Convert.ToBase64String(array);
        }

        public static string? DecryptString(string? message, string passphrase)
        {
            try
            {
                var iv = new byte[16];
                if (message != null)
                {
                    var buffer = Convert.FromBase64String(message);
                    using (var aes = Aes.Create())
                    {
                        aes.Key = Encoding.UTF8.GetBytes(passphrase);
                        aes.IV = iv;
                        var decrypted = aes.CreateDecryptor(aes.Key, aes.IV);
                        using (var memoryStream = new MemoryStream(buffer))
                        {
                            using (var cryptoStream =
                                   new CryptoStream((Stream)memoryStream, decrypted, CryptoStreamMode.Read))
                            {
                                using (var streamReader = new StreamReader((Stream)cryptoStream))
                                {
                                    string stream = streamReader.ReadToEnd();
                                    while (!streamReader.EndOfStream)
                                    {
                                        stream += streamReader.ReadLine();
                                    }
                                    return stream;
                                }
                            }
                        }
                    }
     
                }

            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            return null;
        }

        #endregion

    }
    public class AppSettings
    {
        public string? AccuWeatherApiKey { get; set; }
        public string? OpenWeatherApiKey { get; set; }
        public string? VisualCrossingApiKey { get; set; }
        public string? WeatherApiApiKey { get; set; }
        public string? WeatherUnlockedAppId { get; set; }
        public string? WeatherUnlockedAppKey { get; set; }
        public string? WeatherBitApiKey { get; set; }

        public WeatherServiceFlags WeatherSelection { get; set; }

        public AppSettings()
        {
            AccuWeatherApiKey = "";
            OpenWeatherApiKey = "";
            VisualCrossingApiKey = "";
            WeatherApiApiKey = "";
            WeatherUnlockedAppId = "";
            WeatherUnlockedAppKey = "";
            WeatherUnlockedAppKey = "";
            WeatherBitApiKey = "";
            WeatherSelection = WeatherServiceFlags.None;
        }
    }

    [Flags]
    public enum WeatherServiceFlags
    {
        None = 0x00000000,
        AccuWeather = 0x00000001,
        OpenWeather = 0x00000002,
        VisualCrossing = 0x00000004,
        WeatherApi = 0x00000008,
        WeatherUnlocked = 0x00000010,
        WeatherBit = 0x00000020,
    }
}
