
namespace BaoCao_MonHoc
{
    partial class Rp_KH
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
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLy_DienThoaiDataSet = new BaoCao_MonHoc.QuanLy_DienThoaiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.khachhangTableAdapter = new BaoCao_MonHoc.QuanLy_DienThoaiDataSetTableAdapters.khachhangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLy_DienThoaiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "khachhang";
            this.khachhangBindingSource.DataSource = this.QuanLy_DienThoaiDataSet;
            // 
            // QuanLy_DienThoaiDataSet
            // 
            this.QuanLy_DienThoaiDataSet.DataSetName = "QuanLy_DienThoaiDataSet";
            this.QuanLy_DienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.khachhangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BaoCao_MonHoc.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1013, 533);
            this.reportViewer1.TabIndex = 0;
          
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // Rp_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 533);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rp_KH";
            this.Text = "Rp_KH";
            this.Load += new System.EventHandler(this.Rp_KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLy_DienThoaiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private QuanLy_DienThoaiDataSet QuanLy_DienThoaiDataSet;
        private QuanLy_DienThoaiDataSetTableAdapters.khachhangTableAdapter khachhangTableAdapter;
    }
}