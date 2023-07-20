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

namespace _7.Porje_Kelime_Öğren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1DQCP20\SQLEXPRESS;Initial Catalog=7.project.DbDictionary;Integrated Security=True");
        Random rn = new Random();
        int sure = 300;
        int sure2 = 50;
        int kelime = 0;
        public int TALEP;
       
        void getir()
        {
            int sayi;
            sayi = rn.Next(2490);
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from sozluk where id = @p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {

                TxtIngilizce.Text = dr[1].ToString();
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();

            }
            baglanti.Close();

        }
        
        private void Form1_Load(object sender, EventArgs e)
            
        {
            getir();
            TxtTurkce.Focus();
            timer1.Start();
          
            label8.Text = timer1.Interval.ToString();
            anaForm2 CKD = new anaForm2();
           



    }

        private void TxtTurkce_TextChanged(object sender, EventArgs e)
        {
           
            if (TxtTurkce.Text == LblCevap.Text)
            {
                kelime++;
                LblKelime.Text = kelime.ToString();
                getir();
                TxtTurkce.Clear();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();
            if (sure == 0)
            {
                TxtTurkce.Enabled = false;
                TxtIngilizce.Enabled = false;
                timer1.Stop();
                
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            getir();
            LblCevap.Visible = false;
            label5.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            timer2.Start();
            LblCevap.Visible = true;
            label5.Visible = false;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure2--;
            l7.Text = sure2.ToString();

            if (sure2 == 0)
            {
                LblCevap.Visible = false;
                label5.Visible = true;
                timer2.Stop();
                sure2 = 45;
            }
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            anaForm2 TC = new anaForm2();
            TC.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SONUCLAR tık = new SONUCLAR();
            tık.Show();
            this.Hide();
        }
    }
}
