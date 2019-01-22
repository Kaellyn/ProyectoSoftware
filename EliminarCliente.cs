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
    public partial class EliminarCliente : Form
    {
        String buscador;
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            buscador = elimCliente.Text;
            if (buscador == "")
            {
                eliminar.Enabled = false;
                MessageBox.Show("No se ingreso Nombre ");
                
            }
            else
            {
                eliminar.Enabled = true;
                MessageBox.Show("Datos del Cliente");
                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult opcion = MessageBox.Show("Desea Eliminar Cliente?", "Exit", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                MessageBox.Show("Se Eliminó Exitosamente");
            }
            else
            {
                MessageBox.Show("NO Se Eliminó Cliente");
            }
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            eliminar.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
