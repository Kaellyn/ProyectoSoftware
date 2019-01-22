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
    public partial class Renovar_NuevaTarjetaAH : Form
    {
        public Renovar_NuevaTarjetaAH()
        {
            InitializeComponent();
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            radioButton2.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            String tipoMembre = checkedButton.Text;
            String fechaFinalizacion = DateTime.Now.AddMonths(3).ToString(); ;
            if (checkedButton.Text.ToString().Equals("Mensual"))
                fechaFinalizacion = DateTime.Now.AddMonths(1).ToString();

            dateTimePicker3.Value = DateTime.Now;
            String dialogo = "Se registrará una nueva tarjeta para el Área Húmeda con la siguiente información:\n\n" +
                "Nombres del Cliente: " + textBox2.Text + "\n" +
                "CI del Cliente: " + textBox1.Text + "\n" +
                "Tipo de Membresia: " + tipoMembre + "\n" +
                "Fecha de Inicio: " + dateTimePicker3.Value.ToString() + "\n" +
                "Fecha de Finalizacion: " + fechaFinalizacion + "\n\n" +
                "¿Esta seguro de realizar esta accion?";

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
                    DialogResult dialogResult = MessageBox.Show(dialogo, "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dialogResult = MessageBox.Show("Tarjeta Registrada con exito", "Informacion", MessageBoxButtons.OK);
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
    }
}
