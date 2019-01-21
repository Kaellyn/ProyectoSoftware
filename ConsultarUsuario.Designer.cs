namespace ProyectoSoftware
{
    partial class ConsultarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.conUsuario = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Usuario";
            // 
            // conUsuario
            // 
            this.conUsuario.Location = new System.Drawing.Point(350, 18);
            this.conUsuario.Name = "conUsuario";
            this.conUsuario.Size = new System.Drawing.Size(201, 20);
            this.conUsuario.TabIndex = 1;
            this.conUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.conUsuario_KeyPress);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(339, 325);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Atras";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableUsuario
            // 
            this.tableUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsuario.Location = new System.Drawing.Point(12, 88);
            this.tableUsuario.Name = "tableUsuario";
            this.tableUsuario.Size = new System.Drawing.Size(776, 204);
            this.tableUsuario.TabIndex = 4;
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.conUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarUsuario";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ConsultarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conUsuario;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tableUsuario;
    }
}