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

		private void loadButton_Click(object sender, EventArgs e)
		{
			string[] lines = File.ReadAllLines("staff_data.csv");  // CSV file path
			foreach (string line in lines)
			{
				lstAllRecords.Items.Add(line);
			}
			lblStatus.Text = $"{lines.Length} records loaded.";
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			string searchTerm = txtFilter.Text.ToLower();
			var filteredRecords = lstAllRecords.Items.Cast<string>()
				.Where(record => record.ToLower().Contains(searchTerm)).ToList();

			lstFilteredRecords.Items.Clear();
			foreach (var record in filteredRecords)
			{
				lstFilteredRecords.Items.Add(record);
			}

			lblStatus.Text = $"{filteredRecords.Count} records found.";
		}
	}
}
