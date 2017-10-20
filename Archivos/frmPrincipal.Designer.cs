namespace Archivos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.gbLibros = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.mtxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.cmbTipoArchivo = new System.Windows.Forms.ComboBox();
            this.lblTipoArchivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtAnno = new System.Windows.Forms.MaskedTextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gbLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLibros
            // 
            this.gbLibros.Controls.Add(this.txtAnno);
            this.gbLibros.Controls.Add(this.txtEditorial);
            this.gbLibros.Controls.Add(this.label2);
            this.gbLibros.Controls.Add(this.label1);
            this.gbLibros.Controls.Add(this.btnBorrar);
            this.gbLibros.Controls.Add(this.btnGuardar);
            this.gbLibros.Controls.Add(this.txtAutor);
            this.gbLibros.Controls.Add(this.lblCodigo);
            this.gbLibros.Controls.Add(this.txtTitulo);
            this.gbLibros.Controls.Add(this.mtxCodigo);
            this.gbLibros.Controls.Add(this.lblAutor);
            this.gbLibros.Controls.Add(this.lblTitulo);
            this.gbLibros.Location = new System.Drawing.Point(15, 55);
            this.gbLibros.Margin = new System.Windows.Forms.Padding(6);
            this.gbLibros.Name = "gbLibros";
            this.gbLibros.Padding = new System.Windows.Forms.Padding(6);
            this.gbLibros.Size = new System.Drawing.Size(507, 192);
            this.gbLibros.TabIndex = 7;
            this.gbLibros.TabStop = false;
            this.gbLibros.Text = "Libro";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(369, 84);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 33);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(369, 32);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(89, 96);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(6);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(197, 24);
            this.txtAutor.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 35);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(89, 61);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(6);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(197, 24);
            this.txtTitulo.TabIndex = 4;
            // 
            // mtxCodigo
            // 
            this.mtxCodigo.Location = new System.Drawing.Point(89, 32);
            this.mtxCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.mtxCodigo.Mask = "99999";
            this.mtxCodigo.Name = "mtxCodigo";
            this.mtxCodigo.Size = new System.Drawing.Size(96, 24);
            this.mtxCodigo.TabIndex = 1;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(21, 99);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(43, 18);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 67);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(44, 18);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título";
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(12, 256);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowTemplate.Height = 33;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(510, 228);
            this.dgvLibros.TabIndex = 8;
            this.dgvLibros.SelectionChanged += new System.EventHandler(this.dgvLibros_SelectionChanged);
            // 
            // cmbTipoArchivo
            // 
            this.cmbTipoArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoArchivo.FormattingEnabled = true;
            this.cmbTipoArchivo.Location = new System.Drawing.Point(134, 17);
            this.cmbTipoArchivo.Name = "cmbTipoArchivo";
            this.cmbTipoArchivo.Size = new System.Drawing.Size(237, 25);
            this.cmbTipoArchivo.TabIndex = 0;
            this.cmbTipoArchivo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoArchivo_SelectedIndexChanged);
            // 
            // lblTipoArchivo
            // 
            this.lblTipoArchivo.AutoSize = true;
            this.lblTipoArchivo.Location = new System.Drawing.Point(15, 24);
            this.lblTipoArchivo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTipoArchivo.Name = "lblTipoArchivo";
            this.lblTipoArchivo.Size = new System.Drawing.Size(110, 18);
            this.lblTipoArchivo.TabIndex = 8;
            this.lblTipoArchivo.Text = "Tipo de Archivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editorial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Año";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(89, 128);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(96, 24);
            this.txtEditorial.TabIndex = 10;
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(89, 159);
            this.txtAnno.Mask = "0000";
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(96, 24);
            this.txtAnno.TabIndex = 12;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(557, 511);
            this.Controls.Add(this.lblTipoArchivo);
            this.Controls.Add(this.cmbTipoArchivo);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.gbLibros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Ejemplo Archivos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbLibros.ResumeLayout(false);
            this.gbLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLibros;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.MaskedTextBox mtxCodigo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.ComboBox cmbTipoArchivo;
        private System.Windows.Forms.Label lblTipoArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.MaskedTextBox txtAnno;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

