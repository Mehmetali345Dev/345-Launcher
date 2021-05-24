using CmlLib.Core;
using System;
using System.IO;
using System.Windows.Forms;

namespace _345_Launcher.Re_Write
{
    public partial class PathForm : Form
    {
        public MinecraftPath MinecraftPath;

        public PathForm()
        {
            InitializeComponent();
        }

        public PathForm(MinecraftPath path)
        {
            this.MinecraftPath = path;

            //Sets minecraft path not works now
            InitializeComponent();
        }

        private void InitializingForm_Load(object sender, EventArgs e)
        {
            if (MinecraftPath == null)
                btnSetDefault_Click(null, null);
            else
                apply(MinecraftPath);
            // Selects minecraft path default

        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            var defaultPath = MinecraftPath.GetOSDefaultPath();
            apply(new MinecraftPath(defaultPath));
            // When you press path is changes to default Appdata/Roaming/.minecraft
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var mc = new MinecraftPath(txtPath.Text)
            {
                Runtime = MinecraftPath.Runtime,
                Assets = Path.Combine(MinecraftPath.GetOSDefaultPath(), "assets")
                //assets folder
            };
            apply(mc);
        }

        void apply(MinecraftPath path)
        {
            this.MinecraftPath = path;

            txtPath.Text = path.BasePath;
            // Paths etc.
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
