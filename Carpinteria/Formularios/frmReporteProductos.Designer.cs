
namespace Carpinteria.Formularios
{
    partial class frmReporteProductos
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
            this.dSProductos = new Carpinteria.Reportes.DSProductos();
            this.dSProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_PRODUCTOSTableAdapter = new Carpinteria.Reportes.DSProductosTableAdapters.T_PRODUCTOSTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbReporte = new System.Windows.Forms.GroupBox();
            this.rvProducto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUCTOSBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSProductos
            // 
            this.dSProductos.DataSetName = "DSProductos";
            this.dSProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSProductosBindingSource
            // 
            this.dSProductosBindingSource.DataSource = this.dSProductos;
            this.dSProductosBindingSource.Position = 0;
            // 
            // tPRODUCTOSBindingSource
            // 
            this.tPRODUCTOSBindingSource.DataMember = "T_PRODUCTOS";
            this.tPRODUCTOSBindingSource.DataSource = this.dSProductos;
            // 
            // t_PRODUCTOSTableAdapter
            // 
            this.t_PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbReporte
            // 
            this.gbReporte.Controls.Add(this.rvProducto);
            this.gbReporte.Location = new System.Drawing.Point(12, 93);
            this.gbReporte.Name = "gbReporte";
            this.gbReporte.Size = new System.Drawing.Size(882, 535);
            this.gbReporte.TabIndex = 1;
            this.gbReporte.TabStop = false;
            this.gbReporte.Text = "Reporte";
            // 
            // rvProducto
            // 
            this.rvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvProducto.LocalReport.ReportEmbeddedResource = "Carpinteria.Reportes.rptTotalProducto.rdlc";
            this.rvProducto.Location = new System.Drawing.Point(3, 22);
            this.rvProducto.Name = "rvProducto";
            this.rvProducto.ServerReport.BearerToken = null;
            this.rvProducto.Size = new System.Drawing.Size(876, 510);
            this.rvProducto.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(927, 629);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 38);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(127, 25);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(212, 26);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(507, 25);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(212, 26);
            this.dtpHasta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "hasta";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(759, 18);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(117, 38);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 679);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbReporte);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReporteProductos";
            this.Text = "frmReporteProductos";
            this.Load += new System.EventHandler(this.frmReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUCTOSBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dSProductosBindingSource;
        private Reportes.DSProductos dSProductos;
        private System.Windows.Forms.BindingSource tPRODUCTOSBindingSource;
        private Reportes.DSProductosTableAdapters.T_PRODUCTOSTableAdapter t_PRODUCTOSTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rvProducto;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnSalir;
    }
}