namespace Cramer_Method {
    partial class Cramer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cramer));
            this.linearSystem = new System.Windows.Forms.DataGridView();
            this.roots = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.labelAmountEquation = new System.Windows.Forms.Label();
            this.amountEquation = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.resetEquation = new System.Windows.Forms.Button();
            this.resetResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.linearSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountEquation)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linearSystem
            // 
            this.linearSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linearSystem.Location = new System.Drawing.Point(12, 68);
            this.linearSystem.Name = "linearSystem";
            this.linearSystem.Size = new System.Drawing.Size(571, 197);
            this.linearSystem.TabIndex = 0;
            // 
            // roots
            // 
            this.roots.AllowUserToAddRows = false;
            this.roots.AllowUserToDeleteRows = false;
            this.roots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roots.Location = new System.Drawing.Point(589, 68);
            this.roots.Name = "roots";
            this.roots.ReadOnly = true;
            this.roots.Size = new System.Drawing.Size(233, 337);
            this.roots.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Система линейных уравнений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Корни";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(12, 411);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(810, 38);
            this.solveButton.TabIndex = 4;
            this.solveButton.Text = "Решить методом Крамера";
            this.solveButton.UseVisualStyleBackColor = true;
            // 
            // labelAmountEquation
            // 
            this.labelAmountEquation.AutoSize = true;
            this.labelAmountEquation.Location = new System.Drawing.Point(12, 295);
            this.labelAmountEquation.Name = "labelAmountEquation";
            this.labelAmountEquation.Size = new System.Drawing.Size(218, 21);
            this.labelAmountEquation.TabIndex = 5;
            this.labelAmountEquation.Text = "Кол-во уравнений системы —";
            // 
            // amountEquation
            // 
            this.amountEquation.Location = new System.Drawing.Point(232, 293);
            this.amountEquation.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.amountEquation.Name = "amountEquation";
            this.amountEquation.Size = new System.Drawing.Size(347, 25);
            this.amountEquation.TabIndex = 6;
            this.amountEquation.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(834, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(106, 22);
            this.toolStripLabel1.Text = "Ульянов А.В.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel2.Text = "ПКсп-117";
            // 
            // resetEquation
            // 
            this.resetEquation.Location = new System.Drawing.Point(12, 370);
            this.resetEquation.Name = "resetEquation";
            this.resetEquation.Size = new System.Drawing.Size(567, 35);
            this.resetEquation.TabIndex = 8;
            this.resetEquation.Text = "Сбросить систему уравнений";
            this.resetEquation.UseVisualStyleBackColor = true;
            // 
            // resetResult
            // 
            this.resetResult.Location = new System.Drawing.Point(12, 328);
            this.resetResult.Name = "resetResult";
            this.resetResult.Size = new System.Drawing.Size(567, 35);
            this.resetResult.TabIndex = 9;
            this.resetResult.Text = "Сбросить результат";
            this.resetResult.UseVisualStyleBackColor = true;
            // 
            // Cramer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.resetResult);
            this.Controls.Add(this.resetEquation);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.amountEquation);
            this.Controls.Add(this.labelAmountEquation);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roots);
            this.Controls.Add(this.linearSystem);
            this.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Cramer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение линейных уравнений методом Крамера";
            ((System.ComponentModel.ISupportInitialize)(this.linearSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountEquation)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView linearSystem;
        private System.Windows.Forms.DataGridView roots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label labelAmountEquation;
        private System.Windows.Forms.NumericUpDown amountEquation;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button resetEquation;
        private System.Windows.Forms.Button resetResult;
    }
}

