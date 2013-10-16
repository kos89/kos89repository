namespace TasksDevite
{
    partial class TasksForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange21 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange22 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange23 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange24 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange25 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.dataSetDevite = new TasksDevite.DataSetDevite();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.Calendar.Calendar();
            this.monthView1 = new System.Windows.Forms.Calendar.MonthView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new TasksDevite.DataSetDeviteTableAdapters.TasksTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDevite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.AllowUserToAddRows = false;
            this.dataGridViewTask.AllowUserToDeleteRows = false;
            this.dataGridViewTask.AllowUserToResizeRows = false;
            this.dataGridViewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTask.AutoGenerateColumns = false;
            this.dataGridViewTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.taskStatusDataGridViewCheckBoxColumn,
            this.aboutDataGridViewTextBoxColumn,
            this.timeStartDataGridViewTextBoxColumn,
            this.timeEndDataGridViewTextBoxColumn});
            this.dataGridViewTask.DataSource = this.tasksBindingSource;
            this.dataGridViewTask.Location = new System.Drawing.Point(6, 59);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.ReadOnly = true;
            this.dataGridViewTask.RowHeadersVisible = false;
            this.dataGridViewTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTask.Size = new System.Drawing.Size(915, 254);
            this.dataGridViewTask.TabIndex = 0;
            // 
            // dataSetDevite
            // 
            this.dataSetDevite.DataSetName = "DataSetDevite";
            this.dataSetDevite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Image = global::TasksDevite.Properties.Resources.phone_6363;
            this.button1.Location = new System.Drawing.Point(335, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::TasksDevite.Properties.Resources.down_2313;
            this.button2.Location = new System.Drawing.Point(279, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calendar
            // 
            this.calendar.AllowItemEdit = false;
            this.calendar.AllowItemResize = false;
            this.calendar.AllowNew = false;
            this.calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange21.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange21.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange21.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange22.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange22.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange22.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange23.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange23.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange23.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange24.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange24.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange24.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange25.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange25.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange25.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange21,
        calendarHighlightRange22,
        calendarHighlightRange23,
        calendarHighlightRange24,
        calendarHighlightRange25};
            this.calendar.Location = new System.Drawing.Point(3, 3);
            this.calendar.MaximumViewDays = 42;
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(1148, 304);
            this.calendar.TabIndex = 9;
            this.calendar.Text = "calendar1";
            this.calendar.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
            // 
            // monthView1
            // 
            this.monthView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView1.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(927, 8);
            this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(219, 305);
            this.monthView1.TabIndex = 11;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
            this.monthView1.SelectionChanged += new System.EventHandler(this.monthView1_SelectionChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::TasksDevite.Properties.Resources.edit_8791;
            this.buttonEdit.Location = new System.Drawing.Point(59, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(50, 50);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::TasksDevite.Properties.Resources.cancel_2821;
            this.buttonDelete.Location = new System.Drawing.Point(115, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::TasksDevite.Properties.Resources.add_8579;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(4, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.statusComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.userComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.monthView1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewTask);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel1.Controls.Add(this.buttonEdit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calendar);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 638);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 12;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Все",
            "Открытые",
            "Закрытые"});
            this.statusComboBox.Location = new System.Drawing.Point(800, 5);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 13;
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Items.AddRange(new object[] {
            "Все",
            "Клейменов",
            "Булгаков",
            "Свиридов"});
            this.userComboBox.Location = new System.Drawing.Point(800, 32);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(121, 21);
            this.userComboBox.TabIndex = 12;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.dataSetDevite;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "Users";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taskStatusDataGridViewCheckBoxColumn
            // 
            this.taskStatusDataGridViewCheckBoxColumn.DataPropertyName = "TaskStatus";
            this.taskStatusDataGridViewCheckBoxColumn.HeaderText = "TaskStatus";
            this.taskStatusDataGridViewCheckBoxColumn.Name = "taskStatusDataGridViewCheckBoxColumn";
            this.taskStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // aboutDataGridViewTextBoxColumn
            // 
            this.aboutDataGridViewTextBoxColumn.DataPropertyName = "About";
            this.aboutDataGridViewTextBoxColumn.HeaderText = "About";
            this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
            this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStartDataGridViewTextBoxColumn
            // 
            this.timeStartDataGridViewTextBoxColumn.DataPropertyName = "TimeStart";
            this.timeStartDataGridViewTextBoxColumn.HeaderText = "TimeStart";
            this.timeStartDataGridViewTextBoxColumn.Name = "timeStartDataGridViewTextBoxColumn";
            this.timeStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeEndDataGridViewTextBoxColumn
            // 
            this.timeEndDataGridViewTextBoxColumn.DataPropertyName = "TimeEnd";
            this.timeEndDataGridViewTextBoxColumn.HeaderText = "TimeEnd";
            this.timeEndDataGridViewTextBoxColumn.Name = "timeEndDataGridViewTextBoxColumn";
            this.timeEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 660);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TasksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TasksForm";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDevite)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Calendar.Calendar calendar;
        private System.Windows.Forms.Calendar.MonthView monthView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox userComboBox;
        private DataSetDevite dataSetDevite;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private DataSetDeviteTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn taskStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn;
    }
}