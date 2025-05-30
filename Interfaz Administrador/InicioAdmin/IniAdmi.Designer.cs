namespace InicioAdmin
{
    partial class IniAdmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniAdmi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.Bienvenida = new System.Windows.Forms.Label();
            this.VerEmp = new System.Windows.Forms.Button();
            this.VerCli = new System.Windows.Forms.Button();
            this.HistTra = new System.Windows.Forms.Button();
            this.RegEmp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(859, 33);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(128, 28);
            this.toolStripLabel1.Text = "Administrador";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(123, 28);
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
            this.LogOut.Size = new System.Drawing.Size(34, 28);
            this.LogOut.Text = "toolStripButton1";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.ForeColor = System.Drawing.Color.White;
            this.Bienvenida.Location = new System.Drawing.Point(365, 53);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(109, 22);
            this.Bienvenida.TabIndex = 35;
            this.Bienvenida.Text = "Bienvenid@...";
            // 
            // VerEmp
            // 
            this.VerEmp.BackColor = System.Drawing.Color.SlateBlue;
            this.VerEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerEmp.Location = new System.Drawing.Point(27, 75);
            this.VerEmp.Name = "VerEmp";
            this.VerEmp.Size = new System.Drawing.Size(131, 65);
            this.VerEmp.TabIndex = 37;
            this.VerEmp.Text = "Ver Empleados";
            this.VerEmp.UseVisualStyleBackColor = false;
            this.VerEmp.Click += new System.EventHandler(this.VerEmp_Click);
            // 
            // VerCli
            // 
            this.VerCli.BackColor = System.Drawing.Color.SlateBlue;
            this.VerCli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerCli.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerCli.Location = new System.Drawing.Point(27, 352);
            this.VerCli.Name = "VerCli";
            this.VerCli.Size = new System.Drawing.Size(131, 65);
            this.VerCli.TabIndex = 38;
            this.VerCli.Text = "Ver Clientes";
            this.VerCli.UseVisualStyleBackColor = false;
            this.VerCli.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistTra
            // 
            this.HistTra.BackColor = System.Drawing.Color.SlateBlue;
            this.HistTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HistTra.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistTra.Location = new System.Drawing.Point(27, 506);
            this.HistTra.Name = "HistTra";
            this.HistTra.Size = new System.Drawing.Size(131, 65);
            this.HistTra.TabIndex = 39;
            this.HistTra.Text = "Historial Transacciones";
            this.HistTra.UseVisualStyleBackColor = false;
            this.HistTra.Click += new System.EventHandler(this.HistTra_Click);
            // 
            // RegEmp
            // 
            this.RegEmp.BackColor = System.Drawing.Color.SlateBlue;
            this.RegEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegEmp.Location = new System.Drawing.Point(27, 208);
            this.RegEmp.Name = "RegEmp";
            this.RegEmp.Size = new System.Drawing.Size(131, 65);
            this.RegEmp.TabIndex = 40;
            this.RegEmp.Text = "Rgistrar Empleado";
            this.RegEmp.UseVisualStyleBackColor = false;
            this.RegEmp.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // IniAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(859, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegEmp);
            this.Controls.Add(this.HistTra);
            this.Controls.Add(this.VerCli);
            this.Controls.Add(this.VerEmp);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.toolStrip1);
            this.Name = "IniAdmi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FonaVit.SV";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton LogOut;
        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Button VerEmp;
        private System.Windows.Forms.Button VerCli;
        private System.Windows.Forms.Button HistTra;
        private System.Windows.Forms.Button RegEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

