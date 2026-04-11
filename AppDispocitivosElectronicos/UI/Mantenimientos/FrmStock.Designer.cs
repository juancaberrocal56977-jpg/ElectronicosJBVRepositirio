namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    partial class FrmStock
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
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblCod2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.dgvInfoShow = new System.Windows.Forms.DataGridView();
            this.tlpOpcionesBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbCodigoProducto = new System.Windows.Forms.ComboBox();
            this.lblObservar = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCodFactura = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pbDocumento = new System.Windows.Forms.PictureBox();
            this.nudTipo = new System.Windows.Forms.NumericUpDown();
            this.lblcStock = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.blEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoShow)).BeginInit();
            this.tlpOpcionesBotones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(135, 157);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(177, 29);
            this.txtObservaciones.TabIndex = 22;
            // 
            // lblCod2
            // 
            this.lblCod2.AutoSize = true;
            this.lblCod2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod2.Location = new System.Drawing.Point(6, 55);
            this.lblCod2.Name = "lblCod2";
            this.lblCod2.Size = new System.Drawing.Size(90, 19);
            this.lblCod2.TabIndex = 21;
            this.lblCod2.Text = "CodFactura";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(135, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(177, 29);
            this.txtCantidad.TabIndex = 20;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(321, 3);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(97, 19);
            this.lblCodProducto.TabIndex = 19;
            this.lblCodProducto.Text = "CodProducto";
            // 
            // dgvInfoShow
            // 
            this.dgvInfoShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoShow.Location = new System.Drawing.Point(12, 281);
            this.dgvInfoShow.Name = "dgvInfoShow";
            this.dgvInfoShow.Size = new System.Drawing.Size(699, 124);
            this.dgvInfoShow.TabIndex = 18;
            // 
            // tlpOpcionesBotones
            // 
            this.tlpOpcionesBotones.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpOpcionesBotones.ColumnCount = 1;
            this.tlpOpcionesBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOpcionesBotones.Controls.Add(this.btnAceptar, 0, 0);
            this.tlpOpcionesBotones.Controls.Add(this.btnSalir, 0, 4);
            this.tlpOpcionesBotones.Controls.Add(this.btnEditar, 0, 1);
            this.tlpOpcionesBotones.Controls.Add(this.btnLimpiar, 0, 3);
            this.tlpOpcionesBotones.Controls.Add(this.btnBorrar, 0, 2);
            this.tlpOpcionesBotones.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpOpcionesBotones.Location = new System.Drawing.Point(717, 12);
            this.tlpOpcionesBotones.Name = "tlpOpcionesBotones";
            this.tlpOpcionesBotones.RowCount = 5;
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.50505F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.49495F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOpcionesBotones.Size = new System.Drawing.Size(162, 393);
            this.tlpOpcionesBotones.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::UTN.Winform.Electronicos.Properties.Resources.ok_accept_17936;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 68);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::UTN.Winform.Electronicos.Properties.Resources.exit_delete_17889;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(6, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 56);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Image = global::UTN.Winform.Electronicos.Properties.Resources.pencil_17925;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(6, 88);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 64);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Image = global::UTN.Winform.Electronicos.Properties.Resources.page_17914;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 247);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 70);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Image = global::UTN.Winform.Electronicos.Properties.Resources.cut_scissors_17842;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(6, 168);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(150, 70);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cmbCodigoProducto
            // 
            this.cmbCodigoProducto.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoProducto.FormattingEnabled = true;
            this.cmbCodigoProducto.Location = new System.Drawing.Point(429, 6);
            this.cmbCodigoProducto.Name = "cmbCodigoProducto";
            this.cmbCodigoProducto.Size = new System.Drawing.Size(260, 30);
            this.cmbCodigoProducto.TabIndex = 23;
            // 
            // lblObservar
            // 
            this.lblObservar.AutoSize = true;
            this.lblObservar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservar.Location = new System.Drawing.Point(6, 154);
            this.lblObservar.Name = "lblObservar";
            this.lblObservar.Size = new System.Drawing.Size(105, 19);
            this.lblObservar.TabIndex = 26;
            this.lblObservar.Text = "Observaciones";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 103);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 19);
            this.lblCantidad.TabIndex = 25;
            this.lblCantidad.Text = "Cantidad";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.75235F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.24765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel1.Controls.Add(this.txtCodFactura, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDoc, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCodProducto, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtObservaciones, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblObservar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCod2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTipo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCantidad, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCantidad, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbDocumento, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudTipo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbCodigoProducto, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblcStock, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 3, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.04082F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.95918F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 211);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // txtCodFactura
            // 
            this.txtCodFactura.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFactura.Location = new System.Drawing.Point(135, 58);
            this.txtCodFactura.Name = "txtCodFactura";
            this.txtCodFactura.Size = new System.Drawing.Size(177, 29);
            this.txtCodFactura.TabIndex = 34;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(135, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(177, 29);
            this.txtCodigo.TabIndex = 33;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(321, 154);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(86, 19);
            this.lblDoc.TabIndex = 30;
            this.lblDoc.Text = "Documento";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(321, 103);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 19);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(321, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 19);
            this.lblTipo.TabIndex = 27;
            this.lblTipo.Text = "Tipo";
            // 
            // pbDocumento
            // 
            this.pbDocumento.BackgroundImage = global::UTN.Winform.Electronicos.Properties.Resources.My_Documents_27048__1_;
            this.pbDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDocumento.Location = new System.Drawing.Point(429, 157);
            this.pbDocumento.Name = "pbDocumento";
            this.pbDocumento.Size = new System.Drawing.Size(260, 48);
            this.pbDocumento.TabIndex = 31;
            this.pbDocumento.TabStop = false;
            this.pbDocumento.Click += new System.EventHandler(this.pbDocumento_Click);
            // 
            // nudTipo
            // 
            this.nudTipo.Location = new System.Drawing.Point(429, 58);
            this.nudTipo.Name = "nudTipo";
            this.nudTipo.Size = new System.Drawing.Size(260, 26);
            this.nudTipo.TabIndex = 32;
            // 
            // lblcStock
            // 
            this.lblcStock.AutoSize = true;
            this.lblcStock.Location = new System.Drawing.Point(6, 3);
            this.lblcStock.Name = "lblcStock";
            this.lblcStock.Size = new System.Drawing.Size(57, 19);
            this.lblcStock.TabIndex = 29;
            this.lblcStock.Text = "Codigo";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(429, 106);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(260, 26);
            this.dtpFecha.TabIndex = 35;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Image = global::UTN.Winform.Electronicos.Properties.Resources.ok_accept_17936;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox1.Location = new System.Drawing.Point(181, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 48);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Activo           ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Image = global::UTN.Winform.Electronicos.Properties.Resources.exit_delete_17889;
            this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox2.Location = new System.Drawing.Point(463, 229);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(123, 48);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Inactivo          ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // blEstado
            // 
            this.blEstado.AutoSize = true;
            this.blEstado.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blEstado.Location = new System.Drawing.Point(18, 241);
            this.blEstado.Name = "blEstado";
            this.blEstado.Size = new System.Drawing.Size(55, 19);
            this.blEstado.TabIndex = 30;
            this.blEstado.Text = "Estado";
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(877, 417);
            this.Controls.Add(this.blEstado);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvInfoShow);
            this.Controls.Add(this.tlpOpcionesBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoShow)).EndInit();
            this.tlpOpcionesBotones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblCod2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.DataGridView dgvInfoShow;
        private System.Windows.Forms.TableLayoutPanel tlpOpcionesBotones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbCodigoProducto;
        private System.Windows.Forms.Label lblObservar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblcStock;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtCodFactura;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pbDocumento;
        private System.Windows.Forms.NumericUpDown nudTipo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label blEstado;
    }
}