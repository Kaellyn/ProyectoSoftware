﻿using System;
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
    public partial class AsistenciasGimnasio : Form
    {
        public AsistenciasGimnasio()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AsistenciasGimnasio_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validar().SoloNumerosSeguidos(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String dialogo = "Se registrara la asistencia al Gimnasio del cliente:\n\n\n" +
                "Nombre: "+textBox2.Text + "\n" +
                "CI: " + textBox1.Text + "\n" +
                "Fecha: " + dateTimePicker3.Text + "\n" +
                "En el horario de: " + textBox5.Text + "\n\n" +
                "¿Esta seguro de realizar esta accion?";

            int countSpaces = textBox1.Text.Count(Char.IsWhiteSpace); // 6
            int countWords = textBox1.Text.Split().Length; // 7


            if(countSpaces<=0 && countWords == 1)
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
                String causa = "cedula";
                DialogResult dialogResult = MessageBox.Show("Ingreso de "+causa+" incorrecto.\n\nPor favor ingreselo nuevamente.", "Error", MessageBoxButtons.OK);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
