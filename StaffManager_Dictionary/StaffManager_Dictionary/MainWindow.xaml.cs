using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StaffManager_Dictionary
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		// Static and public dictionary
		public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();

		public MainWindow()
		{
			InitializeComponent();
			LoadDataFromCsv();
			DisplayData();
			// Attach the PreviewKeyDown event programmatically
			this.PreviewKeyDown += new KeyEventHandler(MainWindow_PreviewKeyDown);


		}
		// Method to load data from CSV into Dictionary 
		private void LoadDataFromCsv()
		{
			try
			{
				using (var reader = new StreamReader("staff_data.csv"))
				{
					while (!reader.EndOfStream)
					{
						var line = reader.ReadLine();
						var values = line.Split(',');

						if (int.TryParse(values[0], out int id) && !MasterFile.ContainsKey(id))
						{
							MasterFile.Add(id, values[1]);
						}
					}
				}
				StatusText.Text = "Data loaded successfully.";
			}
			catch (Exception ex)
			{
				StatusText.Text = $"Error loading data: {ex.Message}";
			}
		}
		// Method to display Dictionary data in ListBox1
		private void DisplayData()
		{
			ListBox1.Items.Clear();
			foreach (var item in MasterFile)
			{
				ListBox1.Items.Add($"{item.Key}: {item.Value}");
			}
		}
		// Method to filter by Staff Name
		private void TxtFilterName_TextChanged(object sender, TextChangedEventArgs e)
		{
			string filter = TxtFilterName.Text.ToLower();
			ListBox2.Items.Clear();
			var filteredData = MasterFile.Where(item => item.Value.ToLower().Contains(filter));

			ListBox2.Items.Clear();
			foreach (var item in filteredData)
			{
				ListBox2.Items.Add($"{item.Key}: {item.Value}");
			}
		}
		// Method to filter by Staff ID
		private void TxtFilterID_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (int.TryParse(TxtFilterID.Text, out int idFilter))
			{
				var filteredData = MasterFile.Where(item => item.Key.ToString().Contains(idFilter.ToString()));

				ListBox2.Items.Clear();
				foreach (var item in filteredData)
				{
					ListBox2.Items.Add($"{item.Key}: {item.Value}");
				}
			}
		}
		// Method to clear and focus on Staff Name textbox
		private void ClearAndFocusNameBox()
		{
			TxtFilterName.Clear();
			TxtFilterName.Focus();
			ListBox2.Items.Clear();
		}

		// Method to clear and focus on Staff ID textbox
		private void ClearAndFocusIDBox()
		{
			TxtFilterID.Clear();
			TxtFilterID.Focus();
			ListBox2.Items.Clear();
		}
		//Clears the Staff Name filter text box and sets focus. (Alt + N shortcut)
		private void ClearNameFilter_Click(object sender, RoutedEventArgs e)
		{
			ClearAndFocusNameBox();
		}
		// Clears the Staff ID filter text box and sets focus. (Alt + I shortcut)
		private void ClearIDFilter_Click(object sender, RoutedEventArgs e)
		{
			ClearAndFocusIDBox();
		}
		// select a record
		private void ListBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ListBox2.SelectedItem != null)
			{
				var selected = ListBox2.SelectedItem.ToString();
				var parts = selected.Split(':');
				if (parts.Length == 2)
				{
					TxtFilterID.Text = parts[0].Trim();
					TxtFilterName.Text = parts[1].Trim();
				}
			}
		}
		//Open Admin
		private void OpenAdminForm()
		{
			//int.TryParse(TxtFilterID.Text, out int staffId);
			//string staffName = TxtFilterName.Text;
			// Check for Staff ID 77 with empty Staff Name to open in Create mode
			//bool isCreateMode = staffId == 77 && string.IsNullOrWhiteSpace(staffName);
			ListBox1.Items.Clear();
			//ListBox2.Items.Add(isCreateMode);
			//AdminWindow adminWindow = new AdminWindow();
			//adminWindow.Owner = this;

			//adminWindow.ShowDialog(); // Open as modal

		}
		// Keyboard shortcut handler for clearing filter textboxes and opening admin form
		private void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			// Ctrl + N to clear and focus Staff Name
			if (e.Key == Key.N && Keyboard.Modifiers == ModifierKeys.Control)
			{
				ClearAndFocusNameBox();
				e.Handled = true; // Mark event as handled
			}
			// Ctrl + I to clear and focus Staff ID
			else if (e.Key == Key.I && Keyboard.Modifiers == ModifierKeys.Control)
			{
				ClearAndFocusIDBox();
				e.Handled = true;
			}
			// Alt + A to open Admin form
			else if (e.Key == Key.A && Keyboard.Modifiers == ModifierKeys.Alt)
			{
				OpenAdminForm();
				e.Handled = true;
			}
		}		
	}
}