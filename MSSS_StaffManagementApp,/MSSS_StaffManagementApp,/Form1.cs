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
		// SortedDictionary instead of Dictionary to keep data sorted by ID
		public static SortedDictionary<int, string> MasterFile = new SortedDictionary<int, string>();
		private List<Staff> staffRecords = new List<Staff>();

		public Form1()
		{
			InitializeComponent();
			LoadStaffData();			
		}
		// Method to load staff data from CSV into SortedDictionary
		private void LoadStaffData()
		{
			try
			{
				string[] lines = File.ReadAllLines("staff_data.csv");
				MasterFile.Clear();  // Clear any existing records

				foreach (string line in lines)
				{
					string[] parts = line.Split(',');
					if (parts.Length == 2 && int.TryParse(parts[0], out int id))
					{
						MasterFile.Add(id, parts[1]);  // Add to the SortedDictionary
					}
				}

				DisplayData();
				lblStatus.Text = $"{MasterFile.Count} records loaded.";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading data: {ex.Message}");
			}
		}
		// Method to display all data in ListBox1 (read-only ListBox for all records)
		private void DisplayData()
		{
			lstAllRecords.Items.Clear();
			foreach (var item in MasterFile)
			{
				lstAllRecords.Items.Add($"{item.Key}: {item.Value}");
			}
		}
		// Filter data based on text entered in txtFilter (real-time filtering)
		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			string filter = txtFilter.Text.ToLower();
			lstFilteredRecords.Items.Clear(); // Clear the ListBox before filtering

			// Filter staff names from MasterFile based on the filter
			var filtered = MasterFile
				.Where(x => x.Value.ToLower().Contains(filter))
				.ToList();

			foreach (var item in filtered)
			{
				lstFilteredRecords.Items.Add($"{item.Key}: {item.Value}");
			}

			lblStatus.Text = $"{filtered.Count} records found.";
		}

		private void loadButton_Click(object sender, EventArgs e)
		{
			LoadStaffData();			
		}
		// Method to clear and focus the name filter text box using Ctrl + N
		private void ClearAndFocusNameBox()
		{
			txtFilterName.Clear();
			txtFilterName.Focus();
		}

		// Method to clear and focus the ID filter text box using Ctrl + I
		private void ClearAndFocusIDBox()
		{
			txtFilterID.Clear();
			txtFilterID.Focus();
		}
		// Keyboard shortcut handler for clearing filter textboxes and opening admin form
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.N))
			{
				ClearAndFocusNameBox();
				return true;
			}
			if (keyData == (Keys.Control | Keys.I))
			{
				ClearAndFocusIDBox();
				return true;
			}
			if (keyData == (Keys.Alt | Keys.A))
			{
				OpenAdminForm();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Open AdminForm when Alt + A is pressed
		private void OpenAdminForm()
		{
			string id = txtStaffId.Text;
			string name = txtStaffName.Text;
			int x = int.Parse(id);
			if (id == "77" && string.IsNullOrEmpty(name))
			{
				AdminForm adminForm = new AdminForm(77,"");
				adminForm.ShowDialog();
			}
			else
			{
				AdminForm adminForm = new AdminForm(x, name);
				adminForm.ShowDialog();
			}
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
			string username = txtStaffId.Text;
			string password = pwdTextBox.Text;

			// 2. Perform login validation (replace with your validation logic)
			if (IsValidLogin(username, password))
			{
				// Login successful - Open AdminForm
				AdminForm adminForm = new AdminForm(1234,"Admin");
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
