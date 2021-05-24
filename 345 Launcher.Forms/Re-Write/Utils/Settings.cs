﻿using _345_Launcher.Source.Localization;
using Newtonsoft.Json;
using System;
using System.IO;

namespace _345_Launcher.Re__Write.Utils
{
    class Settings
    {
        public string Language = "";
        public bool RPC = true;

        public static string GetSettingsFilename()
        {
            string confpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".345launcher");

            return Path.Combine(confpath, "lang_settings.json");
        }

        public static void SaveSettings(Settings settings)
        {
            if (settings.Language.Contains("Default"))
            {
                settings.Language = "";
            }

            var serialized = JsonConvert.SerializeObject(settings);
            var file = GetSettingsFilename();

            if (File.Exists(file))
                File.Delete(file);

            File.WriteAllText(file, serialized);

            LocalizationHelper.Update();
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
