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
    public partial class konum : Form
    {
        public konum()
        {
            InitializeComponent();
        }

        private void konum_Load(object sender, EventArgs e)
        {
            string bag_cum = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\İlknur Özdemir\Desktop\otomasyon ödev\otopark_otomasyon\otopark_otomasyon\otopark.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(bag_cum);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from parkyeri,kayit where parkyeri.ParkYeri=kayitlar.ParkAlan",con);
            SqlDataReader oku = cmd.ExecuteReader();
            while(oku.Read())
            {
                if (oku["p_yeri"].ToString() == "1.KAT A1")
                {
                    pictureBox19.BackColor = Color.Red;
                    label33.Text = oku["plaka"].ToString();
                    label1.BackColor = Color.Red;
                    label33.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="1.KAT A2")
                {
                    pictureBox1.BackColor = Color.Red;
                    label9.Text = oku["plaka"].ToString();
                    label2.BackColor = Color.Red;
                    label9.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="1.KAT A3")
                {
                    pictureBox4.BackColor = Color.Red;
                    label10.Text = oku["plaka"].ToString();
                    label3.BackColor = Color.Red;
                    label10.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="1.KAT A4")
                {
                    pictureBox6.BackColor = Color.Red;
                    label11.Text = oku["plaka"].ToString();
                    label4.BackColor = Color.Red;
                    label11.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="1.KAT A5")
                {
                    pictureBox5.BackColor = Color.Red;
                    label12.Text = oku["plaka"].ToString();
                    label5.BackColor = Color.Red;
                    label12.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="1.KAT A6")
                {
                    pictureBox25.BackColor = Color.Red;
                    label13.Text = oku["plaka"].ToString();
                    label6.BackColor = Color.Red;
                    label13.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="1.KAT A7")
                {
                    pictureBox23.BackColor = Color.Red;
                    label14.Text = oku["plaka"].ToString();
                    label7.BackColor = Color.Red;
                    label14.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="1.KAT A8")
                {
                    pictureBox24.BackColor = Color.Red;
                    label31.Text = oku["plaka"].ToString();
                    label8.BackColor = Color.Red;
                    label31.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="2.KAT B1")
                {
                    pictureBox14.BackColor = Color.Red;
                    label15.Text = oku["plaka"].ToString();
                    label17.BackColor = Color.Red;
                    label15.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="2.KAT B2")
                {
                    pictureBox13.BackColor = Color.Red;
                    label16.Text = oku["plaka"].ToString();
                    label18.BackColor = Color.Red;
                    label16.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="2.KAT B3")
                {
                    pictureBox10.BackColor = Color.Red;
                    label25.Text = oku["plaka"].ToString();
                    label19.BackColor = Color.Red;
                    label25.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="2.KAT B4")
                {
                    pictureBox17.BackColor = Color.Red;
                    label26.Text = oku["plaka"].ToString();
                    label20.BackColor = Color.Red;
                    label26.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="2.KAT B5")
                {
                    pictureBox15.BackColor = Color.Red;
                    label27.Text = oku["plaka"].ToString();
                    label21.BackColor = Color.Red;
                    label27.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="2.KAT B6")
                {
                    pictureBox30.BackColor = Color.Red;
                    label28.Text = oku["plaka"].ToString();
                    label22.BackColor = Color.Red;
                    label28.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="2.KAT B7")
                {
                    pictureBox32.BackColor = Color.Red;
                    label29.Text = oku["plaka"].ToString();
                    label23.BackColor = Color.Red;
                    label29.ForeColor = Color.Black;
                }
                if(oku["p_yeri"].ToString()=="2.KAT B8")
                {
                    pictureBox27.BackColor = Color.Red;
                    label30.Text = oku["plaka"].ToString();
                    label24.BackColor = Color.Red;
                    label30.ForeColor = Color.Black;
                }
            }
            con.Close();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();

        }

        

        

       
    }
}
