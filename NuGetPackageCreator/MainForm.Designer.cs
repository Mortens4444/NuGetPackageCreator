namespace NuGetPackageCreator
{
	partial class MainForm
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
			this.pMain = new System.Windows.Forms.Panel();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.tbPcakageContent = new System.Windows.Forms.TextBox();
			this.lblPcakageContent = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.lblDescription = new System.Windows.Forms.Label();
			this.rtbPackageDescription = new System.Windows.Forms.RichTextBox();
			this.tbPackageId = new System.Windows.Forms.TextBox();
			this.lblPackageId = new System.Windows.Forms.Label();
			this.tbPackageVersion = new System.Windows.Forms.TextBox();
			this.lblPackageVersion = new System.Windows.Forms.Label();
			this.tbPackageName = new System.Windows.Forms.TextBox();
			this.lblPackageName = new System.Windows.Forms.Label();
			this.tbCreator = new System.Windows.Forms.TextBox();
			this.lblCreator = new System.Windows.Forms.Label();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.tbTags = new System.Windows.Forms.TextBox();
			this.lblTags = new System.Windows.Forms.Label();
			this.tbIconUrl = new System.Windows.Forms.TextBox();
			this.lblIconUrl = new System.Windows.Forms.Label();
			this.tbProjectUrl = new System.Windows.Forms.TextBox();
			this.lblProjectUrl = new System.Windows.Forms.Label();
			this.tbCopyright = new System.Windows.Forms.TextBox();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.pMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.tbTags);
			this.pMain.Controls.Add(this.lblTags);
			this.pMain.Controls.Add(this.tbIconUrl);
			this.pMain.Controls.Add(this.lblIconUrl);
			this.pMain.Controls.Add(this.tbProjectUrl);
			this.pMain.Controls.Add(this.lblProjectUrl);
			this.pMain.Controls.Add(this.tbCopyright);
			this.pMain.Controls.Add(this.lblCopyright);
			this.pMain.Controls.Add(this.btnBrowse);
			this.pMain.Controls.Add(this.tbPcakageContent);
			this.pMain.Controls.Add(this.lblPcakageContent);
			this.pMain.Controls.Add(this.btnCreate);
			this.pMain.Controls.Add(this.lblDescription);
			this.pMain.Controls.Add(this.rtbPackageDescription);
			this.pMain.Controls.Add(this.tbPackageId);
			this.pMain.Controls.Add(this.lblPackageId);
			this.pMain.Controls.Add(this.tbPackageVersion);
			this.pMain.Controls.Add(this.lblPackageVersion);
			this.pMain.Controls.Add(this.tbPackageName);
			this.pMain.Controls.Add(this.lblPackageName);
			this.pMain.Controls.Add(this.tbCreator);
			this.pMain.Controls.Add(this.lblCreator);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(383, 386);
			this.pMain.TabIndex = 0;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnBrowse.Location = new System.Drawing.Point(296, 319);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 12;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// tbPcakageContent
			// 
			this.tbPcakageContent.Location = new System.Drawing.Point(15, 321);
			this.tbPcakageContent.Name = "tbPcakageContent";
			this.tbPcakageContent.ReadOnly = true;
			this.tbPcakageContent.Size = new System.Drawing.Size(275, 20);
			this.tbPcakageContent.TabIndex = 11;
			// 
			// lblPcakageContent
			// 
			this.lblPcakageContent.AutoSize = true;
			this.lblPcakageContent.Location = new System.Drawing.Point(12, 305);
			this.lblPcakageContent.Name = "lblPcakageContent";
			this.lblPcakageContent.Size = new System.Drawing.Size(44, 13);
			this.lblPcakageContent.TabIndex = 10;
			this.lblPcakageContent.Text = "Content";
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCreate.Location = new System.Drawing.Point(295, 352);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 13;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(12, 165);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 8;
			this.lblDescription.Text = "Description";
			// 
			// rtbPackageDescription
			// 
			this.rtbPackageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbPackageDescription.Location = new System.Drawing.Point(15, 181);
			this.rtbPackageDescription.Name = "rtbPackageDescription";
			this.rtbPackageDescription.Size = new System.Drawing.Size(355, 125);
			this.rtbPackageDescription.TabIndex = 9;
			this.rtbPackageDescription.Text = "";
			// 
			// tbPackageId
			// 
			this.tbPackageId.Location = new System.Drawing.Point(15, 142);
			this.tbPackageId.Name = "tbPackageId";
			this.tbPackageId.ReadOnly = true;
			this.tbPackageId.Size = new System.Drawing.Size(175, 20);
			this.tbPackageId.TabIndex = 7;
			// 
			// lblPackageId
			// 
			this.lblPackageId.AutoSize = true;
			this.lblPackageId.Location = new System.Drawing.Point(12, 126);
			this.lblPackageId.Name = "lblPackageId";
			this.lblPackageId.Size = new System.Drawing.Size(16, 13);
			this.lblPackageId.TabIndex = 6;
			this.lblPackageId.Text = "Id";
			// 
			// tbPackageVersion
			// 
			this.tbPackageVersion.Location = new System.Drawing.Point(15, 103);
			this.tbPackageVersion.Name = "tbPackageVersion";
			this.tbPackageVersion.Size = new System.Drawing.Size(175, 20);
			this.tbPackageVersion.TabIndex = 5;
			// 
			// lblPackageVersion
			// 
			this.lblPackageVersion.AutoSize = true;
			this.lblPackageVersion.Location = new System.Drawing.Point(12, 87);
			this.lblPackageVersion.Name = "lblPackageVersion";
			this.lblPackageVersion.Size = new System.Drawing.Size(42, 13);
			this.lblPackageVersion.TabIndex = 4;
			this.lblPackageVersion.Text = "Version";
			// 
			// tbPackageName
			// 
			this.tbPackageName.Location = new System.Drawing.Point(15, 64);
			this.tbPackageName.Name = "tbPackageName";
			this.tbPackageName.Size = new System.Drawing.Size(175, 20);
			this.tbPackageName.TabIndex = 3;
			this.tbPackageName.TextChanged += new System.EventHandler(this.GeneratePackageId);
			// 
			// lblPackageName
			// 
			this.lblPackageName.AutoSize = true;
			this.lblPackageName.Location = new System.Drawing.Point(12, 48);
			this.lblPackageName.Name = "lblPackageName";
			this.lblPackageName.Size = new System.Drawing.Size(35, 13);
			this.lblPackageName.TabIndex = 2;
			this.lblPackageName.Text = "Name";
			// 
			// tbCreator
			// 
			this.tbCreator.Location = new System.Drawing.Point(15, 25);
			this.tbCreator.Name = "tbCreator";
			this.tbCreator.Size = new System.Drawing.Size(175, 20);
			this.tbCreator.TabIndex = 1;
			// 
			// lblCreator
			// 
			this.lblCreator.AutoSize = true;
			this.lblCreator.Location = new System.Drawing.Point(12, 9);
			this.lblCreator.Name = "lblCreator";
			this.lblCreator.Size = new System.Drawing.Size(41, 13);
			this.lblCreator.TabIndex = 0;
			this.lblCreator.Text = "Creator";
			// 
			// tbTags
			// 
			this.tbTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTags.Location = new System.Drawing.Point(196, 142);
			this.tbTags.Name = "tbTags";
			this.tbTags.Size = new System.Drawing.Size(174, 20);
			this.tbTags.TabIndex = 21;
			// 
			// lblTags
			// 
			this.lblTags.AutoSize = true;
			this.lblTags.Location = new System.Drawing.Point(193, 126);
			this.lblTags.Name = "lblTags";
			this.lblTags.Size = new System.Drawing.Size(31, 13);
			this.lblTags.TabIndex = 20;
			this.lblTags.Text = "Tags";
			// 
			// tbIconUrl
			// 
			this.tbIconUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbIconUrl.Location = new System.Drawing.Point(196, 103);
			this.tbIconUrl.Name = "tbIconUrl";
			this.tbIconUrl.Size = new System.Drawing.Size(174, 20);
			this.tbIconUrl.TabIndex = 19;
			// 
			// lblIconUrl
			// 
			this.lblIconUrl.AutoSize = true;
			this.lblIconUrl.Location = new System.Drawing.Point(193, 87);
			this.lblIconUrl.Name = "lblIconUrl";
			this.lblIconUrl.Size = new System.Drawing.Size(53, 13);
			this.lblIconUrl.TabIndex = 18;
			this.lblIconUrl.Text = "Icon URL";
			// 
			// tbProjectUrl
			// 
			this.tbProjectUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbProjectUrl.Location = new System.Drawing.Point(196, 64);
			this.tbProjectUrl.Name = "tbProjectUrl";
			this.tbProjectUrl.Size = new System.Drawing.Size(174, 20);
			this.tbProjectUrl.TabIndex = 17;
			// 
			// lblProjectUrl
			// 
			this.lblProjectUrl.AutoSize = true;
			this.lblProjectUrl.Location = new System.Drawing.Point(193, 48);
			this.lblProjectUrl.Name = "lblProjectUrl";
			this.lblProjectUrl.Size = new System.Drawing.Size(65, 13);
			this.lblProjectUrl.TabIndex = 16;
			this.lblProjectUrl.Text = "Project URL";
			// 
			// tbCopyright
			// 
			this.tbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCopyright.Location = new System.Drawing.Point(196, 25);
			this.tbCopyright.Name = "tbCopyright";
			this.tbCopyright.Size = new System.Drawing.Size(175, 20);
			this.tbCopyright.TabIndex = 15;
			// 
			// lblCopyright
			// 
			this.lblCopyright.AutoSize = true;
			this.lblCopyright.Location = new System.Drawing.Point(193, 9);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(51, 13);
			this.lblCopyright.TabIndex = 14;
			this.lblCopyright.Text = "Copyright";
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnCreate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 386);
			this.Controls.Add(this.pMain);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NuGet Package Creator";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Label lblCreator;
		private System.Windows.Forms.TextBox tbCreator;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.RichTextBox rtbPackageDescription;
		private System.Windows.Forms.TextBox tbPackageId;
		private System.Windows.Forms.Label lblPackageId;
		private System.Windows.Forms.TextBox tbPackageVersion;
		private System.Windows.Forms.Label lblPackageVersion;
		private System.Windows.Forms.TextBox tbPackageName;
		private System.Windows.Forms.Label lblPackageName;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox tbPcakageContent;
		private System.Windows.Forms.Label lblPcakageContent;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.TextBox tbTags;
		private System.Windows.Forms.Label lblTags;
		private System.Windows.Forms.TextBox tbIconUrl;
		private System.Windows.Forms.Label lblIconUrl;
		private System.Windows.Forms.TextBox tbProjectUrl;
		private System.Windows.Forms.Label lblProjectUrl;
		private System.Windows.Forms.TextBox tbCopyright;
		private System.Windows.Forms.Label lblCopyright;
	}
}

