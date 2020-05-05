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
            this.replaceString = new System.Windows.Forms.TextBox();
            this.newString = new System.Windows.Forms.TextBox();
            this.inputString = new System.Windows.Forms.RichTextBox();
            this.replaceStringLabel = new System.Windows.Forms.Label();
            this.newStringLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.outputString = new System.Windows.Forms.RichTextBox();
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
            // replaceString
            // 
            this.replaceString.Location = new System.Drawing.Point(221, 225);
            this.replaceString.Name = "replaceString";
            this.replaceString.Size = new System.Drawing.Size(325, 26);
            this.replaceString.TabIndex = 2;
            // 
            // newString
            // 
            this.newString.Location = new System.Drawing.Point(221, 260);
            this.newString.Name = "newString";
            this.newString.Size = new System.Drawing.Size(325, 26);
            this.newString.TabIndex = 3;
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
            // replaceStringLabel
            // 
            this.replaceStringLabel.AutoSize = true;
            this.replaceStringLabel.Location = new System.Drawing.Point(8, 228);
            this.replaceStringLabel.Name = "replaceStringLabel";
            this.replaceStringLabel.Size = new System.Drawing.Size(207, 19);
            this.replaceStringLabel.TabIndex = 5;
            this.replaceStringLabel.Text = "Заменяемая подстрока —";
            // 
            // newStringLabel
            // 
            this.newStringLabel.AutoSize = true;
            this.newStringLabel.Location = new System.Drawing.Point(53, 263);
            this.newStringLabel.Name = "newStringLabel";
            this.newStringLabel.Size = new System.Drawing.Size(162, 19);
            this.newStringLabel.TabIndex = 6;
            this.newStringLabel.Text = "Новая подстрока —";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "^^ВВЕДИТЕ СТРОКУ^^";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(221, 292);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(325, 32);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Изменить!";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // outputString
            // 
            this.outputString.Location = new System.Drawing.Point(12, 330);
            this.outputString.Name = "outputString";
            this.outputString.ReadOnly = true;
            this.outputString.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputString.Size = new System.Drawing.Size(534, 144);
            this.outputString.TabIndex = 4;
            this.outputString.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(558, 481);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newStringLabel);
            this.Controls.Add(this.replaceStringLabel);
            this.Controls.Add(this.outputString);
            this.Controls.Add(this.inputString);
            this.Controls.Add(this.newString);
            this.Controls.Add(this.replaceString);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 520);
            this.MinimumSize = new System.Drawing.Size(574, 520);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практикум 7. Задание 1.";
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
        private System.Windows.Forms.TextBox replaceString;
        private System.Windows.Forms.TextBox newString;
        private System.Windows.Forms.RichTextBox inputString;
        private System.Windows.Forms.Label replaceStringLabel;
        private System.Windows.Forms.Label newStringLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.RichTextBox outputString;
    }
}

