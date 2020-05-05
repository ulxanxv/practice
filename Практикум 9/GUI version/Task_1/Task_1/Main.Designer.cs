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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nameLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.output = new System.Windows.Forms.RichTextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maxNumberTB = new System.Windows.Forms.TextBox();
            this.sizeTB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTB)).BeginInit();
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
            this.output.Location = new System.Drawing.Point(12, 110);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(534, 239);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(12, 28);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(135, 76);
            this.outputButton.TabIndex = 2;
            this.outputButton.Text = "Вывести";
            this.outputButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Верхняя граница —";
            // 
            // maxNumberTB
            // 
            this.maxNumberTB.Location = new System.Drawing.Point(398, 30);
            this.maxNumberTB.Name = "maxNumberTB";
            this.maxNumberTB.Size = new System.Drawing.Size(148, 26);
            this.maxNumberTB.TabIndex = 4;
            this.maxNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sizeTB
            // 
            this.sizeTB.Location = new System.Drawing.Point(398, 62);
            this.sizeTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sizeTB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.Size = new System.Drawing.Size(148, 26);
            this.sizeTB.TabIndex = 5;
            this.sizeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeTB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество чисел —";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(558, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeTB);
            this.Controls.Add(this.maxNumberTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 400);
            this.MinimumSize = new System.Drawing.Size(574, 400);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практикум 9. Задание 1.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel nameLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel groupLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxNumberTB;
        private System.Windows.Forms.NumericUpDown sizeTB;
        private System.Windows.Forms.Label label2;
    }
}

