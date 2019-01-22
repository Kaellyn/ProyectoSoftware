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
    public partial class ActualizarParametro : Form
    {
        public float mensualGym, diarioGym, veinteGym, doceGym, mensualPis, diarioPis, veintePis, docePis;

        private void dGym_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.NumerosDecimales(e);
        }

        private void mPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.NumerosDecimales(e);
        }

        private void dPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.NumerosDecimales(e);
        }

        private void dGym_TextChanged(object sender, EventArgs e)
        {

        }

        private void vGym_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.NumerosDecimales(e);
        }

        private void docGym_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.NumerosDecimales(e);
        }

        private void vPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.NumerosDecimales(e);
        }

        private void docPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.NumerosDecimales(e);
        }

        private void mGym_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.NumerosDecimales(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mGym.Enabled = true;
            dGym.Enabled = true;
            vGym.Enabled = true;
            docGym.Enabled = true;
            mPis.Enabled = true;
            dPis.Enabled = true;
            vPis.Enabled = true;
            docPis.Enabled = true;
        }

        public ActualizarParametro()
        {
            InitializeComponent();

            bloquear();
        }

        public void bloquear()
        {
            mGym.Enabled = false;
            dGym.Enabled = false;
            vGym.Enabled = false;
            docGym.Enabled = false;
            mPis.Enabled = false;
            dPis.Enabled = false;
            vPis.Enabled = false;
            docPis.Enabled = false;
        }

        private void Parametro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mGym.Text == "" || dGym.Text == "" || vGym.Text == "" || docGym.Text == "" || mPis.Text == "" || dPis.Text == "" || vPis.Text == ""||docPis.Text=="")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                DialogResult opcion = MessageBox.Show("Desea Modificar los Datos?", "Exit", MessageBoxButtons.YesNo);

                if (opcion == DialogResult.Yes)
                {
                    MessageBox.Show("Se Actualizo Exitosamente");
                }
                else
                {
                    MessageBox.Show("No se Actualizo");
                }

            }
        }
    }
}
