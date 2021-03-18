
namespace _345_Launcher
{
    partial class PathForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathForm));
            this.gPaths = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtRuntime = new MetroFramework.Controls.MetroTextBox();
            this.btnChangeJava = new Guna.UI2.WinForms.Guna2Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtLibrary = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtVersion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAssets = new MetroFramework.Controls.MetroTextBox();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.btnSetDefault = new Guna.UI2.WinForms.Guna2Button();
            this.btnApply = new Guna.UI2.WinForms.Guna2Button();
            this.cbEditMore = new MetroFramework.Controls.MetroCheckBox();
            this.gPaths.SuspendLayout();
            this.SuspendLayout();
            // 
            // gPaths
            // 
            this.gPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gPaths.Controls.Add(this.metroLabel4);
            this.gPaths.Controls.Add(this.txtRuntime);
            this.gPaths.Controls.Add(this.btnChangeJava);
            this.gPaths.Controls.Add(this.metroLabel3);
            this.gPaths.Controls.Add(this.txtLibrary);
            this.gPaths.Controls.Add(this.metroLabel2);
            this.gPaths.Controls.Add(this.txtVersion);
            this.gPaths.Controls.Add(this.metroLabel5);
            this.gPaths.Controls.Add(this.metroLabel1);
            this.gPaths.Controls.Add(this.txtAssets);
            this.gPaths.ForeColor = System.Drawing.Color.White;
            this.gPaths.Location = new System.Drawing.Point(12, 99);
            this.gPaths.Name = "gPaths";
            this.gPaths.Size = new System.Drawing.Size(550, 188);
            this.gPaths.TabIndex = 4;
            this.gPaths.TabStop = false;
            this.gPaths.Text = "Ayrıntılı Klasör Ayarı";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(10, 154);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Runtime";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // txtRuntime
            // 
            // 
            // 
            // 
            this.txtRuntime.CustomButton.Image = null;
            this.txtRuntime.CustomButton.Location = new System.Drawing.Point(414, 1);
            this.txtRuntime.CustomButton.Name = "";
            this.txtRuntime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRuntime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRuntime.CustomButton.TabIndex = 1;
            this.txtRuntime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRuntime.CustomButton.UseSelectable = true;
            this.txtRuntime.CustomButton.Visible = false;
            this.txtRuntime.Lines = new string[0];
            this.txtRuntime.Location = new System.Drawing.Point(108, 150);
            this.txtRuntime.MaxLength = 32767;
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.PasswordChar = '\0';
            this.txtRuntime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRuntime.SelectedText = "";
            this.txtRuntime.SelectionLength = 0;
            this.txtRuntime.SelectionStart = 0;
            this.txtRuntime.ShortcutsEnabled = true;
            this.txtRuntime.Size = new System.Drawing.Size(436, 23);
            this.txtRuntime.TabIndex = 18;
            this.txtRuntime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRuntime.UseSelectable = true;
            this.txtRuntime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRuntime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnChangeJava
            // 
            this.btnChangeJava.CheckedState.Parent = this.btnChangeJava;
            this.btnChangeJava.CustomImages.Parent = this.btnChangeJava;
            this.btnChangeJava.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangeJava.ForeColor = System.Drawing.Color.White;
            this.btnChangeJava.HoverState.Parent = this.btnChangeJava;
            this.btnChangeJava.Location = new System.Drawing.Point(201, 68);
            this.btnChangeJava.Name = "btnChangeJava";
            this.btnChangeJava.ShadowDecoration.Parent = this.btnChangeJava;
            this.btnChangeJava.Size = new System.Drawing.Size(161, 18);
            this.btnChangeJava.TabIndex = 13;
            this.btnChangeJava.Text = "Assetler klasörünü kullan.";
            this.btnChangeJava.Click += new System.EventHandler(this.btnChangeJava_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(10, 96);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Libary";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txtLibrary
            // 
            // 
            // 
            // 
            this.txtLibrary.CustomButton.Image = null;
            this.txtLibrary.CustomButton.Location = new System.Drawing.Point(414, 1);
            this.txtLibrary.CustomButton.Name = "";
            this.txtLibrary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLibrary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLibrary.CustomButton.TabIndex = 1;
            this.txtLibrary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLibrary.CustomButton.UseSelectable = true;
            this.txtLibrary.CustomButton.Visible = false;
            this.txtLibrary.Lines = new string[0];
            this.txtLibrary.Location = new System.Drawing.Point(108, 92);
            this.txtLibrary.MaxLength = 32767;
            this.txtLibrary.Name = "txtLibrary";
            this.txtLibrary.PasswordChar = '\0';
            this.txtLibrary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLibrary.SelectedText = "";
            this.txtLibrary.SelectionLength = 0;
            this.txtLibrary.SelectionStart = 0;
            this.txtLibrary.ShortcutsEnabled = true;
            this.txtLibrary.Size = new System.Drawing.Size(436, 23);
            this.txtLibrary.TabIndex = 16;
            this.txtLibrary.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtLibrary.UseSelectable = true;
            this.txtLibrary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLibrary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(10, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Versiyon";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtVersion
            // 
            // 
            // 
            // 
            this.txtVersion.CustomButton.Image = null;
            this.txtVersion.CustomButton.Location = new System.Drawing.Point(414, 1);
            this.txtVersion.CustomButton.Name = "";
            this.txtVersion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVersion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVersion.CustomButton.TabIndex = 1;
            this.txtVersion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVersion.CustomButton.UseSelectable = true;
            this.txtVersion.CustomButton.Visible = false;
            this.txtVersion.Lines = new string[0];
            this.txtVersion.Location = new System.Drawing.Point(108, 121);
            this.txtVersion.MaxLength = 32767;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.PasswordChar = '\0';
            this.txtVersion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVersion.SelectedText = "";
            this.txtVersion.SelectionLength = 0;
            this.txtVersion.SelectionStart = 0;
            this.txtVersion.ShortcutsEnabled = true;
            this.txtVersion.Size = new System.Drawing.Size(436, 23);
            this.txtVersion.TabIndex = 14;
            this.txtVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtVersion.UseSelectable = true;
            this.txtVersion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVersion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(101, 71);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(10, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Assetler";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtAssets
            // 
            // 
            // 
            // 
            this.txtAssets.CustomButton.Image = null;
            this.txtAssets.CustomButton.Location = new System.Drawing.Point(414, 1);
            this.txtAssets.CustomButton.Name = "";
            this.txtAssets.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAssets.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAssets.CustomButton.TabIndex = 1;
            this.txtAssets.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAssets.CustomButton.UseSelectable = true;
            this.txtAssets.CustomButton.Visible = false;
            this.txtAssets.Lines = new string[0];
            this.txtAssets.Location = new System.Drawing.Point(108, 19);
            this.txtAssets.MaxLength = 32767;
            this.txtAssets.Name = "txtAssets";
            this.txtAssets.PasswordChar = '\0';
            this.txtAssets.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAssets.SelectedText = "";
            this.txtAssets.SelectionLength = 0;
            this.txtAssets.SelectionStart = 0;
            this.txtAssets.ShortcutsEnabled = true;
            this.txtAssets.Size = new System.Drawing.Size(436, 23);
            this.txtAssets.TabIndex = 2;
            this.txtAssets.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAssets.UseSelectable = true;
            this.txtAssets.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAssets.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnStart
            // 
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(22, 306);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(530, 35);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Kaydet";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(22, 31);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Minecraft Yolu";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // txtPath
            // 
            // 
            // 
            // 
            this.txtPath.CustomButton.Image = null;
            this.txtPath.CustomButton.Location = new System.Drawing.Point(398, 1);
            this.txtPath.CustomButton.Name = "";
            this.txtPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPath.CustomButton.TabIndex = 1;
            this.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPath.CustomButton.UseSelectable = true;
            this.txtPath.CustomButton.Visible = false;
            this.txtPath.Lines = new string[0];
            this.txtPath.Location = new System.Drawing.Point(136, 30);
            this.txtPath.MaxLength = 32767;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.ShortcutsEnabled = true;
            this.txtPath.Size = new System.Drawing.Size(420, 23);
            this.txtPath.TabIndex = 16;
            this.txtPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPath.UseSelectable = true;
            this.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.CheckedState.Parent = this.btnSetDefault;
            this.btnSetDefault.CustomImages.Parent = this.btnSetDefault;
            this.btnSetDefault.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSetDefault.ForeColor = System.Drawing.Color.White;
            this.btnSetDefault.HoverState.Parent = this.btnSetDefault;
            this.btnSetDefault.Location = new System.Drawing.Point(303, 59);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.ShadowDecoration.Parent = this.btnSetDefault;
            this.btnSetDefault.Size = new System.Drawing.Size(161, 18);
            this.btnSetDefault.TabIndex = 18;
            this.btnSetDefault.Text = "Varsayılan yol";
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // btnApply
            // 
            this.btnApply.CheckedState.Parent = this.btnApply;
            this.btnApply.CustomImages.Parent = this.btnApply;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.HoverState.Parent = this.btnApply;
            this.btnApply.Location = new System.Drawing.Point(136, 59);
            this.btnApply.Name = "btnApply";
            this.btnApply.ShadowDecoration.Parent = this.btnApply;
            this.btnApply.Size = new System.Drawing.Size(161, 34);
            this.btnApply.TabIndex = 19;
            this.btnApply.Text = "Uygula";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbEditMore
            // 
            this.cbEditMore.AutoSize = true;
            this.cbEditMore.Location = new System.Drawing.Point(455, 83);
            this.cbEditMore.Name = "cbEditMore";
            this.cbEditMore.Size = new System.Drawing.Size(107, 15);
            this.cbEditMore.TabIndex = 20;
            this.cbEditMore.Text = "Gelişmiş Ayarlar";
            this.cbEditMore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbEditMore.UseSelectable = true;
            this.cbEditMore.CheckedChanged += new System.EventHandler(this.cbEditMore_CheckedChanged);
            // 
            // PathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(574, 353);
            this.Controls.Add(this.cbEditMore);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSetDefault);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gPaths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PathForm";
            this.ShowInTaskbar = false;
            this.Text = "Minecraft nereye kurulsun?";
            this.gPaths.ResumeLayout(false);
            this.gPaths.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gPaths;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtRuntime;
        private Guna.UI2.WinForms.Guna2Button btnChangeJava;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtLibrary;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtVersion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAssets;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPath;
        private Guna.UI2.WinForms.Guna2Button btnSetDefault;
        private Guna.UI2.WinForms.Guna2Button btnApply;
        private MetroFramework.Controls.MetroCheckBox cbEditMore;
    }
}