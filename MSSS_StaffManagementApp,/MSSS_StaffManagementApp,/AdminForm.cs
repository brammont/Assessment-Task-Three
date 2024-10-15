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
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
			loadData();
			
		}
		private List<Staff> staffRecords = new List<Staff>();
		private void loadData()
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
				}
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
		public void CloseForm()
		{
			this.Close();
		}
		private void btnOpenMain_Click(object sender, EventArgs e)
		{
			this.Close();


		}
	}
}
