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
    public partial class ConsultarAsistenciasAH : Form
    {
        public ConsultarAsistenciasAH()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String dialogo = "";
            int countSpaces = textBox7.Text.Count(Char.IsWhiteSpace); // 6
            int countWords = textBox7.Text.Split().Length; // 7

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
                    "Por favor verifique que todos los campos han sido ingresados correctamente.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (countSpaces <= 3 && countWords <= 4)
                {

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
