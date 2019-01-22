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
    public partial class Renovar_NuevaSuscripcion : Form
    {
        private bool focus = false;
        public Renovar_NuevaSuscripcion()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("1"))
            {
                textBox2.Text = "Henry";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloNumeros(e);

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            focus = true;
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            if (focus == true)
                button2_Click(sender,e);
        }
    }
}
