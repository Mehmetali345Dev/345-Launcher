
namespace _345_Launcher.Re_Write
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
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.btnSetDefault = new Guna.UI2.WinForms.Guna2Button();
            this.btnApply = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(22, 99);
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
            // PathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(574, 169);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSetDefault);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PathForm";
            this.ShowInTaskbar = false;
            this.Text = "Minecraft nereye kurulsun?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPath;
        private Guna.UI2.WinForms.Guna2Button btnSetDefault;
        private Guna.UI2.WinForms.Guna2Button btnApply;
    }
}