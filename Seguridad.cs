using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoftware
{
    public partial class Seguridad : Form
    {
        public String login, password;

        public Seguridad()
        {

            InitializeComponent();

            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 20;

        }

        public Seguridad(String login, String password)
        {
            this.login = login;
            this.password = password;

        }

        private void Seguridad_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        public void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            password = textBox2.Text;
            if (login == "" || password == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if(login == "jona" && password == "mds")
            {
                MessageBox.Show("Ingreso al sistema");
            }
            else 
            {
                MessageBox.Show("Login o Password Incorrectos");
            }
        }
        public void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
