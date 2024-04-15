namespace DanismanRezervasyonOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(75, 106);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(75, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(130, 67);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(192, 23);
            txt_user.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(130, 103);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(192, 23);
            txt_pass.TabIndex = 4;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Aqua;
            btn_login.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_login.Location = new Point(160, 150);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(104, 36);
            btn_login.TabIndex = 5;
            btn_login.Text = "GİRİŞ";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 240);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Button btn_login;
    }
}
