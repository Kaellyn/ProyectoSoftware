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
    public partial class EliminarUsuario : Form
    {
        String buscador;

        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DialogResult opcion = MessageBox.Show("Desea Eliminar Usuario?", "Exit", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                MessageBox.Show("Se Eliminó Exitosamente");
            }
            else
            {
                MessageBox.Show("NO Se Eliminó Usuario");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscador = elimiUsuario.Text;
            if (buscador == "")
            {
                eliminar.Enabled = false;
                MessageBox.Show("No se ingreso Nombre ");
            }
            else
            {
                eliminar.Enabled = true;
                MessageBox.Show("Datos del Usuario");
            }
        }

        private void elimiUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloLetras(e);
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            eliminar.Enabled = false;
        }
    }
}