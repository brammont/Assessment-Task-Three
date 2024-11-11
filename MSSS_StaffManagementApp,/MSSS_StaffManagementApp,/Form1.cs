﻿using System;
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
            string filter = txtFilter.Text.Trim().ToLower();
            lstFilteredRecords.Items.Clear(); // Clear the ListBox before filtering

            // Check if the filter input is an integer
            if (int.TryParse(filter, out int idFilter))
            {
                // Filter by ID if the input is an integer
                var filteredById = MasterFile
                    .Where(x => x.Key == idFilter)
                    .ToList();

                foreach (var item in filteredById)
                {
                    lstFilteredRecords.Items.Add($"{item.Key}: {item.Value}");
                }

                lblStatus.Text = $"{filteredById.Count} record(s) found by ID.";
            }
            else
            {
                // Filter by Name if the input is not an integer
                var filteredByName = MasterFile
                    .Where(x => x.Value.ToLower().Contains(filter))
                    .ToList();

                foreach (var item in filteredByName)
                {
                    lstFilteredRecords.Items.Add($"{item.Key}: {item.Value}");
                }

                lblStatus.Text = $"{filteredByName.Count} record(s) found by Name.";
            }
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
          
			string id = txtFilterID.Text;
			string name = txtFilterName.Text;
			AdminForm adminForm = new AdminForm(int.Parse(id), name);
			adminForm.ShowDialog();
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

        private void lstFilteredRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lstFilteredRecords.SelectedItem != null)
            {
                string selectedItem = lstFilteredRecords.SelectedItem.ToString();
                var parts = selectedItem.Split(new[] { ':' }, 2);
                if (parts.Length == 2)
                {
                    
                    txtFilterID.Text = parts[0].Trim();
                    txtFilterName.Text = parts[1].Trim();                    
                }
                
            }
            
        }

       
    }
}
