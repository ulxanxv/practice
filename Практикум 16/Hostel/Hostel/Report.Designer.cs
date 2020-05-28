namespace Hostel {
    partial class Report {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.StudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HostelDataSet = new HostelDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.privilegeTableAdapter1 = new HostelDataSetTableAdapters.PrivilegeTableAdapter();
            this.infoStrip = new System.Windows.Forms.ToolStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanelSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autorName = new System.Windows.Forms.ToolStripLabel();
            this.infoPanelSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.autorGroup = new System.Windows.Forms.ToolStripLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.roomsTableAdapter1 = new HostelDataSetTableAdapters.RoomsTableAdapter();
            this.StudentsTableAdapter = new HostelDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostelDataSet)).BeginInit();
            this.infoStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsBindingSource
            // 
            this.StudentsBindingSource.DataMember = "Students";
            this.StudentsBindingSource.DataSource = this.HostelDataSet;
            // 
            // HostelDataSet
            // 
            this.HostelDataSet.DataSetName = "HostelDataSet";
            this.HostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // privilegeTableAdapter1
            // 
            this.privilegeTableAdapter1.ClearBeforeFill = true;
            // 
            // infoStrip
            // 
            this.infoStrip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.infoPanelSeparator1,
            this.autorName,
            this.infoPanelSeparator2,
            this.autorGroup});
            this.infoStrip.Location = new System.Drawing.Point(0, 0);
            this.infoStrip.Name = "infoStrip";
            this.infoStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.infoStrip.Size = new System.Drawing.Size(934, 25);
            this.infoStrip.TabIndex = 5;
            // 
            // fileMenu
            // 
            this.fileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitButton});
            this.fileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 22);
            this.fileMenu.Text = "Файл";
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 22);
            this.exitButton.Text = "Выход";
            // 
            // infoPanelSeparator1
            // 
            this.infoPanelSeparator1.Name = "infoPanelSeparator1";
            this.infoPanelSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // autorName
            // 
            this.autorName.Name = "autorName";
            this.autorName.Size = new System.Drawing.Size(91, 22);
            this.autorName.Text = "Ульянов А.В.";
            // 
            // infoPanelSeparator2
            // 
            this.infoPanelSeparator2.Name = "infoPanelSeparator2";
            this.infoPanelSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // autorGroup
            // 
            this.autorGroup.Name = "autorGroup";
            this.autorGroup.Size = new System.Drawing.Size(63, 22);
            this.autorGroup.Text = "ПКсп-117";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hostel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(934, 496);
            this.reportViewer1.TabIndex = 6;
            // 
            // roomsTableAdapter1
            // 
            this.roomsTableAdapter1.ClearBeforeFill = true;
            // 
            // StudentsTableAdapter
            // 
            this.StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(934, 521);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.infoStrip);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 560);
            this.MinimumSize = new System.Drawing.Size(950, 560);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование отчетов";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostelDataSet)).EndInit();
            this.infoStrip.ResumeLayout(false);
            this.infoStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HostelDataSetTableAdapters.PrivilegeTableAdapter privilegeTableAdapter1;
        private System.Windows.Forms.ToolStrip infoStrip;
        private System.Windows.Forms.ToolStripDropDownButton fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripSeparator infoPanelSeparator1;
        private System.Windows.Forms.ToolStripLabel autorName;
        private System.Windows.Forms.ToolStripSeparator infoPanelSeparator2;
        private System.Windows.Forms.ToolStripLabel autorGroup;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private HostelDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter1;
        private System.Windows.Forms.BindingSource StudentsBindingSource;
        private HostelDataSet HostelDataSet;
        private HostelDataSetTableAdapters.StudentsTableAdapter StudentsTableAdapter;
    }
}