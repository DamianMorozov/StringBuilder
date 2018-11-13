using System;
using System.IO;
using System.Windows.Forms;

namespace StringBuilder
{
	public partial class Form1 : Form
    {
		public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			// windir
			textBoxFolder.Text = Environment.GetEnvironmentVariable("userprofile");  
		}

		private bool PrepareGui()
        {
            richTextBoxOut.Clear();

			Utils.Dir = textBoxFolder.Text;
			if (!Directory.Exists(Utils.Dir))
			{
				richTextBoxOut.AppendText(@"Error folder path!" + Environment.NewLine);
				return false;
			}
			Utils.DirInfo = new DirectoryInfo(Utils.Dir);

			return true;
		}

		private void PrintResults()
		{
			richTextBoxOut.AppendText(@"Count of dirs: " + Convert.ToString(Utils.CountDirs) + Environment.NewLine);
			richTextBoxOut.AppendText(@"Count of files: " + Convert.ToString(Utils.CountFiles) + Environment.NewLine);
			richTextBoxOut.AppendText(@"Count of find files: " + Convert.ToString(Utils.CountFilesFind) + Environment.NewLine);
			richTextBoxOut.AppendText(@"Execute timeout: " + Convert.ToString(DateTime.Now - Utils.DtStart) + Environment.NewLine);
		}

		private void buttonChangeFolder_Click(object sender, EventArgs e)
		{
			using (var folderBrowserDialog = new FolderBrowserDialog() { })
			{
				DialogResult dialogResult = folderBrowserDialog.ShowDialog();
				if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
				{
					textBoxFolder.Text = folderBrowserDialog.SelectedPath;
				}
			}
		}

		private void buttonString_Click(object sender, EventArgs e)
		{
			if (!PrepareGui())
				return;

			var core = new ClassCore<string>(
				ref richTextBoxOut,
				checkBoxUseIncludeFolders.Checked, checkBoxCountNames.Checked, textBoxFindName.Text);

			PrintResults();
		}

		private void buttonStringBuilder_Click(object sender, EventArgs e)
		{
			if (!PrepareGui())
				return;

			var core = new ClassCore<System.Text.StringBuilder>(
				ref richTextBoxOut,
				checkBoxUseIncludeFolders.Checked, checkBoxCountNames.Checked, textBoxFindName.Text);

			PrintResults();
		}

		private void buttonWithCollection_Click(object sender, EventArgs e)
		{
			if (!PrepareGui())
				return;

			var core = new ClassCore<System.Collections.ObjectModel.Collection<string>>(
				ref richTextBoxOut,
				checkBoxUseIncludeFolders.Checked, checkBoxCountNames.Checked, textBoxFindName.Text);

			PrintResults();
		}

	}
}
