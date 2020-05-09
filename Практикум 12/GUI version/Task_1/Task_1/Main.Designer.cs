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
            this.resultButton = new System.Windows.Forms.Button();
            this.setDate1 = new System.Windows.Forms.MaskedTextBox();
            this.setDateButton1 = new System.Windows.Forms.Button();
            this.setDateButton2 = new System.Windows.Forms.Button();
            this.setDate2 = new System.Windows.Forms.MaskedTextBox();
            this.days = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
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
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(12, 323);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(223, 26);
            this.resultButton.TabIndex = 3;
            this.resultButton.Text = "Вывод информации";
            this.resultButton.UseVisualStyleBackColor = true;
            // 
            // setDate1
            // 
            this.setDate1.Location = new System.Drawing.Point(241, 251);
            this.setDate1.Mask = "00/00/0000";
            this.setDate1.Name = "setDate1";
            this.setDate1.Size = new System.Drawing.Size(305, 26);
            this.setDate1.TabIndex = 4;
            this.setDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setDate1.ValidatingType = typeof(System.DateTime);
            // 
            // setDateButton1
            // 
            this.setDateButton1.Location = new System.Drawing.Point(12, 250);
            this.setDateButton1.Name = "setDateButton1";
            this.setDateButton1.Size = new System.Drawing.Size(223, 26);
            this.setDateButton1.TabIndex = 5;
            this.setDateButton1.Text = "Установить дату 1";
            this.setDateButton1.UseVisualStyleBackColor = true;
            // 
            // setDateButton2
            // 
            this.setDateButton2.Location = new System.Drawing.Point(12, 283);
            this.setDateButton2.Name = "setDateButton2";
            this.setDateButton2.Size = new System.Drawing.Size(223, 34);
            this.setDateButton2.TabIndex = 6;
            this.setDateButton2.Text = "Установить дату 2";
            this.setDateButton2.UseVisualStyleBackColor = true;
            // 
            // setDate2
            // 
            this.setDate2.Location = new System.Drawing.Point(241, 288);
            this.setDate2.Mask = "00/00/0000";
            this.setDate2.Name = "setDate2";
            this.setDate2.Size = new System.Drawing.Size(305, 26);
            this.setDate2.TabIndex = 4;
            this.setDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setDate2.ValidatingType = typeof(System.DateTime);
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(409, 325);
            this.days.Maximum = new decimal(new int[] {
            512000,
            0,
            0,
            0});
            this.days.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(137, 26);
            this.days.TabIndex = 7;
            this.days.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество дней —";
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(12, 28);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(534, 216);
            this.output.TabIndex = 9;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(558, 361);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.days);
            this.Controls.Add(this.setDateButton2);
            this.Controls.Add(this.setDateButton1);
            this.Controls.Add(this.setDate2);
            this.Controls.Add(this.setDate1);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 400);
            this.MinimumSize = new System.Drawing.Size(574, 400);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практикум 12. Задание 1.";
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
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.MaskedTextBox setDate1;
        private System.Windows.Forms.Button setDateButton1;
        private System.Windows.Forms.Button setDateButton2;
        private System.Windows.Forms.MaskedTextBox setDate2;
        private System.Windows.Forms.NumericUpDown days;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output;
    }
}

