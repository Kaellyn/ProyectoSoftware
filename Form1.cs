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
            this.WindowState = FormWindowState.Maximized;
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.TopLevel = false;
            bienvenida.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(bienvenida);
            this.panelContenedor.Tag = bienvenida;
            bienvenida.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
           
            this.WindowState = FormWindowState.Maximized;
            AsistenciasGimnasio asisGim = new AsistenciasGimnasio();
            asisGim.TopLevel = false;
            asisGim.Dock = DockStyle.Fill;
            asisGim.AutoSize = false;
            asisGim.Anchor = AnchorStyles.Right | AnchorStyles.Left| AnchorStyles.Top | AnchorStyles.Bottom;
            this.panelContenedor.Controls.Add(asisGim);
            this.panelContenedor.Tag = asisGim;
            asisGim.Show();
            
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void renovarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            this.WindowState = FormWindowState.Maximized;
            Renovar_NuevaSuscripcion renovar = new Renovar_NuevaSuscripcion();
            renovar.TopLevel = false;
            renovar.Dock = DockStyle.Fill;
            renovar.AutoSize = false;
            renovar.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.panelContenedor.Controls.Add(renovar);
            this.panelContenedor.Tag = renovar;
            renovar.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            this.WindowState = FormWindowState.Maximized;
            ConsultarGimnasio consultar = new ConsultarGimnasio();
            consultar.TopLevel = false;
            consultar.Dock = DockStyle.Fill;
            consultar.AutoSize = false;
            consultar.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.panelContenedor.Controls.Add(consultar);
            this.panelContenedor.Tag = consultar;
            consultar.Show();
        }

        private void diarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            this.WindowState = FormWindowState.Maximized;
            DiarioGimnasio diario = new DiarioGimnasio();
            diario.TopLevel = false;
            diario.Dock = DockStyle.Fill;
            diario.AutoSize = false;
            diario.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.panelContenedor.Controls.Add(diario);
            this.panelContenedor.Tag = diario;
            diario.Show();
        }

        private void registrarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            this.WindowState = FormWindowState.Maximized;
            AsistenciaEntrenadorGim asistenciaEntrenadorGim = new AsistenciaEntrenadorGim();
            asistenciaEntrenadorGim.TopLevel = false;
            asistenciaEntrenadorGim.Dock = DockStyle.Fill;
            asistenciaEntrenadorGim.AutoSize = false;
            asistenciaEntrenadorGim.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.panelContenedor.Controls.Add(asistenciaEntrenadorGim);
            this.panelContenedor.Tag = asistenciaEntrenadorGim;
            asistenciaEntrenadorGim.Show();

        }

        private void nuevoEntrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            this.WindowState = FormWindowState.Maximized;
            NuevoEntrenadorGim nuevoEntrenadorGim = new NuevoEntrenadorGim();
            nuevoEntrenadorGim.TopLevel = false;
            nuevoEntrenadorGim.Dock = DockStyle.Fill;
            nuevoEntrenadorGim.AutoSize = false;
            nuevoEntrenadorGim.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.panelContenedor.Controls.Add(nuevoEntrenadorGim);
            this.panelContenedor.Tag = nuevoEntrenadorGim;
            nuevoEntrenadorGim.Show();
        }
    }
}
