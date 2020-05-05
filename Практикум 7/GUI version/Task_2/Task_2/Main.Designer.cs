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
            this.inputString = new System.Windows.Forms.RichTextBox();
            this.inputStringLabel = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.longWordLabel = new System.Windows.Forms.Label();
            this.outputResult = new System.Windows.Forms.TextBox();
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
            // inputString
            // 
            this.inputString.Location = new System.Drawing.Point(12, 28);
            this.inputString.Name = "inputString";
            this.inputString.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.inputString.Size = new System.Drawing.Size(534, 144);
            this.inputString.TabIndex = 4;
            this.inputString.Text = "";
            // 
            // inputStringLabel
            // 
            this.inputStringLabel.AutoSize = true;
            this.inputStringLabel.Location = new System.Drawing.Point(180, 175);
            this.inputStringLabel.Name = "inputStringLabel";
            this.inputStringLabel.Size = new System.Drawing.Size(171, 19);
            this.inputStringLabel.TabIndex = 7;
            this.inputStringLabel.Text = "^^ВВЕДИТЕ СТРОКУ^^";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(221, 197);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(325, 32);
            this.resultButton.TabIndex = 8;
            this.resultButton.Text = "Определить!";
            this.resultButton.UseVisualStyleBackColor = true;
            // 
            // longWordLabel
            // 
            this.longWordLabel.AutoSize = true;
            this.longWordLabel.Location = new System.Drawing.Point(12, 204);
            this.longWordLabel.Name = "longWordLabel";
            this.longWordLabel.Size = new System.Drawing.Size(171, 19);
            this.longWordLabel.TabIndex = 9;
            this.longWordLabel.Text = "САМОЕ ДЛИНОЕ СЛОВО";
            // 
            // outputResult
            // 
            this.outputResult.Location = new System.Drawing.Point(12, 235);
            this.outputResult.Name = "outputResult";
            this.outputResult.Size = new System.Drawing.Size(534, 26);
            this.outputResult.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(558, 269);
            this.Controls.Add(this.outputResult);
            this.Controls.Add(this.longWordLabel);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.inputStringLabel);
            this.Controls.Add(this.inputString);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практикум 7. Задание 2.";
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
        private System.Windows.Forms.RichTextBox inputString;
        private System.Windows.Forms.Label inputStringLabel;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label longWordLabel;
        private System.Windows.Forms.TextBox outputResult;
    }
}

