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
        private List<Staff> staffRecords = new List<Staff>();
        int initicalId;
        public AdminForm(int staffId, string staffName)
		{
			InitializeComponent();
			LoadStaffData();
            string initicalName = staffName;
            initicalId = staffId;
            // Set the staff details in text boxes
            txtAdminID.Text = staffId.ToString();
			txtAdminName.Text = staffName;
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

		private void btnCreate_Click(object sender, EventArgs e)
		{
			string id = txtAdminID.Text;
			string name = txtAdminName.Text;

			// Check for duplicate ID number
			if (staffRecords.Any(s => s.ID == id))
			{
				lblAdminStatus.Text = "Duplicate ID found. Record not created.";
				return;
			}

			// Add new staff record
			Staff newStaff = new Staff { ID = id, Name = name };
			staffRecords.Add(newStaff);

			// Append to CSV file
			File.AppendAllText("staff_data.csv", $"{id},{name}{Environment.NewLine}");

			lblAdminStatus.Text = "Record created successfully.";
		}

		private void btnOpenMain_Click(object sender, EventArgs e)
		{
			this.Close();

		}
        // Method to update a staff record
        private void UpdateStaffRecord()
        {
            // Parse the ID from the text box
            if (int.TryParse(txtAdminID.Text, out int id) && !string.IsNullOrWhiteSpace(txtAdminName.Text))
            {
                // Check if the ID exists in MasterFile
                if (MasterFile.ContainsKey(id))
                {
                    // Update the name for the existing ID
                    MasterFile[id] = txtAdminName.Text.Trim();

                    // Save the updated records back to the CSV file
                    SaveStaffData();

                    // Display a success message and refresh the display
                    lblAdminStatus.Text = "Record updated successfully.";
                    DisplayData();
                }
                else
                {
                    // If the ID doesn't exist, display an error message
                    lblAdminStatus.Text = "Record not found. Update failed.";
                }
            }
            else
            {
                // If the ID or Name is invalid, display an error message
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
                    MasterFile.Remove(id); // Remove the record
                    SaveStaffData(); // Save changes to the CSV file
                    lblAdminStatus.Text = "Record deleted successfully.";
                    DisplayData(); // Refresh the displayed data
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
