namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    partial class FrmImpuesto
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
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.dgvInfoShow = new System.Windows.Forms.DataGridView();
            this.tlpOpcionesBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoShow)).BeginInit();
            this.tlpOpcionesBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentaje.Location = new System.Drawing.Point(107, 53);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(268, 29);
            this.txtPorcentaje.TabIndex = 22;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(8, 60);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(93, 22);
            this.lblDes.TabIndex = 21;
            this.lblDes.Text = "Porcentaje";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(107, 11);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(268, 29);
            this.txtCod.TabIndex = 20;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(8, 12);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(67, 22);
            this.lblCod.TabIndex = 19;
            this.lblCod.Text = "Codigo";
            // 
            // dgvInfoShow
            // 
            this.dgvInfoShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoShow.Location = new System.Drawing.Point(12, 97);
            this.dgvInfoShow.Name = "dgvInfoShow";
            this.dgvInfoShow.Size = new System.Drawing.Size(419, 194);
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
            this.tlpOpcionesBotones.Location = new System.Drawing.Point(438, 12);
            this.tlpOpcionesBotones.Name = "tlpOpcionesBotones";
            this.tlpOpcionesBotones.RowCount = 5;
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.08197F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.91803F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpOpcionesBotones.Size = new System.Drawing.Size(203, 305);
            this.tlpOpcionesBotones.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::UTN.Winform.Electronicos.Properties.Resources.ok_accept_17936;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(188, 44);
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
            this.btnSalir.Location = new System.Drawing.Point(6, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Image = global::UTN.Winform.Electronicos.Properties.Resources.pencil_17925;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(6, 59);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(188, 55);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Image = global::UTN.Winform.Electronicos.Properties.Resources.page_17914;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 186);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 54);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Image = global::UTN.Winform.Electronicos.Properties.Resources.cut_scissors_17842;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(6, 123);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(188, 54);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // FrmImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(648, 334);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.dgvInfoShow);
            this.Controls.Add(this.tlpOpcionesBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmImpuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImpuesto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoShow)).EndInit();
            this.tlpOpcionesBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPorcentaje;
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
    }
}