namespace Pomodoro
{
    partial class Frmpamadro
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxbilgi = new System.Windows.Forms.RichTextBox();
            this.pictureBoxresim1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxresim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(227, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "DEVAM ET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxbilgi
            // 
            this.richTextBoxbilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxbilgi.ForeColor = System.Drawing.Color.IndianRed;
            this.richTextBoxbilgi.Location = new System.Drawing.Point(74, 194);
            this.richTextBoxbilgi.Name = "richTextBoxbilgi";
            this.richTextBoxbilgi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxbilgi.Size = new System.Drawing.Size(190, 90);
            this.richTextBoxbilgi.TabIndex = 17;
            this.richTextBoxbilgi.Text = "Pomodoro Tekniği, 1980\'lerin sonunda\nFrancesco Cirillo tarafından geliştirilen \nb" +
    "ir zaman yönetimi yöntemidir";
            // 
            // pictureBoxresim1
            // 
            this.pictureBoxresim1.Image = global::Pomodoro.Properties.Resources.icons8_administrator_male_100px;
            this.pictureBoxresim1.Location = new System.Drawing.Point(100, 47);
            this.pictureBoxresim1.Name = "pictureBoxresim1";
            this.pictureBoxresim1.Size = new System.Drawing.Size(142, 124);
            this.pictureBoxresim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxresim1.TabIndex = 0;
            this.pictureBoxresim1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pomodoro.Properties.Resources.icons8_messaging_100px_1;
            this.pictureBox1.Location = new System.Drawing.Point(100, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.richTextBox1.Location = new System.Drawing.Point(74, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(190, 90);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "Teknikte, iş geleneksel olarak 25 dakika \nuzunluğunda, kısa molalarla ayrılır. Bu" +
    "nun içinse zamanlayıcı kullanılır.";
            this.richTextBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 21;
            this.label1.Visible = false;
            // 
            // Frmpamadro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxbilgi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxresim1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmpamadro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmpamadro";
            this.Load += new System.EventHandler(this.Frmpamadro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxresim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxresim1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxbilgi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}