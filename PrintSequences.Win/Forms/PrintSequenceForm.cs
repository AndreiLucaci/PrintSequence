using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintSequences.Win.Forms
{
	public partial class PrintSequenceForm : Form
	{
		public PrintSequenceForm()
		{
			InitializeComponent();
			pagesPerPage.SelectedIndex = 0;
		}

		private void RichTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			var richTextBox = sender as RichTextBox;
			richTextBox?.SelectAll();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Task.Factory.StartNew(ProcessPageSequences, TaskCreationOptions.AttachedToParent
			                                            | TaskCreationOptions.LongRunning);
		}

		private void ProcessPageSequences()
		{
			throw new NotImplementedException();
		}

		private void pagesPerPage_SelectedIndexChanged(object sender, EventArgs e)
		{
			totalPages.Increment = totalPages.Value = totalPages.Minimum = Convert.ToInt32(pagesPerPage.Text)*2;
		}
	}
}
