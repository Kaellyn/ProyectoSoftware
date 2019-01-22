namespace ProyectoSoftware
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaHumedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gimansioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renovarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suscripcionMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEntrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEntrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEntrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionDeParametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instalacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.actualizarDatosEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.Location = new System.Drawing.Point(0, 27);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(825, 425);
            this.panelContenedor.TabIndex = 2;
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // areaHumedaToolStripMenuItem
            // 
            this.areaHumedaToolStripMenuItem.Name = "areaHumedaToolStripMenuItem";
            this.areaHumedaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.areaHumedaToolStripMenuItem.Text = "Area Humeda";
            // 
            // gimansioToolStripMenuItem
            // 
            this.gimansioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem,
            this.renovarNuevoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.diarioToolStripMenuItem,
            this.entrenamientoToolStripMenuItem});
            this.gimansioToolStripMenuItem.Name = "gimansioToolStripMenuItem";
            this.gimansioToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gimansioToolStripMenuItem.Text = "Gimansio";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            this.asistenciaToolStripMenuItem.Click += new System.EventHandler(this.asistenciaToolStripMenuItem_Click);
            // 
            // renovarNuevoToolStripMenuItem
            // 
            this.renovarNuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suscripcionMensualToolStripMenuItem,
            this.tarjetaToolStripMenuItem});
            this.renovarNuevoToolStripMenuItem.Name = "renovarNuevoToolStripMenuItem";
            this.renovarNuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renovarNuevoToolStripMenuItem.Text = "Renovar/Nuevo";
            this.renovarNuevoToolStripMenuItem.Click += new System.EventHandler(this.renovarNuevoToolStripMenuItem_Click);
            // 
            // suscripcionMensualToolStripMenuItem
            // 
            this.suscripcionMensualToolStripMenuItem.Name = "suscripcionMensualToolStripMenuItem";
            this.suscripcionMensualToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.suscripcionMensualToolStripMenuItem.Text = "Suscripcion Mensual";
            // 
            // tarjetaToolStripMenuItem
            // 
            this.tarjetaToolStripMenuItem.Name = "tarjetaToolStripMenuItem";
            this.tarjetaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tarjetaToolStripMenuItem.Text = "Tarjeta";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // diarioToolStripMenuItem
            // 
            this.diarioToolStripMenuItem.Name = "diarioToolStripMenuItem";
            this.diarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diarioToolStripMenuItem.Text = "Diario";
            this.diarioToolStripMenuItem.Click += new System.EventHandler(this.diarioToolStripMenuItem_Click);
            // 
            // entrenamientoToolStripMenuItem
            // 
            this.entrenamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAsistenciaToolStripMenuItem,
            this.nuevoEntrenadorToolStripMenuItem,
            this.actualizarDatosEntrenador,
            this.verEntrenadoresToolStripMenuItem,
            this.eliminarEntrenadorToolStripMenuItem});
            this.entrenamientoToolStripMenuItem.Name = "entrenamientoToolStripMenuItem";
            this.entrenamientoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entrenamientoToolStripMenuItem.Text = "Entrenadores";
            // 
            // registrarAsistenciaToolStripMenuItem
            // 
            this.registrarAsistenciaToolStripMenuItem.Name = "registrarAsistenciaToolStripMenuItem";
            this.registrarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.registrarAsistenciaToolStripMenuItem.Text = "Asistencia Entrenador Gim";
            this.registrarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.registrarAsistenciaToolStripMenuItem_Click);
            // 
            // nuevoEntrenadorToolStripMenuItem
            // 
            this.nuevoEntrenadorToolStripMenuItem.Name = "nuevoEntrenadorToolStripMenuItem";
            this.nuevoEntrenadorToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.nuevoEntrenadorToolStripMenuItem.Text = "Nuevo Entrenador Gim";
            this.nuevoEntrenadorToolStripMenuItem.Click += new System.EventHandler(this.nuevoEntrenadorToolStripMenuItem_Click);
            // 
            // verEntrenadoresToolStripMenuItem
            // 
            this.verEntrenadoresToolStripMenuItem.Name = "verEntrenadoresToolStripMenuItem";
            this.verEntrenadoresToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.verEntrenadoresToolStripMenuItem.Text = "Ver Entrenadores Gim";
            // 
            // eliminarEntrenadorToolStripMenuItem
            // 
            this.eliminarEntrenadorToolStripMenuItem.Name = "eliminarEntrenadorToolStripMenuItem";
            this.eliminarEntrenadorToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.eliminarEntrenadorToolStripMenuItem.Text = "Eliminar Entrenador Gim";
            // 
            // administracionDelSistemaToolStripMenuItem
            // 
            this.administracionDelSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionDeUsuariosToolStripMenuItem,
            this.administracionDeParametrosToolStripMenuItem});
            this.administracionDelSistemaToolStripMenuItem.Name = "administracionDelSistemaToolStripMenuItem";
            this.administracionDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.administracionDelSistemaToolStripMenuItem.Text = "Administracion del Sistema";
            // 
            // administracionDeUsuariosToolStripMenuItem
            // 
            this.administracionDeUsuariosToolStripMenuItem.Name = "administracionDeUsuariosToolStripMenuItem";
            this.administracionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.administracionDeUsuariosToolStripMenuItem.Text = "Administracion de Usuarios";
            // 
            // administracionDeParametrosToolStripMenuItem
            // 
            this.administracionDeParametrosToolStripMenuItem.Name = "administracionDeParametrosToolStripMenuItem";
            this.administracionDeParametrosToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.administracionDeParametrosToolStripMenuItem.Text = "Administracion de Parametros";
            // 
            // instalacionesToolStripMenuItem
            // 
            this.instalacionesToolStripMenuItem.Name = "instalacionesToolStripMenuItem";
            this.instalacionesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.instalacionesToolStripMenuItem.Text = "Instalaciones";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.helpToolStripMenuItem.Text = "Movimiento Economico";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.areaHumedaToolStripMenuItem,
            this.gimansioToolStripMenuItem,
            this.administracionDelSistemaToolStripMenuItem,
            this.instalacionesToolStripMenuItem,
            this.parametrosToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(825, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // actualizarDatosEntrenador
            // 
            this.actualizarDatosEntrenador.Name = "actualizarDatosEntrenador";
            this.actualizarDatosEntrenador.Size = new System.Drawing.Size(245, 22);
            this.actualizarDatosEntrenador.Text = "Actualizar Datos Entrenador Gim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "TECH-J";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaHumedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gimansioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renovarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suscripcionMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionDeParametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instalacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem registrarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEntrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEntrenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEntrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosEntrenador;
    }
}

