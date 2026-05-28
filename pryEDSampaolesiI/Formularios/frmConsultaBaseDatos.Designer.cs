namespace pryEDSampaolesiI
{
    partial class frmConsultaBaseDatos
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
            this.lblConsulta = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(12, 18);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(200, 26);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Consulta en SQL:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(9, 57);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(884, 192);
            this.txtConsulta.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(787, 259);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(106, 24);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(9, 287);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(884, 329);
            this.dgvDatos.TabIndex = 3;
            // 
            // frmConsultaBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 630);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConsultaBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas en la Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}
