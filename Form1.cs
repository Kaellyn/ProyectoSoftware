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
            AbrirFormEnPanel<Form2>();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void administracionDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gimansioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        /*private void AbrirPanelM(object formM)
        {
            if (this.panelcontrol.Controls.Count > 0)
                this.panelcontrol.Controls.RemoveAt(0);

            Form fh = formM as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontrol.Controls.Add(fh);
            this.panelcontrol.Tag = fh;
            fh.Show();
        }*/
        private void panelcontrol_Paint(object sender, PaintEventArgs e)
        {
           // AbrirPanelM(new Form2());
        }
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelcontrol.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelcontrol.Controls.Add(formulario);
                panelcontrol.Tag = formulario;
                formulario.Show();
            }
            else { 
                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
                }

        }
    }
}
