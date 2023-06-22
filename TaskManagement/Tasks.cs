using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace TaskManagement
{
    public partial class tasksForm : Form
    {
        string connectionString = @"Data Source=(local);Initial Catalog=TasksManagementDatabase;Integrated Security=True";
        private int taskIdColumnIndex = -1;
        private bool isEditing = false; // New flag to track if editing is in progress
        private bool isSaveChanges = false;
        private Dictionary<int, DataGridViewRow> editedRows = new Dictionary<int, DataGridViewRow>(); // Store edited rows


        public tasksForm()
        {
            InitializeComponent();

            // Load the tasks from the database and populate the DataGridView
            LoadTasks();

            // Set TaskID column as read-only
            tasksTable.Columns["TaskID"].ReadOnly = true;

            // Hook up event handlers
            tasksTable.CellBeginEdit += tasksTable_CellBeginEdit; // Track when cell editing starts
            tasksTable.CellEndEdit += tasksTable_CellEndEdit; // Handle cell editing completion

            tasksTable.CellValidating += tasksTable_CellValidating; // Handle cell validation

            // Add priority options to the combo box
            priorityFilterComboBox.Items.Add("High");
            priorityFilterComboBox.Items.Add("Medium");
            priorityFilterComboBox.Items.Add("Low");

            applyDateFilterButton.Click += applyDateFilterButton_Click;
            clearFiltersButton.Click += clearFiltersButton_Click;       

            // Set the initial state of the DataGridView
            tasksTable.ReadOnly = true;
            editAndSaveButton.Text = "Edit Tasks";

            // Subscribe to the FormClosing event
            this.FormClosing += tasksForm_FormClosing;        
        }
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            // Retrieve the task details from the input controls
            string title = addTitleTextBox.Text.Trim();
            string description = addDescRichTextBox.Text.Trim();
            DateTime dueDate = addDueDatePicker.Value;

            string priority = "";
            if (priorityHighRadioButton.Checked)
                priority = "High";
            else if (priorityMediumRadioButton.Checked)
                priority = "Medium";
            else if (priorityLowRadioButton.Checked)
                priority = "Low";

            // Perform field validation
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(priority))
            {
                MessageBox.Show("Please fill in all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create the SQL query to insert the task into the database
            string query = "INSERT INTO Tasks (TaskTitle, TaskDescription, DueDate, PriorityLevel) " +
                "VALUES (@Title, @Description, @DueDate, @Priority)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@DueDate", dueDate);
                    command.Parameters.AddWithValue("@Priority", priority);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Task added successfully!");

                        // Refresh the tasks in the DataGridView
                        LoadTasks();

                        // Clear the input controls after adding the task
                        addTitleTextBox.Text = string.Empty;
                        addDescRichTextBox.Text = string.Empty;
                        addDueDatePicker.Value = DateTime.Today;

                        priorityHighRadioButton.Checked = false;
                        priorityMediumRadioButton.Checked = false;
                        priorityLowRadioButton.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while adding the task: " + ex.Message);
                    }
                }
            }
        }

        private void tasksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tasksTable.Columns["deleteTaskColumn"].Index)
            {
                // Check if the row is in an uncommitted state
                if (tasksTable.Rows[e.RowIndex].IsNewRow)
                {
                    MessageBox.Show("Cannot delete an uncommitted new task.");
                    return;
                }

                // Check if the "TaskID" column exists
                if (taskIdColumnIndex != -1)
                {
                    // Use int.TryParse to safely convert the value to an integer
                    if (int.TryParse(tasksTable.Rows[e.RowIndex].Cells[taskIdColumnIndex].Value.ToString(), out int taskId))
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Call the DeleteTask method to delete the task from the database
                            DeleteTask(taskId);

                            // Refresh the tasks in the DataGridView
                            LoadTasks();

                            MessageBox.Show("Task deleted successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Task ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Task ID column not found.");
                }
            }
        }

        private void DeleteTask(int taskId)
        {
            string query = "DELETE FROM Tasks WHERE TaskID = @TaskID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaskID", taskId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Task not found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the task: " + ex.Message);
                    }
                }
            }
        }

        private void LoadTasks()
        {
            string query = "SELECT TaskID, TaskTitle, TaskDescription, DueDate, PriorityLevel FROM Tasks";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        tasksTable.Rows.Clear();

                        while (reader.Read())
                        {
                            int taskId = reader.GetInt32(0);
                            string taskTitle = reader.GetString(1);
                            string taskDescription = reader.GetString(2);
                            DateTime dueDate = reader.GetDateTime(3);
                            string priorityLevel = reader.GetString(4);

                            tasksTable.Rows.Add(taskId, taskTitle, taskDescription, dueDate, priorityLevel);
                        }

                        reader.Close();

                        // Set the TaskID column index
                        if (tasksTable.Columns.Contains("TaskID"))
                        {
                            taskIdColumnIndex = tasksTable.Columns["TaskID"].Index;
                        }
                        // Hide the empty row at the bottom of the DataGridView
                        tasksTable.AllowUserToAddRows = false;
                        tasksTable.ScrollBars = ScrollBars.Vertical;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading tasks: " + ex.Message);
                    }
                }
            }
           
        }
        private void tasksTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            isEditing = true; // Set the flag to true when a cell begins editing
        }

        private void tasksTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int taskIdColumnIndex = tasksTable.Columns["TaskID"].Index;
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                // Check if the edited cell is not the TaskID column
                if (columnIndex != taskIdColumnIndex)
                {
                    DataGridViewRow editedRow = tasksTable.Rows[rowIndex];
                    DataGridViewCell taskIdCell = editedRow.Cells[taskIdColumnIndex];

                    // Check if the TaskID cell is not null and its value is a valid integer
                    if (taskIdCell.Value != null && int.TryParse(taskIdCell.Value.ToString(), out int taskId))
                    {
                        // Add the edited row to the dictionary
                        editedRows[taskId] = editedRow;
                    }
                }
            }
        }
        private void tasksTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == tasksTable.Columns["Due"].Index)
            {
                // Validate the cell in the "Due Date" column
                DateTime newDate;
                if (!DateTime.TryParse(e.FormattedValue.ToString(), out newDate))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a valid date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == tasksTable.Columns["Priority"].Index)
            {
                // Validate the cell in the "Priority" column
                string priority = e.FormattedValue.ToString().Trim().ToLower();
                if (priority != "high" && priority != "medium" && priority != "low")
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a valid priority (High, Medium, Low).", "Invalid Priority", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Convert the priority to proper case (e.g., High, Medium, Low)
                    tasksTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = char.ToUpper(priority[0]) + priority.Substring(1);
                }
            }
        }

        private void editAndSaveButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                // Enable editing in the DataGridView
                tasksTable.ReadOnly = false;
                tasksTable.Columns["TaskID"].ReadOnly = true;

                editAndSaveButton.Text = "Save Changes";
                isEditing = true;
            }
            else
            {
                // Disable editing in the DataGridView
                tasksTable.ReadOnly = true;
                editAndSaveButton.Text = "Edit Tasks";
                isEditing = false;

                // Save the changes to the database
                foreach (var entry in editedRows)
                {
                    int taskId = entry.Key;
                    DataGridViewRow editedRow = entry.Value;

                    // Update the task in the database
                    bool updateResult = UpdateTask(taskId, editedRow);

                    if (updateResult)
                    {
                        // Show a success message if the task is updated successfully
                        MessageBox.Show("Task updated successfully!");
                    }
                    else
                    {
                        // Show an error message if the task update fails
                        MessageBox.Show("Failed to update the task.");
                    }
                }

                editedRows.Clear(); // Clear the dictionary after saving changes

                // Show a message indicating that changes are saved
                MessageBox.Show("Changes are saved.", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the tasks in the DataGridView
                LoadTasks();
            }
        }

        private bool UpdateTask(int taskId, DataGridViewRow editedRow)
        {
            string query = "UPDATE Tasks SET TaskTitle = @Title, TaskDescription = @Description, DueDate = @DueDate, PriorityLevel = @Priority WHERE TaskID = @TaskID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaskID", taskId);
                    command.Parameters.AddWithValue("@Title", editedRow.Cells["TaskTitle"].Value.ToString());
                    command.Parameters.AddWithValue("@Description", editedRow.Cells["Description"].Value.ToString());
                    command.Parameters.AddWithValue("@DueDate", editedRow.Cells["Due"].Value);

                    // Convert the priority to the desired format (first letter uppercase)
                    string priority = editedRow.Cells["Priority"].Value.ToString().ToLower();
                    if (priority == "high" || priority == "medium" || priority == "low")
                    {
                        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                        priority = textInfo.ToTitleCase(priority);
                    }
                    command.Parameters.AddWithValue("@Priority", priority);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Refresh the tasks in the DataGridView
                            RefreshTasks();

                            return true; // Return true if the update is successful
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the task: " + ex.Message);
                    }
                }
            }

            return false; // Return false if the update fails
        }

        private void RefreshTasks()
        {
            tasksTable.EndEdit(); // End any ongoing editing before refreshing the data source

            // Store the selected row and scroll position
            int selectedRowIndex = tasksTable.SelectedCells.Count > 0 ? tasksTable.SelectedCells[0].RowIndex : -1;
            int firstDisplayedScrollingRowIndex = tasksTable.FirstDisplayedScrollingRowIndex;

            // Reload the tasks from the database and repopulate the DataGridView
            LoadTasks();

            // Restore the selected row and scroll position
            if (selectedRowIndex >= 0 && selectedRowIndex < tasksTable.RowCount)
            {
                tasksTable.Rows[selectedRowIndex].Selected = true;
                tasksTable.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
            }
        }

        private void priorityFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPriority = priorityFilterComboBox.Text; // Use the Text property instead of SelectedText

            if (string.IsNullOrEmpty(selectedPriority))
            {
                // No priority selected, show all rows
                foreach (DataGridViewRow row in tasksTable.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                // Filter rows based on selected priority
                foreach (DataGridViewRow row in tasksTable.Rows)
                {
                    string priority = row.Cells["Priority"].Value.ToString();

                    if (priority == selectedPriority)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void applyDateFilterButton_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve the selected start and end dates
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            // Step 2: Apply the date range filter
            ApplyDateRangeFilter(startDate, endDate);
        }

        private void ApplyDateRangeFilter(DateTime startDate, DateTime endDate)
        {
            foreach (DataGridViewRow row in tasksTable.Rows)
            {
                DateTime dueDate = Convert.ToDateTime(row.Cells["Due"].Value);

                if (dueDate >= startDate && dueDate <= endDate)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            startDatePicker.Value = DateTime.Now.Date;
            endDatePicker.Value = DateTime.Now.Date;
            priorityFilterComboBox.SelectedItem = null;

            LoadTasks();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tasksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEditing && editedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes. Are you sure you want to exit?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
       
    }
}

