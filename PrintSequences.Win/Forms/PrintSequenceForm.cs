using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintSequences.Win
{
	public partial class PrintSequenceForm : Form
	{
		public PrintSequenceForm()
		{
			InitializeComponent();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void RichTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			var richTextBox = sender as RichTextBox;
			richTextBox?.SelectAll();
		}
	}
}
