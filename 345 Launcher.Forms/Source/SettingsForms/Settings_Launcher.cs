using _345_Launcher.Source.Localization;
using _345_Launcher.Source.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _345_Launcher.Source.SettingsForms
{
    public partial class Settings_Launcher : Form
    {
        public Settings_Launcher()
        {
            InitializeComponent();
            lang();
        }

        private void lang()
        {
            var settings = Settings.LoadSettings();

            var languages = LocalizationHelper.GetLanguages();
            languageCombo.Items.Clear();
            foreach (var language in languages)
            {
                languageCombo.Items.Add(language);
            }

            if (string.IsNullOrEmpty(settings.Language))
            {
                var defaultLanguage = languageCombo.Items.Add("Default (Build-in English)");
                languageCombo.SelectedIndex = defaultLanguage;
            }
            else
            {
                var index = languageCombo.Items.IndexOf(settings.Language);
                languageCombo.SelectedIndex = index;
            }
        }
    }
}
