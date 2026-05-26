namespace pryEDSampaolesiI.Formularios
{
    partial class frmGrafo
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
            this.picGrafo = new System.Windows.Forms.PictureBox();
            this.gpbCargaDatos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.lblPrecioCarga = new System.Windows.Forms.Label();
            this.txtPrecioCarga = new System.Windows.Forms.TextBox();
            this.cmbDestinoCarga = new System.Windows.Forms.ComboBox();
            this.lblDestinoCarga = new System.Windows.Forms.Label();
            this.cmbOrigenCarga = new System.Windows.Forms.ComboBox();
            this.lblOrigenCarga = new System.Windows.Forms.Label();
            this.gpbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblPrecioConsulta = new System.Windows.Forms.Label();
            this.txtPrecioConsulta = new System.Windows.Forms.TextBox();
            this.cmbDestinoConsulta = new System.Windows.Forms.ComboBox();
            this.lblDestinoConsulta = new System.Windows.Forms.Label();
            this.cmbOrigenConsulta = new System.Windows.Forms.ComboBox();
            this.lblOrigenConsulta = new System.Windows.Forms.Label();
            this.lblListarViajes = new System.Windows.Forms.Label();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnVerTodosViajes = new System.Windows.Forms.Button();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafo)).BeginInit();
            this.gpbCargaDatos.SuspendLayout();
            this.gpbConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // picGrafo
            // 
            this.picGrafo.BackColor = System.Drawing.SystemColors.Window;
            this.picGrafo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGrafo.Image = global::pryEDSampaolesiI.Properties.Resources.grafos;
            this.picGrafo.Location = new System.Drawing.Point(12, 12);
            this.picGrafo.Name = "picGrafo";
            this.picGrafo.Size = new System.Drawing.Size(240, 217);
            this.picGrafo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrafo.TabIndex = 0;
            this.picGrafo.TabStop = false;
            // 
            // gpbCargaDatos
            // 
            this.gpbCargaDatos.Controls.Add(this.btnCargar);
            this.gpbCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.gpbCargaDatos.Controls.Add(this.lblPrecioCarga);
            this.gpbCargaDatos.Controls.Add(this.txtPrecioCarga);
            this.gpbCargaDatos.Controls.Add(this.cmbDestinoCarga);
            this.gpbCargaDatos.Controls.Add(this.lblDestinoCarga);
            this.gpbCargaDatos.Controls.Add(this.cmbOrigenCarga);
            this.gpbCargaDatos.Controls.Add(this.lblOrigenCarga);
            this.gpbCargaDatos.Location = new System.Drawing.Point(270, 12);
            this.gpbCargaDatos.Name = "gpbCargaDatos";
            this.gpbCargaDatos.Size = new System.Drawing.Size(217, 132);
            this.gpbCargaDatos.TabIndex = 1;
            this.gpbCargaDatos.TabStop = false;
            this.gpbCargaDatos.Text = "Carga de Datos:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(123, 99);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(80, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(14, 99);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(80, 23);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // lblPrecioCarga
            // 
            this.lblPrecioCarga.AutoSize = true;
            this.lblPrecioCarga.Location = new System.Drawing.Point(14, 76);
            this.lblPrecioCarga.Name = "lblPrecioCarga";
            this.lblPrecioCarga.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioCarga.TabIndex = 5;
            this.lblPrecioCarga.Text = "Precio:";
            // 
            // txtPrecioCarga
            // 
            this.txtPrecioCarga.Location = new System.Drawing.Point(123, 73);
            this.txtPrecioCarga.Name = "txtPrecioCarga";
            this.txtPrecioCarga.Size = new System.Drawing.Size(80, 20);
            this.txtPrecioCarga.TabIndex = 4;
            // 
            // cmbDestinoCarga
            // 
            this.cmbDestinoCarga.FormattingEnabled = true;
            this.cmbDestinoCarga.Location = new System.Drawing.Point(123, 46);
            this.cmbDestinoCarga.Name = "cmbDestinoCarga";
            this.cmbDestinoCarga.Size = new System.Drawing.Size(80, 21);
            this.cmbDestinoCarga.TabIndex = 3;
            // 
            // lblDestinoCarga
            // 
            this.lblDestinoCarga.AutoSize = true;
            this.lblDestinoCarga.Location = new System.Drawing.Point(14, 49);
            this.lblDestinoCarga.Name = "lblDestinoCarga";
            this.lblDestinoCarga.Size = new System.Drawing.Size(46, 13);
            this.lblDestinoCarga.TabIndex = 2;
            this.lblDestinoCarga.Text = "Destino:";
            // 
            // cmbOrigenCarga
            // 
            this.cmbOrigenCarga.FormattingEnabled = true;
            this.cmbOrigenCarga.Location = new System.Drawing.Point(123, 19);
            this.cmbOrigenCarga.Name = "cmbOrigenCarga";
            this.cmbOrigenCarga.Size = new System.Drawing.Size(80, 21);
            this.cmbOrigenCarga.TabIndex = 1;
            // 
            // lblOrigenCarga
            // 
            this.lblOrigenCarga.AutoSize = true;
            this.lblOrigenCarga.Location = new System.Drawing.Point(14, 22);
            this.lblOrigenCarga.Name = "lblOrigenCarga";
            this.lblOrigenCarga.Size = new System.Drawing.Size(41, 13);
            this.lblOrigenCarga.TabIndex = 0;
            this.lblOrigenCarga.Text = "Origen:";
            // 
            // gpbConsultaDatos
            // 
            this.gpbConsultaDatos.Controls.Add(this.btnBorrar);
            this.gpbConsultaDatos.Controls.Add(this.btnConsultar);
            this.gpbConsultaDatos.Controls.Add(this.lblPrecioConsulta);
            this.gpbConsultaDatos.Controls.Add(this.txtPrecioConsulta);
            this.gpbConsultaDatos.Controls.Add(this.cmbDestinoConsulta);
            this.gpbConsultaDatos.Controls.Add(this.lblDestinoConsulta);
            this.gpbConsultaDatos.Controls.Add(this.cmbOrigenConsulta);
            this.gpbConsultaDatos.Controls.Add(this.lblOrigenConsulta);
            this.gpbConsultaDatos.Location = new System.Drawing.Point(504, 12);
            this.gpbConsultaDatos.Name = "gpbConsultaDatos";
            this.gpbConsultaDatos.Size = new System.Drawing.Size(217, 132);
            this.gpbConsultaDatos.TabIndex = 2;
            this.gpbConsultaDatos.TabStop = false;
            this.gpbConsultaDatos.Text = "Consulta de Datos:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(123, 99);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(80, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(14, 99);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(80, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblPrecioConsulta
            // 
            this.lblPrecioConsulta.AutoSize = true;
            this.lblPrecioConsulta.Location = new System.Drawing.Point(14, 76);
            this.lblPrecioConsulta.Name = "lblPrecioConsulta";
            this.lblPrecioConsulta.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioConsulta.TabIndex = 13;
            this.lblPrecioConsulta.Text = "Precio:";
            // 
            // txtPrecioConsulta
            // 
            this.txtPrecioConsulta.Location = new System.Drawing.Point(123, 73);
            this.txtPrecioConsulta.Name = "txtPrecioConsulta";
            this.txtPrecioConsulta.ReadOnly = true;
            this.txtPrecioConsulta.Size = new System.Drawing.Size(80, 20);
            this.txtPrecioConsulta.TabIndex = 12;
            // 
            // cmbDestinoConsulta
            // 
            this.cmbDestinoConsulta.FormattingEnabled = true;
            this.cmbDestinoConsulta.Location = new System.Drawing.Point(123, 46);
            this.cmbDestinoConsulta.Name = "cmbDestinoConsulta";
            this.cmbDestinoConsulta.Size = new System.Drawing.Size(80, 21);
            this.cmbDestinoConsulta.TabIndex = 11;
            // 
            // lblDestinoConsulta
            // 
            this.lblDestinoConsulta.AutoSize = true;
            this.lblDestinoConsulta.Location = new System.Drawing.Point(14, 49);
            this.lblDestinoConsulta.Name = "lblDestinoConsulta";
            this.lblDestinoConsulta.Size = new System.Drawing.Size(46, 13);
            this.lblDestinoConsulta.TabIndex = 10;
            this.lblDestinoConsulta.Text = "Destino:";
            // 
            // cmbOrigenConsulta
            // 
            this.cmbOrigenConsulta.FormattingEnabled = true;
            this.cmbOrigenConsulta.Location = new System.Drawing.Point(123, 16);
            this.cmbOrigenConsulta.Name = "cmbOrigenConsulta";
            this.cmbOrigenConsulta.Size = new System.Drawing.Size(80, 21);
            this.cmbOrigenConsulta.TabIndex = 9;
            // 
            // lblOrigenConsulta
            // 
            this.lblOrigenConsulta.AutoSize = true;
            this.lblOrigenConsulta.Location = new System.Drawing.Point(14, 19);
            this.lblOrigenConsulta.Name = "lblOrigenConsulta";
            this.lblOrigenConsulta.Size = new System.Drawing.Size(41, 13);
            this.lblOrigenConsulta.TabIndex = 8;
            this.lblOrigenConsulta.Text = "Origen:";
            // 
            // lblListarViajes
            // 
            this.lblListarViajes.AutoSize = true;
            this.lblListarViajes.Location = new System.Drawing.Point(24, 245);
            this.lblListarViajes.Name = "lblListarViajes";
            this.lblListarViajes.Size = new System.Drawing.Size(77, 13);
            this.lblListarViajes.TabIndex = 3;
            this.lblListarViajes.Text = "Listar viajes ....";
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(113, 242);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(85, 21);
            this.cmbDesde.TabIndex = 4;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(211, 242);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(99, 23);
            this.btnListarDestinos.TabIndex = 5;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(328, 245);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 6;
            this.lblHasta.Text = "Hasta";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(372, 242);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(85, 21);
            this.cmbHasta.TabIndex = 7;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(470, 242);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(99, 23);
            this.btnListarOrigenes.TabIndex = 8;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnVerTodosViajes
            // 
            this.btnVerTodosViajes.Location = new System.Drawing.Point(585, 242);
            this.btnVerTodosViajes.Name = "btnVerTodosViajes";
            this.btnVerTodosViajes.Size = new System.Drawing.Size(99, 23);
            this.btnVerTodosViajes.TabIndex = 9;
            this.btnVerTodosViajes.Text = "Ver todos los viajes";
            this.btnVerTodosViajes.UseVisualStyleBackColor = true;
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.AllowUserToAddRows = false;
            this.dgvGrafo.AllowUserToDeleteRows = false;
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Location = new System.Drawing.Point(12, 278);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.ReadOnly = true;
            this.dgvGrafo.RowHeadersWidth = 51;
            this.dgvGrafo.Size = new System.Drawing.Size(708, 271);
            this.dgvGrafo.TabIndex = 10;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 568);
            this.Controls.Add(this.dgvGrafo);
            this.Controls.Add(this.btnVerTodosViajes);
            this.Controls.Add(this.btnListarOrigenes);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnListarDestinos);
            this.Controls.Add(this.cmbDesde);
            this.Controls.Add(this.lblListarViajes);
            this.Controls.Add(this.gpbConsultaDatos);
            this.Controls.Add(this.gpbCargaDatos);
            this.Controls.Add(this.picGrafo);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones en un Grafo";
            ((System.ComponentModel.ISupportInitialize)(this.picGrafo)).EndInit();
            this.gpbCargaDatos.ResumeLayout(false);
            this.gpbCargaDatos.PerformLayout();
            this.gpbConsultaDatos.ResumeLayout(false);
            this.gpbConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGrafo;
        private System.Windows.Forms.GroupBox gpbCargaDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Label lblPrecioCarga;
        private System.Windows.Forms.TextBox txtPrecioCarga;
        private System.Windows.Forms.ComboBox cmbDestinoCarga;
        private System.Windows.Forms.Label lblDestinoCarga;
        private System.Windows.Forms.ComboBox cmbOrigenCarga;
        private System.Windows.Forms.Label lblOrigenCarga;
        private System.Windows.Forms.GroupBox gpbConsultaDatos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblPrecioConsulta;
        private System.Windows.Forms.TextBox txtPrecioConsulta;
        private System.Windows.Forms.ComboBox cmbDestinoConsulta;
        private System.Windows.Forms.Label lblDestinoConsulta;
        private System.Windows.Forms.ComboBox cmbOrigenConsulta;
        private System.Windows.Forms.Label lblOrigenConsulta;
        private System.Windows.Forms.Label lblListarViajes;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnVerTodosViajes;
        private System.Windows.Forms.DataGridView dgvGrafo;
    }
}
