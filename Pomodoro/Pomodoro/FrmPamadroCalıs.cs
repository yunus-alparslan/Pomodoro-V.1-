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
    public partial class FrmPamadroCalıs : Form
    {
        // Sql Database Bağlantısı
        SqlConnection dbağlanti = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=Pomadro;Integrated Security=True");
        // Sql Database Bağlantısı


        public FrmPamadroCalıs()
        {
            InitializeComponent();
        }

        // Değişkenler
        public string kullanıcıadi;
        //saat değişkenleri

        int saniye = 0, dakika = 0;

        int score = 0, baslat = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            baslat++;

            if (baslat == 1)
            {
                timer1.Start();
                button1.Text = "DURDUR";
            }
            else if(baslat==2)
            {
                
          
                timer1.Stop();
                MessageBox.Show("Pomodoro Durduruldu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Text = "BASLAT";
            }
            else if (baslat == 3)
            {
                timer1.Start();
                baslat = 1;
                button1.Text = "DURDUR";
            }
     
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V.1 Güncellleme İle gelicektir :)","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            saniye++;
  
            saniyeetext.Text = saniye.ToString();

           

            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
                dakikatext.Text = dakika.ToString();
            }

            //if (dakika == 1)
            //{
            //    score += 10;
            //    score = Convert.ToInt32(label4.Text);
            //    score += 10;
            //    label4.Text = score.ToString();
            //    baslat = 0;
            //    button1.Text = "BASLAT";
            //    timer1.Stop();
            //    dakika = 0;
            //    dbağlanti.Open();
            //    SqlCommand bgln2 = new SqlCommand("Update Table_Hesaplar Set Puan=@p1 where KullanıcıAd=@p2", dbağlanti);
            //    bgln2.Parameters.AddWithValue("@p1", labelskor.Text);
            //    bgln2.Parameters.AddWithValue("@p2", Kullanıcıadı.Text);
            //    labelskor.Text = label4.Text;
            //    bgln2.ExecuteNonQuery();
            //    dbağlanti.Close();
            //    MessageBox.Show("Pomodro Yapıldı Puanınız eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}


 

            switch (dakika)
            {
                case 60:
                    score = Convert.ToInt32(label4.Text);
                    score += 10;
                    label4.Text = score.ToString();
                    baslat = 0;
                    button1.Text = "BASLAT";
                    timer1.Stop();
                    dakika = 0;
                    dbağlanti.Open();
                    SqlCommand bgln23 = new SqlCommand("Update Table_Hesaplar Set Puan=@p1 where KullanıcıAd=@p2", dbağlanti);
                    bgln23.Parameters.AddWithValue("@p1", labelskor.Text);
                    bgln23.Parameters.AddWithValue("@p2", Kullanıcıadı.Text);
                    labelskor.Text = label4.Text;
                    bgln23.ExecuteNonQuery();
                    dbağlanti.Close();
                    MessageBox.Show("Pomodro Yapıldı Puanınız eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }     
        }

        private void FrmPamadroCalıs_Load(object sender, EventArgs e)
        {

            // Kullanıcı Bilgileri Çekme
            Kullanıcıadı.Text = kullanıcıadi;

            dbağlanti.Open();
            SqlCommand bağlan = new SqlCommand("Select * from Table_Hesaplar where KullanıcıAd=@p1", dbağlanti);
            bağlan.Parameters.AddWithValue("@p1", Kullanıcıadı.Text);

            SqlDataReader dt = bağlan.ExecuteReader();
            while (dt.Read())
            {
                labelisim.Text = dt[1].ToString();
                labelsoyad.Text = dt[2].ToString();
                labelskor.Text = dt[6].ToString();
                label9.Text = dt[7].ToString();

            }
            dbağlanti.Close();
            // Kullanıcı Bilgileri Çekme

           
            label4.Text = labelskor.Text;





        }
    }
}
