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
    public partial class Renovar_NuevoCursoAH : Form
    {
        public Renovar_NuevoCursoAH()
        {
            InitializeComponent();
            dia1.SelectedIndex = 0;
            dia2.SelectedIndex = 0;
            dia3.SelectedIndex = 0;
            dia4.SelectedIndex = 0;
            dia5.SelectedIndex = 0;
            dia6.SelectedIndex = 0;
            dia7.SelectedIndex = 0;
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            String tipoMembre = checkedButton.Text;
            String fechaFinalizacion = DateTime.Now.AddMonths(3).ToString(); ;
            if (checkedButton.Text.ToString().Equals("Mensual"))
                fechaFinalizacion = DateTime.Now.AddMonths(1).ToString();
            String horarios = "";
            bool error = false;
            String causa = "";

            //YA NADAAAAAA

            if (!dia1.SelectedItem.Equals("-----------"))
            {

                if (horaInicio1.Text.Equals("Hora Inicio") || horaFin1.Text.Equals("Hora Fin") || horaInicio1.SelectedIndex >= horaFin1.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia1.SelectedItem + " de " + horaInicio1.Text + " a " + horaFin1.Text + "\n";
            }
            if (!dia2.SelectedItem.Equals("-----------"))
            {

                if (horaInicio2.Text.Equals("Hora Inicio") || horaFin2.Text.Equals("Hora Fin") || horaInicio2.SelectedIndex >= horaFin2.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia2.SelectedItem + " de " + horaInicio2.Text + " a " + horaFin2.Text + "\n";
            }
            if (!dia3.SelectedItem.Equals("-----------"))
            {

                if (horaInicio3.Text.Equals("Hora Inicio") || horaFin3.Text.Equals("Hora Fin") || horaInicio3.SelectedIndex >= horaFin3.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia3.SelectedItem + " de " + horaInicio3.Text + " a " + horaFin3.Text + "\n";
            }
            if (!dia4.SelectedItem.Equals("-----------"))
            {

                if (horaInicio4.Text.Equals("Hora Inicio") || horaFin4.Text.Equals("Hora Fin") || horaInicio4.SelectedIndex >= horaFin4.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia4.SelectedItem + " de " + horaInicio4.Text + " a " + horaFin4.Text + "\n";
            }
            if (!dia5.SelectedItem.Equals("-----------"))
            {

                if (horaInicio5.Text.Equals("Hora Inicio") || horaFin5.Text.Equals("Hora Fin") || horaInicio5.SelectedIndex >= horaFin5.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia5.SelectedItem + " de " + horaInicio5.Text + " a " + horaFin5.Text + "\n";
            }
            if (!dia6.SelectedItem.Equals("-----------"))
            {

                if (horaInicio6.Text.Equals("Hora Inicio") || horaFin6.Text.Equals("Hora Fin") || horaInicio6.SelectedIndex >= horaFin6.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia6.SelectedItem + " de " + horaInicio6.Text + " a " + horaFin6.Text + "\n";
            }
            if (!dia7.SelectedItem.Equals("-----------"))
            {

                if (horaInicio7.Text.Equals("Hora Inicio") || horaFin7.Text.Equals("Hora Fin") || horaInicio7.SelectedIndex >= horaFin7.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia7.SelectedItem + " de " + horaInicio7.Text + " a " + horaFin7.Text + "\n";
            }

            String dialogo = "Se registrará un nuevo curso de Natación con la siguiente informacion:\n\n" +
                "Nombres del Cliente: " + textBox2.Text + "\n" +
                "CI del Cliente: " + textBox1.Text + "\n" +
                "Nivel del Curso: " + tipoMembre + "\n" +
                "Fecha de Inicio: " + dateTimePicker3.Value.ToString() + "\n" +
                "Fecha de Finalizacion: " + dateTimePicker3.Value.AddMonths(3) + "\n" +
                "En los horarios de:\n" + horarios + "\n" +
                "\n¿Esta seguro de realizar esta accion?";

            int countSpaces = textBox1.Text.Count(Char.IsWhiteSpace); // 6
            int countWords = textBox1.Text.Split().Length; // 7
            
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
                        dialogResult = MessageBox.Show("Suscripción registrada con éxito", "Informacion", MessageBoxButtons.OK);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
