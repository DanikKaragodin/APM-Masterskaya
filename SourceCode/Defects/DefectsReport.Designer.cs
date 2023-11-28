namespace BD5
{
    partial class DefectsReport
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
            this.запчастиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мастерскаяDataSet = new BD5.МастерскаяDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.запчастиTableAdapter = new BD5.МастерскаяDataSetTableAdapters.ЗапчастиTableAdapter();
            this.НеисправностьСЗапчастямиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.неисправностьСЗапчастямиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.неисправностьСЗапчастямиTableAdapter = new BD5.МастерскаяDataSetTableAdapters.НеисправностьСЗапчастямиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.НеисправностьСЗапчастямиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.неисправностьСЗапчастямиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // запчастиBindingSource
            // 
            this.запчастиBindingSource.DataMember = "Запчасти";
            this.запчастиBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // мастерскаяDataSet
            // 
            this.мастерскаяDataSet.DataSetName = "МастерскаяDataSet";
            this.мастерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.неисправностьСЗапчастямиBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BD5.Defects.Defects.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // запчастиTableAdapter
            // 
            this.запчастиTableAdapter.ClearBeforeFill = true;
            // 
            // НеисправностьСЗапчастямиBindingSource
            // 
            this.НеисправностьСЗапчастямиBindingSource.DataMember = "НеисправностьСЗапчастями";
            this.НеисправностьСЗапчастямиBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // неисправностьСЗапчастямиBindingSource1
            // 
            this.неисправностьСЗапчастямиBindingSource1.DataMember = "НеисправностьСЗапчастями";
            this.неисправностьСЗапчастямиBindingSource1.DataSource = this.мастерскаяDataSet;
            // 
            // неисправностьСЗапчастямиTableAdapter
            // 
            this.неисправностьСЗапчастямиTableAdapter.ClearBeforeFill = true;
            // 
            // DefectsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DefectsReport";
            this.Text = "СlientReport";
            this.Load += new System.EventHandler(this.MasterReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.НеисправностьСЗапчастямиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.неисправностьСЗапчастямиBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private МастерскаяDataSet мастерскаяDataSet;
        private System.Windows.Forms.BindingSource запчастиBindingSource;
        private МастерскаяDataSetTableAdapters.ЗапчастиTableAdapter запчастиTableAdapter;
        private System.Windows.Forms.BindingSource НеисправностьСЗапчастямиBindingSource;
        private System.Windows.Forms.BindingSource неисправностьСЗапчастямиBindingSource1;
        private МастерскаяDataSetTableAdapters.НеисправностьСЗапчастямиTableAdapter неисправностьСЗапчастямиTableAdapter;
    }
}