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
            this.picGrafo.Location = new System.Drawing.Point(16, 15);
            this.picGrafo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGrafo.Name = "picGrafo";
            this.picGrafo.Size = new System.Drawing.Size(319, 266);
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
            this.gpbCargaDatos.Location = new System.Drawing.Point(360, 15);
            this.gpbCargaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCargaDatos.Name = "gpbCargaDatos";
            this.gpbCargaDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCargaDatos.Size = new System.Drawing.Size(289, 162);
            this.gpbCargaDatos.TabIndex = 1;
            this.gpbCargaDatos.TabStop = false;
            this.gpbCargaDatos.Text = "Carga de Datos:";
            // 
            // btnCargar
            // 
            this.btnCargar.Enabled = false;
            this.btnCargar.Location = new System.Drawing.Point(164, 122);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(107, 28);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(19, 122);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(107, 28);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // lblPrecioCarga
            // 
            this.lblPrecioCarga.AutoSize = true;
            this.lblPrecioCarga.Location = new System.Drawing.Point(19, 94);
            this.lblPrecioCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioCarga.Name = "lblPrecioCarga";
            this.lblPrecioCarga.Size = new System.Drawing.Size(49, 16);
            this.lblPrecioCarga.TabIndex = 5;
            this.lblPrecioCarga.Text = "Precio:";
            // 
            // txtPrecioCarga
            // 
            this.txtPrecioCarga.Location = new System.Drawing.Point(164, 90);
            this.txtPrecioCarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioCarga.Name = "txtPrecioCarga";
            this.txtPrecioCarga.Size = new System.Drawing.Size(105, 22);
            this.txtPrecioCarga.TabIndex = 4;
            this.txtPrecioCarga.TextChanged += new System.EventHandler(this.txtPrecioCarga_TextChanged);
            // 
            // cmbDestinoCarga
            // 
            this.cmbDestinoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoCarga.FormattingEnabled = true;
            this.cmbDestinoCarga.Location = new System.Drawing.Point(164, 57);
            this.cmbDestinoCarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestinoCarga.Name = "cmbDestinoCarga";
            this.cmbDestinoCarga.Size = new System.Drawing.Size(105, 24);
            this.cmbDestinoCarga.TabIndex = 3;
            this.cmbDestinoCarga.SelectedIndexChanged += new System.EventHandler(this.cmbDestinoCarga_SelectedIndexChanged);
            // 
            // lblDestinoCarga
            // 
            this.lblDestinoCarga.AutoSize = true;
            this.lblDestinoCarga.Location = new System.Drawing.Point(19, 60);
            this.lblDestinoCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinoCarga.Name = "lblDestinoCarga";
            this.lblDestinoCarga.Size = new System.Drawing.Size(56, 16);
            this.lblDestinoCarga.TabIndex = 2;
            this.lblDestinoCarga.Text = "Destino:";
            // 
            // cmbOrigenCarga
            // 
            this.cmbOrigenCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenCarga.FormattingEnabled = true;
            this.cmbOrigenCarga.Location = new System.Drawing.Point(164, 23);
            this.cmbOrigenCarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigenCarga.Name = "cmbOrigenCarga";
            this.cmbOrigenCarga.Size = new System.Drawing.Size(105, 24);
            this.cmbOrigenCarga.TabIndex = 1;
            this.cmbOrigenCarga.SelectedIndexChanged += new System.EventHandler(this.cmbOrigenCarga_SelectedIndexChanged);
            // 
            // lblOrigenCarga
            // 
            this.lblOrigenCarga.AutoSize = true;
            this.lblOrigenCarga.Location = new System.Drawing.Point(19, 27);
            this.lblOrigenCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigenCarga.Name = "lblOrigenCarga";
            this.lblOrigenCarga.Size = new System.Drawing.Size(50, 16);
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
            this.gpbConsultaDatos.Location = new System.Drawing.Point(672, 15);
            this.gpbConsultaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbConsultaDatos.Name = "gpbConsultaDatos";
            this.gpbConsultaDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbConsultaDatos.Size = new System.Drawing.Size(289, 162);
            this.gpbConsultaDatos.TabIndex = 2;
            this.gpbConsultaDatos.TabStop = false;
            this.gpbConsultaDatos.Text = "Consulta de Datos:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(164, 122);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(107, 28);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(19, 122);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 28);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblPrecioConsulta
            // 
            this.lblPrecioConsulta.AutoSize = true;
            this.lblPrecioConsulta.Location = new System.Drawing.Point(19, 94);
            this.lblPrecioConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioConsulta.Name = "lblPrecioConsulta";
            this.lblPrecioConsulta.Size = new System.Drawing.Size(49, 16);
            this.lblPrecioConsulta.TabIndex = 13;
            this.lblPrecioConsulta.Text = "Precio:";
            // 
            // txtPrecioConsulta
            // 
            this.txtPrecioConsulta.Location = new System.Drawing.Point(164, 90);
            this.txtPrecioConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioConsulta.Name = "txtPrecioConsulta";
            this.txtPrecioConsulta.ReadOnly = true;
            this.txtPrecioConsulta.Size = new System.Drawing.Size(105, 22);
            this.txtPrecioConsulta.TabIndex = 12;
            // 
            // cmbDestinoConsulta
            // 
            this.cmbDestinoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoConsulta.FormattingEnabled = true;
            this.cmbDestinoConsulta.Location = new System.Drawing.Point(164, 57);
            this.cmbDestinoConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestinoConsulta.Name = "cmbDestinoConsulta";
            this.cmbDestinoConsulta.Size = new System.Drawing.Size(105, 24);
            this.cmbDestinoConsulta.TabIndex = 11;
            // 
            // lblDestinoConsulta
            // 
            this.lblDestinoConsulta.AutoSize = true;
            this.lblDestinoConsulta.Location = new System.Drawing.Point(19, 60);
            this.lblDestinoConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinoConsulta.Name = "lblDestinoConsulta";
            this.lblDestinoConsulta.Size = new System.Drawing.Size(56, 16);
            this.lblDestinoConsulta.TabIndex = 10;
            this.lblDestinoConsulta.Text = "Destino:";
            // 
            // cmbOrigenConsulta
            // 
            this.cmbOrigenConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenConsulta.FormattingEnabled = true;
            this.cmbOrigenConsulta.Location = new System.Drawing.Point(164, 20);
            this.cmbOrigenConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigenConsulta.Name = "cmbOrigenConsulta";
            this.cmbOrigenConsulta.Size = new System.Drawing.Size(105, 24);
            this.cmbOrigenConsulta.TabIndex = 9;
            // 
            // lblOrigenConsulta
            // 
            this.lblOrigenConsulta.AutoSize = true;
            this.lblOrigenConsulta.Location = new System.Drawing.Point(19, 23);
            this.lblOrigenConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigenConsulta.Name = "lblOrigenConsulta";
            this.lblOrigenConsulta.Size = new System.Drawing.Size(50, 16);
            this.lblOrigenConsulta.TabIndex = 8;
            this.lblOrigenConsulta.Text = "Origen:";
            // 
            // lblListarViajes
            // 
            this.lblListarViajes.AutoSize = true;
            this.lblListarViajes.Location = new System.Drawing.Point(32, 302);
            this.lblListarViajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListarViajes.Name = "lblListarViajes";
            this.lblListarViajes.Size = new System.Drawing.Size(93, 16);
            this.lblListarViajes.TabIndex = 3;
            this.lblListarViajes.Text = "Listar viajes ....";
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(151, 298);
            this.cmbDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(112, 24);
            this.cmbDesde.TabIndex = 4;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(281, 298);
            this.btnListarDestinos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(132, 28);
            this.btnListarDestinos.TabIndex = 5;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            this.btnListarDestinos.Click += new System.EventHandler(this.btnListarDestinos_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(437, 302);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 6;
            this.lblHasta.Text = "Hasta";
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(496, 298);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(112, 24);
            this.cmbHasta.TabIndex = 7;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(627, 298);
            this.btnListarOrigenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(132, 28);
            this.btnListarOrigenes.TabIndex = 8;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            this.btnListarOrigenes.Click += new System.EventHandler(this.btnListarOrigenes_Click);
            // 
            // btnVerTodosViajes
            // 
            this.btnVerTodosViajes.Location = new System.Drawing.Point(780, 298);
            this.btnVerTodosViajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerTodosViajes.Name = "btnVerTodosViajes";
            this.btnVerTodosViajes.Size = new System.Drawing.Size(132, 28);
            this.btnVerTodosViajes.TabIndex = 9;
            this.btnVerTodosViajes.Text = "Ver todos los viajes";
            this.btnVerTodosViajes.UseVisualStyleBackColor = true;
            this.btnVerTodosViajes.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.AllowUserToAddRows = false;
            this.dgvGrafo.AllowUserToDeleteRows = false;
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Location = new System.Drawing.Point(16, 342);
            this.dgvGrafo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.ReadOnly = true;
            this.dgvGrafo.RowHeadersWidth = 51;
            this.dgvGrafo.Size = new System.Drawing.Size(944, 334);
            this.dgvGrafo.TabIndex = 10;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 699);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
