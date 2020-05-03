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
            this.output = new System.Windows.Forms.RichTextBox();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.inputH = new System.Windows.Forms.TextBox();
            this.outButton = new System.Windows.Forms.Button();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
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
            // output
            // 
            this.output.Location = new System.Drawing.Point(264, 29);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(282, 135);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(12, 38);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(100, 26);
            this.inputA.TabIndex = 2;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(12, 70);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(100, 26);
            this.inputB.TabIndex = 2;
            // 
            // inputH
            // 
            this.inputH.Location = new System.Drawing.Point(12, 102);
            this.inputH.Name = "inputH";
            this.inputH.Size = new System.Drawing.Size(100, 26);
            this.inputH.TabIndex = 2;
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(12, 134);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(246, 30);
            this.outButton.TabIndex = 3;
            this.outButton.Text = "Вывод";
            this.outButton.UseVisualStyleBackColor = true;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(118, 41);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(36, 19);
            this.aLabel.TabIndex = 4;
            this.aLabel.Text = "— A";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(118, 73);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(36, 19);
            this.bLabel.TabIndex = 4;
            this.bLabel.Text = "— B";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(118, 105);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(36, 19);
            this.hLabel.TabIndex = 4;
            this.hLabel.Text = "— H";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(558, 169);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.inputH);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
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
            this.Text = "Практикум 3. Задание 1.";
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
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox inputH;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label hLabel;
    }
}

