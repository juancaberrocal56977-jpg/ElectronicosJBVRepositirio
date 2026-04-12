namespace AppReportesElectronicos.Reporteria
{
    partial class FrmReporteCliente
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
            this.btnReporteCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReporteCliente
            // 
            this.btnReporteCliente.Location = new System.Drawing.Point(107, 47);
            this.btnReporteCliente.Name = "btnReporteCliente";
            this.btnReporteCliente.Size = new System.Drawing.Size(183, 55);
            this.btnReporteCliente.TabIndex = 0;
            this.btnReporteCliente.Text = "Crear Reporte";
            this.btnReporteCliente.UseVisualStyleBackColor = true;
            this.btnReporteCliente.Click += new System.EventHandler(this.btnReporteCliente_Click);
            // 
            // FrmReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 161);
            this.Controls.Add(this.btnReporteCliente);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmReporteCliente";
            this.Text = "FrmReporteCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporteCliente;
    }
}