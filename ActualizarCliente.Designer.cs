namespace ProyectoSoftware
{
    partial class ActualizarCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.actualizarClie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updC = new System.Windows.Forms.TextBox();
            this.updsn = new System.Windows.Forms.TextBox();
            this.updpn = new System.Windows.Forms.TextBox();
            this.updpa = new System.Windows.Forms.TextBox();
            this.updsa = new System.Windows.Forms.TextBox();
            this.upddir = new System.Windows.Forms.TextBox();
            this.updtel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Atrás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(313, 346);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(75, 23);
            this.actualizar.TabIndex = 4;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.button4_Click);
            // 
            // actualizarClie
            // 
            this.actualizarClie.Location = new System.Drawing.Point(201, 54);
            this.actualizarClie.Name = "actualizarClie";
            this.actualizarClie.Size = new System.Drawing.Size(228, 20);
            this.actualizarClie.TabIndex = 5;
            this.actualizarClie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cédula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teléfono";
            // 
            // updC
            // 
            this.updC.Location = new System.Drawing.Point(61, 134);
            this.updC.Name = "updC";
            this.updC.Size = new System.Drawing.Size(206, 20);
            this.updC.TabIndex = 11;
            this.updC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // updsn
            // 
            this.updsn.Location = new System.Drawing.Point(167, 203);
            this.updsn.Name = "updsn";
            this.updsn.Size = new System.Drawing.Size(100, 20);
            this.updsn.TabIndex = 12;
            this.updsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // updpn
            // 
            this.updpn.Location = new System.Drawing.Point(61, 203);
            this.updpn.Name = "updpn";
            this.updpn.Size = new System.Drawing.Size(100, 20);
            this.updpn.TabIndex = 13;
            this.updpn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // updpa
            // 
            this.updpa.Location = new System.Drawing.Point(329, 203);
            this.updpa.Name = "updpa";
            this.updpa.Size = new System.Drawing.Size(100, 20);
            this.updpa.TabIndex = 14;
            this.updpa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // updsa
            // 
            this.updsa.Location = new System.Drawing.Point(435, 203);
            this.updsa.Name = "updsa";
            this.updsa.Size = new System.Drawing.Size(100, 20);
            this.updsa.TabIndex = 15;
            this.updsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // upddir
            // 
            this.upddir.Location = new System.Drawing.Point(61, 277);
            this.upddir.Name = "upddir";
            this.upddir.Size = new System.Drawing.Size(206, 20);
            this.upddir.TabIndex = 16;
            // 
            // updtel
            // 
            this.updtel.Location = new System.Drawing.Point(61, 349);
            this.updtel.Name = "updtel";
            this.updtel.Size = new System.Drawing.Size(100, 20);
            this.updtel.TabIndex = 17;
            this.updtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // ActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.updtel);
            this.Controls.Add(this.upddir);
            this.Controls.Add(this.updsa);
            this.Controls.Add(this.updpa);
            this.Controls.Add(this.updpn);
            this.Controls.Add(this.updsn);
            this.Controls.Add(this.updC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actualizarClie);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarCliente";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ActualizarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.TextBox actualizarClie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updC;
        private System.Windows.Forms.TextBox updsn;
        private System.Windows.Forms.TextBox updpn;
        private System.Windows.Forms.TextBox updpa;
        private System.Windows.Forms.TextBox updsa;
        private System.Windows.Forms.TextBox upddir;
        private System.Windows.Forms.TextBox updtel;
    }
}