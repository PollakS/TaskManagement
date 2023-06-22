namespace TaskManagement
{
    partial class tasksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tasksTable = new System.Windows.Forms.DataGridView();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteTaskColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.priorityLowRadioButton = new System.Windows.Forms.RadioButton();
            this.priorityMediumRadioButton = new System.Windows.Forms.RadioButton();
            this.priorityHighRadioButton = new System.Windows.Forms.RadioButton();
            this.addDueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addDescRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addTitleTextBox = new System.Windows.Forms.TextBox();
            this.addPriorityLabel = new System.Windows.Forms.Label();
            this.addTaskTitleLabel = new System.Windows.Forms.Label();
            this.addDueDateLabel = new System.Windows.Forms.Label();
            this.addTaskDescLabel = new System.Windows.Forms.Label();
            this.createNewTaskLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.editAndSaveButton = new System.Windows.Forms.Button();
            this.priorityFilterComboBox = new System.Windows.Forms.ComboBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.filterDueDateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterByPriorityLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clearFiltersButton = new System.Windows.Forms.Button();
            this.applyDateFilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tasksTable)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksTable
            // 
            this.tasksTable.AllowUserToOrderColumns = true;
            this.tasksTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.tasksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.TaskTitle,
            this.Description,
            this.Due,
            this.Priority,
            this.deleteTaskColumn});
            this.tasksTable.Location = new System.Drawing.Point(258, 123);
            this.tasksTable.Name = "tasksTable";
            this.tasksTable.RowHeadersWidth = 51;
            this.tasksTable.RowTemplate.Height = 24;
            this.tasksTable.Size = new System.Drawing.Size(813, 157);
            this.tasksTable.TabIndex = 1;
            this.tasksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tasksTable_CellContentClick);
            // 
            // TaskID
            // 
            this.TaskID.HeaderText = "Task ID";
            this.TaskID.MinimumWidth = 6;
            this.TaskID.Name = "TaskID";
            this.TaskID.Width = 125;
            // 
            // TaskTitle
            // 
            this.TaskTitle.HeaderText = "Task Title";
            this.TaskTitle.MinimumWidth = 6;
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Due
            // 
            this.Due.HeaderText = "Due Date";
            this.Due.MinimumWidth = 6;
            this.Due.Name = "Due";
            this.Due.Width = 125;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority Level";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.Width = 125;
            // 
            // deleteTaskColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.deleteTaskColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.deleteTaskColumn.HeaderText = "";
            this.deleteTaskColumn.MinimumWidth = 6;
            this.deleteTaskColumn.Name = "deleteTaskColumn";
            this.deleteTaskColumn.Text = "Delete Task";
            this.deleteTaskColumn.ToolTipText = "Delete Task";
            this.deleteTaskColumn.UseColumnTextForButtonValue = true;
            this.deleteTaskColumn.Width = 125;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.leftPanel.Controls.Add(this.addTaskButton);
            this.leftPanel.Controls.Add(this.priorityLowRadioButton);
            this.leftPanel.Controls.Add(this.priorityMediumRadioButton);
            this.leftPanel.Controls.Add(this.priorityHighRadioButton);
            this.leftPanel.Controls.Add(this.addDueDatePicker);
            this.leftPanel.Controls.Add(this.addDescRichTextBox);
            this.leftPanel.Controls.Add(this.addTitleTextBox);
            this.leftPanel.Controls.Add(this.addPriorityLabel);
            this.leftPanel.Controls.Add(this.addTaskTitleLabel);
            this.leftPanel.Controls.Add(this.addDueDateLabel);
            this.leftPanel.Controls.Add(this.addTaskDescLabel);
            this.leftPanel.Controls.Add(this.createNewTaskLabel);
            this.leftPanel.Location = new System.Drawing.Point(11, 12);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(241, 454);
            this.leftPanel.TabIndex = 2;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addTaskButton.Location = new System.Drawing.Point(58, 414);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(120, 29);
            this.addTaskButton.TabIndex = 4;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // priorityLowRadioButton
            // 
            this.priorityLowRadioButton.AutoSize = true;
            this.priorityLowRadioButton.Location = new System.Drawing.Point(15, 386);
            this.priorityLowRadioButton.Name = "priorityLowRadioButton";
            this.priorityLowRadioButton.Size = new System.Drawing.Size(54, 21);
            this.priorityLowRadioButton.TabIndex = 10;
            this.priorityLowRadioButton.TabStop = true;
            this.priorityLowRadioButton.Text = "Low";
            this.priorityLowRadioButton.UseVisualStyleBackColor = true;
            // 
            // priorityMediumRadioButton
            // 
            this.priorityMediumRadioButton.AutoSize = true;
            this.priorityMediumRadioButton.Location = new System.Drawing.Point(15, 363);
            this.priorityMediumRadioButton.Name = "priorityMediumRadioButton";
            this.priorityMediumRadioButton.Size = new System.Drawing.Size(78, 21);
            this.priorityMediumRadioButton.TabIndex = 9;
            this.priorityMediumRadioButton.TabStop = true;
            this.priorityMediumRadioButton.Text = "Medium";
            this.priorityMediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // priorityHighRadioButton
            // 
            this.priorityHighRadioButton.AutoSize = true;
            this.priorityHighRadioButton.Location = new System.Drawing.Point(15, 341);
            this.priorityHighRadioButton.Name = "priorityHighRadioButton";
            this.priorityHighRadioButton.Size = new System.Drawing.Size(58, 21);
            this.priorityHighRadioButton.TabIndex = 8;
            this.priorityHighRadioButton.TabStop = true;
            this.priorityHighRadioButton.Text = "High";
            this.priorityHighRadioButton.UseVisualStyleBackColor = true;
            // 
            // addDueDatePicker
            // 
            this.addDueDatePicker.Location = new System.Drawing.Point(15, 275);
            this.addDueDatePicker.Name = "addDueDatePicker";
            this.addDueDatePicker.Size = new System.Drawing.Size(212, 23);
            this.addDueDatePicker.TabIndex = 7;
            // 
            // addDescRichTextBox
            // 
            this.addDescRichTextBox.Location = new System.Drawing.Point(15, 152);
            this.addDescRichTextBox.Name = "addDescRichTextBox";
            this.addDescRichTextBox.Size = new System.Drawing.Size(210, 78);
            this.addDescRichTextBox.TabIndex = 4;
            this.addDescRichTextBox.Text = "";
            // 
            // addTitleTextBox
            // 
            this.addTitleTextBox.Location = new System.Drawing.Point(15, 88);
            this.addTitleTextBox.Name = "addTitleTextBox";
            this.addTitleTextBox.Size = new System.Drawing.Size(212, 23);
            this.addTitleTextBox.TabIndex = 4;
            // 
            // addPriorityLabel
            // 
            this.addPriorityLabel.AutoSize = true;
            this.addPriorityLabel.Location = new System.Drawing.Point(14, 319);
            this.addPriorityLabel.Name = "addPriorityLabel";
            this.addPriorityLabel.Size = new System.Drawing.Size(94, 17);
            this.addPriorityLabel.TabIndex = 6;
            this.addPriorityLabel.Text = "Priority Level:";
            // 
            // addTaskTitleLabel
            // 
            this.addTaskTitleLabel.AutoSize = true;
            this.addTaskTitleLabel.Location = new System.Drawing.Point(12, 66);
            this.addTaskTitleLabel.Name = "addTaskTitleLabel";
            this.addTaskTitleLabel.Size = new System.Drawing.Size(74, 17);
            this.addTaskTitleLabel.TabIndex = 4;
            this.addTaskTitleLabel.Text = "Task Title:";
            // 
            // addDueDateLabel
            // 
            this.addDueDateLabel.AutoSize = true;
            this.addDueDateLabel.Location = new System.Drawing.Point(14, 252);
            this.addDueDateLabel.Name = "addDueDateLabel";
            this.addDueDateLabel.Size = new System.Drawing.Size(72, 17);
            this.addDueDateLabel.TabIndex = 5;
            this.addDueDateLabel.Text = "Due Date:";
            // 
            // addTaskDescLabel
            // 
            this.addTaskDescLabel.AutoSize = true;
            this.addTaskDescLabel.Location = new System.Drawing.Point(14, 130);
            this.addTaskDescLabel.Name = "addTaskDescLabel";
            this.addTaskDescLabel.Size = new System.Drawing.Size(83, 17);
            this.addTaskDescLabel.TabIndex = 4;
            this.addTaskDescLabel.Text = "Description:";
            // 
            // createNewTaskLabel
            // 
            this.createNewTaskLabel.AutoSize = true;
            this.createNewTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTaskLabel.Location = new System.Drawing.Point(28, 20);
            this.createNewTaskLabel.Name = "createNewTaskLabel";
            this.createNewTaskLabel.Size = new System.Drawing.Size(186, 25);
            this.createNewTaskLabel.TabIndex = 4;
            this.createNewTaskLabel.Text = "Create New Task:";
            this.createNewTaskLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(946, 432);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 34);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editAndSaveButton
            // 
            this.editAndSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.editAndSaveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editAndSaveButton.Location = new System.Drawing.Point(12, 9);
            this.editAndSaveButton.Name = "editAndSaveButton";
            this.editAndSaveButton.Size = new System.Drawing.Size(121, 34);
            this.editAndSaveButton.TabIndex = 4;
            this.editAndSaveButton.Text = "Edit Tasks";
            this.editAndSaveButton.UseVisualStyleBackColor = true;
            this.editAndSaveButton.Click += new System.EventHandler(this.editAndSaveButton_Click);
            // 
            // priorityFilterComboBox
            // 
            this.priorityFilterComboBox.FormattingEnabled = true;
            this.priorityFilterComboBox.Location = new System.Drawing.Point(16, 55);
            this.priorityFilterComboBox.Name = "priorityFilterComboBox";
            this.priorityFilterComboBox.Size = new System.Drawing.Size(121, 24);
            this.priorityFilterComboBox.TabIndex = 6;
            this.priorityFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.priorityFilterComboBox_SelectedIndexChanged);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.topPanel.Controls.Add(this.applyDateFilterButton);
            this.topPanel.Controls.Add(this.endDatePicker);
            this.topPanel.Controls.Add(this.startDatePicker);
            this.topPanel.Controls.Add(this.toLabel);
            this.topPanel.Controls.Add(this.fromLabel);
            this.topPanel.Controls.Add(this.filterDueDateLabel);
            this.topPanel.Location = new System.Drawing.Point(258, 12);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(505, 105);
            this.topPanel.TabIndex = 9;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(74, 66);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(249, 23);
            this.endDatePicker.TabIndex = 11;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(74, 35);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(249, 23);
            this.startDatePicker.TabIndex = 11;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(39, 66);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 17);
            this.toLabel.TabIndex = 11;
            this.toLabel.Text = "To:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(24, 40);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 17);
            this.fromLabel.TabIndex = 10;
            this.fromLabel.Text = "From:";
            // 
            // filterDueDateLabel
            // 
            this.filterDueDateLabel.AutoSize = true;
            this.filterDueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDueDateLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.filterDueDateLabel.Location = new System.Drawing.Point(22, 8);
            this.filterDueDateLabel.Name = "filterDueDateLabel";
            this.filterDueDateLabel.Size = new System.Drawing.Size(143, 18);
            this.filterDueDateLabel.TabIndex = 9;
            this.filterDueDateLabel.Text = "Filter by Due Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.editAndSaveButton);
            this.panel1.Location = new System.Drawing.Point(926, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 51);
            this.panel1.TabIndex = 10;
            // 
            // filterByPriorityLabel
            // 
            this.filterByPriorityLabel.AutoSize = true;
            this.filterByPriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByPriorityLabel.Location = new System.Drawing.Point(12, 21);
            this.filterByPriorityLabel.Name = "filterByPriorityLabel";
            this.filterByPriorityLabel.Size = new System.Drawing.Size(127, 18);
            this.filterByPriorityLabel.TabIndex = 0;
            this.filterByPriorityLabel.Text = "Filter by Priority";
            this.filterByPriorityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.filterByPriorityLabel);
            this.panel2.Controls.Add(this.priorityFilterComboBox);
            this.panel2.Location = new System.Drawing.Point(769, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 105);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.clearFiltersButton);
            this.panel3.Location = new System.Drawing.Point(926, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 51);
            this.panel3.TabIndex = 12;
            // 
            // clearFiltersButton
            // 
            this.clearFiltersButton.Location = new System.Drawing.Point(12, 9);
            this.clearFiltersButton.Name = "clearFiltersButton";
            this.clearFiltersButton.Size = new System.Drawing.Size(121, 34);
            this.clearFiltersButton.TabIndex = 1;
            this.clearFiltersButton.Text = "Clear Filters";
            this.clearFiltersButton.UseVisualStyleBackColor = true;
            // 
            // applyDateFilterButton
            // 
            this.applyDateFilterButton.Location = new System.Drawing.Point(354, 35);
            this.applyDateFilterButton.Name = "applyDateFilterButton";
            this.applyDateFilterButton.Size = new System.Drawing.Size(121, 40);
            this.applyDateFilterButton.TabIndex = 2;
            this.applyDateFilterButton.Text = "Apply Filter";
            this.applyDateFilterButton.UseVisualStyleBackColor = true;
            this.applyDateFilterButton.Click += new System.EventHandler(this.applyDateFilterButton_Click);
            // 
            // tasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tasksTable);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "tasksForm";
            this.Text = "Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.tasksTable)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tasksTable;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label createNewTaskLabel;
        private System.Windows.Forms.Label addTaskTitleLabel;
        private System.Windows.Forms.TextBox addTitleTextBox;
        private System.Windows.Forms.Label addPriorityLabel;
        private System.Windows.Forms.Label addDueDateLabel;
        private System.Windows.Forms.Label addTaskDescLabel;
        private System.Windows.Forms.DateTimePicker addDueDatePicker;
        private System.Windows.Forms.RichTextBox addDescRichTextBox;
        private System.Windows.Forms.RadioButton priorityLowRadioButton;
        private System.Windows.Forms.RadioButton priorityMediumRadioButton;
        private System.Windows.Forms.RadioButton priorityHighRadioButton;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Due;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewButtonColumn deleteTaskColumn;
        private System.Windows.Forms.Button editAndSaveButton;
        private System.Windows.Forms.ComboBox priorityFilterComboBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label filterDueDateLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label filterByPriorityLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clearFiltersButton;
        private System.Windows.Forms.Button applyDateFilterButton;
    }
}

