using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _345_Launcher___Core.Utils
{
    class Settings
    {
        public string Username;

        public bool RememberMe = false;
        public static string GetSettingsFilename()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lang_settings.json");
        }

        public static void SaveSettings(Settings settings)
        {
            if (settings.Username.Contains(""))
            {
                settings.Username = "";

            }

            var serialized = JsonConvert.SerializeObject(settings);

            var file = GetSettingsFilename();

            File.WriteAllText(file, serialized);

        }

        public static Settings LoadSettings()
        {
            var file = GetSettingsFilename();

            if (!File.Exists(file))
                return new Settings();

            var context = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<Settings>(context);
        }
    }
}
