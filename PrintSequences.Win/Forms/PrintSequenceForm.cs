using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintSequences.Engine;

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
			var pages = Convert.ToInt32(pagesPerPage.Text);
			var total = (int) totalPages.Value;
			Task.Factory.StartNew(() => ProcessPageSequences(pages, total),
				TaskCreationOptions.AttachedToParent
				| TaskCreationOptions.LongRunning);
		}

		private void ProcessPageSequences(int pages, int total)
		{
			var engine = new PrintSequencesEngine(pages, total);
			var oddSequence = engine.ComputeOddPrintSequence();
			var evenSequence = engine.ComputeEvenPrintSequence();

			SetRichTextBoxValue(oddSelectionRichTextBox, string.Join(",", oddSequence.Values));
			SetRichTextBoxValue(evenSelectionRichTextBox, string.Join(",", evenSequence.Values));
		}

		private void SetRichTextBoxValue(RichTextBox richTextBox, string value)
		{
			richTextBox.Invoke(new Action(() => richTextBox.Text = value));
		}

		private void pagesPerPage_SelectedIndexChanged(object sender, EventArgs e)
		{
			totalPages.Increment = totalPages.Value = totalPages.Minimum = Convert.ToInt32(pagesPerPage.Text)*2;
		}
	}
}
