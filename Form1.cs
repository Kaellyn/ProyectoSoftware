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
            AbrirFormulario<AsistenciasGimnasio>();
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            
         //       this.WindowState = FormWindowState.Maximized;

                Bienvenida bienvenida = new Bienvenida();
                bienvenida.TopLevel = false;
                bienvenida.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(bienvenida);
                this.panelContenedor.Tag = bienvenida;
                bienvenida.Show();
                bienvenida.BringToFront();

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

        private void renovarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Renovar_NuevaSuscripcion>();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultarGimnasio>();
        }

        private void diarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<DiarioGimnasio>();
        }

        private void registrarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AsistenciaEntrenadorGim>();
        }

        private void nuevoEntrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<NuevoEntrenadorGim>();
        }

        private void actualizarDatosEntrenador_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ActualizarEntrenadorGim>();
        }

        private void verEntrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VerEntrenadoresGim>();
        }

        private void eliminarEntrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EliminarEntrenadorGim>();
        }

        private void registrarAsistenciaAHToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirFormulario<AsistenciaAH>();
        }

        private void renovarNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Renovar_NuevoCursoAH>();
        }

        private void renovarNuevaTarjetaAHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Renovar_NuevaTarjetaAH>();
        }

        private void consultarAsistenciasAHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultarAsistenciasAH>();
        }

        private void diarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroDiarioAH>();
        }

        private void asistenciaInstructorAHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AsistenciaInstructorAH>();
        }

        private void nuevoInstructorAHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<NuevoInstructorAH>();
        }

        private void actualizarDatosInstructorAHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ActualizarDatosInstruAH>();
        }

        private void verInstructoresAHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VerInstructoresAH>();
        }

        private void eliminarInstructorAHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EliminarInstructorAH>();
        }
    }
}
