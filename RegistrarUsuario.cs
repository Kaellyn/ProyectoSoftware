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
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProyectoSoftware
{
    public partial class RegistrarUsuario : Form
    {
        String pNombre,sNombre, pApellido,sApellido, cedula, telefono, login, password, verificarPass;
        String valCombo;
        SqlCommand cmd;

        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void snombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloLetras(e);
        }

        private void pApellidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloLetras(e);
        }

        private void sApellidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloLetras(e);
        }

        private void snombreTxt_Enter(object sender, EventArgs e)
        {
           // snombreTxt.Clear();
        }

        private void pApellidoTxt_Enter(object sender, EventArgs e)
        {
          //  pApellidoTxt.Clear();
        }

        private void sApellidoTxt_Enter(object sender, EventArgs e)
        {
           // sApellidoTxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnom.Clear();
            snom.Clear();
            papellid.Clear();
            sapellid.Clear();
            ced.Clear();
            tel.Clear();
            log.Clear();
            pass.Clear();
            verpass.Clear();
           
        }

        private void pnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloLetras(e);
        }

        private void snom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloLetras(e);
        }

        private void ced_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloNumeros(e);
        }

        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloNumeros(e);
        }

       private void opciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            opciones.SelectedIndexChanged += new System.EventHandler(opciones_SelectedIndexChanged);
        }

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

        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            //pnombreTxt.Clear();
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

            //pnombreTxt.Text = "PrimerNombre";
            //snombreTxt.Text = "SegundoNombre";
            //pApellidoTxt.Text = "PrimerApellido";
            //sApellidoTxt.Text = "SegundoApellido";

           // opciones.Items.Add("");
            opciones.Items.Add("Administrador");
            opciones.Items.Add("Usuario");
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            pNombre = pnom.Text;
            sNombre = snom.Text;
            pApellido = papellid.Text;
            sApellido = sapellid.Text;
            cedula = ced.Text;
            telefono = tel.Text;
            login = log.Text;
            password = pass.Text;
            verificarPass = verpass.Text;
            

            
            ConexionSqlServer cn = new ConexionSqlServer();
          
               // valCombo = opciones.SelectedItem.ToString();

          


            if (pNombre == "" || sNombre == "" || pApellido == "" || sApellido == "" || cedula == "" || telefono == "" || login == "" || password == "" || verificarPass == "" || opciones.SelectedItem==null )
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else if (password == verificarPass)
                {
                    DialogResult opcion = MessageBox.Show("Desea Registrar Usuario?", "Exit", MessageBoxButtons.YesNo);

                    if (opcion == DialogResult.Yes)
                    {
                        //insertar en la atabla

                        try
                        {
                            cmd = new SqlCommand("insert into usuario(cedula,pnombre,snombre,papellido,sapellido,telefono,logins,passwords) " +
                                "values ('" + cedula + "','" + pNombre + "','" + sNombre + "','" + pApellido + "','" + sApellido + "','" + telefono + "','" + login + "','" + password + "')", cn.AbrirConexion());
                            cmd.ExecuteNonQuery();
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine("no se inserto" + ex.ToString());
                        }

                        
                        MessageBox.Show("Registro Exitoso");
                    cn.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("NO se Registro Usuario");
                    }

                }
                else
                {

                    MessageBox.Show("Password incorrectos");
                }

            

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
