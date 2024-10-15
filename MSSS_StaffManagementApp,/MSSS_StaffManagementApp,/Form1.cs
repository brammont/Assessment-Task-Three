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
		public Form1()
		{
			InitializeComponent();
		}
		private List<Staff> staffRecords = new List<Staff>();
		private void loadButton_Click(object sender, EventArgs e)
		{
			string[] lines = File.ReadAllLines("staff_data.csv");

			staffRecords.Clear();  // Clear any existing records
			foreach (string line in lines)
			{
				string[] parts = line.Split(',');
				if (parts.Length == 2)
				{
					string id = parts[0];
					string name = parts[1];
					staffRecords.Add(new Staff { ID = id, Name = name });

					lstAllRecords.Items.Add($"ID: {id} - Name: {name}"); ;
				}
			}

			lblStatus.Text = $"{staffRecords.Count} records loaded.";
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

		private void btnOpenAdmin_Click(object sender, EventArgs e)
		{
			AdminForm adminForm = new AdminForm();
			adminForm.Show();
		}
	}
}
