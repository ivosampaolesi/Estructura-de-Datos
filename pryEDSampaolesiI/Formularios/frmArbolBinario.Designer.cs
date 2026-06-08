namespace pryEDSampaolesiI.Formularios
{
    partial class frmArbolBinario
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramiteN = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblNombreN = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigoN = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.columCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optInOrden = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(885, 43);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(373, 485);
            this.treeView1.TabIndex = 0;
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
            this.groupBox3.Location = new System.Drawing.Point(324, 43);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(235, 229);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(12, 153);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(203, 52);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramiteN
            // 
            this.lblTramiteN.AutoSize = true;
            this.lblTramiteN.Location = new System.Drawing.Point(8, 124);
            this.lblTramiteN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteN.Name = "lblTramiteN";
            this.lblTramiteN.Size = new System.Drawing.Size(56, 16);
            this.lblTramiteN.TabIndex = 5;
            this.lblTramiteN.Text = "Tramite:";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(93, 121);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 4;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // lblNombreN
            // 
            this.lblNombreN.AutoSize = true;
            this.lblNombreN.Location = new System.Drawing.Point(8, 84);
            this.lblNombreN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreN.Name = "lblNombreN";
            this.lblNombreN.Size = new System.Drawing.Size(59, 16);
            this.lblNombreN.TabIndex = 3;
            this.lblNombreN.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblCodigoN
            // 
            this.lblCodigoN.AutoSize = true;
            this.lblCodigoN.Location = new System.Drawing.Point(8, 44);
            this.lblCodigoN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoN.Name = "lblCodigoN";
            this.lblCodigoN.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoN.TabIndex = 1;
            this.lblCodigoN.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(117, 41);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(108, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLista);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(585, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(235, 127);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Elemento";
            // 
            // cmbLista
            // 
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Location = new System.Drawing.Point(96, 28);
            this.cmbLista.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(108, 24);
            this.cmbLista.TabIndex = 8;
            this.cmbLista.SelectedIndexChanged += new System.EventHandler(this.cmbLista_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(32, 71);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(173, 39);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo:";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Enabled = false;
            this.btnEquilibrar.Location = new System.Drawing.Point(604, 196);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(203, 52);
            this.btnEquilibrar.TabIndex = 9;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columCodigo,
            this.columnNombre,
            this.columnTramite});
            this.dgvListaDoble.Location = new System.Drawing.Point(320, 295);
            this.dgvListaDoble.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersWidth = 51;
            this.dgvListaDoble.Size = new System.Drawing.Size(548, 233);
            this.dgvListaDoble.TabIndex = 15;
            // 
            // columCodigo
            // 
            this.columCodigo.HeaderText = "Codigo";
            this.columCodigo.MinimumWidth = 6;
            this.columCodigo.Name = "columCodigo";
            this.columCodigo.Width = 60;
            // 
            // columnNombre
            // 
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.MinimumWidth = 6;
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.Width = 180;
            // 
            // columnTramite
            // 
            this.columnTramite.HeaderText = "Tramite";
            this.columnTramite.MinimumWidth = 6;
            this.columnTramite.Name = "columnTramite";
            this.columnTramite.Width = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optPostOrden);
            this.groupBox1.Controls.Add(this.optPreOrden);
            this.groupBox1.Controls.Add(this.optInOrden);
            this.groupBox1.Location = new System.Drawing.Point(45, 295);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(235, 229);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado del arbol";
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(39, 167);
            this.optPostOrden.Margin = new System.Windows.Forms.Padding(4);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(96, 20);
            this.optPostOrden.TabIndex = 2;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.CheckedChanged += new System.EventHandler(this.optPostOrden_CheckedChanged);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(39, 108);
            this.optPreOrden.Margin = new System.Windows.Forms.Padding(4);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(90, 20);
            this.optPreOrden.TabIndex = 1;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optPreOrden_CheckedChanged);
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Location = new System.Drawing.Point(39, 49);
            this.optInOrden.Margin = new System.Windows.Forms.Padding(4);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(79, 20);
            this.optInOrden.TabIndex = 0;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In-Orden";
            this.optInOrden.UseVisualStyleBackColor = true;
            this.optInOrden.CheckedChanged += new System.EventHandler(this.optInOrden_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDSampaolesiI.Properties.Resources.arbol_binario;
            this.pictureBox1.Location = new System.Drawing.Point(45, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListaDoble);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArbolBinario";
            this.Text = "frmArbolBinario";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramiteN;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblNombreN;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigoN;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTramite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrden;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
