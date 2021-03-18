
namespace _345_Launcher
{
    partial class JavaForm
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
            this.gAutoJava = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtJavaDirectory = new MetroFramework.Controls.MetroTextBox();
            this.rbAutoJava = new MetroFramework.Controls.MetroRadioButton();
            this.rbUserJava = new MetroFramework.Controls.MetroRadioButton();
            this.gUserJava = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtUserJava = new MetroFramework.Controls.MetroTextBox();
            this.gAutoJava.SuspendLayout();
            this.gUserJava.SuspendLayout();
            this.SuspendLayout();
            // 
            // gAutoJava
            // 
            this.gAutoJava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gAutoJava.Controls.Add(this.metroLabel1);
            this.gAutoJava.Controls.Add(this.metroLabel5);
            this.gAutoJava.Controls.Add(this.metroLabel3);
            this.gAutoJava.Controls.Add(this.txtJavaDirectory);
            this.gAutoJava.ForeColor = System.Drawing.Color.White;
            this.gAutoJava.Location = new System.Drawing.Point(12, 42);
            this.gAutoJava.Name = "gAutoJava";
            this.gAutoJava.Size = new System.Drawing.Size(237, 79);
            this.gAutoJava.TabIndex = 4;
            this.gAutoJava.TabStop = false;
            this.gAutoJava.Text = "Otomatik Java";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(6, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 15);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Java Yolu:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
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
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(0, 56);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(233, 15);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Program javayı otomatik ayarlar. Yoksa indirir.";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txtJavaDirectory
            // 
            // 
            // 
            // 
            this.txtJavaDirectory.CustomButton.Image = null;
            this.txtJavaDirectory.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtJavaDirectory.CustomButton.Name = "";
            this.txtJavaDirectory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJavaDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJavaDirectory.CustomButton.TabIndex = 1;
            this.txtJavaDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJavaDirectory.CustomButton.UseSelectable = true;
            this.txtJavaDirectory.CustomButton.Visible = false;
            this.txtJavaDirectory.Lines = new string[0];
            this.txtJavaDirectory.Location = new System.Drawing.Point(67, 21);
            this.txtJavaDirectory.MaxLength = 32767;
            this.txtJavaDirectory.Name = "txtJavaDirectory";
            this.txtJavaDirectory.PasswordChar = '\0';
            this.txtJavaDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJavaDirectory.SelectedText = "";
            this.txtJavaDirectory.SelectionLength = 0;
            this.txtJavaDirectory.SelectionStart = 0;
            this.txtJavaDirectory.ShortcutsEnabled = true;
            this.txtJavaDirectory.Size = new System.Drawing.Size(164, 23);
            this.txtJavaDirectory.TabIndex = 2;
            this.txtJavaDirectory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtJavaDirectory.UseSelectable = true;
            this.txtJavaDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJavaDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbAutoJava
            // 
            this.rbAutoJava.AutoSize = true;
            this.rbAutoJava.Checked = true;
            this.rbAutoJava.Location = new System.Drawing.Point(12, 12);
            this.rbAutoJava.Name = "rbAutoJava";
            this.rbAutoJava.Size = new System.Drawing.Size(138, 15);
            this.rbAutoJava.TabIndex = 7;
            this.rbAutoJava.TabStop = true;
            this.rbAutoJava.Text = "Java\'yı otomatik indir.";
            this.rbAutoJava.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbAutoJava.UseSelectable = true;
            this.Load += new System.EventHandler(this.rbAutoJava_CheckedChanged);
            // 
            // rbUserJava
            // 
            this.rbUserJava.AutoSize = true;
            this.rbUserJava.Location = new System.Drawing.Point(12, 127);
            this.rbUserJava.Name = "rbUserJava";
            this.rbUserJava.Size = new System.Drawing.Size(97, 15);
            this.rbUserJava.TabIndex = 8;
            this.rbUserJava.Text = "Kendin ayarla.";
            this.rbUserJava.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbUserJava.UseSelectable = true;
            this.Load += new System.EventHandler(this.rbUserJava_CheckedChanged);
            // 
            // gUserJava
            // 
            this.gUserJava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gUserJava.Controls.Add(this.metroLabel2);
            this.gUserJava.Controls.Add(this.metroLabel4);
            this.gUserJava.Controls.Add(this.metroLabel6);
            this.gUserJava.Controls.Add(this.txtUserJava);
            this.gUserJava.ForeColor = System.Drawing.Color.White;
            this.gUserJava.Location = new System.Drawing.Point(12, 148);
            this.gUserJava.Name = "gUserJava";
            this.gUserJava.Size = new System.Drawing.Size(237, 79);
            this.gUserJava.TabIndex = 9;
            this.gUserJava.TabStop = false;
            this.gUserJava.Text = "Kendin Seç";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(6, 24);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 15);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Java Yolu:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(101, 71);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(6, 56);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(156, 15);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "jawaw.exe ayda java.exe seçin.";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // txtUserJava
            // 
            // 
            // 
            // 
            this.txtUserJava.CustomButton.Image = null;
            this.txtUserJava.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtUserJava.CustomButton.Name = "";
            this.txtUserJava.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserJava.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserJava.CustomButton.TabIndex = 1;
            this.txtUserJava.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserJava.CustomButton.UseSelectable = true;
            this.txtUserJava.CustomButton.Visible = false;
            this.txtUserJava.Lines = new string[0];
            this.txtUserJava.Location = new System.Drawing.Point(67, 21);
            this.txtUserJava.MaxLength = 32767;
            this.txtUserJava.Name = "txtUserJava";
            this.txtUserJava.PasswordChar = '\0';
            this.txtUserJava.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserJava.SelectedText = "";
            this.txtUserJava.SelectionLength = 0;
            this.txtUserJava.SelectionStart = 0;
            this.txtUserJava.ShortcutsEnabled = true;
            this.txtUserJava.Size = new System.Drawing.Size(164, 23);
            this.txtUserJava.TabIndex = 2;
            this.txtUserJava.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUserJava.UseSelectable = true;
            this.txtUserJava.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserJava.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // JavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(286, 254);
            this.Controls.Add(this.gUserJava);
            this.Controls.Add(this.rbUserJava);
            this.Controls.Add(this.rbAutoJava);
            this.Controls.Add(this.gAutoJava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JavaForm";
            this.ShowInTaskbar = false;
            this.Text = "Java Seç";
            this.Load += new System.EventHandler(this.JavaForm_Load);
            this.gAutoJava.ResumeLayout(false);
            this.gAutoJava.PerformLayout();
            this.gUserJava.ResumeLayout(false);
            this.gUserJava.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gAutoJava;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtJavaDirectory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rbAutoJava;
        private MetroFramework.Controls.MetroRadioButton rbUserJava;
        private System.Windows.Forms.GroupBox gUserJava;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtUserJava;
    }
}