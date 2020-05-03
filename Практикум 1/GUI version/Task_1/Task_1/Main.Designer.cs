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
            this.inputX1 = new System.Windows.Forms.TextBox();
            this.inputX2 = new System.Windows.Forms.TextBox();
            this.inputY1 = new System.Windows.Forms.TextBox();
            this.inputY2 = new System.Windows.Forms.TextBox();
            this.inputZ1 = new System.Windows.Forms.TextBox();
            this.inputZ2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // inputX1
            // 
            this.inputX1.Location = new System.Drawing.Point(83, 38);
            this.inputX1.Multiline = true;
            this.inputX1.Name = "inputX1";
            this.inputX1.Size = new System.Drawing.Size(100, 24);
            this.inputX1.TabIndex = 1;
            this.inputX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputX2
            // 
            this.inputX2.Location = new System.Drawing.Point(83, 71);
            this.inputX2.Multiline = true;
            this.inputX2.Name = "inputX2";
            this.inputX2.Size = new System.Drawing.Size(100, 24);
            this.inputX2.TabIndex = 2;
            this.inputX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputY1
            // 
            this.inputY1.Location = new System.Drawing.Point(261, 38);
            this.inputY1.Multiline = true;
            this.inputY1.Name = "inputY1";
            this.inputY1.Size = new System.Drawing.Size(100, 24);
            this.inputY1.TabIndex = 3;
            this.inputY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputY2
            // 
            this.inputY2.Location = new System.Drawing.Point(261, 71);
            this.inputY2.Multiline = true;
            this.inputY2.Name = "inputY2";
            this.inputY2.Size = new System.Drawing.Size(100, 24);
            this.inputY2.TabIndex = 4;
            this.inputY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputZ1
            // 
            this.inputZ1.Location = new System.Drawing.Point(437, 38);
            this.inputZ1.Multiline = true;
            this.inputZ1.Name = "inputZ1";
            this.inputZ1.Size = new System.Drawing.Size(100, 24);
            this.inputZ1.TabIndex = 5;
            this.inputZ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputZ2
            // 
            this.inputZ2.Location = new System.Drawing.Point(437, 71);
            this.inputZ2.Multiline = true;
            this.inputZ2.Name = "inputZ2";
            this.inputZ2.Size = new System.Drawing.Size(100, 24);
            this.inputZ2.TabIndex = 6;
            this.inputZ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "x1 — ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "x2 —";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "y1 —";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "y2 —";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "z1 —";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "z2 —";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(558, 169);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputZ2);
            this.Controls.Add(this.inputZ1);
            this.Controls.Add(this.inputY2);
            this.Controls.Add(this.inputY1);
            this.Controls.Add(this.inputX2);
            this.Controls.Add(this.inputX1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 208);
            this.MinimumSize = new System.Drawing.Size(574, 208);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практикум 1. Задание 1.";
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
        private System.Windows.Forms.TextBox inputX1;
        private System.Windows.Forms.TextBox inputX2;
        private System.Windows.Forms.TextBox inputY1;
        private System.Windows.Forms.TextBox inputY2;
        private System.Windows.Forms.TextBox inputZ1;
        private System.Windows.Forms.TextBox inputZ2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

