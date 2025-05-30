namespace RegistroClientes
{
    partial class DatosFCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosFCli));
            this.LblDirección = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmBDepart = new System.Windows.Forms.ComboBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Bene1 = new System.Windows.Forms.Label();
            this.TxtNomCom1 = new System.Windows.Forms.TextBox();
            this.LblParent1 = new System.Windows.Forms.Label();
            this.Parentesco1 = new System.Windows.Forms.ComboBox();
            this.Bene2 = new System.Windows.Forms.Label();
            this.TxtNomCom2 = new System.Windows.Forms.TextBox();
            this.LblParent2 = new System.Windows.Forms.Label();
            this.Parentesco2 = new System.Windows.Forms.ComboBox();
            this.Bene3 = new System.Windows.Forms.Label();
            this.TxtNomCom3 = new System.Windows.Forms.TextBox();
            this.LblParent3 = new System.Windows.Forms.Label();
            this.Parentesco3 = new System.Windows.Forms.ComboBox();
            this.Bene4 = new System.Windows.Forms.Label();
            this.TxtNomCom4 = new System.Windows.Forms.TextBox();
            this.LblParent4 = new System.Windows.Forms.Label();
            this.Parentesco4 = new System.Windows.Forms.ComboBox();
            this.LblPorcentaje = new System.Windows.Forms.Label();
            this.BCancelar5 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Atrás = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Finalizar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDirección
            // 
            this.LblDirección.AutoSize = true;
            this.LblDirección.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDirección.ForeColor = System.Drawing.Color.White;
            this.LblDirección.Location = new System.Drawing.Point(243, 55);
            this.LblDirección.Name = "LblDirección";
            this.LblDirección.Size = new System.Drawing.Size(371, 22);
            this.LblDirección.TabIndex = 4;
            this.LblDirección.Text = "Por último, por favor llena los siguientes campos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estado\r\nFamiliar:";
            // 
            // CmBDepart
            // 
            this.CmBDepart.FormattingEnabled = true;
            this.CmBDepart.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Dirvorciado/a"});
            this.CmBDepart.Location = new System.Drawing.Point(115, 111);
            this.CmBDepart.Name = "CmBDepart";
            this.CmBDepart.Size = new System.Drawing.Size(148, 29);
            this.CmBDepart.TabIndex = 7;
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(22, 234);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(95, 19);
            this.LblNombres.TabIndex = 8;
            this.LblNombres.Text = "Beneficiarios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "A continuación, selecciona la cantidad de beneficiarios a registrar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(154, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 29);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Bene1
            // 
            this.Bene1.AutoSize = true;
            this.Bene1.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bene1.Location = new System.Drawing.Point(22, 287);
            this.Bene1.Name = "Bene1";
            this.Bene1.Size = new System.Drawing.Size(75, 38);
            this.Bene1.TabIndex = 11;
            this.Bene1.Text = "Nombre\r\nCompleto:";
            this.Bene1.Visible = false;
            // 
            // TxtNomCom1
            // 
            this.TxtNomCom1.Location = new System.Drawing.Point(115, 299);
            this.TxtNomCom1.Name = "TxtNomCom1";
            this.TxtNomCom1.Size = new System.Drawing.Size(331, 29);
            this.TxtNomCom1.TabIndex = 12;
            this.TxtNomCom1.Visible = false;
            // 
            // LblParent1
            // 
            this.LblParent1.AutoSize = true;
            this.LblParent1.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParent1.Location = new System.Drawing.Point(482, 301);
            this.LblParent1.Name = "LblParent1";
            this.LblParent1.Size = new System.Drawing.Size(83, 19);
            this.LblParent1.TabIndex = 13;
            this.LblParent1.Text = "Parentesco:";
            this.LblParent1.Visible = false;
            // 
            // Parentesco1
            // 
            this.Parentesco1.FormattingEnabled = true;
            this.Parentesco1.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Hermano/a",
            "Esposo/a",
            "Hijo/a",
            "Abuelo/a",
            "Tío/a",
            "Primo/a",
            "Otro"});
            this.Parentesco1.Location = new System.Drawing.Point(568, 297);
            this.Parentesco1.Name = "Parentesco1";
            this.Parentesco1.Size = new System.Drawing.Size(148, 29);
            this.Parentesco1.TabIndex = 14;
            this.Parentesco1.Visible = false;
            // 
            // Bene2
            // 
            this.Bene2.AutoSize = true;
            this.Bene2.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bene2.Location = new System.Drawing.Point(22, 351);
            this.Bene2.Name = "Bene2";
            this.Bene2.Size = new System.Drawing.Size(75, 38);
            this.Bene2.TabIndex = 15;
            this.Bene2.Text = "Nombre\r\nCompleto:";
            this.Bene2.Visible = false;
            // 
            // TxtNomCom2
            // 
            this.TxtNomCom2.Location = new System.Drawing.Point(115, 363);
            this.TxtNomCom2.Name = "TxtNomCom2";
            this.TxtNomCom2.Size = new System.Drawing.Size(331, 29);
            this.TxtNomCom2.TabIndex = 16;
            this.TxtNomCom2.Visible = false;
            // 
            // LblParent2
            // 
            this.LblParent2.AutoSize = true;
            this.LblParent2.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParent2.Location = new System.Drawing.Point(482, 367);
            this.LblParent2.Name = "LblParent2";
            this.LblParent2.Size = new System.Drawing.Size(83, 19);
            this.LblParent2.TabIndex = 17;
            this.LblParent2.Text = "Parentesco:";
            this.LblParent2.Visible = false;
            // 
            // Parentesco2
            // 
            this.Parentesco2.FormattingEnabled = true;
            this.Parentesco2.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Hermano/a",
            "Esposo/a",
            "Hijo/a",
            "Abuelo/a",
            "Tío/a",
            "Primo/a",
            "Otro"});
            this.Parentesco2.Location = new System.Drawing.Point(568, 363);
            this.Parentesco2.Name = "Parentesco2";
            this.Parentesco2.Size = new System.Drawing.Size(148, 29);
            this.Parentesco2.TabIndex = 18;
            this.Parentesco2.Visible = false;
            // 
            // Bene3
            // 
            this.Bene3.AutoSize = true;
            this.Bene3.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bene3.Location = new System.Drawing.Point(22, 419);
            this.Bene3.Name = "Bene3";
            this.Bene3.Size = new System.Drawing.Size(75, 38);
            this.Bene3.TabIndex = 19;
            this.Bene3.Text = "Nombre\r\nCompleto:";
            this.Bene3.Visible = false;
            // 
            // TxtNomCom3
            // 
            this.TxtNomCom3.Location = new System.Drawing.Point(115, 432);
            this.TxtNomCom3.Name = "TxtNomCom3";
            this.TxtNomCom3.Size = new System.Drawing.Size(331, 29);
            this.TxtNomCom3.TabIndex = 20;
            this.TxtNomCom3.Visible = false;
            // 
            // LblParent3
            // 
            this.LblParent3.AutoSize = true;
            this.LblParent3.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParent3.Location = new System.Drawing.Point(482, 436);
            this.LblParent3.Name = "LblParent3";
            this.LblParent3.Size = new System.Drawing.Size(83, 19);
            this.LblParent3.TabIndex = 21;
            this.LblParent3.Text = "Parentesco:";
            this.LblParent3.Visible = false;
            // 
            // Parentesco3
            // 
            this.Parentesco3.FormattingEnabled = true;
            this.Parentesco3.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Hermano/a",
            "Esposo/a",
            "Hijo/a",
            "Abuelo/a",
            "Tío/a",
            "Primo/a",
            "Otro"});
            this.Parentesco3.Location = new System.Drawing.Point(568, 429);
            this.Parentesco3.Name = "Parentesco3";
            this.Parentesco3.Size = new System.Drawing.Size(148, 29);
            this.Parentesco3.TabIndex = 22;
            this.Parentesco3.Visible = false;
            // 
            // Bene4
            // 
            this.Bene4.AutoSize = true;
            this.Bene4.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bene4.Location = new System.Drawing.Point(22, 491);
            this.Bene4.Name = "Bene4";
            this.Bene4.Size = new System.Drawing.Size(75, 38);
            this.Bene4.TabIndex = 23;
            this.Bene4.Text = "Nombre\r\nCompleto:";
            this.Bene4.Visible = false;
            // 
            // TxtNomCom4
            // 
            this.TxtNomCom4.Location = new System.Drawing.Point(115, 504);
            this.TxtNomCom4.Name = "TxtNomCom4";
            this.TxtNomCom4.Size = new System.Drawing.Size(331, 29);
            this.TxtNomCom4.TabIndex = 24;
            this.TxtNomCom4.Visible = false;
            // 
            // LblParent4
            // 
            this.LblParent4.AutoSize = true;
            this.LblParent4.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParent4.Location = new System.Drawing.Point(482, 508);
            this.LblParent4.Name = "LblParent4";
            this.LblParent4.Size = new System.Drawing.Size(83, 19);
            this.LblParent4.TabIndex = 25;
            this.LblParent4.Text = "Parentesco:";
            this.LblParent4.Visible = false;
            // 
            // Parentesco4
            // 
            this.Parentesco4.FormattingEnabled = true;
            this.Parentesco4.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Hermano/a",
            "Esposo/a",
            "Hijo/a",
            "Abuelo/a",
            "Tío/a",
            "Primo/a",
            "Otro"});
            this.Parentesco4.Location = new System.Drawing.Point(568, 502);
            this.Parentesco4.Name = "Parentesco4";
            this.Parentesco4.Size = new System.Drawing.Size(148, 29);
            this.Parentesco4.TabIndex = 26;
            this.Parentesco4.Visible = false;
            // 
            // LblPorcentaje
            // 
            this.LblPorcentaje.AutoSize = true;
            this.LblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPorcentaje.ForeColor = System.Drawing.Color.White;
            this.LblPorcentaje.Location = new System.Drawing.Point(243, 234);
            this.LblPorcentaje.Name = "LblPorcentaje";
            this.LblPorcentaje.Size = new System.Drawing.Size(173, 19);
            this.LblPorcentaje.TabIndex = 27;
            this.LblPorcentaje.Text = "Porcentaje para cada uno";
            // 
            // BCancelar5
            // 
            this.BCancelar5.BackColor = System.Drawing.Color.Indigo;
            this.BCancelar5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCancelar5.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar5.ForeColor = System.Drawing.Color.White;
            this.BCancelar5.Location = new System.Drawing.Point(26, 573);
            this.BCancelar5.Name = "BCancelar5";
            this.BCancelar5.Size = new System.Drawing.Size(104, 38);
            this.BCancelar5.TabIndex = 30;
            this.BCancelar5.Text = "Cancelar";
            this.BCancelar5.UseVisualStyleBackColor = false;
            this.BCancelar5.Click += new System.EventHandler(this.BCancelar5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atrás,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(859, 38);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Atrás
            // 
            this.Atrás.BackColor = System.Drawing.Color.SlateBlue;
            this.Atrás.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Atrás.Image = ((System.Drawing.Image)(resources.GetObject("Atrás.Image")));
            this.Atrás.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Atrás.Name = "Atrás";
            this.Atrás.Size = new System.Drawing.Size(34, 33);
            this.Atrás.Text = "toolStripButton2";
            this.Atrás.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 33);
            this.toolStripLabel1.Text = "Paso 3";
            // 
            // Finalizar
            // 
            this.Finalizar.BackColor = System.Drawing.Color.Indigo;
            this.Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Finalizar.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finalizar.ForeColor = System.Drawing.Color.White;
            this.Finalizar.Location = new System.Drawing.Point(743, 573);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(104, 38);
            this.Finalizar.TabIndex = 32;
            this.Finalizar.Text = "Guardar";
            this.Finalizar.UseVisualStyleBackColor = false;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // DatosFCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(859, 630);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BCancelar5);
            this.Controls.Add(this.LblPorcentaje);
            this.Controls.Add(this.Parentesco4);
            this.Controls.Add(this.LblParent4);
            this.Controls.Add(this.TxtNomCom4);
            this.Controls.Add(this.Bene4);
            this.Controls.Add(this.Parentesco3);
            this.Controls.Add(this.LblParent3);
            this.Controls.Add(this.TxtNomCom3);
            this.Controls.Add(this.Bene3);
            this.Controls.Add(this.Parentesco2);
            this.Controls.Add(this.LblParent2);
            this.Controls.Add(this.TxtNomCom2);
            this.Controls.Add(this.Bene2);
            this.Controls.Add(this.Parentesco1);
            this.Controls.Add(this.LblParent1);
            this.Controls.Add(this.TxtNomCom1);
            this.Controls.Add(this.Bene1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.CmBDepart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDirección);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DatosFCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FonaVit.SV";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDirección;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmBDepart;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Bene1;
        private System.Windows.Forms.TextBox TxtNomCom1;
        private System.Windows.Forms.Label LblParent1;
        private System.Windows.Forms.ComboBox Parentesco1;
        private System.Windows.Forms.Label Bene2;
        private System.Windows.Forms.TextBox TxtNomCom2;
        private System.Windows.Forms.Label LblParent2;
        private System.Windows.Forms.ComboBox Parentesco2;
        private System.Windows.Forms.Label Bene3;
        private System.Windows.Forms.TextBox TxtNomCom3;
        private System.Windows.Forms.Label LblParent3;
        private System.Windows.Forms.ComboBox Parentesco3;
        private System.Windows.Forms.Label Bene4;
        private System.Windows.Forms.TextBox TxtNomCom4;
        private System.Windows.Forms.Label LblParent4;
        private System.Windows.Forms.ComboBox Parentesco4;
        private System.Windows.Forms.Label LblPorcentaje;
        private System.Windows.Forms.Button BCancelar5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Atrás;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button Finalizar;
    }
}