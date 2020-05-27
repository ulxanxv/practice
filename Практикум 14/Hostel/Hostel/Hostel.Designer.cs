namespace Hostel {
    partial class Hostel {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hostel));
            this.infoStrip = new System.Windows.Forms.ToolStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.studentsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanelSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autorName = new System.Windows.Forms.ToolStripLabel();
            this.infoPanelSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.autorGroup = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDataSet = new HostelDataSet();
            this.infoStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.infoStrip.Size = new System.Drawing.Size(634, 25);
            this.infoStrip.TabIndex = 3;
            // 
            // fileMenu
            // 
            this.fileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsButton,
            this.roomsButton,
            this.privilegesButton,
            this.exitButton});
            this.fileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 22);
            this.fileMenu.Text = "Файл";
            // 
            // studentsButton
            // 
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(144, 22);
            this.studentsButton.Text = "Студенты";
            // 
            // roomsButton
            // 
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(144, 22);
            this.roomsButton.Text = "Комнаты";
            // 
            // privilegesButton
            // 
            this.privilegesButton.Name = "privilegesButton";
            this.privilegesButton.Size = new System.Drawing.Size(144, 22);
            this.privilegesButton.Text = "Привилегии";
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 22);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Consolas", 84F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 131);
            this.label1.TabIndex = 4;
            this.label1.Text = "ОБЩЕЖИТИЕ";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = this.hostelDataSet;
            this.bindingSource.Position = 0;
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "HostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Hostel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoStrip);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 215);
            this.MinimumSize = new System.Drawing.Size(650, 215);
            this.Name = "Hostel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Общежитие";
            this.infoStrip.ResumeLayout(false);
            this.infoStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip infoStrip;
        private System.Windows.Forms.ToolStripDropDownButton fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripSeparator infoPanelSeparator1;
        private System.Windows.Forms.ToolStripLabel autorName;
        private System.Windows.Forms.ToolStripSeparator infoPanelSeparator2;
        private System.Windows.Forms.ToolStripLabel autorGroup;
        private System.Windows.Forms.ToolStripMenuItem studentsButton;
        private System.Windows.Forms.ToolStripMenuItem roomsButton;
        private System.Windows.Forms.ToolStripMenuItem privilegesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource;
        private HostelDataSet hostelDataSet;
    }
}