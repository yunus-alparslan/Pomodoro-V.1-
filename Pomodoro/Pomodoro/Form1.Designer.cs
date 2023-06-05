namespace Pomodoro
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.üyeol = new System.Windows.Forms.LinkLabel();
            this.textboxloginkullanıcı = new System.Windows.Forms.TextBox();
            this.textboxsifrelogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // üyeol
            // 
            this.üyeol.AutoSize = true;
            this.üyeol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.üyeol.ForeColor = System.Drawing.Color.LightBlue;
            this.üyeol.LinkColor = System.Drawing.Color.Transparent;
            this.üyeol.Location = new System.Drawing.Point(206, 302);
            this.üyeol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.üyeol.Name = "üyeol";
            this.üyeol.Size = new System.Drawing.Size(43, 16);
            this.üyeol.TabIndex = 1;
            this.üyeol.TabStop = true;
            this.üyeol.Text = "Üye Ol";
            this.üyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.üyeol_LinkClicked);
            // 
            // textboxloginkullanıcı
            // 
            this.textboxloginkullanıcı.ForeColor = System.Drawing.Color.Black;
            this.textboxloginkullanıcı.Location = new System.Drawing.Point(174, 207);
            this.textboxloginkullanıcı.Margin = new System.Windows.Forms.Padding(4);
            this.textboxloginkullanıcı.Name = "textboxloginkullanıcı";
            this.textboxloginkullanıcı.Size = new System.Drawing.Size(116, 22);
            this.textboxloginkullanıcı.TabIndex = 4;
            // 
            // textboxsifrelogin
            // 
            this.textboxsifrelogin.Location = new System.Drawing.Point(174, 239);
            this.textboxsifrelogin.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsifrelogin.Name = "textboxsifrelogin";
            this.textboxsifrelogin.Size = new System.Drawing.Size(116, 22);
            this.textboxsifrelogin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(79, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(97, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pomodoro.Properties.Resources.icons8_name_100px;
            this.pictureBox2.Location = new System.Drawing.Point(149, 36);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Pomodoro.Properties.Resources.icons8_cancel_100px_2;
            this.button2.Location = new System.Drawing.Point(397, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 28);
            this.button2.TabIndex = 889;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(186, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 890;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(442, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxsifrelogin);
            this.Controls.Add(this.textboxloginkullanıcı);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.üyeol);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel üyeol;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textboxloginkullanıcı;
        private System.Windows.Forms.TextBox textboxsifrelogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

