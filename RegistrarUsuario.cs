using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoftware
{
    public partial class RegistrarUsuario : Form
    {
        String nombres, apellidos, cedula, telefono, login, password, verificarPass;

        private void nombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloLetras(e);
        }

        private void apellidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloLetras(e);
        }

        private void cedulaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedulaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloNumeros(e);
        }

        private void telefonoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloNumeros(e);
        }

        private void nombreTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        public RegistrarUsuario()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {

            nombres = nombreTxt.Text;
            apellidos = apellidoTxt.Text;
            cedula = cedulaTxt.Text;
            telefono = telefonoTxt.Text;
            login = loginTxt.Text;
            password = passwordTxt.Text;
            verificarPass = vpasswordTxt.Text;

            if (nombres == ""||apellidos==""||cedula==""||telefono==""||login==""||password==""||verificarPass=="")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                DialogResult opcion = MessageBox.Show("Desea Registrar Usuario?", "Exit", MessageBoxButtons.YesNo);

                if (opcion == DialogResult.Yes)
                {
                    MessageBox.Show("Registro Exitoso");
                }
                else
                {
                    MessageBox.Show("NO se Registro Usuario");
                }

            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
