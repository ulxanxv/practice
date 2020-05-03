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
            this.output = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.MaskedTextBox();
            this.days = new System.Windows.Forms.NumericUpDown();
            this.dateLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
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
            // output
            // 
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(12, 137);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(534, 24);
            this.output.TabIndex = 7;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(304, 28);
            this.date.Mask = "00/00/0000";
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 26);
            this.date.TabIndex = 8;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.ValidatingType = typeof(System.DateTime);
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(304, 60);
            this.days.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.days.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(200, 26);
            this.days.TabIndex = 9;
            this.days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.days.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(235, 31);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(63, 19);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Дата —";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(73, 62);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(225, 19);
            this.daysLabel.TabIndex = 11;
            this.daysLabel.Text = "Сколько дней добавить? —";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(235, 115);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(54, 19);
            this.outputLabel.TabIndex = 12;
            this.outputLabel.Text = "ВЫВОД";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(558, 169);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.days);
            this.Controls.Add(this.date);
            this.Controls.Add(this.output);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 208);
            this.MinimumSize = new System.Drawing.Size(574, 208);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практикум 2. Задание 2.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel nameLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel groupLabel;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.MaskedTextBox date;
        private System.Windows.Forms.NumericUpDown days;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

