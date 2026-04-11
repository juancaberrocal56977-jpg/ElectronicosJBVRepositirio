namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    partial class FrmCliente
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.dgvInfoShow = new System.Windows.Forms.DataGridView();
            this.tlpOpcionesBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.tlpControlesCliente = new System.Windows.Forms.TableLayoutPanel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConsultarId = new System.Windows.Forms.ToolStripButton();
            this.lblImg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoShow)).BeginInit();
            this.tlpOpcionesBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.tlpControlesCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(121, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 29);
            this.txtNombre.TabIndex = 22;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(6, 41);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(73, 22);
            this.lblDes.TabIndex = 21;
            this.lblDes.Text = "Nombre";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(121, 6);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(150, 29);
            this.txtCod.TabIndex = 20;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(6, 3);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(67, 22);
            this.lblCod.TabIndex = 19;
            this.lblCod.Text = "Codigo";
            // 
            // dgvInfoShow
            // 
            this.dgvInfoShow.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvInfoShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoShow.Location = new System.Drawing.Point(21, 355);
            this.dgvInfoShow.Name = "dgvInfoShow";
            this.dgvInfoShow.Size = new System.Drawing.Size(708, 251);
            this.dgvInfoShow.TabIndex = 18;
            this.dgvInfoShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoShow_CellContentClick);
            // 
            // tlpOpcionesBotones
            // 
            this.tlpOpcionesBotones.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpOpcionesBotones.ColumnCount = 1;
            this.tlpOpcionesBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOpcionesBotones.Controls.Add(this.btnSalir, 0, 4);
            this.tlpOpcionesBotones.Controls.Add(this.btnEditar, 0, 1);
            this.tlpOpcionesBotones.Controls.Add(this.btnLimpiar, 0, 3);
            this.tlpOpcionesBotones.Controls.Add(this.btnBorrar, 0, 2);
            this.tlpOpcionesBotones.Controls.Add(this.btnAceptar, 0, 0);
            this.tlpOpcionesBotones.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpOpcionesBotones.Location = new System.Drawing.Point(872, 74);
            this.tlpOpcionesBotones.Name = "tlpOpcionesBotones";
            this.tlpOpcionesBotones.RowCount = 5;
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.50505F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.49495F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlpOpcionesBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpOpcionesBotones.Size = new System.Drawing.Size(203, 416);
            this.tlpOpcionesBotones.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::UTN.Winform.Electronicos.Properties.Resources.exit_delete_17889;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(6, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 73);
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
            this.btnEditar.Location = new System.Drawing.Point(6, 76);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(188, 60);
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
            this.btnLimpiar.Location = new System.Drawing.Point(6, 221);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 70);
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
            this.btnBorrar.Location = new System.Drawing.Point(6, 145);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(188, 67);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::UTN.Winform.Electronicos.Properties.Resources.ok_accept_17936;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(188, 61);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 29);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Direccion";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(121, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 29);
            this.textBox2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Correo";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(121, 209);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(150, 29);
            this.txtApellido2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Apellido 2";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(121, 166);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(150, 29);
            this.txtApellido1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Apellido";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(121, 254);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 29);
            this.textBox5.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Telefono";
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbImagen.BackgroundImage = global::UTN.Winform.Electronicos.Properties.Resources.live_pictures_15405;
            this.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagen.Location = new System.Drawing.Point(735, 89);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(106, 121);
            this.pbImagen.TabIndex = 33;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // tlpControlesCliente
            // 
            this.tlpControlesCliente.BackColor = System.Drawing.Color.Transparent;
            this.tlpControlesCliente.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpControlesCliente.ColumnCount = 4;
            this.tlpControlesCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.92635F));
            this.tlpControlesCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.07365F));
            this.tlpControlesCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tlpControlesCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tlpControlesCliente.Controls.Add(this.textBox5, 1, 6);
            this.tlpControlesCliente.Controls.Add(this.textBox11, 3, 2);
            this.tlpControlesCliente.Controls.Add(this.label9, 2, 2);
            this.tlpControlesCliente.Controls.Add(this.lblCod, 0, 0);
            this.tlpControlesCliente.Controls.Add(this.txtCod, 1, 0);
            this.tlpControlesCliente.Controls.Add(this.label5, 0, 6);
            this.tlpControlesCliente.Controls.Add(this.label12, 2, 1);
            this.tlpControlesCliente.Controls.Add(this.numericUpDown1, 3, 1);
            this.tlpControlesCliente.Controls.Add(this.txtApellido2, 1, 5);
            this.tlpControlesCliente.Controls.Add(this.label6, 2, 0);
            this.tlpControlesCliente.Controls.Add(this.txtNombre, 1, 1);
            this.tlpControlesCliente.Controls.Add(this.label3, 0, 5);
            this.tlpControlesCliente.Controls.Add(this.label2, 0, 2);
            this.tlpControlesCliente.Controls.Add(this.txtApellido1, 1, 4);
            this.tlpControlesCliente.Controls.Add(this.textBox2, 1, 2);
            this.tlpControlesCliente.Controls.Add(this.label4, 0, 4);
            this.tlpControlesCliente.Controls.Add(this.label1, 0, 3);
            this.tlpControlesCliente.Controls.Add(this.textBox1, 1, 3);
            this.tlpControlesCliente.Controls.Add(this.lblDes, 0, 1);
            this.tlpControlesCliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpControlesCliente.Location = new System.Drawing.Point(21, 58);
            this.tlpControlesCliente.Name = "tlpControlesCliente";
            this.tlpControlesCliente.RowCount = 7;
            this.tlpControlesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControlesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControlesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpControlesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpControlesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpControlesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpControlesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpControlesCliente.Size = new System.Drawing.Size(708, 291);
            this.tlpControlesCliente.TabIndex = 34;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(489, 82);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(205, 29);
            this.textBox11.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "TipoIdentificacion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(280, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "Estado";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(489, 44);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(205, 22);
            this.numericUpDown1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Provincia";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultarId});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1087, 55);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnConsultarId
            // 
            this.btnConsultarId.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConsultarId.Image = global::UTN.Winform.Electronicos.Properties.Resources.search_14765;
            this.btnConsultarId.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConsultarId.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultarId.Name = "btnConsultarId";
            this.btnConsultarId.Size = new System.Drawing.Size(52, 52);
            this.btnConsultarId.Text = "tsbtnBuscarID";
            this.btnConsultarId.Click += new System.EventHandler(this.btnConsultarId_Click);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.Location = new System.Drawing.Point(735, 64);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(46, 22);
            this.lblImg.TabIndex = 34;
            this.lblImg.Text = "Foto";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1087, 614);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tlpControlesCliente);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.dgvInfoShow);
            this.Controls.Add(this.tlpOpcionesBotones);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoShow)).EndInit();
            this.tlpOpcionesBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.tlpControlesCliente.ResumeLayout(false);
            this.tlpControlesCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TableLayoutPanel tlpControlesCliente;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConsultarId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblImg;
    }
}