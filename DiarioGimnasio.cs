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
    public partial class DiarioGimnasio : Form
    {
        public DiarioGimnasio()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            String dialogo = "Se registrara un Ingreso Diario al Gimnasio del cliente:\n\n" +
                "Nombre del Cliente: " + textBox2.Text +" "+ textBox7.Text + "\n" +
                "CI del Cliente: " + textBox1.Text + "\n" +
                "Fecha: " + dateTimePicker1.Value.ToString() + "\n\n" +
                "¿Esta seguro de realizar esta accion?";

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
    }
}
