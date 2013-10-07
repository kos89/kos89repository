namespace TasksDevite
{
    partial class TaskMonthForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCncl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAdd,
            this.ColumnUser,
            this.ColumnClient,
            this.ColumnDate,
            this.ColumnStart,
            this.ColumnEnd});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(884, 380);
            this.dataGridView.TabIndex = 0;
            // 
            // ColumnAdd
            // 
            this.ColumnAdd.HeaderText = "Добавить";
            this.ColumnAdd.Name = "ColumnAdd";
            // 
            // ColumnUser
            // 
            this.ColumnUser.HeaderText = "Ответственный";
            this.ColumnUser.Name = "ColumnUser";
            // 
            // ColumnClient
            // 
            this.ColumnClient.HeaderText = "Клиент";
            this.ColumnClient.Name = "ColumnClient";
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnStart
            // 
            this.ColumnStart.HeaderText = "Начало";
            this.ColumnStart.Name = "ColumnStart";
            // 
            // ColumnEnd
            // 
            this.ColumnEnd.HeaderText = "Конец";
            this.ColumnEnd.Name = "ColumnEnd";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(632, 398);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(129, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Подтвердить";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCncl
            // 
            this.buttonCncl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCncl.Location = new System.Drawing.Point(767, 398);
            this.buttonCncl.Name = "buttonCncl";
            this.buttonCncl.Size = new System.Drawing.Size(129, 23);
            this.buttonCncl.TabIndex = 2;
            this.buttonCncl.Text = "Отмена";
            this.buttonCncl.UseVisualStyleBackColor = true;
            // 
            // TaskMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 433);
            this.Controls.Add(this.buttonCncl);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dataGridView);
            this.Name = "TaskMonthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskMonthForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.DataGridViewCheckBoxColumn ColumnAdd;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColumnStart;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnd;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCncl;
    }
}