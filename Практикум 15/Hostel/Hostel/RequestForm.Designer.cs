namespace Hostel {
    partial class RequestForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            this.infoStrip = new System.Windows.Forms.ToolStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanelSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autorName = new System.Windows.Forms.ToolStripLabel();
            this.infoPanelSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.autorGroup = new System.Windows.Forms.ToolStripLabel();
            this.chooseRequest = new System.Windows.Forms.GroupBox();
            this.studentListInGroupPO = new System.Windows.Forms.RadioButton();
            this.roomsIn3Floor = new System.Windows.Forms.RadioButton();
            this.groupList = new System.Windows.Forms.RadioButton();
            this.shortInfo = new System.Windows.Forms.RadioButton();
            this.fullInfo = new System.Windows.Forms.RadioButton();
            this.runRequestButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.DataGridView();
            this.infoStrip.SuspendLayout();
            this.chooseRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.response)).BeginInit();
            this.SuspendLayout();
            // 
            // infoStrip
            // 
            this.infoStrip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.infoPanelSeparator1,
            this.autorName,
            this.infoPanelSeparator2,
            this.autorGroup});
            this.infoStrip.Location = new System.Drawing.Point(0, 0);
            this.infoStrip.Name = "infoStrip";
            this.infoStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.infoStrip.Size = new System.Drawing.Size(933, 25);
            this.infoStrip.TabIndex = 4;
            // 
            // fileMenu
            // 
            this.fileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitButton});
            this.fileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 22);
            this.fileMenu.Text = "Файл";
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 22);
            this.exitButton.Text = "Выход";
            // 
            // infoPanelSeparator1
            // 
            this.infoPanelSeparator1.Name = "infoPanelSeparator1";
            this.infoPanelSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // autorName
            // 
            this.autorName.Name = "autorName";
            this.autorName.Size = new System.Drawing.Size(91, 22);
            this.autorName.Text = "Ульянов А.В.";
            // 
            // infoPanelSeparator2
            // 
            this.infoPanelSeparator2.Name = "infoPanelSeparator2";
            this.infoPanelSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // autorGroup
            // 
            this.autorGroup.Name = "autorGroup";
            this.autorGroup.Size = new System.Drawing.Size(63, 22);
            this.autorGroup.Text = "ПКсп-117";
            // 
            // chooseRequest
            // 
            this.chooseRequest.Controls.Add(this.studentListInGroupPO);
            this.chooseRequest.Controls.Add(this.roomsIn3Floor);
            this.chooseRequest.Controls.Add(this.groupList);
            this.chooseRequest.Controls.Add(this.shortInfo);
            this.chooseRequest.Controls.Add(this.fullInfo);
            this.chooseRequest.Location = new System.Drawing.Point(12, 54);
            this.chooseRequest.Name = "chooseRequest";
            this.chooseRequest.Size = new System.Drawing.Size(515, 165);
            this.chooseRequest.TabIndex = 5;
            this.chooseRequest.TabStop = false;
            this.chooseRequest.Text = "Выберите запрос";
            // 
            // studentListInGroupPO
            // 
            this.studentListInGroupPO.AutoSize = true;
            this.studentListInGroupPO.Location = new System.Drawing.Point(25, 134);
            this.studentListInGroupPO.Name = "studentListInGroupPO";
            this.studentListInGroupPO.Size = new System.Drawing.Size(319, 19);
            this.studentListInGroupPO.TabIndex = 1;
            this.studentListInGroupPO.TabStop = true;
            this.studentListInGroupPO.Text = "Список студентов, обучающихся в группах ПО";
            this.studentListInGroupPO.UseVisualStyleBackColor = true;
            // 
            // roomsIn3Floor
            // 
            this.roomsIn3Floor.AutoSize = true;
            this.roomsIn3Floor.Location = new System.Drawing.Point(25, 109);
            this.roomsIn3Floor.Name = "roomsIn3Floor";
            this.roomsIn3Floor.Size = new System.Drawing.Size(312, 19);
            this.roomsIn3Floor.TabIndex = 1;
            this.roomsIn3Floor.TabStop = true;
            this.roomsIn3Floor.Text = "Номер комнат, расположенных на 3-ем этаже";
            this.roomsIn3Floor.UseVisualStyleBackColor = true;
            // 
            // groupList
            // 
            this.groupList.AutoSize = true;
            this.groupList.Location = new System.Drawing.Point(25, 84);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(396, 19);
            this.groupList.TabIndex = 1;
            this.groupList.TabStop = true;
            this.groupList.Text = "Список групп студентов, которые проживают в общежитии";
            this.groupList.UseVisualStyleBackColor = true;
            // 
            // shortInfo
            // 
            this.shortInfo.AutoSize = true;
            this.shortInfo.Location = new System.Drawing.Point(25, 59);
            this.shortInfo.Name = "shortInfo";
            this.shortInfo.Size = new System.Drawing.Size(333, 19);
            this.shortInfo.TabIndex = 1;
            this.shortInfo.TabStop = true;
            this.shortInfo.Text = "Краткая информация о студентах (ФИО, группа)";
            this.shortInfo.UseVisualStyleBackColor = true;
            // 
            // fullInfo
            // 
            this.fullInfo.AutoSize = true;
            this.fullInfo.Location = new System.Drawing.Point(25, 34);
            this.fullInfo.Name = "fullInfo";
            this.fullInfo.Size = new System.Drawing.Size(221, 19);
            this.fullInfo.TabIndex = 0;
            this.fullInfo.TabStop = true;
            this.fullInfo.Text = "Полная информация о студенте";
            this.fullInfo.UseVisualStyleBackColor = true;
            // 
            // runRequestButton
            // 
            this.runRequestButton.Location = new System.Drawing.Point(534, 54);
            this.runRequestButton.Name = "runRequestButton";
            this.runRequestButton.Size = new System.Drawing.Size(388, 53);
            this.runRequestButton.TabIndex = 6;
            this.runRequestButton.Text = "Выполнить запрос!";
            this.runRequestButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(533, 113);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(388, 53);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Очистить!";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // response
            // 
            this.response.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.response.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.response.Location = new System.Drawing.Point(12, 225);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(909, 282);
            this.response.TabIndex = 7;
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.response);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.runRequestButton);
            this.Controls.Add(this.chooseRequest);
            this.Controls.Add(this.infoStrip);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма запросов";
            this.infoStrip.ResumeLayout(false);
            this.infoStrip.PerformLayout();
            this.chooseRequest.ResumeLayout(false);
            this.chooseRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.response)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip infoStrip;
        private System.Windows.Forms.ToolStripDropDownButton fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripSeparator infoPanelSeparator1;
        private System.Windows.Forms.ToolStripLabel autorName;
        private System.Windows.Forms.ToolStripSeparator infoPanelSeparator2;
        private System.Windows.Forms.ToolStripLabel autorGroup;
        private System.Windows.Forms.GroupBox chooseRequest;
        private System.Windows.Forms.RadioButton studentListInGroupPO;
        private System.Windows.Forms.RadioButton roomsIn3Floor;
        private System.Windows.Forms.RadioButton groupList;
        private System.Windows.Forms.RadioButton shortInfo;
        private System.Windows.Forms.RadioButton fullInfo;
        private System.Windows.Forms.Button runRequestButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView response;
    }
}