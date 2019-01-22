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
    public partial class InstalacionPiscina : Form
    {
        public InstalacionPiscina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            pictureBox1.Image = Image.FromFile("ninos.jpg");
          
        }

        private void Instalacion_Load(object sender, EventArgs e)
        {
            ninos.Enabled = false;
            adultos.Enabled = false;
            semi.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("adultos.jpeg");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("semiolimpica.jpeg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
