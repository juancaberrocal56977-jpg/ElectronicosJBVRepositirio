namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    partial class FrmModelo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoShow)).BeginInit();
            this.tlpOpcionesBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(129, 77);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(247, 29);
            this.txtDesc.TabIndex = 16;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(11, 85);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(103, 22);
            this.lblDes.TabIndex = 15;
            this.lblDes.Text = "Descripcion";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(129, 35);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(247, 29);
            this.txtCod.TabIndex = 14;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(11, 37);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(67, 22);
            this.lblCod.TabIndex = 13;
            this.lblCod.Text = "Codigo";
            // 
            // dgvInfoShow
            // 
            this.dgvInfoShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoShow.Location = new System.Drawing.Point(12, 159);
            this.dgvInfoShow.Name = "dgvInfoShow";
            this.dgvInfoShow.Size = new System.Drawing.Size(408, 184);
            this.dgvInfoShow.TabIndex = 12;
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
            this.tlpOpcionesBotones.Location = new System.Drawing.Point(426, 12);
            this.tlpOpcionesBotones.Name = "tlpOpcionesBotones";
            this.tlpOpcionesBotones.RowCount = 5;
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.50505F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.49495F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpOpcionesBotones.Size = new System.Drawing.Size(203, 331);
            this.tlpOpcionesBotones.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::UTN.Winform.Electronicos.Properties.Resources.ok_accept_17936;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(188, 62);
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
            this.btnSalir.Location = new System.Drawing.Point(6, 272);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 53);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Image = global::UTN.Winform.Electronicos.Properties.Resources.pencil_17925;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(6, 77);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(188, 61);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Image = global::UTN.Winform.Electronicos.Properties.Resources.page_17914;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 51);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Image = global::UTN.Winform.Electronicos.Properties.Resources.cut_scissors_17842;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(6, 147);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(188, 56);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // FrmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(637, 356);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.dgvInfoShow);
            this.Controls.Add(this.tlpOpcionesBotones);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModelo";
            this.Load += new System.EventHandler(this.FrmModelo_Load);
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
    }
}