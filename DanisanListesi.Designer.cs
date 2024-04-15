namespace DanismanRezervasyonOtomasyonu
{
    partial class DanisanListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanisanListesi));
            dt_danisanListesi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dt_danisanListesi).BeginInit();
            SuspendLayout();
            // 
            // dt_danisanListesi
            // 
            dt_danisanListesi.BackgroundColor = Color.WhiteSmoke;
            dt_danisanListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_danisanListesi.GridColor = Color.IndianRed;
            dt_danisanListesi.Location = new Point(28, 12);
            dt_danisanListesi.Name = "dt_danisanListesi";
            dt_danisanListesi.Size = new Size(760, 84);
            dt_danisanListesi.TabIndex = 0;
            // 
            // DanisanListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dt_danisanListesi);
            DoubleBuffered = true;
            ForeColor = SystemColors.AppWorkspace;
            Name = "DanisanListesi";
            Text = "DanisanListesi";
            ((System.ComponentModel.ISupportInitialize)dt_danisanListesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dt_danisanListesi;
    }
}