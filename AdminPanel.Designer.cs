namespace DanismanRezervasyonOtomasyonu
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            btn_ekle = new Button();
            btn_danisanListesi = new Button();
            SuspendLayout();
            // 
            // btn_ekle
            // 
            btn_ekle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_ekle.Location = new Point(55, 39);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(135, 46);
            btn_ekle.TabIndex = 0;
            btn_ekle.Text = "DANIŞAN EKLE";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_danisanListesi
            // 
            btn_danisanListesi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_danisanListesi.Location = new Point(55, 102);
            btn_danisanListesi.Name = "btn_danisanListesi";
            btn_danisanListesi.Size = new Size(135, 46);
            btn_danisanListesi.TabIndex = 1;
            btn_danisanListesi.Text = "DANIŞAN LİSTESİ";
            btn_danisanListesi.UseVisualStyleBackColor = true;
            btn_danisanListesi.Click += btn_danisanListesi_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_danisanListesi);
            Controls.Add(btn_ekle);
            DoubleBuffered = true;
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ekle;
        private Button btn_danisanListesi;
    }
}