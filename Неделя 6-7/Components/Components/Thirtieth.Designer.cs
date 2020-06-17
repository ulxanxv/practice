namespace Components {
    partial class Thirtieth {
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nameLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupLabel = new System.Windows.Forms.ToolStripLabel();
            this.openButton = new System.Windows.Forms.Button();
            this.multiOpenButton = new System.Windows.Forms.Button();
            this.allFiles = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameLabel,
            this.toolStripSeparator2,
            this.groupLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(639, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nameLabel
            // 
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 22);
            this.nameLabel.Text = "Ульянов А.В.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupLabel
            // 
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(63, 22);
            this.groupLabel.Text = "ПКсп-117";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(13, 226);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(146, 23);
            this.openButton.TabIndex = 20;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // multiOpenButton
            // 
            this.multiOpenButton.Location = new System.Drawing.Point(481, 226);
            this.multiOpenButton.Name = "multiOpenButton";
            this.multiOpenButton.Size = new System.Drawing.Size(146, 23);
            this.multiOpenButton.TabIndex = 21;
            this.multiOpenButton.Text = "Мульти-открытие";
            this.multiOpenButton.UseVisualStyleBackColor = true;
            // 
            // allFiles
            // 
            this.allFiles.FormattingEnabled = true;
            this.allFiles.Location = new System.Drawing.Point(12, 28);
            this.allFiles.Name = "allFiles";
            this.allFiles.Size = new System.Drawing.Size(615, 186);
            this.allFiles.TabIndex = 22;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Thirtieth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(639, 261);
            this.Controls.Add(this.allFiles);
            this.Controls.Add(this.multiOpenButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(655, 300);
            this.MinimumSize = new System.Drawing.Size(655, 300);
            this.Name = "Thirtieth";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диалог для открытия файлов";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel nameLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel groupLabel;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button multiOpenButton;
        private System.Windows.Forms.ListBox allFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}