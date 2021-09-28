using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_API_2._0
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.valueText2;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 inicio = new Form1();
            inicio.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 inicio = new Form1();
            inicio.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form5 general = new Form5();
            general.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form6 category = new Form6();
            category.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form8 contact = new Form8();
            contact.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form7 pet = new Form7();
            pet.Show();
        }
    }
}
