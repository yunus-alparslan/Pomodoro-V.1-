using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Frmpamadro : Form
    {
        public Frmpamadro()
        {
            InitializeComponent();
        }

        // DEĞİŞKENLER
        int skip = 0;

        public string kullanıcıadi;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Frmpamadro_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            skip++;

            if (skip == 1)
            {
                pictureBoxresim1.Visible = false;
                richTextBoxbilgi.Visible = false;
            
                pictureBox1.Visible = true;
                richTextBox1.Visible = true;
            }
            else
            {
                FrmPamadroCalıs frmcalıs = new FrmPamadroCalıs();
                frmcalıs.kullanıcıadi = kullanıcıadi;
                frmcalıs.Show();
                this.Hide();
            }
        }
    }
}
