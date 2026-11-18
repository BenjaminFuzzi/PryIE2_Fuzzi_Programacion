namespace PryIE2_Fuzzi_Programacion
{
    partial class frmBajoStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBajoStock));
            this.gbxBajoStock = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBajoStock = new System.Windows.Forms.DataGridView();
            this.gbxBajoStock.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBajoStock
            // 
            this.gbxBajoStock.Controls.Add(this.dgvBajoStock);
            this.gbxBajoStock.Location = new System.Drawing.Point(12, 31);
            this.gbxBajoStock.Name = "gbxBajoStock";
            this.gbxBajoStock.Size = new System.Drawing.Size(656, 190);
            this.gbxBajoStock.TabIndex = 0;
            this.gbxBajoStock.TabStop = false;
            this.gbxBajoStock.Text = "Productos con Bajo Stock";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(571, 227);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(97, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // dgvBajoStock
            // 
            this.dgvBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajoStock.Location = new System.Drawing.Point(6, 21);
            this.dgvBajoStock.Name = "dgvBajoStock";
            this.dgvBajoStock.RowHeadersWidth = 51;
            this.dgvBajoStock.RowTemplate.Height = 24;
            this.dgvBajoStock.Size = new System.Drawing.Size(644, 163);
            this.dgvBajoStock.TabIndex = 0;
            // 
            // frmBajoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 258);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbxBajoStock);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBajoStock";
            this.Text = "Productos con Bajo Stock";
            this.gbxBajoStock.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBajoStock;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvBajoStock;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
    }
}