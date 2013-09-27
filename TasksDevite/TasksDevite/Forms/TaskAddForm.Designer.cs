namespace TasksDevite
{
    partial class TaskAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserСomboBox = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.AboutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCncl = new System.Windows.Forms.Button();
            this.TimeStartComboBox = new System.Windows.Forms.ComboBox();
            this.TimeEndComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserСomboBox
            // 
            this.UserСomboBox.FormattingEnabled = true;
            this.UserСomboBox.Location = new System.Drawing.Point(114, 38);
            this.UserСomboBox.Name = "UserСomboBox";
            this.UserСomboBox.Size = new System.Drawing.Size(217, 21);
            this.UserСomboBox.TabIndex = 0;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(114, 12);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(217, 20);
            this.DateTimePicker.TabIndex = 1;
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(114, 63);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(217, 21);
            this.ClientComboBox.TabIndex = 2;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Открыт",
            "Закрыт"});
            this.StatusComboBox.Location = new System.Drawing.Point(108, 151);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(216, 21);
            this.StatusComboBox.TabIndex = 3;
            // 
            // AboutRichTextBox
            // 
            this.AboutRichTextBox.Location = new System.Drawing.Point(107, 178);
            this.AboutRichTextBox.Name = "AboutRichTextBox";
            this.AboutRichTextBox.Size = new System.Drawing.Size(216, 94);
            this.AboutRichTextBox.TabIndex = 4;
            this.AboutRichTextBox.Text = "";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(24, 18);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Дата:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(21, 41);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(77, 13);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "Исполнитель:";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(21, 66);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(46, 13);
            this.labelClient.TabIndex = 7;
            this.labelClient.Text = "Клиент:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(28, 154);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Статус:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 215);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Примечание:";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(108, 278);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(92, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Сохранить";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCncl
            // 
            this.buttonCncl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCncl.Location = new System.Drawing.Point(221, 278);
            this.buttonCncl.Name = "buttonCncl";
            this.buttonCncl.Size = new System.Drawing.Size(101, 23);
            this.buttonCncl.TabIndex = 11;
            this.buttonCncl.Text = "Отмена";
            this.buttonCncl.UseVisualStyleBackColor = true;
            // 
            // TimeStartComboBox
            // 
            this.TimeStartComboBox.FormattingEnabled = true;
            this.TimeStartComboBox.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00"});
            this.TimeStartComboBox.Location = new System.Drawing.Point(91, 19);
            this.TimeStartComboBox.Name = "TimeStartComboBox";
            this.TimeStartComboBox.Size = new System.Drawing.Size(85, 21);
            this.TimeStartComboBox.TabIndex = 20;
            // 
            // TimeEndComboBox
            // 
            this.TimeEndComboBox.FormattingEnabled = true;
            this.TimeEndComboBox.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00"});
            this.TimeEndComboBox.Location = new System.Drawing.Point(207, 19);
            this.TimeEndComboBox.Name = "TimeEndComboBox";
            this.TimeEndComboBox.Size = new System.Drawing.Size(92, 21);
            this.TimeEndComboBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "до";
            // 
            // TimeGroupBox
            // 
            this.TimeGroupBox.Controls.Add(this.TimeStartComboBox);
            this.TimeGroupBox.Controls.Add(this.label2);
            this.TimeGroupBox.Controls.Add(this.TimeEndComboBox);
            this.TimeGroupBox.Controls.Add(this.label1);
            this.TimeGroupBox.Location = new System.Drawing.Point(24, 90);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(305, 51);
            this.TimeGroupBox.TabIndex = 24;
            this.TimeGroupBox.TabStop = false;
            this.TimeGroupBox.Text = "Время задания";
            // 
            // TaskAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 319);
            this.Controls.Add(this.TimeGroupBox);
            this.Controls.Add(this.buttonCncl);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.AboutRichTextBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.UserСomboBox);
            this.Name = "TaskAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskAddForm";
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox UserСomboBox;
        public System.Windows.Forms.DateTimePicker DateTimePicker;
        public System.Windows.Forms.ComboBox ClientComboBox;
        public System.Windows.Forms.ComboBox StatusComboBox;
        public System.Windows.Forms.RichTextBox AboutRichTextBox;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCncl;
        public System.Windows.Forms.ComboBox TimeStartComboBox;
        public System.Windows.Forms.ComboBox TimeEndComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox TimeGroupBox;
    }
}