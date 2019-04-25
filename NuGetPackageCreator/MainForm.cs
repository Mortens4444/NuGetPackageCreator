using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NuGetPackageCreator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			tbCreator.Text = ConfigurationManager.AppSettings["Creator"];
			tbPackageName.Text = ConfigurationManager.AppSettings["PackageName"];
			tbPackageVersion.Text = ConfigurationManager.AppSettings["PackageVersion"];
			tbCopyright.Text = ConfigurationManager.AppSettings["Copyright"];
			tbProjectUrl.Text = ConfigurationManager.AppSettings["ProjectUrl"];
			tbIconUrl.Text = ConfigurationManager.AppSettings["IconUrl"];
			tbTags.Text = ConfigurationManager.AppSettings["Tags"];
			rtbPackageDescription.Text = ConfigurationManager.AppSettings["Description"];
		}

		private void GeneratePackageId(object sender, EventArgs e)
		{
			tbPackageId.Text = tbPackageName.Text.Replace(' ', '.');
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			tbPackageName.Focus();
		}

		private void BtnBrowse_Click(object sender, EventArgs e)
		{
			Browse();
		}

		private void Browse()
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				tbPcakageContent.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			while (tbPcakageContent.Text == String.Empty)
			{
				MessageBox.Show("Select a folder to pack into the NuGet Package", "No content", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				Browse();
			}

			var nsStr = "http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd";
			XNamespace ns = nsStr;
			var package = new XElement(ns + "package",
				new XAttribute("xmlns", ns),
				new XElement(ns + "metadata",
					new XElement(ns + "id", tbPackageId.Text),
					new XElement(ns + "version", tbPackageVersion.Text),
					new XElement(ns + "description", rtbPackageDescription.Text),
					new XElement(ns + "authors", tbCreator.Text),
					new XElement(ns + "copyright", tbCopyright.Text),
					new XElement(ns + "projectUrl", tbProjectUrl.Text)
				),
				new XElement(ns + "files",
					new XElement(ns + "file",
						new XAttribute("src", String.Concat(tbPcakageContent.Text, "\\**")),
						new XAttribute("target", "content")
					)
				)
			);

			var nuspecFile = Path.Combine(Application.StartupPath, ".nuspec");
			if (File.Exists(nuspecFile))
			{
				File.Delete(nuspecFile);
			}
			package.Save(nuspecFile, SaveOptions.None);

			var ps = Process.Start(new ProcessStartInfo
			{
				FileName = "nuget",
				Arguments = "pack .nuspec",
				RedirectStandardError = true,
				RedirectStandardOutput = true,
				UseShellExecute = false
			});

			var output = ps.StandardOutput.ReadToEnd();
			var error = ps.StandardError.ReadToEnd();
			var resultForm = new ResultForm(output, error);
			resultForm.Show();
		}
	}
}
