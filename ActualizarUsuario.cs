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
    public partial class ActualizarUsuario : Form
    {
        String buscarUsuario;
        String updCeula, updPNombre, updSNombre, updPApellido, updSApellido, updateTipo, updTelefono;


        public ActualizarUsuario()
        {
            InitializeComponent();
        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {
            actualizar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarUsuario = busUsuario.Text;

            if (buscarUsuario == "")
            {
                actualizar.Enabled = false;
                MessageBox.Show("No se ingreso nombre");
            }
            else
            {
                actualizar.Enabled = true;
                MessageBox.Show("Datos del Usuario");

            }
        }

        private void busUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
                val.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloNumeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            updCeula = updCedu.Text;
            updPNombre = updPN.Text;
            updSNombre = updSN.Text;
            updPApellido = updPA.Text;
            updSApellido = updSA.Text;
            updateTipo = updTipo.Text;
            updTelefono = updTel.Text;

            if (updCeula == "" || updPNombre == "" || updSNombre == "" || updPApellido == "" || updSApellido == "" || updateTipo == "" || updTelefono == "" )
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else 
            {
                DialogResult opcion = MessageBox.Show("Desea Actualizar Usuario?", "Exit", MessageBoxButtons.YesNo);

                if (opcion == DialogResult.Yes)
                {

                    MessageBox.Show("Se Actualizo Exitosamente");
                }
                else
                {
                    MessageBox.Show("NO se Actualizo el Usuario");
                }

            }
            
        }
    }
}
