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
            this.SuspendLayout();
            // 
            // UserСomboBox
            // 
            this.UserСomboBox.FormattingEnabled = true;
            this.UserСomboBox.Location = new System.Drawing.Point(105, 38);
            this.UserСomboBox.Name = "UserСomboBox";
            this.UserСomboBox.Size = new System.Drawing.Size(200, 21);
            this.UserСomboBox.TabIndex = 0;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(105, 12);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 1;
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(105, 63);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(200, 21);
            this.ClientComboBox.TabIndex = 2;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Открыт",
            "Закрыт"});
            this.StatusComboBox.Location = new System.Drawing.Point(105, 90);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(200, 21);
            this.StatusComboBox.TabIndex = 3;
            // 
            // AboutRichTextBox
            // 
            this.AboutRichTextBox.Location = new System.Drawing.Point(105, 117);
            this.AboutRichTextBox.Name = "AboutRichTextBox";
            this.AboutRichTextBox.Size = new System.Drawing.Size(200, 94);
            this.AboutRichTextBox.TabIndex = 4;
            this.AboutRichTextBox.Text = "";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(15, 18);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Дата:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 41);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(77, 13);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "Исполнитель:";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 66);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(46, 13);
            this.labelClient.TabIndex = 7;
            this.labelClient.Text = "Клиент:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(15, 93);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Статус:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 120);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Примечание:";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(105, 217);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(92, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Сохранить";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCncl
            // 
            this.buttonCncl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCncl.Location = new System.Drawing.Point(214, 217);
            this.buttonCncl.Name = "buttonCncl";
            this.buttonCncl.Size = new System.Drawing.Size(91, 23);
            this.buttonCncl.TabIndex = 11;
            this.buttonCncl.Text = "Отмена";
            this.buttonCncl.UseVisualStyleBackColor = true;
            // 
            // TaskAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 258);
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
    }
}