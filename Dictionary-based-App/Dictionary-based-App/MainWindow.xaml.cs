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

namespace Dictionary_based_App
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();

		public MainWindow()
		{
			InitializeComponent();
		}
		private void btnLoadData_Click(object sender, RoutedEventArgs e)
		{
			LoadDataFromCSV("MalinStaffNamesV3.csv");
			DisplayAllRecords();
		}

		private void LoadDataFromCSV(string filePath)
		{
			try
			{
				var lines = System.IO.File.ReadAllLines(filePath);
				foreach (var line in lines)
				{
					var parts = line.Split(',');
					int id = int.Parse(parts[0]);
					string name = parts[1];
					MasterFile[id] = name;
				}
				lblRecordCount.Content = $"Displaying {MasterFile.Count} records.";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading data: " + ex.Message);
			}
		}
		private void DisplayAllRecords()
		{
			lstAllRecords.Items.Clear();
			foreach (var entry in MasterFile)
			{
				lstAllRecords.Items.Add($"{entry.Key} - {entry.Value}");
			}
		}
	}
}