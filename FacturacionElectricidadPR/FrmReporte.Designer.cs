namespace FacturacionElectricidadPR
{
    partial class FrmReporte
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
            this.RwFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnBuscarContrato = new System.Windows.Forms.Button();
            this.TxtContrato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RwFacturas
            // 
            this.RwFacturas.LocalReport.ReportEmbeddedResource = "FacturacionElectricidadPR.RpFacturaPR.rdlc";
            this.RwFacturas.Location = new System.Drawing.Point(9, 50);
            this.RwFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.RwFacturas.Name = "RwFacturas";
            this.RwFacturas.ServerReport.BearerToken = null;
            this.RwFacturas.Size = new System.Drawing.Size(939, 498);
            this.RwFacturas.TabIndex = 1;
            // 
            // BtnBuscarContrato
            // 
            this.BtnBuscarContrato.Location = new System.Drawing.Point(257, 19);
            this.BtnBuscarContrato.Name = "BtnBuscarContrato";
            this.BtnBuscarContrato.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarContrato.TabIndex = 2;
            this.BtnBuscarContrato.Text = "Buscar";
            this.BtnBuscarContrato.UseVisualStyleBackColor = true;
            this.BtnBuscarContrato.Click += new System.EventHandler(this.BtnBuscarContrato_Click);
            // 
            // TxtContrato
            // 
            this.TxtContrato.Location = new System.Drawing.Point(151, 22);
            this.TxtContrato.Name = "TxtContrato";
            this.TxtContrato.Size = new System.Drawing.Size(100, 20);
            this.TxtContrato.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "No. Contrato";
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContrato);
            this.Controls.Add(this.BtnBuscarContrato);
            this.Controls.Add(this.RwFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer RwFacturas;
        private System.Windows.Forms.Button BtnBuscarContrato;
        private System.Windows.Forms.TextBox TxtContrato;
        private System.Windows.Forms.Label label1;
    }
}