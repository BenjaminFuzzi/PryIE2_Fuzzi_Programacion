namespace PryIE2_Fuzzi_Programacion
{
    partial class frmImportaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportaciones));
            this.dgvImportaciones = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvImportarArchivo = new System.Windows.Forms.GroupBox();
            this.cbxArchivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTabla = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportaciones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.DgvImportarArchivo.SuspendLayout();
            this.gbxTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImportaciones
            // 
            this.dgvImportaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportaciones.Location = new System.Drawing.Point(22, 21);
            this.dgvImportaciones.Name = "dgvImportaciones";
            this.dgvImportaciones.RowHeadersWidth = 51;
            this.dgvImportaciones.RowTemplate.Height = 24;
            this.dgvImportaciones.Size = new System.Drawing.Size(579, 227);
            this.dgvImportaciones.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(565, 397);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(222, 72);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // DgvImportarArchivo
            // 
            this.DgvImportarArchivo.Controls.Add(this.label1);
            this.DgvImportarArchivo.Controls.Add(this.cbxArchivo);
            this.DgvImportarArchivo.Controls.Add(this.btnImportar);
            this.DgvImportarArchivo.Location = new System.Drawing.Point(19, 30);
            this.DgvImportarArchivo.Name = "DgvImportarArchivo";
            this.DgvImportarArchivo.Size = new System.Drawing.Size(303, 101);
            this.DgvImportarArchivo.TabIndex = 4;
            this.DgvImportarArchivo.TabStop = false;
            this.DgvImportarArchivo.Text = "Importar archivo";
            // 
            // cbxArchivo
            // 
            this.cbxArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArchivo.FormattingEnabled = true;
            this.cbxArchivo.Location = new System.Drawing.Point(126, 32);
            this.cbxArchivo.Name = "cbxArchivo";
            this.cbxArchivo.Size = new System.Drawing.Size(165, 24);
            this.cbxArchivo.TabIndex = 3;
            this.cbxArchivo.SelectedIndexChanged += new System.EventHandler(this.cbxArchivo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Archivo de texto:";
            // 
            // gbxTabla
            // 
            this.gbxTabla.Controls.Add(this.dgvImportaciones);
            this.gbxTabla.Location = new System.Drawing.Point(19, 137);
            this.gbxTabla.Name = "gbxTabla";
            this.gbxTabla.Size = new System.Drawing.Size(621, 254);
            this.gbxTabla.TabIndex = 5;
            this.gbxTabla.TabStop = false;
            this.gbxTabla.Text = "groupBox2";
            // 
            // frmImportaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 425);
            this.Controls.Add(this.gbxTabla);
            this.Controls.Add(this.DgvImportarArchivo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmImportaciones";
            this.Text = "Historial de Importaciones";
            this.Load += new System.EventHandler(this.frmImportaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportaciones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DgvImportarArchivo.ResumeLayout(false);
            this.DgvImportarArchivo.PerformLayout();
            this.gbxTabla.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImportaciones;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.GroupBox DgvImportarArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxArchivo;
        private System.Windows.Forms.GroupBox gbxTabla;
    }
}