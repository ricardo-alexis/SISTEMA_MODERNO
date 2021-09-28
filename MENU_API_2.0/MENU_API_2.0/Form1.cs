using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;


namespace MENU_API_2._0
{
    public partial class Form1 : Form
    {
        public static string valueText1 = "";
        public static string valueText2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void sesion()
        {
            valueText1 = usertxt.Text;
            string password = passtxt.Text;

            if (valueText1 == "" && valueText2 == "")
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
            if (usertxt.Text == "EQUIPO_AV" && passtxt.Text == "admin01")
            {

                valueText1 = usertxt.Text;
                this.Hide();
                Form2 loading = new Form2();
                loading.ShowDialog();
                password = passtxt.Text;
                valueText2 = usertxt.Text;
                Form4 interfaz = new Form4();
                interfaz.Show();

            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO");
            }


        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            sesion();
            
        }

        private void btnlogi_Click(object sender, EventArgs e)
        {

            Form3 btninvitado = new Form3();
            btninvitado.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }



    }
