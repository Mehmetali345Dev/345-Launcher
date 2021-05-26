
namespace _345_Launcher.Source.SettingsForms
{
    partial class Settings_Launcher
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.languageCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Launcher Ayarları";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.Animated = true;
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.Checked = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.guna2CheckBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2CheckBox1.Location = new System.Drawing.Point(19, 135);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(148, 27);
            this.guna2CheckBox1.TabIndex = 1;
            this.guna2CheckBox1.Text = "Discord-RPC";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UseVisualStyleBackColor = true;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discord Rpc";
            // 
            // languageCombo
            // 
            this.languageCombo.BackColor = System.Drawing.Color.Transparent;
            this.languageCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(109)))));
            this.languageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.languageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageCombo.FillColor = System.Drawing.Color.DarkSlateGray;
            this.languageCombo.FocusedColor = System.Drawing.Color.Empty;
            this.languageCombo.FocusedState.Parent = this.languageCombo;
            this.languageCombo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.languageCombo.ForeColor = System.Drawing.Color.White;
            this.languageCombo.FormattingEnabled = true;
            this.languageCombo.HoverState.Parent = this.languageCombo;
            this.languageCombo.ItemHeight = 30;
            this.languageCombo.ItemsAppearance.Parent = this.languageCombo;
            this.languageCombo.Location = new System.Drawing.Point(19, 219);
            this.languageCombo.Name = "languageCombo";
            this.languageCombo.ShadowDecoration.Parent = this.languageCombo;
            this.languageCombo.Size = new System.Drawing.Size(228, 36);
            this.languageCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dil";
            // 
            // Settings_Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(326, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.languageCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings_Launcher";
            this.Text = "Settings_Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox languageCombo;
        private System.Windows.Forms.Label label3;
    }
}