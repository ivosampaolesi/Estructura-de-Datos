namespace pryEDSampaolesiI
{
    partial class frmCola
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoN = new System.Windows.Forms.Label();
            this.lblNombreN = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTramiteN = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.columCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCola);
            this.groupBox1.Controls.Add(this.lstCola);
            this.groupBox1.Location = new System.Drawing.Point(12, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado en Lista y en Grilla";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.lblTramite);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Elemento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.lblTramiteN);
            this.groupBox3.Controls.Add(this.txtTramite);
            this.groupBox3.Controls.Add(this.lblNombreN);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.lblCodigoN);
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Location = new System.Drawing.Point(222, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 173);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuevo Elemento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(88, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(82, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigoN
            // 
            this.lblCodigoN.AutoSize = true;
            this.lblCodigoN.Location = new System.Drawing.Point(6, 36);
            this.lblCodigoN.Name = "lblCodigoN";
            this.lblCodigoN.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoN.TabIndex = 1;
            this.lblCodigoN.Text = "Codigo:";
            // 
            // lblNombreN
            // 
            this.lblNombreN.AutoSize = true;
            this.lblNombreN.Location = new System.Drawing.Point(6, 68);
            this.lblNombreN.Name = "lblNombreN";
            this.lblNombreN.Size = new System.Drawing.Size(47, 13);
            this.lblNombreN.TabIndex = 3;
            this.lblNombreN.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(70, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblTramiteN
            // 
            this.lblTramiteN.AutoSize = true;
            this.lblTramiteN.Location = new System.Drawing.Point(6, 101);
            this.lblTramiteN.Name = "lblTramiteN";
            this.lblTramiteN.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteN.TabIndex = 5;
            this.lblTramiteN.Text = "Tramite:";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(70, 98);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tramite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Location = new System.Drawing.Point(88, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 20);
            this.lblCodigo.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(70, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 20);
            this.lblNombre.TabIndex = 10;
            // 
            // lblTramite
            // 
            this.lblTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite.Location = new System.Drawing.Point(70, 98);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(100, 20);
            this.lblTramite.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(24, 124);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(130, 32);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(6, 19);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(185, 173);
            this.lstCola.TabIndex = 0;
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columCodigo,
            this.columnNombre,
            this.columnTramite});
            this.dgvCola.Location = new System.Drawing.Point(200, 19);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(361, 172);
            this.dgvCola.TabIndex = 1;
            // 
            // columCodigo
            // 
            this.columCodigo.HeaderText = "Codigo";
            this.columCodigo.Name = "columCodigo";
            this.columCodigo.Width = 60;
            // 
            // columnNombre
            // 
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.Width = 180;
            // 
            // columnTramite
            // 
            this.columnTramite.HeaderText = "Tramite";
            this.columnTramite.Name = "columnTramite";
            this.columnTramite.Width = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDSampaolesiI.Properties.Resources.Cola;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica Lineal - Cola";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTramiteN;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblNombreN;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTramite;
    }
}