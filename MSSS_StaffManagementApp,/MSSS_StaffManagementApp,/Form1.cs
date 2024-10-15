using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MSSS_StaffManagementApp_
{
	public partial class Form1 : Form
	{
		public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();
		private List<Staff> staffRecords = new List<Staff>();

		public Form1()
		{
			InitializeComponent();
			LoadStaffData();			
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
					MasterFile.Add(id, parts[1]);  // Add to the Dictionary
				}
			}
			DisplayData();
			lblStatus.Text = $"{MasterFile.Count} records loaded.";
		}
		// Method to display all data in ListBox1
		private void DisplayData()
		{
			lstAllRecords.Items.Clear();
			foreach (var item in MasterFile)
			{
				lstAllRecords.Items.Add($"{item.Key}: {item.Value}");
			}
		}
		private void loadButton_Click(object sender, EventArgs e)
		{
			LoadStaffData();			
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			string searchTerm = txtFilter.Text.ToLower();

			var filteredRecords = staffRecords
				.Where(record => record.ID.Contains(searchTerm) || record.Name.ToLower().Contains(searchTerm))
				.ToList();

			lstFilteredRecords.Items.Clear();
			foreach (var record in filteredRecords)
			{
				lstFilteredRecords.Items.Add($"{record.ID} - {record.Name}");
			}

			lblStatus.Text = $"{filteredRecords.Count} records found.";
		}
		private bool IsValidLogin(string username, string password)
		{
			
			if (username == "admin" && password == "1234")
			{
				return true; // Login successful
			}
			else
			{
				return false; // Login failed
			}
		}
		private void btnOpenAdmin_Click(object sender, EventArgs e)
		{
			// 1. Get username and password from textbox controls (replace with your textbox names)
			string username = UserTextBox.Text;
			string password = pwdTextBox.Text;

			// 2. Perform login validation (replace with your validation logic)
			if (IsValidLogin(username, password))
			{
				// Login successful - Open AdminForm
				AdminForm adminForm = new AdminForm();
				adminForm.Show();
				//this.Hide(); 
			}
			else
			{
				// Login failed - Show error message
				MessageBox.Show("Invalid username or password!");
			}
		}
	}
}
