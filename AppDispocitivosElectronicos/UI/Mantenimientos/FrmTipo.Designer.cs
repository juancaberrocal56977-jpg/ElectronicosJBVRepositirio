namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    partial class FrmTipo
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.dgvInfoShow = new System.Windows.Forms.DataGridView();
            this.tlpOpcionesBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.blEstado = new System.Windows.Forms.Label();
            this.ckInactivo = new System.Windows.Forms.CheckBox();
            this.ckActivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoShow)).BeginInit();
            this.tlpOpcionesBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(139, 78);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(249, 29);
            this.txtDesc.TabIndex = 22;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(21, 86);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(73, 22);
            this.lblDes.TabIndex = 21;
            this.lblDes.Text = "Nombre";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(139, 26);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(249, 29);
            this.txtCod.TabIndex = 20;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(21, 28);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(67, 22);
            this.lblCod.TabIndex = 19;
            this.lblCod.Text = "Codigo";
            // 
            // dgvInfoShow
            // 
            this.dgvInfoShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoShow.Location = new System.Drawing.Point(12, 171);
            this.dgvInfoShow.Name = "dgvInfoShow";
            this.dgvInfoShow.Size = new System.Drawing.Size(426, 151);
            this.dgvInfoShow.TabIndex = 18;
            // 
            // tlpOpcionesBotones
            // 
            this.tlpOpcionesBotones.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpOpcionesBotones.ColumnCount = 1;
            this.tlpOpcionesBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOpcionesBotones.Controls.Add(this.btnAceptar, 0, 0);
            this.tlpOpcionesBotones.Controls.Add(this.btnLimpiar, 0, 3);
            this.tlpOpcionesBotones.Controls.Add(this.btnBorrar, 0, 2);
            this.tlpOpcionesBotones.Controls.Add(this.btnSalir, 0, 4);
            this.tlpOpcionesBotones.Controls.Add(this.btnEditar, 0, 1);
            this.tlpOpcionesBotones.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpOpcionesBotones.Location = new System.Drawing.Point(444, 26);
            this.tlpOpcionesBotones.Name = "tlpOpcionesBotones";
            this.tlpOpcionesBotones.RowCount = 5;
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpOpcionesBotones.Size = new System.Drawing.Size(184, 296);
            this.tlpOpcionesBotones.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::UTN.Winform.Electronicos.Properties.Resources.ok_accept_17936;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(172, 55);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Image = global::UTN.Winform.Electronicos.Properties.Resources.page_17914;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 192);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(172, 45);
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
            this.btnBorrar.Location = new System.Drawing.Point(6, 131);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(172, 52);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::UTN.Winform.Electronicos.Properties.Resources.exit_delete_17889;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(6, 246);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(172, 44);
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
            this.btnEditar.Location = new System.Drawing.Point(6, 70);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(172, 52);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // blEstado
            // 
            this.blEstado.AutoSize = true;
            this.blEstado.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blEstado.Location = new System.Drawing.Point(15, 131);
            this.blEstado.Name = "blEstado";
            this.blEstado.Size = new System.Drawing.Size(55, 19);
            this.blEstado.TabIndex = 33;
            this.blEstado.Text = "Estado";
            // 
            // ckInactivo
            // 
            this.ckInactivo.AutoSize = true;
            this.ckInactivo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckInactivo.Image = global::UTN.Winform.Electronicos.Properties.Resources.exit_delete_17889;
            this.ckInactivo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ckInactivo.Location = new System.Drawing.Point(277, 117);
            this.ckInactivo.Name = "ckInactivo";
            this.ckInactivo.Size = new System.Drawing.Size(123, 48);
            this.ckInactivo.TabIndex = 32;
            this.ckInactivo.Text = "Inactivo          ";
            this.ckInactivo.UseVisualStyleBackColor = true;
            // 
            // ckActivo
            // 
            this.ckActivo.AutoSize = true;
            this.ckActivo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckActivo.Image = global::UTN.Winform.Electronicos.Properties.Resources.ok_accept_17936;
            this.ckActivo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ckActivo.Location = new System.Drawing.Point(122, 113);
            this.ckActivo.Name = "ckActivo";
            this.ckActivo.Size = new System.Drawing.Size(115, 48);
            this.ckActivo.TabIndex = 31;
            this.ckActivo.Text = "Activo           ";
            this.ckActivo.UseVisualStyleBackColor = true;
            // 
            // FrmTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(637, 336);
            this.Controls.Add(this.blEstado);
            this.Controls.Add(this.ckInactivo);
            this.Controls.Add(this.ckActivo);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.dgvInfoShow);
            this.Controls.Add(this.tlpOpcionesBotones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTipo";
            this.Load += new System.EventHandler(this.FrmTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoShow)).EndInit();
            this.tlpOpcionesBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.DataGridView dgvInfoShow;
        private System.Windows.Forms.TableLayoutPanel tlpOpcionesBotones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label blEstado;
        private System.Windows.Forms.CheckBox ckInactivo;
        private System.Windows.Forms.CheckBox ckActivo;
    }
}