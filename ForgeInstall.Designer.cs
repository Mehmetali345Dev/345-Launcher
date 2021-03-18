
namespace _345_Launcher
{
    partial class ForgeInstall
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgeInstall));
            this.btnInstall = new Guna.UI2.WinForms.Guna2Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtMC = new MetroFramework.Controls.MetroTextBox();
            this.pbProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtForge = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.CheckedState.Parent = this.btnInstall;
            this.btnInstall.CustomImages.Parent = this.btnInstall;
            this.btnInstall.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInstall.ForeColor = System.Drawing.Color.White;
            this.btnInstall.HoverState.Parent = this.btnInstall;
            this.btnInstall.Location = new System.Drawing.Point(200, 25);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.ShadowDecoration.Parent = this.btnInstall;
            this.btnInstall.Size = new System.Drawing.Size(65, 69);
            this.btnInstall.TabIndex = 13;
            this.btnInstall.Text = "Kur";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(1, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Minecraft Sürümü";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtMC
            // 
            // 
            // 
            // 
            this.txtMC.CustomButton.Image = null;
            this.txtMC.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.txtMC.CustomButton.Name = "";
            this.txtMC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMC.CustomButton.TabIndex = 1;
            this.txtMC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMC.CustomButton.UseSelectable = true;
            this.txtMC.CustomButton.Visible = false;
            this.txtMC.Lines = new string[0];
            this.txtMC.Location = new System.Drawing.Point(126, 26);
            this.txtMC.MaxLength = 32767;
            this.txtMC.Name = "txtMC";
            this.txtMC.PasswordChar = '\0';
            this.txtMC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMC.SelectedText = "";
            this.txtMC.SelectionLength = 0;
            this.txtMC.SelectionStart = 0;
            this.txtMC.ShortcutsEnabled = true;
            this.txtMC.Size = new System.Drawing.Size(69, 23);
            this.txtMC.TabIndex = 2;
            this.txtMC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtMC.UseSelectable = true;
            this.txtMC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbProgress
            // 
            this.pbProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pbProgress.Location = new System.Drawing.Point(21, 126);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.ShadowDecoration.Parent = this.pbProgress;
            this.pbProgress.Size = new System.Drawing.Size(232, 24);
            this.pbProgress.TabIndex = 16;
            this.pbProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(10, 178);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(255, 279);
            this.txtLog.TabIndex = 17;
            this.txtLog.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(1, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Forge Versiyonu";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtForge
            // 
            // 
            // 
            // 
            this.txtForge.CustomButton.Image = null;
            this.txtForge.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.txtForge.CustomButton.Name = "";
            this.txtForge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtForge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtForge.CustomButton.TabIndex = 1;
            this.txtForge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtForge.CustomButton.UseSelectable = true;
            this.txtForge.CustomButton.Visible = false;
            this.txtForge.Lines = new string[0];
            this.txtForge.Location = new System.Drawing.Point(116, 71);
            this.txtForge.MaxLength = 32767;
            this.txtForge.Name = "txtForge";
            this.txtForge.PasswordChar = '\0';
            this.txtForge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtForge.SelectedText = "";
            this.txtForge.SelectionLength = 0;
            this.txtForge.SelectionStart = 0;
            this.txtForge.ShortcutsEnabled = true;
            this.txtForge.Size = new System.Drawing.Size(78, 23);
            this.txtForge.TabIndex = 18;
            this.txtForge.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtForge.UseSelectable = true;
            this.txtForge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtForge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Örnek: 1.12.2 / 14.23.5.2768\r\n      1.16.2 / 33.0.5";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(12, 156);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 19);
            this.lbStatus.TabIndex = 21;
            this.lbStatus.Text = "Hazır";
            this.lbStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbStatus.UseCustomForeColor = true;
            // 
            // ForgeInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(277, 469);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtForge);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.txtMC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ForgeInstall";
            this.Text = "ForgeInstall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnInstall;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtMC;
        private Guna.UI2.WinForms.Guna2ProgressBar pbProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtLog;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtForge;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroLabel lbStatus;
    }
}