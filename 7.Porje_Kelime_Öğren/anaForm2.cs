using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Porje_Kelime_Öğren
{
    public partial class anaForm2 : Form
    {
        public anaForm2()
        {
            InitializeComponent();
        }


        
        private void label4_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            FRM.Show();
            this.Hide();
            

        }

        private void TxtIngilizce_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must answer the Turkish equivalents of the words within the specified time and enter your name and surname to start.", "INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void anaForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
