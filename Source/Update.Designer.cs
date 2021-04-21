
namespace _345_Launcher
{
    partial class Update
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
            this.Pb_File = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.gün_but = new Guna.UI2.WinForms.Guna2TileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pb_File
            // 
            this.Pb_File.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.Pb_File.Location = new System.Drawing.Point(12, 47);
            this.Pb_File.Name = "Pb_File";
            this.Pb_File.ShadowDecoration.Parent = this.Pb_File;
            this.Pb_File.Size = new System.Drawing.Size(296, 20);
            this.Pb_File.TabIndex = 15;
            this.Pb_File.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // gün_but
            // 
            this.gün_but.CheckedState.Parent = this.gün_but;
            this.gün_but.CustomImages.Parent = this.gün_but;
            this.gün_but.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gün_but.ForeColor = System.Drawing.Color.White;
            this.gün_but.HoverState.Parent = this.gün_but;
            this.gün_but.Location = new System.Drawing.Point(12, 73);
            this.gün_but.Name = "gün_but";
            this.gün_but.ShadowDecoration.Parent = this.gün_but;
            this.gün_but.Size = new System.Drawing.Size(323, 25);
            this.gün_but.TabIndex = 16;
            this.gün_but.Text = "Güncelle";
            this.gün_but.Click += new System.EventHandler(this.gün_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "%0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "345 Updater";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Dosya launcherın bulunduğu yere indirilicektir.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "İndikten sonra eskisini silip yeni indirilen dosyayı çalıştırmanız yeterlidir.";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(350, 122);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gün_but);
            this.Controls.Add(this.Pb_File);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Update";
            this.Text = "Güncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar Pb_File;
        private System.ComponentModel.BackgroundWorker bw;
        private Guna.UI2.WinForms.Guna2TileButton gün_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}