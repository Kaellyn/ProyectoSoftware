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

        private void administracionDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistrarUsuario>();

            //RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //registrarUsuario.TopLevel = false;
            //registrarUsuario.Dock = DockStyle.Top;
            //registrarUsuario.AutoSize = false;
            //this.panelContenedor.Controls.Add(registrarUsuario);
            //this.panelContenedor.Tag = registrarUsuario;
            //registrarUsuario.Show();

        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultarUsuario>();

            //ConsultarUsuario consultar = new ConsultarUsuario();

            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //consultar.TopLevel = false;
            //consultar.Dock = DockStyle.Top;
            //consultar.AutoSize = false;
            //this.panelContenedor.Controls.Add(consultar);
            //this.panelContenedor.Tag = consultar;
            //consultar.Show();


        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EliminarUsuario>();

            //EliminarUsuario eliminarUsuario = new EliminarUsuario();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //eliminarUsuario.TopLevel = false;
            //eliminarUsuario.Dock = DockStyle.Top;
            //eliminarUsuario.AutoSize = false;
            //this.panelContenedor.Controls.Add(eliminarUsuario);
            //this.panelContenedor.Tag = eliminarUsuario;
            //eliminarUsuario.Show();


        }

        private void registrarParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ActualizarParametro>();

            //ActualizarParametro ActualizarParametro = new ActualizarParametro();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //ActualizarParametro.TopLevel = false;
            //ActualizarParametro.Dock = DockStyle.Top;
            //ActualizarParametro.AutoSize = false;
            //this.panelContenedor.Controls.Add(ActualizarParametro);
            //this.panelContenedor.Tag = ActualizarParametro;
            //ActualizarParametro.Show();
        }

        private void eliminarParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ActualizarUsuario>();

            //ActualizarUsuario actualizarUsuario = new ActualizarUsuario();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //actualizarUsuario.TopLevel = false;
            //actualizarUsuario.Dock = DockStyle.Top;
            //actualizarUsuario.AutoSize = false;
            //this.panelContenedor.Controls.Add(actualizarUsuario);
            //this.panelContenedor.Tag = actualizarUsuario;
            //actualizarUsuario.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Cliente>();

            //Cliente cliente = new Cliente();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //cliente.TopLevel = false;
            //cliente.Dock = DockStyle.Top;
            //cliente.AutoSize = false;
            //this.panelContenedor.Controls.Add(cliente);
            //this.panelContenedor.Tag = cliente;
            //cliente.Show();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultarCliente>();

            //ConsultarCliente consultar = new ConsultarCliente();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //consultar.TopLevel = false;
            //consultar.Dock = DockStyle.Top;
            //consultar.AutoSize = false;
            //this.panelContenedor.Controls.Add(consultar);
            //this.panelContenedor.Tag = consultar;
            //consultar.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EliminarCliente>();

            //EliminarCliente eliminar = new EliminarCliente();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //eliminar.TopLevel = false;
            //eliminar.Dock = DockStyle.Top;
            //eliminar.AutoSize = false;
            //this.panelContenedor.Controls.Add(eliminar);
            //this.panelContenedor.Tag = eliminar;
            //eliminar.Show();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ActualizarCliente>();

            //ActualizarCliente actualizar = new ActualizarCliente();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //actualizar.TopLevel = false;
            //actualizar.Dock = DockStyle.Top;
            //actualizar.AutoSize = false;
            //this.panelContenedor.Controls.Add(actualizar);
            //this.panelContenedor.Tag = actualizar;
            //actualizar.Show();
        }

        private void piscinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InstalacionPiscina>();

            //InstalacionPiscina piscina = new InstalacionPiscina();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);

            //piscina.TopLevel = false;
            //piscina.Dock = DockStyle.Top;
            //piscina.AutoSize = false;
            //this.panelContenedor.Controls.Add(piscina);
            //this.panelContenedor.Tag = piscina;
            //piscina.Show();
        }
    }
}
