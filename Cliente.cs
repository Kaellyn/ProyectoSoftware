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
    public partial class Cliente : Form
    {
        String cedulaC, primerNom, segundoNom, primerApell, segundoApell, direccion, telefono;

        public Cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cedulaC = cedC.Text;
            primerNom = nompC.Text;
            segundoNom = nomsC.Text;
            primerApell = apellpC.Text;
            segundoApell = apellsC.Text;
            direccion = dirC.Text;
            telefono = telC.Text;

            if (cedulaC == "" || primerNom == "" || segundoNom == "" || primerApell == "" || segundoApell == "" || direccion == "" || telefono == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else 
            {
                DialogResult opcion = MessageBox.Show("Desea Registrar Usuario?", "Exit", MessageBoxButtons.YesNo);

                if (opcion == DialogResult.Yes)
                {
                    MessageBox.Show("Registro Exitoso");
                }
                else
                {
                    MessageBox.Show("NO se Registro Usuario");
                }

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            nompC.Text = "";
            nomsC.Text = "";
            apellpC.Text = "";
            apellsC.Text = "";
            cedC.Text = "";
            dirC.Text = "";
            telC.Text = "";
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

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar val = new Validar();
            val.SoloNumeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
               
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
