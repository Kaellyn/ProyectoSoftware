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
    public partial class ActualizarCliente : Form
    {
        String buscador;
        String updateCedula, updatePNom, updateSNom, updatePApell, updateSApell, updateDir, updateTel;
        public ActualizarCliente()
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
            buscador = actualizarClie.Text;
            if (buscador == "")
            {
                actualizar.Enabled = false;
                MessageBox.Show("No se ingreso Nombre ");
            }
            else
            {
                actualizar.Enabled = true;
                MessageBox.Show("Datos del Cliente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateCedula = updC.Text;
            updatePNom = updpn.Text;
            updateSNom = updsn.Text;
            updatePApell = updpa.Text;
            updateSApell = updsa.Text;
            updateDir = upddir.Text;
            updateTel = updtel.Text;

            if (updateCedula == "" || updatePNom == "" || updateSNom == "" || updatePApell == "" || updateSApell == "" || updateDir == "" || updateTel == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                DialogResult opcion = MessageBox.Show("Desea Actualizar Cliente?", "Exit", MessageBoxButtons.YesNo);

                if (opcion == DialogResult.Yes)
                {
                    actualizar.Enabled = false;
                    MessageBox.Show("Se Actualizo Exitosamente");
                }
                else
                {
                    actualizar.Enabled = true;
                    MessageBox.Show("NO Se Actualizo Cliente");
                }
            }


           
        }

        private void ActualizarCliente_Load(object sender, EventArgs e)
        {
            actualizar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloNumeros(e);
        }
    }
}
