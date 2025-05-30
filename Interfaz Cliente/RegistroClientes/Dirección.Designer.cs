namespace RegistroClientes
{
    partial class DirecCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirecCli));
            this.LblMunicipio = new System.Windows.Forms.Label();
            this.LblDirección = new System.Windows.Forms.Label();
            this.CmBDepart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMuni = new System.Windows.Forms.TextBox();
            this.LblCalle = new System.Windows.Forms.Label();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.LblCasa = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Siguiente = new System.Windows.Forms.ToolStripButton();
            this.Atrás = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BCancelar4 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMunicipio
            // 
            this.LblMunicipio.AutoSize = true;
            this.LblMunicipio.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMunicipio.Location = new System.Drawing.Point(422, 169);
            this.LblMunicipio.Name = "LblMunicipio";
            this.LblMunicipio.Size = new System.Drawing.Size(77, 38);
            this.LblMunicipio.TabIndex = 2;
            this.LblMunicipio.Text = "Municipio/\r\nDistrito:";
            // 
            // LblDirección
            // 
            this.LblDirección.AutoSize = true;
            this.LblDirección.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDirección.ForeColor = System.Drawing.Color.White;
            this.LblDirección.Location = new System.Drawing.Point(311, 52);
            this.LblDirección.Name = "LblDirección";
            this.LblDirección.Size = new System.Drawing.Size(228, 22);
            this.LblDirección.TabIndex = 3;
            this.LblDirección.Text = "Por favor, agrega tu dirección";
            // 
            // CmBDepart
            // 
            this.CmBDepart.FormattingEnabled = true;
            this.CmBDepart.Items.AddRange(new object[] {
            "Ahuachapán",
            "Santa Ana",
            "Sonsonate",
            "Chalatenango",
            "La Libertad",
            "San Salvador",
            "Cuscatlán",
            "La Paz",
            "Cabañas",
            "San Vicente",
            "Usulután",
            "San Miguel",
            "Morazán",
            "La Unión"});
            this.CmBDepart.Location = new System.Drawing.Point(141, 179);
            this.CmBDepart.Name = "CmBDepart";
            this.CmBDepart.Size = new System.Drawing.Size(217, 28);
            this.CmBDepart.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Departamento:";
            // 
            // TxtMuni
            // 
            this.TxtMuni.Location = new System.Drawing.Point(504, 179);
            this.TxtMuni.Name = "TxtMuni";
            this.TxtMuni.Size = new System.Drawing.Size(180, 26);
            this.TxtMuni.TabIndex = 6;
            // 
            // LblCalle
            // 
            this.LblCalle.AutoSize = true;
            this.LblCalle.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalle.Location = new System.Drawing.Point(22, 265);
            this.LblCalle.Name = "LblCalle";
            this.LblCalle.Size = new System.Drawing.Size(45, 19);
            this.LblCalle.TabIndex = 7;
            this.LblCalle.Text = "Calle:";
            // 
            // TxtCalle
            // 
            this.TxtCalle.Location = new System.Drawing.Point(82, 258);
            this.TxtCalle.Multiline = true;
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(276, 26);
            this.TxtCalle.TabIndex = 8;
            // 
            // LblCasa
            // 
            this.LblCasa.AutoSize = true;
            this.LblCasa.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasa.Location = new System.Drawing.Point(422, 246);
            this.LblCasa.Name = "LblCasa";
            this.LblCasa.Size = new System.Drawing.Size(81, 38);
            this.LblCasa.TabIndex = 9;
            this.LblCasa.Text = "Número de\r\nCasa:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(507, 258);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 26);
            this.textBox3.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Siguiente,
            this.Atrás,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(859, 33);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Siguiente
            // 
            this.Siguiente.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Siguiente.BackColor = System.Drawing.Color.SlateBlue;
            this.Siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Siguiente.Image = ((System.Drawing.Image)(resources.GetObject("Siguiente.Image")));
            this.Siguiente.ImageTransparentColor = System.Drawing.Color.DarkSlateBlue;
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(34, 28);
            this.Siguiente.Text = "toolStripButton1";
            this.Siguiente.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Atrás
            // 
            this.Atrás.BackColor = System.Drawing.Color.SlateBlue;
            this.Atrás.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Atrás.Image = ((System.Drawing.Image)(resources.GetObject("Atrás.Image")));
            this.Atrás.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Atrás.Name = "Atrás";
            this.Atrás.Size = new System.Drawing.Size(34, 28);
            this.Atrás.Text = "toolStripButton2";
            this.Atrás.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 28);
            this.toolStripLabel1.Text = "Paso 2";
            // 
            // BCancelar4
            // 
            this.BCancelar4.BackColor = System.Drawing.Color.Indigo;
            this.BCancelar4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCancelar4.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar4.ForeColor = System.Drawing.Color.White;
            this.BCancelar4.Location = new System.Drawing.Point(26, 556);
            this.BCancelar4.Name = "BCancelar4";
            this.BCancelar4.Size = new System.Drawing.Size(104, 36);
            this.BCancelar4.TabIndex = 33;
            this.BCancelar4.Text = "Cancelar";
            this.BCancelar4.UseVisualStyleBackColor = false;
            this.BCancelar4.Click += new System.EventHandler(this.BCancelar4_Click);
            // 
            // DirecCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(859, 600);
            this.Controls.Add(this.BCancelar4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LblCasa);
            this.Controls.Add(this.TxtCalle);
            this.Controls.Add(this.LblCalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMuni);
            this.Controls.Add(this.CmBDepart);
            this.Controls.Add(this.LblDirección);
            this.Controls.Add(this.LblMunicipio);
            this.Name = "DirecCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FonaVit.SV";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMunicipio;
        private System.Windows.Forms.Label LblDirección;
        private System.Windows.Forms.ComboBox CmBDepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMuni;
        private System.Windows.Forms.Label LblCalle;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.Label LblCasa;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Siguiente;
        private System.Windows.Forms.ToolStripButton Atrás;
        private System.Windows.Forms.Button BCancelar4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}