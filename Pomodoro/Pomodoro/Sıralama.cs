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
    public partial class Sıralama : Form
    {
        public Sıralama()
        {
            InitializeComponent();
        }

        // Sql Database Bağlantısı
        SqlConnection dbağlanti = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=Pomadro;Integrated Security=True");
        // Sql Database Bağlantısı

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sıralama_Load(object sender, EventArgs e)
        {

           

            
        }
    }
}
