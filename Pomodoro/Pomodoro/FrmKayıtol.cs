using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Pomodoro
{
    public partial class FrmKayıtol : Form
    {
        public FrmKayıtol()
        {
            InitializeComponent();
        }

        SqlConnection dbağlanti = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=Pomadro;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSİFRE.Text == textBoxSİFRE1.Text)
            {

                dbağlanti.Open();
                SqlCommand kayitoll = new SqlCommand("insert into Table_Hesaplar(Ad,Soyad,KullanıcıAd,Sifre,Cinsiyet) values(@p1,@p2,@p3,@p4,@p5)", dbağlanti);
                kayitoll.Parameters.AddWithValue("@p1", textBoxAD.Text);
                kayitoll.Parameters.AddWithValue("@p2", textBoxSOYAD.Text);
                kayitoll.Parameters.AddWithValue("@p3", textBoxKULLANICIAD.Text);
                kayitoll.Parameters.AddWithValue("@p4", textBoxSİFRE.Text);
                kayitoll.Parameters.AddWithValue("@p5", comboBoxCİNSİYET.Text);
                kayitoll.ExecuteNonQuery();
                dbağlanti.Close();
                MessageBox.Show("Başarılı Şekilde Hesap Oluşturuldun Login Ekranına Yönlendiriyorum", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmamaktadır !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              

            }
         
 
        }

        private void FrmKayıtol_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
