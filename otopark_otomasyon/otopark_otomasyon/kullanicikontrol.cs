using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark_otomasyon
{
    public partial class kullanicikontrol : Form
    {
        public kullanicikontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k_adi = "ilknur";
            string Parola = "123456";
            if (k_adi == textBox1.Text && Parola == textBox2.Text)
            {
                Form1 yeni = new Form1();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı !");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void kullanicikontrol_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
