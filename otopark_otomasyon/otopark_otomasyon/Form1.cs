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

namespace otopark_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            kayitlar yeni = new kayitlar();
            yeni.Show();
   
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kullanicikontrol yeni = new kullanicikontrol();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracgiris Yeni = new aracgiris();
            Yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            araccikis Yeni = new araccikis();
            Yeni.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            konum yeni = new konum();
            yeni.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            kullanicikontrol yeni = new kullanicikontrol();
            yeni.Show();

        }
    }
}
