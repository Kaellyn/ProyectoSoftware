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
    public partial class ConsultarCliente : Form
    {
        String consultar;

        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultar = consulCliente.Text;
            if (consultar == "")
            {
                MessageBox.Show("No se ingreso Nombre ");
            }
            else
            {
                MessageBox.Show("Datos del Usuario");
            }
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
