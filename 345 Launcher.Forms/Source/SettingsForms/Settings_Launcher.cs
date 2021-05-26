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

            if(Properties.Settings.Default.rpc == true)
            {
                guna2CheckBox1.Checked = true;
            }
            else
            {
                guna2CheckBox1.Checked = false;
            }
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
                var defaultLanguage = languageCombo.Items.Add("Varsayılan(Yerleşik TÜrkçe)");
                languageCombo.SelectedIndex = defaultLanguage;
            }
            else
            {
                var index = languageCombo.Items.IndexOf(settings.Language);
                languageCombo.SelectedIndex = index;
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked == true)
            {
                Properties.Settings.Default.rpc = true;
            }
            else
            {
                Properties.Settings.Default.rpc = false;
            }
        }
    }
}
