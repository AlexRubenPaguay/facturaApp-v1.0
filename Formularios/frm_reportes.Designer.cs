namespace FACTURA_TEST1.Formularios
{
    partial class frm_reportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reportes));
            this.visualizarfacturaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Ventas = new FACTURA_TEST1.ds.Ds_Ventas();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscarFactura = new System.Windows.Forms.TextBox();
            this.btn_buscarFactura = new System.Windows.Forms.Button();
            this.reportviewer_factura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.visualizarfacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualizar_facturaTableAdapter = new FACTURA_TEST1.ds.Ds_VentasTableAdapters.visualizar_facturaTableAdapter();
            this.visualizar_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualizarfacturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visualizarfacturaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizarfacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizar_facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizarfacturaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // visualizarfacturaBindingSource2
            // 
            this.visualizarfacturaBindingSource2.DataMember = "visualizar_factura";
            this.visualizarfacturaBindingSource2.DataSource = this.ds_Ventas;
            // 
            // ds_Ventas
            // 
            this.ds_Ventas.DataSetName = "Ds_Ventas";
            this.ds_Ventas.Locale = new System.Globalization.CultureInfo("es-EC");
            this.ds_Ventas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Número de Factura: ";
            // 
            // txt_buscarFactura
            // 
            this.txt_buscarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarFactura.Location = new System.Drawing.Point(480, 24);
            this.txt_buscarFactura.Name = "txt_buscarFactura";
            this.txt_buscarFactura.Size = new System.Drawing.Size(262, 30);
            this.txt_buscarFactura.TabIndex = 1;
            this.txt_buscarFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_buscarFactura
            // 
            this.btn_buscarFactura.Location = new System.Drawing.Point(761, 12);
            this.btn_buscarFactura.Name = "btn_buscarFactura";
            this.btn_buscarFactura.Size = new System.Drawing.Size(132, 59);
            this.btn_buscarFactura.TabIndex = 2;
            this.btn_buscarFactura.Text = "Buscar";
            this.btn_buscarFactura.UseVisualStyleBackColor = true;
            this.btn_buscarFactura.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportviewer_factura
            // 
            reportDataSource1.Name = "Ds_Ventas";
            reportDataSource1.Value = this.visualizarfacturaBindingSource2;
            this.reportviewer_factura.LocalReport.DataSources.Add(reportDataSource1);
            this.reportviewer_factura.LocalReport.ReportEmbeddedResource = "FACTURA_TEST1.Reportes.rpt_factura.rdlc";
            this.reportviewer_factura.Location = new System.Drawing.Point(2, 93);
            this.reportviewer_factura.Name = "reportviewer_factura";
            this.reportviewer_factura.ServerReport.BearerToken = null;
            this.reportviewer_factura.Size = new System.Drawing.Size(1093, 511);
            this.reportviewer_factura.TabIndex = 3;
            this.reportviewer_factura.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // visualizarfacturaBindingSource
            // 
            this.visualizarfacturaBindingSource.DataMember = "visualizar_factura";
            this.visualizarfacturaBindingSource.DataSource = this.ds_Ventas;
            // 
            // visualizar_facturaTableAdapter
            // 
            this.visualizar_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // visualizar_facturaBindingSource
            // 
            this.visualizar_facturaBindingSource.DataMember = "visualizar_factura";
            this.visualizar_facturaBindingSource.DataSource = this.ds_Ventas;
            // 
            // visualizarfacturaBindingSource1
            // 
            this.visualizarfacturaBindingSource1.DataMember = "visualizar_factura";
            this.visualizarfacturaBindingSource1.DataSource = this.ds_Ventas;
            // 
            // frm_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 603);
            this.Controls.Add(this.reportviewer_factura);
            this.Controls.Add(this.btn_buscarFactura);
            this.Controls.Add(this.txt_buscarFactura);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualizarfacturaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizarfacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizar_facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizarfacturaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscarFactura;
        private System.Windows.Forms.Button btn_buscarFactura;
        private Microsoft.Reporting.WinForms.ReportViewer reportviewer_factura;
        private System.Windows.Forms.BindingSource visualizarfacturaBindingSource;
        private ds.Ds_Ventas ds_Ventas;
        private ds.Ds_VentasTableAdapters.visualizar_facturaTableAdapter visualizar_facturaTableAdapter;
        private System.Windows.Forms.BindingSource visualizar_facturaBindingSource;
        private System.Windows.Forms.BindingSource visualizarfacturaBindingSource1;
        private System.Windows.Forms.BindingSource visualizarfacturaBindingSource2;
    }
}