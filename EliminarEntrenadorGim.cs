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
    public partial class EliminarEntrenadorGim : Form
    {
        public EliminarEntrenadorGim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String dialogo = "Se eliminará de la base de datos el entrenador con los siguientes datos:\n\n" +
               "Nombre del Entrenador: " + textBox3.Text + " " + textBox5.Text + "\n" +
               "CI del Entrenador: " + textBox4.Text + "\n" +
               "Dirección: " + textBox2.Text + "\n" +
               "Teléfono: " + textBox1.Text + "\n\n" +
               "¿Está seguro de realizar esta acción?";


            int countSpaces = textBox1.Text.Count(Char.IsWhiteSpace);
            int countWords = textBox1.Text.Split().Length;

            String causa = "";
            bool error = false;

            foreach (Control tb in tableLayoutPanel2.Controls)
            {
                if (tb is TextBox && ((TextBox)tb).Text.Equals(""))
                {
                    causa = error == true ? causa + "y Existe un campo vacio" : "Existe un campo vacio";
                    error = true;
                    break;
                }
            }

            if (error == true)
            {
                DialogResult dialogResult = MessageBox.Show(causa + ".\n\n" +
                    "Por favor verifique que todas las horas han sido ingresadas correctamente.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (countSpaces <= 0 && countWords == 1)
                {
                    DialogResult dialogResult = MessageBox.Show(dialogo, "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dialogResult = MessageBox.Show("Entrenador eliminado de la base con éxito.", "Información", MessageBoxButtons.OK);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    causa = "cedula";
                    DialogResult dialogResult = MessageBox.Show("Ingreso de " + causa + " incorrecto." +
                        "\n\nPor favor ingréselo nuevamente.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloNumerosSeguidos(e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloLetras(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloNumeros(e);
        }
    }
}
