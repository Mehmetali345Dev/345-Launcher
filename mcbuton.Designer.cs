
namespace _345_Launcher
{
    partial class mcbuton
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mcbuton));
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2TileButton1.BackgroundImage")));
            this.guna2TileButton1.CheckedState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.CustomImages.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TileButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Location = new System.Drawing.Point(0, 0);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.ShadowDecoration.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Size = new System.Drawing.Size(156, 58);
            this.guna2TileButton1.TabIndex = 0;
            this.guna2TileButton1.Text = "guna2TileButton1";
            // 
            // mcbuton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TileButton1);
            this.Name = "mcbuton";
            this.Size = new System.Drawing.Size(156, 58);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
    }
}
