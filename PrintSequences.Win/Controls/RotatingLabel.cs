using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PrintSequences.Win.Controls
{
	public class RotatingLabel : Label
	{
		private double _rotationAngle;
		private string _text;
		private Orientation _textOrientation;
		private TextDirection _textTextDirection;

		public RotatingLabel()
		{
			_rotationAngle = 0d;
			_textOrientation = Orientation.Rotate;
			Size = new Size(105, 12);
		}

		[Description("Rotation Angle"), Category("Appearance")]
		public double RotationAngle
		{
			get { return _rotationAngle; }
			set
			{
				_rotationAngle = value;
				Invalidate();
			}
		}

		[Description("Kind of Text Orientation"), Category("Appearance")]
		public Orientation TextOrientation
		{
			get { return _textOrientation; }
			set
			{
				_textOrientation = value;
				Invalidate();
			}
		}

		[Description("Direction of the Text"), Category("Appearance")]
		public TextDirection TextTextDirection
		{
			get { return _textTextDirection; }
			set
			{
				_textTextDirection = value;
				Invalidate();
			}
		}

		[Description("Display Text"), Category("Appearance")]
		public override string Text
		{
			get { return _text; }
			set
			{
				_text = value;
				Invalidate();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			var graphics = e.Graphics;

			Brush textBrush = new SolidBrush(ForeColor);

			var width = graphics.MeasureString(_text, Font).Width;
			var height = graphics.MeasureString(_text, Font).Height;

			var angle = _rotationAngle / 180 * Math.PI;
			graphics.TranslateTransform(
				(ClientRectangle.Width + (float)(height * Math.Sin(angle)) - (float)(width * Math.Cos(angle))) / 2,
				(ClientRectangle.Height - (float)(height * Math.Cos(angle)) - (float)(width * Math.Sin(angle))) / 2);
			graphics.RotateTransform((float)_rotationAngle);
			graphics.DrawString(_text, Font, textBrush, 0, 0);
			graphics.ResetTransform();
		}
	}
}