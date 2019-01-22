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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
                button3.Enabled = false;

            }
            else
            {
                monthCalendar1.Visible = false;

         
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
                button4.Enabled = false;


            }
            else
            {
                monthCalendar1.Visible = false;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (button3.Enabled == false)
            {
                textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
                monthCalendar1.Visible = false;
                button3.Enabled = true;
            }else if(button4.Enabled == false)
            {
                textBox4.Text = monthCalendar1.SelectionStart.ToShortDateString();
                monthCalendar1.Visible = false;
                button4.Enabled = true;
            }
           
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox4.Text))

            {
                string message = "Ingrese la fecha inicial y final";
                string caption = "No ingreso fechas";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);
                
            }
                
        }
    }
}
