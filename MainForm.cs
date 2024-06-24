using System.Xml.Linq;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace FileSplitter
{
	public partial class MainForm : Form
	{
		long partsOrTargetSize = 0;
		string filePath;

		List<KeyValuePair<string, int>> fileSizeSufixList = new();

		Logger log;
		TextFileSplitter textFileSplitter;
		public MainForm()
		{
			InitializeComponent();

			// We assign what sufix coresponds to whitch conversion ratio
			fileSizeSufixList.Add(new("B", 1));
			fileSizeSufixList.Add(new("KB", 1024));
			fileSizeSufixList.Add(new("MB", 1_048_576));
			fileSizeSufixList.Add(new("GB", 1_073_741_824));

			// We assign the sufixes in the list to the Combo Box
			fileSufixComboBox.DataSource = fileSizeSufixList.ConvertAll((x) => { return x.Key; });
			fileSufixComboBox.SelectedIndex = 2;


			log = new(this.LogTextBox);
			textFileSplitter = new(log);

		}

		// Opens the file selection dialog and saves the selected filepath
		private void openFilebtn_Click(object sender, EventArgs e)
		{
			var dialResult = oFD.ShowDialog();

			if (dialResult == DialogResult.OK)
			{
				filePath = oFD.FileName;
				filePathTextBox.Text = filePath;
			}
		}

		// Enable the "Split" button only if there is a selected file
		private void filePathTextBox_TextChanged(object sender, EventArgs e)
		{
			if (filePathTextBox.Text == "") splitBtn.Enabled = false;
			else splitBtn.Enabled = true;
		}

		private void splitBtn_Click(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				partsOrTargetSize = (long)numericSizeOrParts.Value;
				textFileSplitter.Split(filePath, partsOrTargetSize, true);
			}
			else
			{
				partsOrTargetSize = GetTargetSize();
				textFileSplitter.Split(filePath, partsOrTargetSize);
			}
		}

		// Converts value provided in the numericUpDown and the drop down into the target number of bytes we want the file approximately to be
		private long GetTargetSize()
		{
			return ((long)numericSizeOrParts.Value) * fileSizeSufixList[fileSufixComboBox.SelectedIndex].Value;

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				labelSizeorParts.Text = "Number of Parts: ";
				fileSufixComboBox.Visible = false;
			}

			else
			{

				labelSizeorParts.Text = "Target Size: ";
				fileSufixComboBox.Visible = true;
			}

		}
	}
}
