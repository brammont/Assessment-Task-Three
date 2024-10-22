using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MSSS_StaffManagementApp_
{
	public partial class AdminForm : Form
	{
		public AdminForm(int staffId, string staffName)
		{
			InitializeComponent();
			LoadStaffData();

			// Set the staff details in text boxes
			txtAdminID.Text = staffId.ToString();
			txtAdminName.Text = staffName;
		}

		public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();
		private List<Staff> staffRecords = new List<Staff>();

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

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Logic for when a listbox item is selected, if needed
		}
	}
}
