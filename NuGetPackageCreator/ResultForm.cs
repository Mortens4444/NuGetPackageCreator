using System;
using System.Drawing;
using System.Windows.Forms;

namespace NuGetPackageCreator
{
	public partial class ResultForm : Form
	{
		public ResultForm(string output, string error)
		{
			InitializeComponent();

			rtbResult.Text = output;
			rtbResult.Text += Environment.NewLine;

			rtbResult.SelectionStart = rtbResult.TextLength;
			rtbResult.SelectionLength = 0;

			rtbResult.SelectionColor = Color.Red;
			rtbResult.AppendText(error);
		}
	}
}
