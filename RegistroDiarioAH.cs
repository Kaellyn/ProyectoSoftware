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
    public partial class RegistroDiarioAH : Form
    {
        public RegistroDiarioAH()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            String dialogo = "Se registrará un Ingreso Diario al Área Húmeda del cliente:\n\n" +
                "Nombre del Cliente: " + textBox2.Text + " " + textBox7.Text + "\n" +
                "CI del Cliente: " + textBox1.Text + "\n" +
                "Fecha: " + dateTimePicker1.Value.ToString() + "\n\n" +
                "¿Está seguro de realizar esta acción?";


            int countSpaces = textBox1.Text.Count(Char.IsWhiteSpace); // 6
            int countWords = textBox1.Text.Split().Length; // 7

            String causa = "";
            bool error = false;
            //foreach (Control tb in tableLayoutPanel2.Controls)
            //{
            //    if (tb is TextBox && ((TextBox)tb).Text.Equals(""))
            //    {
            //        causa = error == true ? causa + "y Existe un campo vacio" : "Existe un campo vacio";
            //        error = true;
            //        break;
            //    }

            //}
            if (error == true)
            {
                DialogResult dialogResult = MessageBox.Show(causa + ".\n\n" +
                    "Por favor verifique que todos los campos han sido ingresados correctamente.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (countSpaces <= 0 && countWords == 1)
                {
                    DialogResult dialogResult = MessageBox.Show(dialogo, "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dialogResult = MessageBox.Show("Ingreso Diario Registrado con exito", "Informacion", MessageBoxButtons.OK);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloNumerosSeguidos(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloLetras(e);
        }
    }
}
