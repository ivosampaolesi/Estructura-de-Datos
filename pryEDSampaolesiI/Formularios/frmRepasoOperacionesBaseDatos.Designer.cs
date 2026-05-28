namespace pryEDSampaolesiI
{
    partial class frmRepasoOperacionesBaseDatos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(17, 84);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(256, 16);
            this.lblOperacion.TabIndex = 0;
            this.lblOperacion.Text = "Operación a realizar en la base de datos:";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(323, 69);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(520, 24);
            this.cmbOperacion.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(869, 66);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(142, 29);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(13, 117);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(998, 110);
            this.txtConsulta.TabIndex = 3;
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(13, 249);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(998, 357);
            this.dgvDatos.TabIndex = 4;
            // 
            // frmRepasoOperacionesBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 623);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.lblOperacion);
            this.Name = "frmRepasoOperacionesBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}
