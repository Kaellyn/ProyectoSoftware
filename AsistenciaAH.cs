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
    public partial class AsistenciaAH : Form
    {
        public AsistenciaAH()
        {
            InitializeComponent();
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker3.Value = DateTime.Now;
            String dialogo = "Se registrará la asistencia al Area Humeda del cliente:\n\n" +
                "Nombre del Cliente: " + textBox2.Text + "\n" +
                "CI del Cliente: " + textBox1.Text + "\n" +
                "Fecha: " + dateTimePicker3.Value.ToString() + "\n\n" +
                "¿Está seguro de realizar esta acción?";

            int countSpaces = textBox1.Text.Count(Char.IsWhiteSpace); // 6
            int countWords = textBox1.Text.Split().Length; // 7

            String causa = "";
            bool error = false;
            foreach (Control tb in tableLayoutPanel1.Controls)
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
                    "Por favor verifique que todos los campos han sido ingresados correctamente.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (countSpaces <= 0 && countWords == 1)
                {
                    DialogResult dialogResult = MessageBox.Show(dialogo, "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dialogResult = MessageBox.Show("Asistencia Registrada con éxito", "Información", MessageBoxButtons.OK);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    causa = "cedula";
                    DialogResult dialogResult = MessageBox.Show("Ingreso de " + causa + " incorrecto.\n\nPor favor ingreselo nuevamente.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.TextLength < 13)
            {
                new Validar().SoloNumerosSeguidos(e);
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    button1_Enter(sender, e);
            }
            else
            {
                new Validar().nadaIngreso(e);
                DialogResult dialogResult = MessageBox.Show("El numero de caracteres de la cedula" +
                    " debe ser menor o igual a 13.\n\n" +
                    "Por favor intentelo nuevamente.", "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.Focus();
            if (textBox1.Text.Equals("1"))
            {
                textBox2.Text = "Aguilar Quezada Henry Gonzalo";
                textBox4.Text = "Carapungo, Ciu. Alegria";
                textBox3.Text = "099584----";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
