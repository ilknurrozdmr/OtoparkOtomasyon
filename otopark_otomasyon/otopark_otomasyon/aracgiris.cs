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
    public partial class aracgiris :Form
    {
        otoparkEntities4 db = new otoparkEntities4();
        public aracgiris()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kayit ekle = new kayit();
            ekle.ParkAlan=(string)comboBox1.SelectedItem;
            ekle.SahipAdı = textBox1.Text;
            ekle.SahipSoyadı = textBox2.Text;
            ekle.plaka = textBox4.Text;
            ekle.marka = textBox5.Text;
            ekle.model = textBox6.Text;
            ekle.GirisSaati = dateTimePicker1.Value;
            //ekle.CıkısSaati =(DateTime)comboBox2.SelectedItem;
            db.kayits.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Kayıt Eklendi");
            


            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }



        
    }
}
