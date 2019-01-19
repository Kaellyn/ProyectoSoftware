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
    public partial class Form1 : Form
    {
        public Form1()
        {
            Console.WriteLine("Hola");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void administracionDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            registrarUsuario.TopLevel = false;
            registrarUsuario.Dock = DockStyle.Top;
            registrarUsuario.AutoSize = false;
            this.panelContenedor.Controls.Add(registrarUsuario);
            this.panelContenedor.Tag = registrarUsuario;
            registrarUsuario.Show();

        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuario consultar = new ConsultarUsuario();

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            consultar.TopLevel = false;
            consultar.Dock = DockStyle.Top;
            consultar.AutoSize = false;
            this.panelContenedor.Controls.Add(consultar);
            this.panelContenedor.Tag = consultar;
            consultar.Show();


        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarUsuario = new EliminarUsuario();
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            eliminarUsuario.TopLevel = false;
            eliminarUsuario.Dock = DockStyle.Top;
            eliminarUsuario.AutoSize = false;
            this.panelContenedor.Controls.Add(eliminarUsuario);
            this.panelContenedor.Tag = eliminarUsuario;
            eliminarUsuario.Show();


        }

        private void registrarParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarParametro ActualizarParametro = new ActualizarParametro();
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            ActualizarParametro.TopLevel = false;
            ActualizarParametro.Dock = DockStyle.Top;
            ActualizarParametro.AutoSize = false;
            this.panelContenedor.Controls.Add(ActualizarParametro);
            this.panelContenedor.Tag = ActualizarParametro;
            ActualizarParametro.Show();
        }

        private void eliminarParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
