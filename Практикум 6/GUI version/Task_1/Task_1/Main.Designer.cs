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
            this.label1 = new System.Windows.Forms.Label();
            this.input1DArray = new System.Windows.Forms.RichTextBox();
            this.resultButton1D = new System.Windows.Forms.Button();
            this.outputResult = new System.Windows.Forms.TextBox();
            this.labelOutputResult = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.resultButton2D = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.input2DArray = new System.Windows.Forms.RichTextBox();
            this.outputArray = new System.Windows.Forms.TextBox();
            this.outputArrayLabel = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(764, 25);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите массив (одномерный)";
            // 
            // input1DArray
            // 
            this.input1DArray.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input1DArray.Location = new System.Drawing.Point(12, 60);
            this.input1DArray.Name = "input1DArray";
            this.input1DArray.Size = new System.Drawing.Size(252, 166);
            this.input1DArray.TabIndex = 2;
            this.input1DArray.Text = "";
            // 
            // resultButton1D
            // 
            this.resultButton1D.Location = new System.Drawing.Point(12, 232);
            this.resultButton1D.Name = "resultButton1D";
            this.resultButton1D.Size = new System.Drawing.Size(593, 30);
            this.resultButton1D.TabIndex = 4;
            this.resultButton1D.Text = "Подсчитать (в одномерном)!";
            this.resultButton1D.UseVisualStyleBackColor = true;
            // 
            // outputResult
            // 
            this.outputResult.Enabled = false;
            this.outputResult.Location = new System.Drawing.Point(12, 323);
            this.outputResult.Name = "outputResult";
            this.outputResult.ReadOnly = true;
            this.outputResult.Size = new System.Drawing.Size(681, 26);
            this.outputResult.TabIndex = 5;
            this.outputResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelOutputResult
            // 
            this.labelOutputResult.AutoSize = true;
            this.labelOutputResult.Location = new System.Drawing.Point(699, 326);
            this.labelOutputResult.Name = "labelOutputResult";
            this.labelOutputResult.Size = new System.Drawing.Size(54, 19);
            this.labelOutputResult.TabIndex = 6;
            this.labelOutputResult.Text = "ВЫВОД";
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(611, 235);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(100, 26);
            this.inputA.TabIndex = 7;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(611, 271);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(100, 26);
            this.inputB.TabIndex = 8;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(717, 238);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(36, 19);
            this.labelA.TabIndex = 9;
            this.labelA.Text = "— A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(717, 278);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(36, 19);
            this.labelB.TabIndex = 10;
            this.labelB.Text = "— B";
            // 
            // resultButton2D
            // 
            this.resultButton2D.Location = new System.Drawing.Point(12, 268);
            this.resultButton2D.Name = "resultButton2D";
            this.resultButton2D.Size = new System.Drawing.Size(593, 30);
            this.resultButton2D.TabIndex = 4;
            this.resultButton2D.Text = "Подсчитать (в двумерном)!";
            this.resultButton2D.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите массив (двумерный)";
            // 
            // input2DArray
            // 
            this.input2DArray.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input2DArray.Location = new System.Drawing.Point(270, 60);
            this.input2DArray.Name = "input2DArray";
            this.input2DArray.Size = new System.Drawing.Size(252, 166);
            this.input2DArray.TabIndex = 2;
            this.input2DArray.Text = "";
            // 
            // outputArray
            // 
            this.outputArray.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputArray.Location = new System.Drawing.Point(528, 60);
            this.outputArray.Multiline = true;
            this.outputArray.Name = "outputArray";
            this.outputArray.ReadOnly = true;
            this.outputArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputArray.Size = new System.Drawing.Size(225, 166);
            this.outputArray.TabIndex = 11;
            this.outputArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputArrayLabel
            // 
            this.outputArrayLabel.AutoSize = true;
            this.outputArrayLabel.Location = new System.Drawing.Point(627, 34);
            this.outputArrayLabel.Name = "outputArrayLabel";
            this.outputArrayLabel.Size = new System.Drawing.Size(126, 19);
            this.outputArrayLabel.TabIndex = 12;
            this.outputArrayLabel.Text = "Вывод массива";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(764, 361);
            this.Controls.Add(this.outputArrayLabel);
            this.Controls.Add(this.outputArray);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.labelOutputResult);
            this.Controls.Add(this.outputResult);
            this.Controls.Add(this.resultButton2D);
            this.Controls.Add(this.resultButton1D);
            this.Controls.Add(this.input2DArray);
            this.Controls.Add(this.input1DArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 400);
            this.MinimumSize = new System.Drawing.Size(780, 400);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практикум 6. Задание 1.";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox input1DArray;
        private System.Windows.Forms.Button resultButton1D;
        private System.Windows.Forms.TextBox outputResult;
        private System.Windows.Forms.Label labelOutputResult;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button resultButton2D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox input2DArray;
        private System.Windows.Forms.TextBox outputArray;
        private System.Windows.Forms.Label outputArrayLabel;
    }
}

