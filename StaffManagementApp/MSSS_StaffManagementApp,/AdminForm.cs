using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MSSS_StaffManagementApp_
{
    public partial class AdminForm : Form
    {
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();
        private bool target;

        public AdminForm(int staffId, string staffName)
        {
            InitializeComponent();
            LoadStaffData();

            // Set the staff details in text boxes
            txtAdminID.Text = staffId.ToString();
            txtAdminName.Text = staffName;

            // Determine if creation of a new record is allowed
            target = (staffId == 77 && string.IsNullOrEmpty(staffName));

            // Enable the Create button only if target is true
            btnCreate.Enabled = target;
        }
        // Override ProcessCmdKey to detect Alt + L key combination
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.L))
            {
                this.Close(); // Close the AdminForm
                return true;  // Indicate that the key event has been handled
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void LoadStaffData()
        {
            string[] lines = File.ReadAllLines("staff_data.csv");
            MasterFile.Clear();  // Clear any existing records

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && int.TryParse(parts[0], out int id))
                {
                    string name = parts[1];
                    MasterFile.Add(id, name);  // Add to the Dictionary
                }
            }
            DisplayData();
        }

        // Method to display all data in ListBox1
        private void DisplayData()
        {
            listBox1.Items.Clear();
            foreach (var item in MasterFile)
            {
                listBox1.Items.Add($"{item.Key}: {item.Value}");
            }
        }

        // Method to create a new staff record (only allowed if target is true)
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!target)
            {
                lblAdminStatus.Text = "New record creation is not allowed.";
                return;
            }

            if (int.TryParse(txtAdminID.Text, out int id) && !string.IsNullOrWhiteSpace(txtAdminName.Text))
            {
                if (MasterFile.ContainsKey(id))
                {
                    lblAdminStatus.Text = "Duplicate ID found. Record not created.";
                    return;
                }

                // Add new staff record to MasterFile and save to CSV
                MasterFile.Add(id, txtAdminName.Text.Trim());
                SaveStaffData();
                lblAdminStatus.Text = "Record created successfully.";
                DisplayData();
            }
            else
            {
                lblAdminStatus.Text = "Invalid ID or Name.";
            }
        }

        private void btnOpenMain_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
        }

        // Method to update a staff record
        private void UpdateStaffRecord()
        {
            if (int.TryParse(txtAdminID.Text, out int id) && !string.IsNullOrWhiteSpace(txtAdminName.Text))
            {
                if (MasterFile.ContainsKey(id))
                {
                    MasterFile[id] = txtAdminName.Text.Trim();
                    SaveStaffData();
                    lblAdminStatus.Text = "Record updated successfully.";
                    DisplayData();
                }
                else
                {
                    lblAdminStatus.Text = "Record not found. Update failed.";
                }
            }
            else
            {
                lblAdminStatus.Text = "Invalid ID or Name.";
            }
        }

        // Method to delete a staff record
        private void DeleteStaffRecord()
        {
            if (int.TryParse(txtAdminID.Text, out int id))
            {
                if (MasterFile.ContainsKey(id))
                {
                    MasterFile.Remove(id);
                    SaveStaffData();
                    lblAdminStatus.Text = "Record deleted successfully.";
                    DisplayData();
                }
                else
                {
                    lblAdminStatus.Text = "Record not found. Deletion failed.";
                }
            }
            else
            {
                lblAdminStatus.Text = "Invalid ID.";
            }
        }

        // Method to save updated MasterFile data back to the CSV file
        private void SaveStaffData()
        {
            List<string> lines = MasterFile.Select(item => $"{item.Key},{item.Value}").ToList();
            File.WriteAllLines("staff_data.csv", lines);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStaffRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStaffRecord();
        }
    }
}
