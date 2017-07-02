namespace lss_reader
{
	partial class Form1
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
			this.lbLssFile = new System.Windows.Forms.ListBox();
			this.rtbText = new System.Windows.Forms.RichTextBox();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.tbFileName = new System.Windows.Forms.TextBox();
			this.pbProgress = new System.Windows.Forms.ProgressBar();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.tbStringLine = new System.Windows.Forms.TextBox();
			this.tbTag = new System.Windows.Forms.TextBox();
			this.tbMemory = new System.Windows.Forms.TextBox();
			this.tbInstruction = new System.Windows.Forms.TextBox();
			this.tbParameter = new System.Windows.Forms.TextBox();
			this.tbComment = new System.Windows.Forms.TextBox();
			this.tbHexInstruction = new System.Windows.Forms.TextBox();
			this.lbParameter = new System.Windows.Forms.Label();
			this.lbInst = new System.Windows.Forms.Label();
			this.lbHexInst = new System.Windows.Forms.Label();
			this.lbStringLine = new System.Windows.Forms.Label();
			this.lbComment = new System.Windows.Forms.Label();
			this.lbMemory = new System.Windows.Forms.Label();
			this.lbTag = new System.Windows.Forms.Label();
			this.gbElement = new System.Windows.Forms.GroupBox();
			this.lbComponents = new System.Windows.Forms.ListBox();
			this.cbComment = new System.Windows.Forms.CheckBox();
			this.gbElement.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbLssFile
			// 
			this.lbLssFile.FormattingEnabled = true;
			this.lbLssFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbLssFile.ItemHeight = 15;
			this.lbLssFile.Location = new System.Drawing.Point(400, 37);
			this.lbLssFile.Name = "lbLssFile";
			this.lbLssFile.Size = new System.Drawing.Size(265, 199);
			this.lbLssFile.TabIndex = 0;
			this.lbLssFile.SelectedIndexChanged += new System.EventHandler(this.lbLssFile_SelectedIndexChanged);
			// 
			// rtbText
			// 
			this.rtbText.Font = new System.Drawing.Font("Gulim", 7F);
			this.rtbText.Location = new System.Drawing.Point(12, 37);
			this.rtbText.Name = "rtbText";
			this.rtbText.ReadOnly = true;
			this.rtbText.Size = new System.Drawing.Size(382, 304);
			this.rtbText.TabIndex = 1;
			this.rtbText.Text = "";
			this.rtbText.WordWrap = false;
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(319, 8);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 26);
			this.btnOpenFile.TabIndex = 2;
			this.btnOpenFile.Text = "Open";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// tbFileName
			// 
			this.tbFileName.Location = new System.Drawing.Point(12, 9);
			this.tbFileName.Name = "tbFileName";
			this.tbFileName.ReadOnly = true;
			this.tbFileName.Size = new System.Drawing.Size(301, 25);
			this.tbFileName.TabIndex = 3;
			this.tbFileName.Text = " No File Selected";
			// 
			// pbProgress
			// 
			this.pbProgress.Location = new System.Drawing.Point(12, 9);
			this.pbProgress.Name = "pbProgress";
			this.pbProgress.Size = new System.Drawing.Size(301, 25);
			this.pbProgress.Step = 1;
			this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pbProgress.TabIndex = 4;
			this.pbProgress.Visible = false;
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(400, 8);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(165, 25);
			this.tbSearch.TabIndex = 5;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			// 
			// tbStringLine
			// 
			this.tbStringLine.Location = new System.Drawing.Point(108, 28);
			this.tbStringLine.Name = "tbStringLine";
			this.tbStringLine.ReadOnly = true;
			this.tbStringLine.Size = new System.Drawing.Size(519, 25);
			this.tbStringLine.TabIndex = 6;
			// 
			// tbTag
			// 
			this.tbTag.Location = new System.Drawing.Point(94, 108);
			this.tbTag.Name = "tbTag";
			this.tbTag.ReadOnly = true;
			this.tbTag.Size = new System.Drawing.Size(100, 25);
			this.tbTag.TabIndex = 7;
			// 
			// tbMemory
			// 
			this.tbMemory.Location = new System.Drawing.Point(94, 68);
			this.tbMemory.Name = "tbMemory";
			this.tbMemory.ReadOnly = true;
			this.tbMemory.Size = new System.Drawing.Size(100, 25);
			this.tbMemory.TabIndex = 8;
			// 
			// tbInstruction
			// 
			this.tbInstruction.Location = new System.Drawing.Point(297, 68);
			this.tbInstruction.Name = "tbInstruction";
			this.tbInstruction.ReadOnly = true;
			this.tbInstruction.Size = new System.Drawing.Size(100, 25);
			this.tbInstruction.TabIndex = 9;
			// 
			// tbParameter
			// 
			this.tbParameter.Location = new System.Drawing.Point(297, 108);
			this.tbParameter.Name = "tbParameter";
			this.tbParameter.ReadOnly = true;
			this.tbParameter.Size = new System.Drawing.Size(100, 25);
			this.tbParameter.TabIndex = 10;
			// 
			// tbComment
			// 
			this.tbComment.Location = new System.Drawing.Point(527, 108);
			this.tbComment.Name = "tbComment";
			this.tbComment.ReadOnly = true;
			this.tbComment.Size = new System.Drawing.Size(100, 25);
			this.tbComment.TabIndex = 11;
			// 
			// tbHexInstruction
			// 
			this.tbHexInstruction.Location = new System.Drawing.Point(527, 68);
			this.tbHexInstruction.Name = "tbHexInstruction";
			this.tbHexInstruction.ReadOnly = true;
			this.tbHexInstruction.Size = new System.Drawing.Size(100, 25);
			this.tbHexInstruction.TabIndex = 12;
			// 
			// lbParameter
			// 
			this.lbParameter.AutoSize = true;
			this.lbParameter.Location = new System.Drawing.Point(217, 115);
			this.lbParameter.Name = "lbParameter";
			this.lbParameter.Size = new System.Drawing.Size(72, 15);
			this.lbParameter.TabIndex = 13;
			this.lbParameter.Text = "Parameter";
			// 
			// lbInst
			// 
			this.lbInst.AutoSize = true;
			this.lbInst.Location = new System.Drawing.Point(217, 71);
			this.lbInst.Name = "lbInst";
			this.lbInst.Size = new System.Drawing.Size(74, 15);
			this.lbInst.TabIndex = 14;
			this.lbInst.Text = "Instruction";
			// 
			// lbHexInst
			// 
			this.lbHexInst.AutoSize = true;
			this.lbHexInst.Location = new System.Drawing.Point(415, 71);
			this.lbHexInst.Name = "lbHexInst";
			this.lbHexInst.Size = new System.Drawing.Size(106, 15);
			this.lbHexInst.TabIndex = 15;
			this.lbHexInst.Text = "Hex Instruction";
			// 
			// lbStringLine
			// 
			this.lbStringLine.AutoSize = true;
			this.lbStringLine.Location = new System.Drawing.Point(26, 31);
			this.lbStringLine.Name = "lbStringLine";
			this.lbStringLine.Size = new System.Drawing.Size(76, 15);
			this.lbStringLine.TabIndex = 16;
			this.lbStringLine.Text = "String Line";
			// 
			// lbComment
			// 
			this.lbComment.AutoSize = true;
			this.lbComment.Location = new System.Drawing.Point(444, 115);
			this.lbComment.Name = "lbComment";
			this.lbComment.Size = new System.Drawing.Size(68, 15);
			this.lbComment.TabIndex = 17;
			this.lbComment.Text = "Comment";
			// 
			// lbMemory
			// 
			this.lbMemory.AutoSize = true;
			this.lbMemory.Location = new System.Drawing.Point(26, 71);
			this.lbMemory.Name = "lbMemory";
			this.lbMemory.Size = new System.Drawing.Size(59, 15);
			this.lbMemory.TabIndex = 18;
			this.lbMemory.Text = "Memory";
			// 
			// lbTag
			// 
			this.lbTag.AutoSize = true;
			this.lbTag.Location = new System.Drawing.Point(26, 115);
			this.lbTag.Name = "lbTag";
			this.lbTag.Size = new System.Drawing.Size(31, 15);
			this.lbTag.TabIndex = 19;
			this.lbTag.Text = "Tag";
			// 
			// gbElement
			// 
			this.gbElement.Controls.Add(this.lbStringLine);
			this.gbElement.Controls.Add(this.lbMemory);
			this.gbElement.Controls.Add(this.lbTag);
			this.gbElement.Controls.Add(this.tbStringLine);
			this.gbElement.Controls.Add(this.tbTag);
			this.gbElement.Controls.Add(this.lbInst);
			this.gbElement.Controls.Add(this.lbHexInst);
			this.gbElement.Controls.Add(this.lbParameter);
			this.gbElement.Controls.Add(this.lbComment);
			this.gbElement.Controls.Add(this.tbMemory);
			this.gbElement.Controls.Add(this.tbParameter);
			this.gbElement.Controls.Add(this.tbInstruction);
			this.gbElement.Controls.Add(this.tbHexInstruction);
			this.gbElement.Controls.Add(this.tbComment);
			this.gbElement.Location = new System.Drawing.Point(12, 347);
			this.gbElement.Name = "gbElement";
			this.gbElement.Size = new System.Drawing.Size(653, 146);
			this.gbElement.TabIndex = 20;
			this.gbElement.TabStop = false;
			this.gbElement.Text = "Element";
			// 
			// lbComponents
			// 
			this.lbComponents.FormattingEnabled = true;
			this.lbComponents.ItemHeight = 15;
			this.lbComponents.Location = new System.Drawing.Point(400, 247);
			this.lbComponents.Name = "lbComponents";
			this.lbComponents.Size = new System.Drawing.Size(265, 94);
			this.lbComponents.TabIndex = 21;
			this.lbComponents.SelectedIndexChanged += new System.EventHandler(this.lbComponents_SelectedIndexChanged);
			// 
			// cbComment
			// 
			this.cbComment.AutoSize = true;
			this.cbComment.Location = new System.Drawing.Point(571, 12);
			this.cbComment.Name = "cbComment";
			this.cbComment.Size = new System.Drawing.Size(94, 19);
			this.cbComment.TabIndex = 22;
			this.cbComment.Text = "주석 포함";
			this.cbComment.UseVisualStyleBackColor = true;
			this.cbComment.CheckedChanged += new System.EventHandler(this.cbComment_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 506);
			this.Controls.Add(this.cbComment);
			this.Controls.Add(this.lbComponents);
			this.Controls.Add(this.gbElement);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.pbProgress);
			this.Controls.Add(this.tbFileName);
			this.Controls.Add(this.btnOpenFile);
			this.Controls.Add(this.rtbText);
			this.Controls.Add(this.lbLssFile);
			this.Name = "Form1";
			this.Text = "lss reader";
			this.gbElement.ResumeLayout(false);
			this.gbElement.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbLssFile;
		private System.Windows.Forms.RichTextBox rtbText;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.TextBox tbFileName;
		private System.Windows.Forms.ProgressBar pbProgress;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.TextBox tbStringLine;
		private System.Windows.Forms.TextBox tbTag;
		private System.Windows.Forms.TextBox tbMemory;
		private System.Windows.Forms.TextBox tbInstruction;
		private System.Windows.Forms.TextBox tbParameter;
		private System.Windows.Forms.TextBox tbComment;
		private System.Windows.Forms.TextBox tbHexInstruction;
		private System.Windows.Forms.Label lbParameter;
		private System.Windows.Forms.Label lbInst;
		private System.Windows.Forms.Label lbHexInst;
		private System.Windows.Forms.Label lbStringLine;
		private System.Windows.Forms.Label lbComment;
		private System.Windows.Forms.Label lbMemory;
		private System.Windows.Forms.Label lbTag;
		private System.Windows.Forms.GroupBox gbElement;
		private System.Windows.Forms.ListBox lbComponents;
		private System.Windows.Forms.CheckBox cbComment;
	}
}

