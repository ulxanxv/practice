namespace Task_1 {
    partial class Main {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nameLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupLabel = new System.Windows.Forms.ToolStripLabel();
            this.listSoftwareButton = new System.Windows.Forms.Button();
            this.listSoftware = new System.Windows.Forms.TextBox();
            this.listActivatedSoftwareButton = new System.Windows.Forms.Button();
            this.listActivatedSoftware = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameLabel,
            this.toolStripSeparator1,
            this.groupLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(739, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "infoPanel";
            // 
            // nameLabel
            // 
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(117, 22);
            this.nameLabel.Text = "Ульянов А.В.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupLabel
            // 
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(81, 22);
            this.groupLabel.Text = "ПКсп-117";
            // 
            // listSoftwareButton
            // 
            this.listSoftwareButton.Location = new System.Drawing.Point(12, 314);
            this.listSoftwareButton.Name = "listSoftwareButton";
            this.listSoftwareButton.Size = new System.Drawing.Size(355, 35);
            this.listSoftwareButton.TabIndex = 3;
            this.listSoftwareButton.Text = "Список ПО!";
            this.listSoftwareButton.UseVisualStyleBackColor = true;
            // 
            // listSoftware
            // 
            this.listSoftware.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listSoftware.Location = new System.Drawing.Point(12, 28);
            this.listSoftware.Multiline = true;
            this.listSoftware.Name = "listSoftware";
            this.listSoftware.ReadOnly = true;
            this.listSoftware.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listSoftware.Size = new System.Drawing.Size(355, 280);
            this.listSoftware.TabIndex = 4;
            this.listSoftware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listActivatedSoftwareButton
            // 
            this.listActivatedSoftwareButton.Location = new System.Drawing.Point(373, 314);
            this.listActivatedSoftwareButton.Name = "listActivatedSoftwareButton";
            this.listActivatedSoftwareButton.Size = new System.Drawing.Size(355, 35);
            this.listActivatedSoftwareButton.TabIndex = 5;
            this.listActivatedSoftwareButton.Text = "Список активированного ПО!";
            this.listActivatedSoftwareButton.UseVisualStyleBackColor = true;
            // 
            // listActivatedSoftware
            // 
            this.listActivatedSoftware.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listActivatedSoftware.Location = new System.Drawing.Point(373, 28);
            this.listActivatedSoftware.Multiline = true;
            this.listActivatedSoftware.Name = "listActivatedSoftware";
            this.listActivatedSoftware.ReadOnly = true;
            this.listActivatedSoftware.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listActivatedSoftware.Size = new System.Drawing.Size(355, 280);
            this.listActivatedSoftware.TabIndex = 6;
            this.listActivatedSoftware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(739, 361);
            this.Controls.Add(this.listActivatedSoftware);
            this.Controls.Add(this.listActivatedSoftwareButton);
            this.Controls.Add(this.listSoftware);
            this.Controls.Add(this.listSoftwareButton);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(755, 400);
            this.MinimumSize = new System.Drawing.Size(755, 400);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практикум 13. Задание 1.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel nameLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel groupLabel;
        private System.Windows.Forms.Button listSoftwareButton;
        private System.Windows.Forms.TextBox listSoftware;
        private System.Windows.Forms.Button listActivatedSoftwareButton;
        private System.Windows.Forms.TextBox listActivatedSoftware;
    }
}

