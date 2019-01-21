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
    public partial class NuevoEntrenadorGim : Form
    {
        public NuevoEntrenadorGim()
        {
            InitializeComponent();
            dia1.SelectedIndex = 0;
            dia2.SelectedIndex = 0;
            dia3.SelectedIndex = 0;
            dia4.SelectedIndex = 0;
            dia5.SelectedIndex = 0;
            dia6.SelectedIndex = 0;
            dia7.SelectedIndex = 0;
            dia8.SelectedIndex = 0;
            dia9.SelectedIndex = 0;
            dia10.SelectedIndex = 0;

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuevoEntrenadorGim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String horarios = "";
            bool error = false;
            String causa = "";

            //YA NADAAAAAA

            if (!dia1.SelectedItem.Equals("-----------")){
                
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
            if (!dia8.SelectedItem.Equals("-----------"))
            {

                if (horaInicio8.Text.Equals("Hora Inicio") || horaFin8.Text.Equals("Hora Fin") || horaInicio8.SelectedIndex >= horaFin8.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia8.SelectedItem + " de " + horaInicio8.Text + " a " + horaFin8.Text + "\n";
            }
            if (!dia9.SelectedItem.Equals("-----------"))
            {

                if (horaInicio9.Text.Equals("Hora Inicio") || horaFin9.Text.Equals("Hora Fin") || horaInicio9.SelectedIndex >= horaFin9.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia9.SelectedItem + " de " + horaInicio9.Text + " a " + horaFin9.Text + "\n";
            }
            if (!dia10.SelectedItem.Equals("-----------"))
            {

                if (horaInicio10.Text.Equals("Hora Inicio") || horaFin10.Text.Equals("Hora Fin") || horaInicio10.SelectedIndex >= horaFin10.SelectedIndex)
                    error = true;
                else
                    horarios += "\tDia " + dia10.SelectedItem + " de " + horaInicio10.Text + " a " + horaFin10.Text + "\n";
            }


            String dialogo = "Se registrará un nuevo Entrenador de Gimnasio con los siguientes datos:\n\n\n" +
                "Nombre: " + textBox4.Text + " " + textBox2.Text + "\n" +
                "CI: " + textBox1.Text + "\n" +
                "Telefono: " + textBox3.Text + "\n" +
                "Direccion: " + textBox5.Text + "\n" +
                "En los horarios de:\n" + horarios + "\n" +
                "Fecha de Registro: " + dateTimePicker3.Text + "\n" +
                "\n¿Esta seguro de realizar esta accion?";

            int countSpaces = textBox1.Text.Count(Char.IsWhiteSpace);
            int countWords = textBox1.Text.Split().Length;

            causa = error == true ? "Ingreso de Hora de inicio u Hora de Fin erroneo " : causa;

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
                    "Por favor verifique que todas las horas han sido ingresadas correctamente.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (countSpaces <= 0 && countWords == 1)
                {
                    DialogResult dialogResult = MessageBox.Show(dialogo, "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
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
            new Validar().SoloNumerosSeguidos(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloNumerosSeguidos(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
