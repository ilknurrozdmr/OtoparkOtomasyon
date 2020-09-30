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
using System.Data.SqlClient;

namespace otopark_otomasyon
{
    public partial class kayitlar : Form
    {
        public kayitlar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\İlknur Özdemir\Desktop\otomasyon ödev\otopark_otomasyon\otopark_otomasyon\otopark.mdf';Integrated Security=True");
        DataTable tablo = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        private void kayitlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otoparkDataSet.musteri' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'database1DataSet.musteri' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'otoparkDataSet.kayit' table. You can move, or remove it, as needed.
            con.Open();
            SqlCommand gstr = new SqlCommand("select * from kayit",con);
            da.SelectCommand = gstr;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from kayit where plaka='" + textBox1.Text + "'", con);
            da.SelectCommand = cmd;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
    }
}
