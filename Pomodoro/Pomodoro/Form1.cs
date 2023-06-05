using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection dbağlanti = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=Pomadro;Integrated Security=True");


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void üyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayıtol kayit = new FrmKayıtol();
            kayit.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dbağlanti.Open();
            SqlCommand bağlan = new SqlCommand("Select * from Table_Hesaplar where KullanıcıAd=@p1 and Sifre=@p2", dbağlanti);
            bağlan.Parameters.AddWithValue("@p1", textboxloginkullanıcı.Text);
            bağlan.Parameters.AddWithValue("@p2", textboxsifrelogin.Text);

            SqlDataReader dr = bağlan.ExecuteReader();


            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frmpamadro pmdr = new Frmpamadro();
                pmdr.kullanıcıadi = textboxloginkullanıcı.Text;
                pmdr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlış!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            dbağlanti.Close();
        }
    }
}
