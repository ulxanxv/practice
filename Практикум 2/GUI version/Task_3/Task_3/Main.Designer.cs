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
            this.outputLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.inputX = new System.Windows.Forms.TextBox();
            this.inputY = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.RichTextBox();
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
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(248, 138);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(54, 19);
            this.outputLabel.TabIndex = 12;
            this.outputLabel.Text = "ВЫВОД";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(118, 40);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(36, 19);
            this.aLabel.TabIndex = 13;
            this.aLabel.Text = "— A";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(118, 81);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(36, 19);
            this.bLabel.TabIndex = 14;
            this.bLabel.Text = "— B";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(160, 81);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(36, 19);
            this.yLabel.TabIndex = 15;
            this.yLabel.Text = "Y —";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(160, 40);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(36, 19);
            this.xLabel.TabIndex = 16;
            this.xLabel.Text = "X —";
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(12, 37);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(100, 26);
            this.inputA.TabIndex = 17;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(12, 78);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(100, 26);
            this.inputB.TabIndex = 17;
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(202, 37);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(100, 26);
            this.inputX.TabIndex = 17;
            // 
            // inputY
            // 
            this.inputY.Location = new System.Drawing.Point(202, 78);
            this.inputY.Name = "inputY";
            this.inputY.Size = new System.Drawing.Size(100, 26);
            this.inputY.TabIndex = 17;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(308, 37);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(238, 120);
            this.output.TabIndex = 18;
            this.output.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(558, 169);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputY);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 208);
            this.MinimumSize = new System.Drawing.Size(574, 208);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практикум 2. Задание 3.";
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
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.TextBox inputY;
        private System.Windows.Forms.RichTextBox output;
    }
}

