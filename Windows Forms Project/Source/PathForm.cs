using CmlLib.Core;
using System;
using System.IO;
using System.Windows.Forms;

namespace _345_Launcher
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
            txtAssets.Text = path.Assets;
            txtLibrary.Text = path.Library;
            txtRuntime.Text = path.Runtime;
            txtVersion.Text = path.Versions;
            // Paths etc.
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbEditMore.Checked)
            {
                MinecraftPath.Library = txtLibrary.Text;
                MinecraftPath.Runtime = txtRuntime.Text;
                MinecraftPath.Versions = txtVersion.Text;

                // You have to call SetAssetsPath when you want to change assets directory to what you want.
                // SetAssetsPath change not only Assets property, but also AssetsLegacy, AssetsObject, Index property.
                //This commit now writed by me
                if (txtAssets.Text != MinecraftPath.Assets)
                    MinecraftPath.Assets = txtAssets.Text;
            }

            this.Close();
        }

        private void btnChangeJava_Click(object sender, EventArgs e)
        {
            txtAssets.Text = Path.Combine(MinecraftPath.GetOSDefaultPath(), "assets");
            //change java
        }

        private void cbEditMore_CheckedChanged(object sender, EventArgs e)
        {
            gPaths.Enabled = cbEditMore.Checked;

            if (!cbEditMore.Checked)
          //apply
                apply(MinecraftPath);
        }

    }
}
