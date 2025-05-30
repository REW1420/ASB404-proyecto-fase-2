namespace InicioEmpleados
{
    partial class IniEmp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniEmp));
            this.Bienvenida = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.RegCli = new System.Windows.Forms.Button();
            this.VerClientes = new System.Windows.Forms.Button();
            this.Préstamo = new System.Windows.Forms.Button();
            this.Transacción = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.ForeColor = System.Drawing.Color.White;
            this.Bienvenida.Location = new System.Drawing.Point(362, 47);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(109, 22);
            this.Bienvenida.TabIndex = 2;
            this.Bienvenida.Text = "Bienvenid@...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.LogOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(859, 38);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(144, 33);
            this.toolStripLabel1.Text = "Página Principal";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(123, 33);
            this.toolStripLabel2.Text = "Cerrar Sesión";
            // 
            // LogOut
            // 
            this.LogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LogOut.BackColor = System.Drawing.Color.SlateBlue;
            this.LogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(34, 33);
            this.LogOut.Text = "toolStripButton1";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // RegCli
            // 
            this.RegCli.BackColor = System.Drawing.Color.SlateBlue;
            this.RegCli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegCli.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegCli.Location = new System.Drawing.Point(27, 75);
            this.RegCli.Name = "RegCli";
            this.RegCli.Size = new System.Drawing.Size(131, 65);
            this.RegCli.TabIndex = 37;
            this.RegCli.Text = "Registrar Cliente";
            this.RegCli.UseVisualStyleBackColor = false;
            this.RegCli.Click += new System.EventHandler(this.RegCli_Click);
            // 
            // VerClientes
            // 
            this.VerClientes.BackColor = System.Drawing.Color.SlateBlue;
            this.VerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerClientes.Location = new System.Drawing.Point(27, 208);
            this.VerClientes.Name = "VerClientes";
            this.VerClientes.Size = new System.Drawing.Size(131, 65);
            this.VerClientes.TabIndex = 38;
            this.VerClientes.Text = "Ver Clientes";
            this.VerClientes.UseVisualStyleBackColor = false;
            this.VerClientes.Click += new System.EventHandler(this.VerClientes_Click);
            // 
            // Préstamo
            // 
            this.Préstamo.BackColor = System.Drawing.Color.SlateBlue;
            this.Préstamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Préstamo.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Préstamo.Location = new System.Drawing.Point(27, 506);
            this.Préstamo.Name = "Préstamo";
            this.Préstamo.Size = new System.Drawing.Size(131, 65);
            this.Préstamo.TabIndex = 39;
            this.Préstamo.Text = "Realizar Préstamo";
            this.Préstamo.UseVisualStyleBackColor = false;
            this.Préstamo.Click += new System.EventHandler(this.Préstamo_Click);
            // 
            // Transacción
            // 
            this.Transacción.BackColor = System.Drawing.Color.SlateBlue;
            this.Transacción.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Transacción.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transacción.Location = new System.Drawing.Point(27, 352);
            this.Transacción.Name = "Transacción";
            this.Transacción.Size = new System.Drawing.Size(131, 65);
            this.Transacción.TabIndex = 40;
            this.Transacción.Text = "Realizar Transacción";
            this.Transacción.UseVisualStyleBackColor = false;
            this.Transacción.Click += new System.EventHandler(this.Transacción_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // IniEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(859, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Transacción);
            this.Controls.Add(this.Préstamo);
            this.Controls.Add(this.VerClientes);
            this.Controls.Add(this.RegCli);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Bienvenida);
            this.Name = "IniEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FonaVit.SV";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton LogOut;
        private System.Windows.Forms.Button RegCli;
        private System.Windows.Forms.Button VerClientes;
        private System.Windows.Forms.Button Préstamo;
        private System.Windows.Forms.Button Transacción;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

