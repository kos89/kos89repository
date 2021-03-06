﻿namespace TasksDevite
{
    partial class ClientAddForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.DateStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCncl = new System.Windows.Forms.Button();
            this.labelDays = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeEndComboBox = new System.Windows.Forms.ComboBox();
            this.TimeStartComboBox = new System.Windows.Forms.ComboBox();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название:";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(37, 62);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(41, 13);
            this.labelAdress.TabIndex = 1;
            this.labelAdress.Text = "Адрес:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(33, 88);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 114);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(124, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Дата начала договора:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(7, 236);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(111, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Договор действует?";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(133, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(214, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(133, 59);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(214, 20);
            this.AdressTextBox.TabIndex = 6;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(133, 85);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(213, 20);
            this.PhoneTextBox.TabIndex = 7;
            // 
            // DateStartTimePicker
            // 
            this.DateStartTimePicker.Location = new System.Drawing.Point(133, 111);
            this.DateStartTimePicker.Name = "DateStartTimePicker";
            this.DateStartTimePicker.Size = new System.Drawing.Size(213, 20);
            this.DateStartTimePicker.TabIndex = 9;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.StatusComboBox.Location = new System.Drawing.Point(133, 228);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(214, 21);
            this.StatusComboBox.TabIndex = 10;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(133, 255);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 23);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "Сохранить";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCncl
            // 
            this.buttonCncl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCncl.Location = new System.Drawing.Point(249, 255);
            this.buttonCncl.Name = "buttonCncl";
            this.buttonCncl.Size = new System.Drawing.Size(98, 23);
            this.buttonCncl.TabIndex = 12;
            this.buttonCncl.Text = "Отмена";
            this.buttonCncl.UseVisualStyleBackColor = true;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(28, 144);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(70, 13);
            this.labelDays.TabIndex = 27;
            this.labelDays.Text = "Дни недели:";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox7.Location = new System.Drawing.Point(322, 136);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(25, 31);
            this.checkBox7.TabIndex = 26;
            this.checkBox7.Text = "ВС";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox6.Location = new System.Drawing.Point(290, 136);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(25, 31);
            this.checkBox6.TabIndex = 25;
            this.checkBox6.Text = "СБ";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox5.Location = new System.Drawing.Point(258, 136);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(26, 31);
            this.checkBox5.TabIndex = 24;
            this.checkBox5.Text = "ПТ";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox4.Location = new System.Drawing.Point(226, 136);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(26, 31);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "ЧТ";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox3.Location = new System.Drawing.Point(195, 136);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(25, 31);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "СР";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox2.Location = new System.Drawing.Point(164, 136);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(25, 31);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "ВТ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox1.Location = new System.Drawing.Point(131, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(27, 31);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "ПН";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Время окончания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Время начала:";
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
            this.TimeEndComboBox.Location = new System.Drawing.Point(133, 201);
            this.TimeEndComboBox.Name = "TimeEndComboBox";
            this.TimeEndComboBox.Size = new System.Drawing.Size(213, 21);
            this.TimeEndComboBox.TabIndex = 29;
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
            this.TimeStartComboBox.Location = new System.Drawing.Point(133, 174);
            this.TimeStartComboBox.Name = "TimeStartComboBox";
            this.TimeStartComboBox.Size = new System.Drawing.Size(213, 21);
            this.TimeStartComboBox.TabIndex = 28;
            // 
            // UserComboBox
            // 
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(133, 32);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(214, 21);
            this.UserComboBox.TabIndex = 32;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(25, 35);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(89, 13);
            this.labelUser.TabIndex = 33;
            this.labelUser.Text = "Ответственный:";
            // 
            // ClientAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 292);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeEndComboBox);
            this.Controls.Add(this.TimeStartComboBox);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonCncl);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.DateStartTimePicker);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelName);
            this.Name = "ClientAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.TextBox AdressTextBox;
        public System.Windows.Forms.TextBox PhoneTextBox;
        public System.Windows.Forms.DateTimePicker DateStartTimePicker;
        public System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCncl;
        private System.Windows.Forms.Label labelDays;
        public System.Windows.Forms.CheckBox checkBox7;
        public System.Windows.Forms.CheckBox checkBox6;
        public System.Windows.Forms.CheckBox checkBox5;
        public System.Windows.Forms.CheckBox checkBox4;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox TimeEndComboBox;
        public System.Windows.Forms.ComboBox TimeStartComboBox;
        public System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.Label labelUser;
    }
}