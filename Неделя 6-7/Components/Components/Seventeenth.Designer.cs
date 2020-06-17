namespace Components {
    partial class Seventeenth {
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
            this.button = new System.Windows.Forms.Button();
            this.testCheckBox = new System.Windows.Forms.CheckBox();
            this.testRadioButton = new System.Windows.Forms.RadioButton();
            this.testProgressBar = new System.Windows.Forms.ProgressBar();
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
            this.toolStrip1.TabIndex = 10;
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
            // button
            // 
            this.button.Location = new System.Drawing.Point(132, 60);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(380, 23);
            this.button.TabIndex = 11;
            this.button.Text = "ТЕСТ";
            this.button.UseVisualStyleBackColor = true;
            // 
            // testCheckBox
            // 
            this.testCheckBox.AutoSize = true;
            this.testCheckBox.Location = new System.Drawing.Point(132, 102);
            this.testCheckBox.Name = "testCheckBox";
            this.testCheckBox.Size = new System.Drawing.Size(54, 17);
            this.testCheckBox.TabIndex = 12;
            this.testCheckBox.Text = "ТЕСТ";
            this.testCheckBox.UseVisualStyleBackColor = true;
            // 
            // testRadioButton
            // 
            this.testRadioButton.AutoSize = true;
            this.testRadioButton.Location = new System.Drawing.Point(132, 125);
            this.testRadioButton.Name = "testRadioButton";
            this.testRadioButton.Size = new System.Drawing.Size(53, 17);
            this.testRadioButton.TabIndex = 13;
            this.testRadioButton.TabStop = true;
            this.testRadioButton.Text = "ТЕСТ";
            this.testRadioButton.UseVisualStyleBackColor = true;
            // 
            // testProgressBar
            // 
            this.testProgressBar.Location = new System.Drawing.Point(132, 160);
            this.testProgressBar.Minimum = 25;
            this.testProgressBar.Name = "testProgressBar";
            this.testProgressBar.Size = new System.Drawing.Size(380, 23);
            this.testProgressBar.TabIndex = 14;
            this.testProgressBar.Value = 25;
            // 
            // Seventeenth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(639, 261);
            this.Controls.Add(this.testProgressBar);
            this.Controls.Add(this.testRadioButton);
            this.Controls.Add(this.testCheckBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(655, 300);
            this.MinimumSize = new System.Drawing.Size(655, 300);
            this.Name = "Seventeenth";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Применение стилей различных ОС";
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
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.CheckBox testCheckBox;
        private System.Windows.Forms.RadioButton testRadioButton;
        private System.Windows.Forms.ProgressBar testProgressBar;
    }
}