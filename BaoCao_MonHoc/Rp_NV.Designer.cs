
namespace BaoCao_MonHoc
{
    partial class Rp_NV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLy_DienThoaiDataSet = new BaoCao_MonHoc.QuanLy_DienThoaiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nhanvienTableAdapter = new BaoCao_MonHoc.QuanLy_DienThoaiDataSetTableAdapters.nhanvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLy_DienThoaiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.QuanLy_DienThoaiDataSet;
            // 
            // QuanLy_DienThoaiDataSet
            // 
            this.QuanLy_DienThoaiDataSet.DataSetName = "QuanLy_DienThoaiDataSet";
            this.QuanLy_DienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.nhanvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BaoCao_MonHoc.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1066, 556);
            this.reportViewer1.TabIndex = 0;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // Rp_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 556);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rp_NV";
            this.Text = "Rp_NV";
            this.Load += new System.EventHandler(this.Rp_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLy_DienThoaiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private QuanLy_DienThoaiDataSet QuanLy_DienThoaiDataSet;
        private QuanLy_DienThoaiDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
    }
}