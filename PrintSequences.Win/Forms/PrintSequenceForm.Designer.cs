namespace PrintSequences.Win
{
	partial class PrintSequenceForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.evenSelectionRichTextBox = new System.Windows.Forms.RichTextBox();
			this.oddSelectionRichTextBox = new System.Windows.Forms.RichTextBox();
			this.rotatingLabel2 = new PrintSequences.Win.Controls.RotatingLabel();
			this.rotatingLabel1 = new PrintSequences.Win.Controls.RotatingLabel();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(141, 12);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(141, 38);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(77, 20);
			this.numericUpDown2.TabIndex = 1;
			this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Pages per page";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Total number of pages";
			// 
			// evenSelectionRichTextBox
			// 
			this.evenSelectionRichTextBox.Location = new System.Drawing.Point(51, 160);
			this.evenSelectionRichTextBox.Name = "evenSelectionRichTextBox";
			this.evenSelectionRichTextBox.ReadOnly = true;
			this.evenSelectionRichTextBox.Size = new System.Drawing.Size(221, 90);
			this.evenSelectionRichTextBox.TabIndex = 4;
			this.evenSelectionRichTextBox.Text = "";
			this.evenSelectionRichTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseClick);
			// 
			// oddSelectionRichTextBox
			// 
			this.oddSelectionRichTextBox.Location = new System.Drawing.Point(51, 64);
			this.oddSelectionRichTextBox.Name = "oddSelectionRichTextBox";
			this.oddSelectionRichTextBox.ReadOnly = true;
			this.oddSelectionRichTextBox.Size = new System.Drawing.Size(221, 90);
			this.oddSelectionRichTextBox.TabIndex = 5;
			this.oddSelectionRichTextBox.Text = "";
			this.oddSelectionRichTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseClick);
			// 
			// rotatingLabel2
			// 
			this.rotatingLabel2.Location = new System.Drawing.Point(12, 64);
			this.rotatingLabel2.Name = "rotatingLabel2";
			this.rotatingLabel2.RotationAngle = 270D;
			this.rotatingLabel2.Size = new System.Drawing.Size(24, 90);
			this.rotatingLabel2.TabIndex = 7;
			this.rotatingLabel2.Text = "Odd sequence";
			this.rotatingLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rotatingLabel2.TextDirection = PrintSequences.Win.Controls.Direction.AntiClockwise;
			this.rotatingLabel2.TextOrientation = PrintSequences.Win.Controls.Orientation.Rotate;
			// 
			// rotatingLabel1
			// 
			this.rotatingLabel1.Location = new System.Drawing.Point(12, 160);
			this.rotatingLabel1.Name = "rotatingLabel1";
			this.rotatingLabel1.RotationAngle = 270D;
			this.rotatingLabel1.Size = new System.Drawing.Size(24, 90);
			this.rotatingLabel1.TabIndex = 6;
			this.rotatingLabel1.Text = "Even sequence";
			this.rotatingLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rotatingLabel1.TextDirection = PrintSequences.Win.Controls.Direction.AntiClockwise;
			this.rotatingLabel1.TextOrientation = PrintSequences.Win.Controls.Orientation.Rotate;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(224, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 46);
			this.button1.TabIndex = 8;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// PrintSequenceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rotatingLabel2);
			this.Controls.Add(this.rotatingLabel1);
			this.Controls.Add(this.oddSelectionRichTextBox);
			this.Controls.Add(this.evenSelectionRichTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Name = "PrintSequenceForm";
			this.Text = "PrintSequence";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox evenSelectionRichTextBox;
		private System.Windows.Forms.RichTextBox oddSelectionRichTextBox;
		private Controls.RotatingLabel rotatingLabel1;
		private Controls.RotatingLabel rotatingLabel2;
		private System.Windows.Forms.Button button1;
	}
}

